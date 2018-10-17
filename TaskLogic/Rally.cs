using System.Collections.Generic;

namespace TaskLogic
{
    public class Rally
    {
        string name;
        int speakers;
        public int members;
        protected double q;
        public List<string> info = new List<string>();
        public Rally(string name, int speakers, int members)
        {
            this.name = name;
            this.speakers = speakers;
            this.members = members;
        }
        public virtual void Calculation()
        {
            q = speakers / members;
        }
        public virtual List<string> GetInfo()
        {
            Calculation();
            info.Add("Название события = " + name);
            info.Add("Количество ораторов = " + speakers);
            info.Add("количество участников = " + members);
            info.Add("Ораторы / участники = " + q);
            return info;
        }
    }
}
