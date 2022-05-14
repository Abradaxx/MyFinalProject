using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
       
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