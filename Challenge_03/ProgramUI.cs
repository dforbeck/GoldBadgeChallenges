using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_03
{
    public class ProgramUI
    {
        OutingsRepository _outingsRepo = new OutingsRepository();
        int _reponse; //reponse to menu here

        List<Outings> _listOfOutings;

        public void Run()
        {
            _listOfOutings = _outingsRepo.GetOutingsList();
            SeedData();


        }

        private void SeedData()
        {
            _outingsRepo.AddOutingsToList(new Outings(20, DateTime.Parse("11/05/2018"), EventType.Amusement_Park, 34.50));
            _outingsRepo.AddOutingsToList(new Outings(30, DateTime.Parse("06/05/2018"), EventType.Bowling, 15));
            _outingsRepo.AddOutingsToList(new Outings(20, DateTime.Parse("10/05/2018"), EventType.Concert, 20.75));
        }
    }
}
