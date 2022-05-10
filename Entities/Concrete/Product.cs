using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
//bir classın default u internal dır
//internal sadece entities erişebiliyor mesala bu örnekte 
//fakat diğer katmanlarda erişebilsin diye bunu public olarak işaretledik
