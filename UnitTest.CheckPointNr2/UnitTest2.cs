using CheckPointNr2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.CheckPointNr2
{
    internal class UnitTest2
    {
        [TestCase("ukjent navn",0)]
        //[TestCase("Adebayo Akinfenwa", 10)]
        public void Create_getParameters_makesInstancesOfClass(string a,
        int b)
        {
           
            Player deffence1= new Player(a,b );
           
            
      
            Player expected1 = new();
            Player expected2 = new("Adebayo Akinfenwa", 10);
            Team team= new Team("wimbeldon");
            team.Recruit(expected2 );
            team.Recruit(expected1 );
            
           // Assert.That(a, Is.EqualTo(expected1.Name));
           // Assert.That(b, Is.EqualTo(expected1.Number));
           
            //Assert.That(a, Is.EqualTo(expected2.Name));
            //Assert.That(b, Is.EqualTo(expected2.Number));
        }
    }
}
