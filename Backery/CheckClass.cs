using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Backery
{
    public class CheckClass
    {
        
        static public string GetTextCheck(ProductInCheck product_info)
        {
            string result = "";
            result += "Магазин 'Готовая выпечка'\r\n";
            result += string.Format("Чек покупки товара {0}\r\n", product_info.name);
            result += string.Format("Категория товара {0}\r\n", product_info.category);
            result += string.Format("Цена {0}\r\n", product_info.price.ToString());
            result += string.Format("Состав {0}\r\n", product_info.content);
            result += "-------------------------------------------------\r\n";
            result += "Спасибо за покупку!";
            return result;
        }
    }
}
