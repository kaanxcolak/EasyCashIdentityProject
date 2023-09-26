using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using System.ComponentModel;

namespace EasyCashIdentityProject.PresentationLayer.ViewComponents.Customer
{
//    Partial class, bir sınıfın tanımını birden fazla dosyaya bölerek daha düzenli bir yapı oluşturmayı sağlar.Bu, büyük ve karmaşık sınıfların daha kolay yönetilmesini sağlar.

//View Component ise tekrar kullanılabilir bileşenlerin oluşturulmasına yardımcı olan bir yapıdır. Controller'a bağlı olmayan ve bağımsız olarak çalışabilen bileşenlerdir.

    public class _CustomerLayoutHeaderPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
