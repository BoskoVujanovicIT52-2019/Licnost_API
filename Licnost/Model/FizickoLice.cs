namespace Licnost.Model
{
    public class FizickoLice
    {
        public Guid FizickoLiceID { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String JMBG { get; set; }
        public String BrojTelefona1 { get; set; }
        public String BrojTelefona2 { get; set; }
        public String Email { get; set; }
        public String BrojRacuna { get; set; }
        public int AdresaID { get; set; }
        public ICollection<KontaktOsoba> KontaktOsoba { get; set; }
        public ICollection<LicnostM> Licnost { get; set; }

    }
}
