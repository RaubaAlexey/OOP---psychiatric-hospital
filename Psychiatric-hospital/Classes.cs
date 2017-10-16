
using System.Collections.Generic;

namespace CrazyClinic
{
    enum Diagnos
    {
        first,
        second,
        third,
        fourth,
        five
    }

    class Clinic
    {
        public List<Otdel> Otdels = new List<Otdel>();
        public Clinic(Otdel[] otdels)
        {
            foreach(Otdel otdel in otdels)
            {
                Otdels.Add(otdel);
            }
        }
    }

    class Otdel
    {
        public List<CrazyPeoples> CrazyPeoples = new List<CrazyPeoples>();
        public Otdel(CrazyPeoples[] peoples)
        {
            foreach(CrazyPeoples people in peoples)
            {
                CrazyPeoples.Add(people);
            }
        }
    }


    class CrazyPeoples
    {
        public Dictionary<int, Diagnos> Zapis = new Dictionary<int, Diagnos>();
        public void Set(int zap, Diagnos diag)
        {
            Zapis.Add(zap, diag);
        }

    }
}
