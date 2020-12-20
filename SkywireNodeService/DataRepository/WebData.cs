using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using DataRepository.Interfaces;
using ModelLibrary;
namespace DataRepository
{
    public class WebData : INodeRepository
    {
        
        public List<Node> GetAllNodes()
        {
            List<Node> _webNodes = new List<Node>();

            //Get list from web
            //try
            //{
            //    WebRequest request = WebRequest.Create("https://uptime-tracker.skywire.skycoin.com/uptimes");
            //    WebResponse response = request.GetResponse();
            //    using (Stream dataStream = response.GetResponseStream())
            //    {
            //        // Open the stream using a StreamReader for easy access.
            //        StreamReader reader = new StreamReader(dataStream);
            //        // Read the content.
            //        string responseFromServer = reader.ReadToEnd();
            //        // Display the content.
            //        _webNodes = JsonSerializer.Deserialize<List<Node>>(responseFromServer);

            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            return quickFixWebPage();
        }

        private List<Node> quickFixWebPage()
        {
         
            List<Node> _nodes = new List<Node>();

            var stringFromLocalFile = File.ReadAllText("./webNodeData.json");
            _nodes = JsonSerializer.Deserialize<List<Node>>(stringFromLocalFile);

            return _nodes;
           
        }
    }
}
