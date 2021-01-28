using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;

namespace InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public Task<TCKimlikNoDogrulaResponse> CheckIfRealPerson(Customer customer)
        {
            throw new System.NotImplementedException();
        }
    }
}