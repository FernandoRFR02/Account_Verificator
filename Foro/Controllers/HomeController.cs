using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Foro.Models;

namespace Foro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resultado(Cliente clt)
        {
            
            string cadena = clt.SummonerName;
            cadena = cadena.Replace(" ","%20");
            string region = "";
            switch (clt.Region)
            {
                case "LAN":
                    region = "la1";
                    break;
                case "RU":
                    region = "ru";
                    break;
                case "KR":
                    region = "kr";
                    break;
                case "BR":
                    region = "br1";
                    break;
                case "JP":
                    region = "jp1";
                    break;
                case "NA":
                    region = "na1";
                    break;
                case "OC":
                    region = "oc1";
                    break;
                case "EUN":
                    region = "eun1";
                    break;
                case "EUW":
                    region = "euw1";
                    break;
                case "TR":
                    region = "tr1";
                    break;
                case "LAS":
                    region = "la2";
                    break;
            }
            ViewBag.urlReq = "https://" + region + ".api.riotgames.com/lol/summoner/v4/summoners/by-name/" + cadena + "?api_key=" + clt.ApiKey;
            return View(clt);
        }

    }
}