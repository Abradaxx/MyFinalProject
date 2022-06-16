using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductsListed="Ürünler listelendi";

        public static string ProductCountOfCategoryError = "Bir Kategoride en fazla 10 ürün olabilir";

        public static string ProductNameAlreadyExists = "Böyle bir ürün ismi zaten var";
        internal static string CategoryLimitExceded="Category Limiti Aşıldı";
    }
}
