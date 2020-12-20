using System;
using System.Collections.Generic;
using ModelLibrary;

namespace DataRepository.Interfaces
{
    public interface INodeRepository
    {
        public List<Node> GetAllNodes();
    }
}
