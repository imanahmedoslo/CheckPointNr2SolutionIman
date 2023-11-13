using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointNr2
{
    /*
     * Class: Player
       Properties: Name, Number
     */
    public class Player
    {
       
        public string Name { get; } 
          /*  { 
                return _name;
            } private set 
            { 
                if (value == null || value == string.Empty)
                {
                   // throw new Exception("Please give a proper name to the player.");
                    _name = "ukjent navn.";
                }
                else { _name = value; }
               
            } 
        }*/
        public int Number { get; set; }
        public Player(string name="ukjent navn", int number=0) 
        {
            Name = name;
            Number = number;

        }
    }
}
