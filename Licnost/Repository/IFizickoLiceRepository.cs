using Licnost.Model;

namespace Licnost.Repository
{
    public interface IFizickoLiceRepository
    {
        List<FizickoLice> GetFizickoLice(string FizickoLiceIndex = null);
        FizickoLice GetFizickoLiceByID(Guid FizickoLiceID);
        FizickoLiceConfirmation CreateFizickoLice(FizickoLice fizickoLice);
        FizickoLiceConfirmation UpdateFizickoLice(FizickoLice fizickoLice);
        void DeleteFizickoLice(Guid fizickoLiceID);
    }
}
