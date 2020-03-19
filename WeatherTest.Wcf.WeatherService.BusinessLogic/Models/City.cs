using System.Runtime.Serialization;

namespace WeatherTest.Wcf.WeatherService.BusinessLogic.Models
{
    [DataContract]
    public class City
    {

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
