using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УП_Мухина
{
    public partial class Product
    {
        public string Name //вывод наименования
        {
            get
            {
                return TitleProduct.TitleProduct1;
            }
        }
        public string Desc //вывод описания
        {
            get
            {
                return ProductDescription;
            }
        }
        public string Manufact
        {
            get
            {
                return "Производитель: " + Manufacturer.ProductManufacturer;
            }
        }
        public string Price
        {
            get
            {
                return "Цена: " + ProductCost;
            }
        }
        public string Discount
        {
            get
            {
                return "Скидка " + ProductDiscountAmount + " %";
            }
        }
    }
}
