using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Testing.Confuguration.Configuration;
using Testing.Model;

namespace Testing.Service
    {

    public static class Service
        {
        public static void CreateIfNotExsis()
            {
            if (!File.Exists(Dates))
                {
                XDocument Document = new();
                XElement Element = new("Queries");
                Document.Add(Element);
                Document.Save(Dates);
                }
            }
        public static void AddElementService(DateModel model)
            {

            XDocument document = XDocument.Load(Dates);
            XElement? Date = document.Descendants("Queries")?.FirstOrDefault();
            if (Date is null)
                {
                return;
                }
            Date.Add(new XElement("Query",new XElement("Day", model.Day),
            new XElement("DayMonth", model.DayMonth),
            new XElement("Month", model.Month),
            new XElement("Year", model.Year),
            new XElement("Result", model.Result)));
            document.Save(Dates);

            }
        }
    }