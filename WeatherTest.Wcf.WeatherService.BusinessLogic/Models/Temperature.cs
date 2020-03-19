using System;
using System.Runtime.Serialization;

namespace WeatherTest.Wcf.WeatherService.BusinessLogic.Models
{
    [DataContract]
    public class Temperature
    {
        [DataMember]
        public int Degree { get; set; }
        [DataMember]
        public DateTime DateTime { get; set; }
    }
}