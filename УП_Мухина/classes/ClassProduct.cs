using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

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
        public string Manufact //вывод производителя
        {
            get
            {
                return "Производитель: " + Manufacturer.ProductManufacturer;
            }
        }
        public string Price //вывод цены
        {
            get
            {
                return "Цена: " + Math.Round(ProductCost) + " руб.";
            }
        }
        public string Disc
        {
            get
            {
                return "Скидка " + ProductDiscountMax + " %";
            }
        }
        public SolidColorBrush ColorDisc //товар со скидкой
        {
            get
            {
                if (ProductDiscountMax>15)
                {
                    SolidColorBrush Dis = new SolidColorBrush(Color.FromRgb(127, 255, 0));
                    return Dis;
                }
                else
                {
                    return Brushes.White;
                }
            }
        }

    }
}
