using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MemoryGame // Berry
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        
            //flash1.width = 1275;
            //flash1.height = 715;
            //flash1.dock = dockstyle.fill;
            //flash1.anchor = anchorstyles.none;
            //flash1.movie = path.gettemppath() + @"\intro.swf";

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu MainMenu = new MainMenu();
            MainMenu.MdiParent = this.ParentForm;
            MainMenu.Show();
            Close();
        }

        private void CopyResource()
        {
            if (File.Exists(Path.GetTempPath() + @"\IntroResized.swf"))
            {
                File.Delete(Path.GetTempPath() + @"\IntroResized.swf");
                File.WriteAllBytes(Path.GetTempPath() + @"\IntroResized.swf", Properties.Resources.IntroResized);
            }

            else
            {
                File.WriteAllBytes(Path.GetTempPath() + @"\IntroResized.swf", Properties.Resources.IntroResized);
            }
        }

        private void About_Load(object sender, EventArgs e)
        {
            CopyResource();
            // WMP1.enableContextMenu = false;
            Flash1.Width = 1275;
            Flash1.Height = 715;
            Flash1.Enabled = true;
            Flash1.Location = new Point(0, 0);
            Flash1.Size = new Size(this.ClientSize.Width - 50, this.ClientSize.Height - 50);
            Flash1.Dock = DockStyle.Fill;
            Flash1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            //WMP1.URL = @"C:\Users\Berry\AppData\Local\Temp\Intro.mp4"; 
            Flash1.Movie = Path.GetTempPath() + @"\IntroResized.swf";
        }
    }
}
