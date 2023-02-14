namespace Licnost.Model
    
{
    public class Kupac
    {
        public Guid KupacID { get; set; }
        public String Prioritet { get; set; }
        public String Lice { get; set; }
        public int OstvarenaPovrsina { get; set; }
        public String Uplate { get; set; }
        public String OvlascenoLice { get; set; }
        public Boolean ImaZabranu { get; set; }
        public String DatumPocetkaZabrane { get; set; }
        public int DuzinaTrajanjaZabraneUGodinama { get; set; }
        public String DatumPrestankaZabrane { get; set; }
        public String JavnaNadmetanja { get; set; }
    }
}
