using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foro.Models
{
    public class Cliente
    {
        public string SummonerName { get; set; }
        public string Region { get; set; }
        public string ApiKey = "RGAPI-97ec8d3d-23b5-4e58-a59f-d6a6b4648e95";
        public string genURL { get; set; }
    }

    public enum Regiones
    {
        NA,
        EUW,
        LAN,
        LAS,
        KR,
        OC,
        RU,
        BR,
        JP,
        EUN,
        TR
    }
}