using BombermanMultiplayer.Objects.P2.Interpreter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace BombermanMultiplayer
{
    public partial class HighScore : Form
    {
        public HighScore()
        {
            InitializeComponent();


            label1 = new Label();
            button1 = new Button();

            label1.Text = "Score";
            button1.Click += new EventHandler(button1_Click);

            this.Controls.Add(label1);
            this.Controls.Add(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IExpression score = new AddExpression(new NumberExpression(13), new NumberExpression(4));
            IExpression subScore = new SubtractExpression(score, new NumberExpression(1));

            label1.Text = subScore.Interpret().ToString(); 
        }
    }
}
