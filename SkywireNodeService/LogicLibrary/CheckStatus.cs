using System;
using System.Collections.Generic;
using System.Linq;
using DataRepository.Interfaces;
using LogicLibrary.Interfaces;
using ModelLibrary;

namespace LogicLibrary
{
    public class CheckStatus : IStatusLogic
    {
        private readonly IClusterRepository _clusterRepository;
        private readonly INodeRepository _nodeRepository;

        public CheckStatus(IClusterRepository clusterRepository,INodeRepository nodeRepository)
        {
            _clusterRepository = clusterRepository;
            _nodeRepository = nodeRepository;
        }

        public List<Cluster> GetStatusAllClusters()
        {
            //List<Cluster> NewDataList = new List<Cluster>();
            //List<Cluster> OldDataList = _clusterRepository.GetAllClusters();

            //List<Cluster> toCheck = OldDataList.Where(x => x.whitelisted).ToList();

            //foreach(Cluster c in toCheck)
            //{


            //}
            throw new NotImplementedException();
        }

        public Cluster GetStatusCluster(int id)
        {
            List<Node> UpdatedList = new List<Node>();
            Cluster OldClusterInfo = _clusterRepository.GetCluster(id);

            
            foreach(Node n in OldClusterInfo.skycoinNode)
            {
                Node newData = _nodeRepository.GetAllNodes().FirstOrDefault(x => x.key == n.key);
                UpdatedList.Add(newData);
                Console.WriteLine(newData);
            }

            OldClusterInfo.skycoinNode = UpdatedList;

            return OldClusterInfo;
        }
    }
}
