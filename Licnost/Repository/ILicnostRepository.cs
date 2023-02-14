using Licnost.Model;

namespace Licnost.Repository
{
    public interface ILicnostRepository
    {
        List<LicnostM> GetAllLicnost(string licnostID = null);
        LicnostM GetLicnostById(Guid licnostID);
        LicnostMConfirmation CreateLicnost(LicnostM licnost);
        LicnostMConfirmation UpdateLicnost(LicnostM licnost);
        void DeleteLicnost(Guid licnostID);
    }
}
