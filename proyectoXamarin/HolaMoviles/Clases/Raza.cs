using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoXamarin.Clases
{
    public class Raza
    {
        public string praza;

        [JsonProperty(PropertyName = "praza")]
        public string tRaza { get; set; }


    }
}
