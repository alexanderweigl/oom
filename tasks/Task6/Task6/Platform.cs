using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public enum Direct
    {
        H,
        R
    }
    class Platform
    {
        private int stopid;
        private Direct direction;
        private int rblnumber;
        private int order;
        private int sector;
        private string name;
        private Cordinate cor;

        public int StopId { get { return stopid; } }
        public Direct Direction { get { return direction; } }
        public int RblNumber { get { return rblnumber; } }
        public int Order { get { return order; } }
        public int Sector { get { return sector; } }
        public string Name { get { return name; } }
        public Cordinate Cor { get { return cor; } }

        public Platform(int stopid, Direct direction, int rblnumber, int order, int sector, string name, string cor)
        {
            this.stopid = stopid;
            this.direction = direction;
            this.rblnumber = rblnumber;
            this.order = order;
            this.sector = sector;
            this.name = name;

            switch (cor)
            {
                case "H":
                    this.direction = Direct.H;
                    break;
                case "R":
                    this.direction = Direct.R;
                    break;
                default:
                    break;
            }
        }
    }
}
