using ServiceClients.TARIF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.TARIF
{
    public class TARIFAccess
    {
        private TarifserviceClient _client;

        public TARIFAccess()
        {
            _client = new TarifserviceClient();
        }

        public ResultatMUKKVType calcMUKUS()
        {
            berechneMUKUS _berechneMUKUS = new berechneMUKUS();
            BerechnungMUKUSType _BerechnungMUKUSType = new BerechnungMUKUSType();
            berechneMUKUSResponse _berechneMUKUSResponse = new berechneMUKUSResponse();
            // Parameter
            _BerechnungMUKUSType.cntSomeInteger = 1;
            _BerechnungMUKUSType.cntSomeIntegerSpecified = true;
            // Parameter zuweisen
            _berechneMUKUS.BerechnungMUKUS = _BerechnungMUKUSType;
            // Berechnen
            _berechneMUKUSResponse = _client.berechneMUKUS(_berechneMUKUS);
            // 
            return _berechneMUKUSResponse.berechneMUKUSResult;      
        }

    }
}