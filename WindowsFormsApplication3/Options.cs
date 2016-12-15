using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    
    class Options
    {
        static int treeSize=Default.treeSize;
        
        static public int TreeSize
        {
            get
            {
                return treeSize;
            }
            set
            {
                if (value < 40)
                    treeSize = 40;
                else
                    treeSize = value;
            }

        }
        static int lushness= Default.lushness;
        static public int Lushness
        {
            get
            {
                return lushness;
            }
            set
            {
                lushness = value;
            }
        }
        static int brenchFrequency= Default.brenchFrequency;
        static public  int BrenchFrequency
        {
            get
            {
                return brenchFrequency;
            }
            set
            {
                if (value < 1)
                    brenchFrequency = 1;
                else
                    brenchFrequency = value;
            }
        }
        static public int brenchWeaking;
        static public int LeafQuantity = Default.leafQuantity;
        static public int MinLeaf = Default.minLeaf;
        static public int BrenchWidth = Default.brenchWidth;
        static public int BrebchWidthchangr = Default.brenchWidthChange;
        static public int SpawnOffsetFromTop = Default.spawnOffsetFromTop;



    }

    class Default
    {
        static public int treeSize = 200;
        static public int lushness = 100;
        static public int brenchFrequency = 9;
        static public int brenchWeaking = 30;
        static public int leafQuantity = 40;
        static public int minLeaf = 8;
        static public int brenchWidth = 16;
        static public int brenchWidthChange = 16;
        static public int spawnOffsetFromTop = 17;

    }
}
