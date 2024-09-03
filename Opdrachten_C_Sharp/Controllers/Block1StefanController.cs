using Microsoft.AspNetCore.Mvc;
using Opdrachten_C_Sharp.Models.Block1;

namespace Opdrachten_C_Sharp.Controllers
{
    public partial class Block1Controller 
    {
        Me Stefan = new Me();

        public IActionResult Exercise1Stefan()
        {
            /*
             Schrijf een programma dat de volgende informatie van jou op het scherm laat zien:

                    •  Jouw volledige naam
                    •  Jouw adres
                    •  Jouw postcode gevolgd door jouw woonplaats (op één regel)
                    •  Jouw leeftijd

             */

            Stefan.FirstName = "Stefan";
            Stefan.MiddleName = "";
            Stefan.LastName = "Vet";
            Stefan.Address = "Jan Luikenstraat 6";
            Stefan.PostalCode = "7552XK";
            Stefan.City = "Hengelo";
            Stefan.Age = 18;

            return View(Stefan);
        }
        public IActionResult Exercise2Stefan()
        {
            /*
             * Schrijf een programma dat jouw naam weergeeft in een box met sterretjes, zoals hieronder weergegeven:

                ********************
                ***     Marcel   ***
                ********************

             */

            Stefan.FirstName = "Stefan";
            Stefan.MiddleName = "";
            Stefan.LastName = "Vet";
            Stefan.Address = "Jan Luikenstraat 6";
            Stefan.PostalCode = "7552XK";
            Stefan.City = "Hengelo";
            Stefan.Age = 18;

            return View(Stefan);
        }
    }
}
