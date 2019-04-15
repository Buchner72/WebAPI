using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VertragsLibrary;
using ServiceClients.TARIF;
using WebAPI.TARIF;
//using WebAPI.Models;

namespace WebAPI.Controllers
{

    public class mukiAPIController : ApiController   // In Verbindung mit VSC Prpjekt routExample
    {
        List<Vertrag> Vertraege = new List<Vertrag>();

        // GET api/values
        public IEnumerable<Vertrag> Get() //http://localhost:57373/api/mukiAPI
        {
            Vertrag v1 = new Vertrag();
            v1.Versicherungsnehmer.Vorname = "Franz";
            v1.Versicherungsnehmer.Nachname = "Buchner";
            Vertraege.Add(v1);

            Vertrag v2 = new Vertrag();  //Einfach andere Schreibweise für Versicherungsnehmer
            Versicherungsnehmer vn2 = new Versicherungsnehmer();
            //vn2.Vorname = "Michael";
            //vn2.Nachname = "Kieneswenger";

           
            Double USMonatsPraemie = 0;
            

            USMonatsPraemie = 9.99;                     //Zum Test reicht manuell zugewiesene Zahl
            vn2.Vorname = "Manuell zugewiesene Zahl: ";

            //Zum Test wird hier auf Service zugegriffen-------------------------------------------------------------------------------------------------
            //USMonatsPraemie = calcUS();                //In der Firma kann auf das Service zugegriffen werden
            //vn2.Vorname = "Unfallsonderklasse aus TARIFClient(Service): ";   
            //-------------------------------------------------------------------------------------------------------------------------------------------
            vn2.Nachname = USMonatsPraemie.ToString() + " €";
            
            v2.Versicherungsnehmer = vn2;
            Vertraege.Add(v2);

            return Vertraege;
        }

        public double calcUS()
        {
            TARIFAccess client = new TARIFAccess();
            ResultatMUKKVType result = new ResultatMUKKVType();
            // Greife auf Service zu

            result = client.calcMUKUS();
            return result.BruttoPraemieMonat;

        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }



    }
}
