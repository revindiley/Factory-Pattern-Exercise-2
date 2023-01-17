﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){ Name = "Playstation", Price = 400},
            new Product(){ Name = "Xbox", Price = 300},
            new Product(){ Name = "Nintendo Switch", Price = 300},
            new Product(){ Name = "SteamDeck", Price = 500},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I an reading data from List Data Access");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a List Data Access");
        }
    }
}