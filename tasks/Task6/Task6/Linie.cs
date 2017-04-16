using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public enum Type
    {
        ptBusCity,
        ptBusNight,
        ptMetro,
        ptTrainS,
        ptTram,
        ptTramVRT,
        ptTramWLB,
    }
    class Linie
    {
        private string name;
        private int order;
        private bool livedata;
        private Type linietype;
        private string stand;

        public string Name { get { return name; } }
        public int Order { get { return order; } }
        public bool Livedata { get { return livedata; } }
        public Type LinieType { get { return linietype; } }
        public string Stand { get { return stand; } }

        public Linie(string name, int order, bool livedata, string type, string stand)
        {
            this.name = name;
            this.order = order;
            this.livedata = livedata;

            switch (type)
            {
                case "ptBusCity":
                    linietype = Type.ptBusCity;
                    break;
                case "ptBusNight":
                    linietype = Type.ptBusNight;
                    break;
                case "ptMetro":
                    linietype = Type.ptMetro;
                    break;
                case "ptTrainS":
                    linietype = Type.ptTrainS;
                    break;
                case "ptTram":
                    linietype = Type.ptTram;
                    break;
                case "ptTramVRT":
                    linietype = Type.ptTramVRT;
                    break;
                case "ptTramWLB":
                    linietype = Type.ptTramWLB;
                    break;
                default:
                    break;
            }

            this.stand = stand;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
