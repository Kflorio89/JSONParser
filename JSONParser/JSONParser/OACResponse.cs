using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONParser
{
    class OACResponse
    {
        public int EsetNumber { get; set; }
        public string OrderNumber { get; set; }
        public string OrganizationCode { get; set; }
        public string JobNumber { get; set; }
        public string SerialNumber { get; set; }
        public string MACAddress { get; set; }
        public string SoftwareExtension { get; set; }
        public string OperatorName { get; set; }
        public string ClientName { get; set; }
        public string ClientType { get; set; }
        public string OrderType { get; set; }
        public string TransactionType { get; set; }
        public string ForkliftSerialNumber { get; set; }
        public string ReportTypes { get; set; }
        public Rreports Reports { get; set; }
        public RerrorDetails ErrorDetails { get; set; }
        public RresponseDetails ResponseDetails { get; set; }

        public class Rreports
        {
            public List<Rreport> Report { get; set; }
        }

        public class Rreport
        {
            public string FileExtensionName { get; set; }
            public string FileName { get; set; }
            public string FileContent { get; set; }
        }

        public class RerrorDetails
        {
            public string ErrorCode { get; set; }
            public string ErrorMessage { get; set; }
        }

        public class RresponseDetails
        {
            public int ResponseCode { get; set; }
            public string ResponseMessage { get; set; }
        }

        /*
        {
            "EsetNumber": "1",
            "OrderNumber": null,
            "OrganizationCode": "HEL",
            "JobNumber": "J16997582",
            "SerialNumber": "SJ419030011WA",
            "MACAddress": null,
            "SoftwareExtension": null,
            "OperatorName": "eDelivery",
            "ClientName": "eDelivery",
            "ClientType": "eDelivery",
            "OrderType": null,
            "TransactionType": "Upgrade",
            "ForkliftSerialNumber": null,
            "ReportTypes": "xml",
            "Reports": 
            {
                "Report": 
                [{
                    "FileExtensionName": "xml",
                    "FileName": "SJ419030011WA_OAC.xml",
                    "FileContent": ****** 
                }]
            },
            "ErrorDetails":    
            {
                "ErrorCode": null,
                "ErrorMessage": null
            },   
            "ResponseDetails":    
            {
                "ResponseCode": 200,
                "ResponseMessage": "Success"
            }
        }
        */
    }

    class OACRequest
    {
        public int EsetNumber { get; set; }
        public string OrderNumber { get; set; }
        public string OrganizationCode { get; set; }
        public string JobNumber { get; set; }
        public string SerialNumber { get; set; } 
        public string MacAddress { get; set; }
        public string SoftwareExtension { get; set; }
        public string OperatorName { get; set; }
        public string ClientName { get; set; }
        public string ClientType { get; set; }
        public string OrderType { get; set; }
        public string TransactionType { get; set; }
        public string ForkliftSerialNumber { get; set; }
        public string ReportTypes { get; set; }

        /*
         Request json
        {
            "EsetNumber" : "1",
            "OrderNumber" : null,
            "OrganizationCode" : "HEL",
            "JobNumber" : "J16997582",
            "SerialNumber" : "SJ419030011WA",
            "MACAddress" : null,
            "SoftwareExtension" : null,
            "OperatorName" : "eDelivery",
            "ClientName" : "eDelivery",
            "ClientType" : "eDelivery",
            "OrderType" : null,
            "TransactionType" : "Upgrade",
            "ForkliftSerialNumber" : null,
            "ReportTypes" : "xml"
        }
         */
    }
}
