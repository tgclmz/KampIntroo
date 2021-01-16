using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun) //senin neyi eklemek istediğini metota vermek lazım, bunun için parametre tanımlayacağız. 
        {
            Console.WriteLine("Sepete eklendi :  "+ urun.Adi);
        }


        //Sektörede yukarıdaki yerine aşağıdaki gibi kullanımlar da görüyoruz, bunun neden kullanışsız olduğunu az sonra anlıyoruz. 
        //Bu şekilde yapılandırdıktan sonra yönetim sonradan ürün stoğunu da tutmak istediğini söyledi. Gittin Ekle2'nin yapacağı 
        //işi değiştiriyosun. Sonra gidip bir de tüm sayafaları tek tek dolanıp değiştiriyorsun. 

        //Diğer türlü yani yukardaki gibi olduğunda gider değişikliği yalnızca classa uygularsın. Hiç bir sayfan da patlamaz. 
        //Buna ENCAPSULATION deniyor. 
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi :  " + urunAdi);

        }

    }
}
