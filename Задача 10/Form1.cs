using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaintingApp;

namespace Задача_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PenTool p = PenTool.prepare(this);
            p.down();
            p.down();
            p.down();
            p.down();
            
            
            p.right();
            p.right();
            p.right();
            

            p.startLine();
            for(int i = 0; i < 2; i++)
            {
                p.down();
            }
            for (int i = 0; i < 5; i++)
            {
                p.right();
            }
            
            for (int i = 0; i < 8; i++)
            {
                p.down();
            }
            for(int i = 0; i < 2; i++)
            {
                p.right();
            }
            for (int i = 0; i < 6; i++)
            {
                p.down();
            }
            for (int i = 0; i < 2; i++)
            {
                p.left();
            }
            for (int i = 0; i < 2; i++)
            {
                p.down();
            }
            for (int i = 0; i < 4; i++)
            {
                p.right();
            }
            for (int i = 0; i < 8; i++)
            {
                p.up();
            }
            for (int i = 0; i < 15; i++)
            {
                p.right();
            }
            for (int i = 0; i < 6; i++)
            {
                p.down();
            }
            for (int i = 0; i < 2; i++)
            {
                p.left();
            }
            for (int i = 0; i < 2; i++)
            {
                p.down();
            }
            for (int i = 0; i < 4; i++)
            {
                p.right();
            }
            for (int i = 0; i < 12; i++)
            {
                p.up();
            }
            for (int i = 0; i < 2; i++)
            {
                p.right();
            }
            for (int i = 0; i < 5; i++)
            {
                p.up();
            }
            for (int i = 0; i < 2; i++)
            {
                p.left();
            }
            for (int i = 0; i < 3; i++)
            {
                p.down();
            }
            for (int i = 0; i < 17; i++)
            {
                p.left();
            }
            for (int i = 0; i < 8; i++)
            {
                p.up();
            }
            for (int i = 0; i < 2; i++)
            {
                p.left();
            }
            for (int i = 0; i < 2; i++)
            {
                p.down();
            }
            for (int i = 0; i < 3; i++)
            {
                p.left();
            }
            for (int i = 0; i < 2; i++)
            {
                p.down();
            }
            for (int i = 0; i < 4; i++)
            {
                p.left();
            }
        }
    }
}
