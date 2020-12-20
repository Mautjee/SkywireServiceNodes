using System;
using System.Collections.Generic;

namespace ModelLibrary
{
    public class Cluster
    {
        public int id { get; set; }
        public string location { get; set; }
        public bool whitelisted { get; set; }
        public List<Node> skycoinNode { get; set; }

        public Cluster()
        {
        }

        public List<string> getClusterNodesKeys() {

            List<string> publicKeys = new List<string>();

            foreach(Node n in skycoinNode)
            {
                publicKeys.Add(n.key);
            }
            return publicKeys;
        }

        public override string ToString()
        {
            return $"Id = {id} /n Location = {location} /n Whitsted = {whitelisted}";
        }
    }
}
