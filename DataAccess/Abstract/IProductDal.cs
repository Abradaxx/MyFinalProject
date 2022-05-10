using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAllByCategory(int categoryId);
    }
}
/*Public koymayı unutma çünkü public erişimi saglar
 * Bu interface
 * product ile ilgili veri tabanı ile ilgili operasyonları  yapacagım bir interface
 * operasyon bunu ekle şunu sil şunu güncelle mantıgında falan filan
 * Data acces kısmını anlatırken demiştik ki alternatif uses lar olabilir
 * yani farklı yöntem teknolojileri olabilir demiştik
 * bunun vasıtasıyla concrete içerisinde foldering kullanmalıyız.
 * 
 * 
 */