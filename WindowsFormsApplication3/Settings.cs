using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            brenchFrequency.Text = Default.brenchFrequency.ToString();
            lushness.Text = Default.lushness.ToString();
            treeSize.Text = Default.treeSize.ToString();
            brenchWeaking.Text = Default.brenchWeaking.ToString();
            leafQuantity.Text = Default.leafQuantity.ToString();
            minLeaf.Text = Default.minLeaf.ToString();
            brenchWidth.Text = Default.brenchWidth.ToString();
            branchWidthChange.Text = Default.brenchWidthChange.ToString();
            spawnOffsetFromTop.Value = Default.spawnOffsetFromTop;
            Changes(new object(), new EventArgs());
        }

        private void Changes(object sender, EventArgs e)
        {
            try
            {

               Options.BrenchFrequency = Convert.ToInt32(brenchFrequency.Text);
                Options.Lushness = Convert.ToInt32(lushness.Text);
                Options.TreeSize = Convert.ToInt32(treeSize.Text);
                Options.brenchWeaking= Convert.ToInt32(brenchWeaking.Text);
                Options.LeafQuantity = Convert.ToInt32(leafQuantity.Text);
                Options.MinLeaf = Convert.ToInt32(minLeaf.Text);
                Options.BrenchWidth = Convert.ToInt16(brenchWidth.Text);
                Options.BrebchWidthchangr = Convert.ToInt32(branchWidthChange.Text);
                Options.SpawnOffsetFromTop = spawnOffsetFromTop.Value;
            }
            catch (Exception)
            {

               
            }
        }

        
    }
}
