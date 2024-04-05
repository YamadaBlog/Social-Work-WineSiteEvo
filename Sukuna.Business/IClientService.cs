using Sukuna.Common.Models;
using Sukuna.Common.Resources.Client;

namespace Sukuna.Business;

public interface IClientService
{
    public string Add(ClientResource clientResource);
    public string Update(ClientResource clientResource);
    public string Delete(ClientResource clientResource);
    public Client Get( int id);

    public List<Client> GetAll();
}
