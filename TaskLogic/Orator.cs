using System.Collections.Generic;

namespace TaskLogic
{
    public class Orator : Rally
    {
        int p;
        double qp;
        public Orator(string name, int speakers, int members, int p) : base(name, speakers, members)
        {
            this.p = p;
        }
        public override void Calculation()
        {
            base.Calculation();
            qp = q + p / members;
        }
        public override List<string> GetInfo()
        {
            base.GetInfo();
            info.Add("Число групп ораторов, которые высказывали одинаковые мысли = " + qp);
            return info;
        }
    }
}
