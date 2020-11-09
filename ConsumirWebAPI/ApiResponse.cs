using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumirWebAPI
{

    //classe para mapear os dados JSON.
    public class ApiResponse
    {

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("sexo")]
        public string Sexo { get; set; }

        [JsonProperty("uf")]
        public string UF { get; set; }

        [JsonProperty("valormaximo")]
        public string ValorMaximo { get; set; }

        [JsonProperty("valorminimo")]
        public string ValorMinimo { get; set; }
    }
}
