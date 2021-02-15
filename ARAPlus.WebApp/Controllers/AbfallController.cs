using ARAPlus.AbfallLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARAPlus.WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AbfallController : ControllerBase
    {
        // GET: AbfallController
        [HttpGet]
        public Abfall Get()
        {
            //F9 - Breakpoint oder graue linke Liste klicken
            ARAPlus.AbfallLogic.Abfall abfall = new AbfallLogic.Abfall();
            abfall.Bezeichnung = "Montag";
            abfall.Preis = 120;
            abfall.Gewicht = 20;
            return abfall;
        }

     
    }
}
