using System;
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
        private string _name;
        public string Name { get 
            {
                return _name;
            } set
            {
                if (value == null || value == string.Empty)
                {
                    throw new Exception("vennligst gi teamnavn i riktig format.");

                }
                else { _name = value; }

            }
        }
        public List<Player> Players;
        public Team(string name="ukjent teamnavn")
        {
            Players = new List<Player>();
            Name = name;
        }

    }
}
