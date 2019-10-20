using System;
using System.Collections.Generic;
using System.Text;

namespace AppTrue.Models
{
    public class Transection
    {
        public int autoId { get; set; }
        public string idUser { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string idQRCode { get; set; }
        public string idQRCodeDetail { get; set; }
        public string idQRCodePlant { get; set; }
        public string idQRCodeStartTime { get; set; }
        public string idQRCodeMinute { get; set; }
        public string idQRCodeStatus { get; set; }
        public string idQRCodeType { get; set; }
        public string idFactory { get; set; }
        public string idFactoryDetail { get; set; }
        public int idStatus { get; set; }
        public string idStatusDetail { get; set; }
        public string idStatusDetailcolour { get; set; }
        public string createDateTime { get; set; }
        public string editDateTime { get; set; }
        public string detail { get; set; }
        public string status { get; set; }
        public string fileas { get; set; }
    }
}
