using Licnost.Model;

namespace Licnost.Repository
{
    public interface IAdresaRepository
    {
        List<Adresa> GetAllAdresa(string adresaId = null);
        Adresa GetAdresaById(Guid AdresaID);
        AdresaConfirmation CreateAdresa(Adresa adresa);
        AdresaConfirmation UpdateAdresa(Adresa adresa);
        void DeleteAdresa(Guid adresaID);
        
    }
}
