using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CheckPointNr2
{
    /*
     * Class: Star
       Properties: Name, Number, Description
     */
    public class StarPlayer : Player
    {
        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new Exception("vennligst gi en beskrivelse av spilleren i riktig format.");

                }
                else { _description = value; }

            }

        }
        public StarPlayer(string name, int number, string description = "ikke angitt") : base(name, number)
        {
            Description = description;

        }
        public override string ToString()
        {
            return $"{base.ToString()}. spilleren er stjernespiller. beskrivelse:{Description}.";
        }

        public bool Equals(StarPlayer comparingPlayer)
        {
            return Name == comparingPlayer.Name && Number == comparingPlayer.Number && Description == comparingPlayer.Description;
        }
        public override bool Equals(object? someobject)
        {
            if (someobject is StarPlayer comparingPlayer)
            {
                return Equals(comparingPlayer);
            }
            else return false;
        }
        public static bool operator ==(StarPlayer somePlayer, StarPlayer comparingPlayer)
        {
            return somePlayer.Equals(comparingPlayer);
        }
        public static bool operator !=(StarPlayer somePlayer, StarPlayer comparingPlayer)
        {
            return !somePlayer.Equals(comparingPlayer);
        }

    }
}
