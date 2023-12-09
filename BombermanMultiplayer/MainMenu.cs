using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using BombermanMultiplayer.Objects.Command;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ICommand = BombermanMultiplayer.Objects.Command.ICommand;

namespace BombermanMultiplayer //veikia kaip konteinerio klase
{
    public partial class MainMenu : Form
    {
        private ICommand openModeCommand = new OpenModeCommand();
        private ICommand exitCommand = new ExitCommand();
        private ICommand openTutorialCommand = new OpenTutorialCommand();
        private ICommand openHighScoreCommand = new OpenHighScoreCommand();
        private ICommand openSettingCommand = new OpenSettingCommand();
        private ICommand openAboutCommand = new OpenAboutCommand();
        private System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

        public MainMenu()
        {
            InitializeComponent();
            InitHelpMessages();
        }

        public void InitHelpMessages() 
        {
            button1.MouseHover += (sender, e) => ShowHelpMessage(openModeCommand, button1);
            button2.MouseHover += (sender, e) => ShowHelpMessage(openTutorialCommand, button2);
            button3.MouseHover += (sender, e) => ShowHelpMessage(openSettingCommand, button3);
            button5.MouseHover += (sender, e) => ShowHelpMessage(openHighScoreCommand, button5);
            button6.MouseHover += (sender, e) => ShowHelpMessage(openAboutCommand, button6);
            button7.MouseHover += (sender, e) => ShowHelpMessage(exitCommand, button7);
        }
        private void ShowHelpMessage(ICommand command, System.Windows.Forms.Button button)
        {
            var helpMessage = command.GetHelpMessage();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(button, helpMessage);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openModeCommand.Execute();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            exitCommand.Execute();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openTutorialCommand.Execute();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openHighScoreCommand.Execute();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openSettingCommand.Execute();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openAboutCommand.Execute();
        }
    }
}
