using System;
namespace ModelLibrary
{
    public class Node
    {
        public string key { get; set; }
        public int uptime { get; set; }
        public int downtime { get; set; }
        public double percentage { get; set; }
        public bool online { get; set; }

        public Node()
        {

        }
        public override string ToString()
        {
            return $"Key = {key} /n Is Online -> {online} /n Percentage = {percentage}";
        }
    }
}
