namespace CheckPointNr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Team footballTeam= new Team("Afc Wimbeldon");
            Player deffence1 = new ("Adebayo Akinfenwa", 10);
            StarPlayer Attack1 = new ("Lyle Taylor", 11, "kjempeflink til å score!");
            Player goalKeeper = new("Nikola Tzanev", 12);
            footballTeam.Recruit(deffence1);
            footballTeam.Recruit(goalKeeper);
            footballTeam.Recruit(Attack1);
            footballTeam.PrintAllPlayers();


       

        }
    }
}