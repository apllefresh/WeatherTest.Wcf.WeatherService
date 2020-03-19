namespace WeatherTest.Wcf.WeatherService.DataAccess.Models
{
    public class City
    {
        public City(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }
    }
}
