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
        public string score { get; set; }
    }
    public class gamedetails
    {

    }
    public class hiscores
    {
        public string naam { get; set; }
        public string hiscore { get; set; }

    }
    
}

