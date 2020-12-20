using System;
using System.Collections.Generic;
using ModelLibrary;

namespace DataRepository.Interfaces
{
    public interface IClusterRepository
    {
        public List<Cluster> GetAllClusters();
        public Cluster GetCluster(int id);
    }
}
