using System.Drawing;
using System.Windows.Forms;

namespace Recap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            GenerateButtons();
        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;

            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button()
                    {
                        Width = 50,
                        Height = 50,
                        Left = left,
                        Top = top
                    };

                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }

                    left += 50;
                    this.Controls.Add(buttons[i, j]);
                }

                left = 0;
                top += 50;
            }
        }
    }
}