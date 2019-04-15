using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WebAPI.Controllers
{


    public class calcHHEHController : ApiController
    {
        [HttpGet]
        public double Add([FromBody]Tarifservice.pEigenheimHaushalt H)
        {
            Tarifservice.TarifserviceClient _clientX;
            _clientX = new Tarifservice.TarifserviceClient();

            Tarifservice.rEigenheimHaushalt result_H = new Tarifservice.rEigenheimHaushalt();
            result_H = _clientX.calcEigenheimHaushalt(H);

            double PraemieHaushalt = result_H.PraemieHaushalt;   //Dada Prämie für Haushalt ist da :-) !!!!!

            return PraemieHaushalt;
        }
    }



    //public class calcHHEHController : ApiController
    //{
    //    Tarifservice.pEigenheimHaushalt X = new Tarifservice.pEigenheimHaushalt();

    //    GET: api/Berechnung/pEigenheimHaushalt
    //   [HttpGet]
    //    public Tarifservice.rEigenheimHaushalt Get(Tarifservice.pEigenheimHaushalt H)  //offene Frage wie kommen Daten in H ??
    //    {
    //        Tarifservice.TarifserviceClient _clientX;
    //        _clientX = new Tarifservice.TarifserviceClient();

    //        if (H == null)
    //        {
    //            H = X;
    //        }

    //        Testdaten-------------------------------------------------------------------------------------------------- -
    //        H.Klasse = "Haushalt";
    //        H.Buendelrabatt = false;
    //        H.Wohnnutzflaeche = 120;
    //        H.IsEinfamilienhaus = true;
    //        H.IsZweifamilienhaus = false;
    //        H.IsMehrfamilienhaus = false;
    //        H.IsStaendigBewohnt_ja = true;
    //        H.IsStaendigBewohnt_nein = false;
    //        H.IsVerbautesOrtsgebiet_innerhalb = true;
    //        H.IsVerbautesOrtsgebiet_ausserhalb = false;
    //        H.IsVSHaushaltIndividuell = false;
    //        H.VSHaushaltIndividuell = 0;
    //        H.HaushaltTarif = "EP";
    //        H.IsHaushaltHochwasserpaket = false;
    //        H.IsHaushaltGrobeFahrlaessigkeit = false;
    //        H.IsHaushaltHeizungskasko = false;
    //        H.IsHaushaltAusschlussGlasbruch = false;
    //        H.IsHaushaltZuschlagUnbewohntAusserhalb = false;
    //        H.IsErhoehungAufWert = false;
    //        H.ErhoehungAufWertVS = 0;
    //        H.IsHaushaltAlarmanlage = false;
    //        H.IsHaushaltSelbstbehalt = false;
    //        H.IsHaushaltPrivatehaftpflicht = false;
    //        H.IsEigenheimHaushaltHundehaftpflicht = false;
    //        H.CntEigenheimHaushaltHunde = 0;
    //        Zahlunhsweise
    //        H.Zahlungsweise_monat = true;
    //        H.Zahlungsweise_quartal = false;
    //        H.Zahlungsweise_halbjahr = false;
    //        H.Zahlungsweise_jahr = false;
    //        ----------------------------------------------------------------------------------------------------------------

    //        Tarifservice.rEigenheimHaushalt result_H = new Tarifservice.rEigenheimHaushalt();
    //        result_H = _clientX.calcEigenheimHaushalt(H);

    //        return result_H;
    //    }


    //    Eingabe in Fiddler oder Chrome-Postman siehe App_Data/HELP POST_01.PNG
    //    [HttpPost]
    //    public void Post([FromBody]Tarifservice.pEigenheimHaushalt H)
    //    {
    //        Tarifservice.TarifserviceClient _clientX;
    //        _clientX = new Tarifservice.TarifserviceClient();

    //        Tarifservice.rEigenheimHaushalt result_H = new Tarifservice.rEigenheimHaushalt();
    //        result_H = _clientX.calcEigenheimHaushalt(H);

    //        double PraemieHaushalt = result_H.PraemieHaushalt;   //Dada !!!!!
    //    }


    //    [HttpGet]
    //    public double Add([FromBody]Tarifservice.pEigenheimHaushalt H)
    //    {

    //        Tarifservice.TarifserviceClient _clientX;
    //        _clientX = new Tarifservice.TarifserviceClient();

    //        Tarifservice.rEigenheimHaushalt result_H = new Tarifservice.rEigenheimHaushalt();
    //        result_H = _clientX.calcEigenheimHaushalt(H);

    //        double PraemieHaushalt = result_H.PraemieHaushalt;   //Dada !!!!!

    //        return PraemieHaushalt;
    //    }

    //    [HttpPost]
    //    public double Add([FromBody]Tarifservice.pEigenheimHaushalt H)
    //    {

    //        Tarifservice.TarifserviceClient _clientX;
    //        _clientX = new Tarifservice.TarifserviceClient();

    //        Tarifservice.rEigenheimHaushalt result_H = new Tarifservice.rEigenheimHaushalt();
    //        result_H = _clientX.calcEigenheimHaushalt(H);

    //        double PraemieHaushalt = result_H.PraemieHaushalt;   //Dada !!!!!

    //        return PraemieHaushalt;
    //    }

    //}
}
