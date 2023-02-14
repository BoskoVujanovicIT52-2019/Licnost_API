namespace Licnost.Model
{
    public class LicnostM
    {
        public Guid LicnostID { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String Funkcija { get; set; }
        public Kupac Kupac { get; set; }

    }
}
