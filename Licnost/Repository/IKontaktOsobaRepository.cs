using Licnost.Model;

namespace Licnost.Repository
{
    public interface IKontaktOsobaRepository
    {
        List<KontaktOsoba> GetOsoba(string kontaktOsobaIndex = null);
        KontaktOsoba GetKontektOsobaByID(Guid kontektOsobaID);
        KontaktOsobaConfirmation CreateKontaktOsoba(KontaktOsoba kontaktOsoba);
        KontaktOsobaConfirmation UpdateKontaktOsoba(KontaktOsoba kontaktOsoba);
        void DeleteKontaktOsoba(Guid KontaktOsobaId);
    }
}
