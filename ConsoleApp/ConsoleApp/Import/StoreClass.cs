using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Import
{
    public class StoreClass
    {
        public static string StoreDataText = File.ReadAllText("C:/Users/raulv/Documents/C#/lernC#withCris/LearnCSharp/ConsoleApp/ConsoleApp/Stores.json");
    }
}