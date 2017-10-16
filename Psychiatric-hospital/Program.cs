using System;
using System.Collections.Generic;
using System.Linq;

namespace CrazyClinic
{
    class Program
    {
        static void Main(string[] args)
        {
            CrazyPeoples peop1 = new CrazyPeoples();
            CrazyPeoples peop2 = new CrazyPeoples();
            CrazyPeoples peop3 = new CrazyPeoples();
            CrazyPeoples peop4 = new CrazyPeoples();
            CrazyPeoples peop5 = new CrazyPeoples();
            CrazyPeoples peop6 = new CrazyPeoples();

            List<CrazyPeoples> CrazyPeople = new List<CrazyPeoples>(new CrazyPeoples[] { peop1, peop2, peop3, peop4, peop5, peop6 });

            Otdel FirstOtdel = new Otdel(new CrazyPeoples[] { peop1, peop3 });
            Otdel SecondOtdel = new Otdel(new CrazyPeoples[] { peop2, peop4 });
            Otdel ThirdOtdel = new Otdel(new CrazyPeoples[] { peop5, peop6 });

            Clinic CliFirst = new Clinic(new Otdel[] { FirstOtdel, SecondOtdel });
            Clinic CliSecond = new Clinic(new Otdel[] { ThirdOtdel });

            List<Clinic> Clinic = new List<Clinic>();
            Clinic.Add(CliFirst);
            Clinic.Add(CliSecond);

            foreach (CrazyPeoples ppls in CrazyPeople)
            {
                ppls.Set(1, Diagnos.first);
                ppls.Set(2, Diagnos.second);
                ppls.Set(3, Diagnos.third);
                ppls.Set(4, Diagnos.fourth);
                ppls.Set(5, Diagnos.five);
            }

            Clinic.Select(x => x.Otdels);
            int count = CliFirst.Otdels.Sum(x => x.CrazyPeoples.Sum(y => y.Zapis.Count(z => z.Value == Diagnos.first)));
            Console.WriteLine("Count crazy people:" + count.ToString());
        }
    }
}
