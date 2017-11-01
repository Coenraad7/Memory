using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.IO;

namespace MemoryGame
{
    public class spelerdetails
    {
        public int id { get; set; }
        public string speler { get; set; }
        public int score { get; set; }
        public int thema { get; set; }
        public int kaartparen { get; set; }
        public double multiplier { get; set; }
        public int beurtspeler { get; set; }
        public int players { get; set; }
        public int moeilijkheidsgraad { get; set; }
        public int timers { get; set; }
    }
}
    


