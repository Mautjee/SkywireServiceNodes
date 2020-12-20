using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using ModelLibrary;
using LogicLibrary.Interfaces;
using LogicLibrary;
using DataRepository;

namespace ConsoleUI
{
    public class Program
    {
        //Create lists

        private static IStatusLogic _statusLogic;

        static void Main(string[] args)
        {

            _statusLogic = new CheckStatus(new LocalData(),new WebData());

            _statusLogic.GetStatusCluster(1);

            Console.ReadLine();
        }
    }
}
