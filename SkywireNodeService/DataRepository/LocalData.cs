using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using DataRepository.Interfaces;
using ModelLibrary;

namespace DataRepository
{
    public class LocalData : IClusterRepository
    {
        public LocalData()
        {
        }

        public List<Cluster> GetAllClusters()
        {
            return ReadFile();
        }

        //Get Cluster info from json file
        public Cluster GetCluster(int id)
        {

            return ReadFile().FirstOrDefault(x => x.id == id);
        }

        private List<Cluster> ReadFile()
        {
            List<Cluster> _clusters = new List<Cluster>();

            var stringFromLocalFile = File.ReadAllText("./privateNodesList.json");
            _clusters = JsonSerializer.Deserialize<List<Cluster>>(stringFromLocalFile);

            return _clusters;
        }
    }
}
