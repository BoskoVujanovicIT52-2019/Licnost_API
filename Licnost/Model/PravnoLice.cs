namespace Licnost.Model
{
    public class PravnoLice
    {
        public Guid PravnoLiceID { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String JMBG { get; set; }
        public String BrojTelefona1 { get; set; }
        public String BrojTelefona2 { get; set; }
        public String Faks { get; set; }
        public String Email { get; set; }
        public String BrojRacuna { get; set; }
        public Adresa Adresa { get; set; }
        public LicnostM Licnost { get; set; }
    }
}
