using LogReporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Log.App
{
    class Program
    {
        static void Main(string[] args)
        {
            string xPathFile = "TestXPath.xml";
            XmlDocument xP = new XmlDocument();
            xP.Load(xPathFile);
            string path = "//b/d";
            XmlNodeList elements = xP.SelectNodes(path);

            

            string configFile = "config.xml";

            if (args.Length > 0) configFile = args[0];

            XmlDocument xd = new XmlDocument();
            xd.Load(configFile);

            Reporter report = new Reporter(xd.FirstChild);
            Console.WriteLine("Report Started:" + DateTime.Now);
            report.Start();
            Console.WriteLine("Report Finished:" + DateTime.Now);

        }
    }
}
