using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Backery
{
    public class ApiClient
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public static async Task<List<ProductClass>> GetProductsAsync(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            List<ProductClass> products = JsonSerializer.Deserialize<List<ProductClass>>(jsonResponse);
            return products;
        }

        public static async Task<List<CategoryClass>> GetCategoriesAsync(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            List<CategoryClass> categories = JsonSerializer.Deserialize<List<CategoryClass>>(jsonResponse);
            return categories;
        }

        public static async Task<ProductClass> GetProductAsync(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            ProductClass product = JsonSerializer.Deserialize<ProductClass>(jsonResponse);
            return product;
        }

        public static async Task<Image> GetProductImageAsync(ProductClass product)
        {
            string ProductId = product.id.ToString();
            string ImageKey = product.picture_key;
            FileInfo fileinfo = new(ImageKey);
            if (fileinfo.Exists)
            {

                using (FileStream stream = fileinfo.OpenRead())
                {
                    Image img = Image.FromStream(stream);
                    return img;
                }
                
            }
            else
            {
                HttpResponseMessage response = await _httpClient.GetAsync(string.Format("http://185.196.41.109:9000/products/link/{0}", ProductId));
                string imgLink = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    int linkLength = imgLink.Length;
                    imgLink = imgLink.Substring(1, linkLength -2);
                    HttpResponseMessage imageResponse = await _httpClient.GetAsync(imgLink);
                    byte[] imgData = await imageResponse.Content.ReadAsByteArrayAsync();
                    Image img = (Bitmap)((new ImageConverter()).ConvertFrom(imgData));
                    using (FileStream stream = fileinfo.OpenWrite())
                    {
                        stream.Write(imgData, 0, imgData.Length);
                    }
                    return img;
                    
                }
                throw new Exception("products/link/x не доступен вернул код " + response.StatusCode.ToString());
            }

        }

        public static async Task<string> GetTokenAsync(string username, string password)
        {
            
            using (var form = new MultipartFormDataContent())
            {
                if (username == "" || password == "") return "";
                form.Add(new StringContent(username), "username");
                form.Add(new StringContent(password), "password");

                var response = await _httpClient.PostAsync("http://185.196.41.109:9000/token", form);
                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                if (jsonResponse != "false")
                {
                    TokenClass token = JsonSerializer.Deserialize<TokenClass>(jsonResponse);

                    return token.access_token;
                }
                else
                {
                    return "";
                }

            }
        }

        public static async Task<CategoryClass> PutCategoryAsync(CategoryClass category)
        {
            var message = new HttpRequestMessage(HttpMethod.Put, string.Format("http://185.196.41.109:9000/categories/{0}", category.id));
            FileInfo file = new("token");
            
            using (StreamReader stream = file.OpenText())
            {
                var body = JsonSerializer.Serialize(category);
                var token = stream.ReadLine();
                message.Headers.Add("Authorization", "Bearer " + token);
                message.Content = new StringContent(body, Encoding.UTF8, "application/json");
                var response = await _httpClient.SendAsync(message);
                response.EnsureSuccessStatusCode();
                string jsonResponse = await response.Content.ReadAsStringAsync();
                CategoryClass result = JsonSerializer.Deserialize<CategoryClass>(jsonResponse);
                return result;
            }
        }

        public static async Task<CategoryClass> PostCategoryAsync(CategoryClass category)
        {
            var message = new HttpRequestMessage(HttpMethod.Post, "http://185.196.41.109:9000/categories");
            FileInfo file = new("token");

            using (StreamReader stream = file.OpenText())
            {
                var body = JsonSerializer.Serialize(category);
                var token = stream.ReadLine();
                message.Headers.Add("Authorization", "Bearer " + token);
                message.Content = new StringContent(body, Encoding.UTF8, "application/json");
                var response = await _httpClient.SendAsync(message);
                response.EnsureSuccessStatusCode();
                string jsonResponse = await response.Content.ReadAsStringAsync();
                CategoryClass result = JsonSerializer.Deserialize<CategoryClass>(jsonResponse);
                return result;
            }
        }

        public static async Task<int> DeleteCategoryAsync(CategoryClass category)
        {
            var message = new HttpRequestMessage(HttpMethod.Delete, string.Format("http://185.196.41.109:9000/categories/{0}", category.id));
            FileInfo file = new("token");

            using (StreamReader stream = file.OpenText())
            {
                var token = stream.ReadLine();
                message.Headers.Add("Authorization", "Bearer " + token);
                var response = await _httpClient.SendAsync(message);
                response.EnsureSuccessStatusCode();
                string responseValue = await response.Content.ReadAsStringAsync();
                return Convert.ToInt32(responseValue);
            }
        }

        public static async Task<int> DeleteProductAsync(ProductClass product)
        {
            var message = new HttpRequestMessage(HttpMethod.Delete, string.Format("http://185.196.41.109:9000/products/{0}", product.id));
            FileInfo file = new("token");

            using (StreamReader stream = file.OpenText())
            {
                var token = stream.ReadLine();
                message.Headers.Add("Authorization", "Bearer " + token);
                var response = await _httpClient.SendAsync(message);
                response.EnsureSuccessStatusCode();
                string responseValue = await response.Content.ReadAsStringAsync();
                return Convert.ToInt32(responseValue);
            }
        }

        public static async Task<int> PutImageAsync(string imgpath, string key)
        {
            var getlink = new HttpRequestMessage(HttpMethod.Get, string.Format("http://185.196.41.109:9000/products/link/post/{0}", key));
            FileInfo tokenfile = new("token");
            using (StreamReader stream = tokenfile.OpenText())
            {
                var token = stream.ReadLine();
                getlink.Headers.Add("Authorization", "Bearer " + token);
            }
            var response = await _httpClient.SendAsync(getlink);
            string imgLink = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                int linkLength = imgLink.Length;
                imgLink = imgLink.Substring(1, linkLength - 2);
                var message = new HttpRequestMessage(HttpMethod.Put, imgLink);
                FileInfo file = new("token");
                string token;
                using (StreamReader stream = file.OpenText())
                {
                    token = stream.ReadLine();
                }
                byte[] baContent = File.ReadAllBytes(imgpath);
                message.Content = new ByteArrayContent(baContent);
                message.Headers.Add("Authorization", "Bearer " + token);
                var Imageresponse = await _httpClient.SendAsync(message);
                Imageresponse.EnsureSuccessStatusCode();
                return 0;
            }
            return 1;
        }

        public static async Task<int> PutProductAsync(ProductClass product)
        {
            var message = new HttpRequestMessage(HttpMethod.Put, string.Format("http://185.196.41.109:9000/products/{0}", product.id));
            FileInfo file = new("token");

            using (StreamReader stream = file.OpenText())
            {
                var body = JsonSerializer.Serialize(product);
                var token = stream.ReadLine();
                message.Headers.Add("Authorization", "Bearer " + token);
                message.Content = new StringContent(body, Encoding.UTF8, "application/json");
                var response = await _httpClient.SendAsync(message);
                response.EnsureSuccessStatusCode();
                string jsonResponse = await response.Content.ReadAsStringAsync();
                CategoryClass result = JsonSerializer.Deserialize<CategoryClass>(jsonResponse);
                if (result.name != string.Empty)
                {
                    return 0;
                }
                return 1;
            }
        }

        public static async Task<int> PostProductAsync(ProductClass product)
        {
            var message = new HttpRequestMessage(HttpMethod.Post, "http://185.196.41.109:9000/products");
            FileInfo file = new("token");

            using (StreamReader stream = file.OpenText())
            {
                var body = JsonSerializer.Serialize(product);
                var token = stream.ReadLine();
                message.Headers.Add("Authorization", "Bearer " + token);
                message.Content = new StringContent(body, Encoding.UTF8, "application/json");
                var response = await _httpClient.SendAsync(message);
                try
                {
                    response.EnsureSuccessStatusCode();
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show(ex.Message);
                    throw ex;
                }
                string jsonResponse = await response.Content.ReadAsStringAsync();
                CategoryClass result = JsonSerializer.Deserialize<CategoryClass>(jsonResponse);
                if (result.name != string.Empty)
                {
                    return 0;
                }
                return 1;
            }
        }


    }
}
