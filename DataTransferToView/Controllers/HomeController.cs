using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DataTransferToView.Controllers
{
    using DataTransferToView.Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Kategori> Kategoriler = new List<Kategori>
            {
                new Kategori{ID=1,Adi="Beverages",Aciklama="İçecek" },
                new Kategori{ID=2,Adi="Condiments",Aciklama="Soslar"},
                new Kategori{ID=3,Adi="Confections",Aciklama="Giysi,Kıyafet"},
                new Kategori{ID=4,Adi="Dairy/Products",Aciklama="Peynir,Günlük Süt"},
                new Kategori{ID=5,Adi="Seafood",Aciklama="Deniz ürünleri" }
            };
            ViewData["kategoriListesi"] = Kategoriler;
            ViewBag.KategoriListem = Kategoriler;
            TempData["tempKategori"] = Kategoriler;
            return View();
        }
        public ActionResult Deneme()
        {
            return View();
        }
    }
}
/* VIEWDATA & VIEWBAG

   Verilerin Controller'dan view sayfasına taşınmasını sağlar.
   ViewBag MVC 3 ile gelen bir özelliktir ve Runtime sırasında oluşan dinamik bir yapıdır.
   ViewData nesneside birden fazla farklı nesne ayırmasını ViewDataDictionary sınıfı aracılıyla, “key/value” syntax sayesinde çözüm sağlanmıştır.
   ViewBag kullanıldığı zaman complexli değerler için tip dönüşümüne gerek yoktur.
   ViewData, ViewDataDictionary classından türemiş string bir objedir.



   TEMPDATA

   Basit bir çalışma mantığına sahiptir.
   ViewBag ve ViewData ile aynı işi yapar.
   TempData'yı ViewData ve ViewBag’ten ayıran en büyük özellik bir sonraki sayfaya taşınan verilerin daha sonradan tekrardan başka bir sayfada kullanılmak istenilmesi durumunda TempData bu işlemi başarılı bir şekilde gerçekleştirmektedir.
   Bir Controller'dan, başka bir Controller’a veri akışı sağlayabilir.
   TempDataDictionary classından türemiş string ve object olarak kullanılabilen bir yapıdır.
   Genellikle ekranda bir seferlik gösterilmesi sağlanan mesajlarda, hata mesajlarında ve validation(doğrulama) işlemlerinde kullanılabilir.
*/
