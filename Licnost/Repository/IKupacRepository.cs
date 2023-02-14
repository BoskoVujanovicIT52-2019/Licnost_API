using Licnost.Model;

namespace Licnost.Repository
{
    public interface IKupacRepository
    {
        List<Kupac> GetAllKupac(string kupacID = null);
        Kupac GetKupacByID(Guid KupacID);
        KupacConfirmation CreateKupac(Kupac kupac);
        KupacConfirmation UpdateKupac(Kupac kupac);
        void DeleteKupac(Guid kupacID);
        
    }
}
