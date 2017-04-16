using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Stop
    {
        private string name;
        private string community;
        private int community_id;
        private Cordinate cor;
        
        public Stop(string name, string community, int community_id, Cordinate cor)
        {
            this.name = name;
            this.community = community;
            this.community_id = community_id;
            this.cor = cor;
        }
    }
}
