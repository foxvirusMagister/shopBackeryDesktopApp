using System;
using System.Collections.Generic;
using System.Linq;
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
                MessageBox.Show("Подтягиваем с интеренета");
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
    }
}
