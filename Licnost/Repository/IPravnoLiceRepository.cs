using Licnost.Model;

namespace Licnost.Repository
{
    public interface IPravnoLiceRepository
    {
        List<PravnoLice> GetAllPravnoLice(string pravnoLiceID = null);
        PravnoLice GetPravnoLiceByID(Guid PravnoLiceId);
        PravnoLiceConfirmation CreatePravnoLice(PravnoLice pravnoLice);
        PravnoLiceConfirmation UpdatePravnoLice(PravnoLice pravnoLice);
        void DeletePravnoLice(Guid pravnoLiceID);
    }
}
