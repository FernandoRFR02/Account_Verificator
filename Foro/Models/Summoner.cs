﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foro.Models
{
    public class Summoner
    {
        public string id { get; set; }
        public string accountId { get; set; }
        public string puuid { get; set; }
        public string name { get; set; }
        public int profileIconId { get; set; }
        public long revisionDate { get; set; }
        public int summonerLevel { get; set; }
    }
}