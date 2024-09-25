using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGusserGame.Models
{
    internal class Gusser
    {
        public string Name {  get; set; }

        public Gusser(){}

        public int Gusse()
        {
            Random random = new Random();
            return random.Next(10,20);

        }
    }
}
