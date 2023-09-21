using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomFinder_1
{
    public partial class OpeningLoad : Form
    {
        Form1 fr;
        public OpeningLoad(Form1 fr)
        {
            InitializeComponent();
            this.fr = fr;
        }

        public void LoadingPage(string loading)
        {
            LabelLoadText.Text = loading;
        }
    }
}
