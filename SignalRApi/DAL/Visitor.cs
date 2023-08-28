namespace SignalRApi.DAL
{
    public enum ECity
    {
        Edirne = 1,
        İstanbul = 2,
        Ankara = 3,
        Balıkesir = 4,
        Antalya = 5,
        Bursa = 6
    }

    public class Visitor
    {
        public int ID { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
