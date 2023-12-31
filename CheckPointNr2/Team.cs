﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointNr2
{
    /*
     * Properties: Name, Players
     */
    public class Team
    {
       // private string _name;
        public string Name { get; }
           /* {
                return _name;
            } set
            {
                if (value == null || value == string.Empty)
                {
                    throw new Exception("vennligst gi teamnavn i riktig format.");

                }
                else { _name = value; }

            }
        }*/
        private List<Player> Players { get; }
        public Team(string name="ukjent teamnavn")
        {
            Players = new List<Player>();
            Name = name;
        }
        public void PrintAllPlayers()
        {
            Console.WriteLine($"{this} her er en liste over alle spillere:");
            foreach (Player player in Players)
            {
                Console.WriteLine(player); 
            }
        }
        public override string ToString()
        {
            return $" teamnavn: {Name}.";
        }
        public void Recruit(Player player)
        {
            Players.Add(player);
        }


    }
}
