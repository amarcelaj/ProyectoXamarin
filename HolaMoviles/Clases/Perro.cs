using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoXamarin.Clases
{
    public class Perro
    {
        [JsonProperty(PropertyName = "status")]
        public string Estado { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Mensaje { get; set; }
    }
}
