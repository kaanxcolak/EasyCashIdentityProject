using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAccountManager : ICustomerAccountService
    {//Dependency injection bir sınıfı çağırırken diğer sınıfı da newlememek için başvurulan bir tasarım desenidir.Küçük proje için belki sorun olmaz ama proje büyüdükçe yapılacak bir değişiklik için o sınıfın bağımlı bulunduğu bütün sınıflarda tek tek aynı değişikliği uygulamak gerekecek. Aynı zamanda performans açısından ram'in iş yükünü minimize eder.
        private readonly ICustomerAccountDal _customerAccountDal;

        public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
        {
            _customerAccountDal = customerAccountDal;
        }

        public void TDelete(CustomerAccount t)
        {
            _customerAccountDal.Delete(t);
        }

        public CustomerAccount TGetById(int id)
        {
            return _customerAccountDal.GetById(id);        
        }

        public List<CustomerAccount> TGetCustomerAccountsList(int id)
        {
            return _customerAccountDal.GetCustomerAccountsList(id);
        }

        public List<CustomerAccount> TGetList()
        {
            return _customerAccountDal.GetList();
        }

        public void TInsert(CustomerAccount t)
        {
            _customerAccountDal.Insert(t);
        }

        public void TUpdate(CustomerAccount t)
        {
            _customerAccountDal.Update(t);
        }
    }
}
