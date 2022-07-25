using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatFinderUI
{
    public partial class EntryWindow : Form
    {
        public EntryWindow()
        {
            InitializeComponent();
        }

        private void EntryWindow_Load(object sender, EventArgs e)
        {
            EWWelcomeLabel.Text = Properties.Settings.Default.EWWelcomeText;
            EWSearchButton.Text = Properties.Settings.Default.EWSearch;
            EWSeeSavedButton.Text = Properties.Settings.Default.EWCheckSaved;

        }
    }
}
