using System;
using System.Collections.Generic;
using ModelLibrary;

namespace LogicLibrary.Interfaces
{
    public interface IStatusLogic
    {
        public List<Cluster> GetStatusAllClusters();
        public Cluster GetStatusCluster(int id);
    }
}
