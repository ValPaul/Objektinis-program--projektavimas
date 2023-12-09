using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombermanMultiplayer.Objects.Command
{
    public class OpenModeCommand : ICommand
    {
        public void Execute()
        {
            Mode mode = new Mode();
            mode.Show();
        }

        public void Undo()
        {
            Mode mode = new Mode();
            mode.Hide();
        }

        public string GetHelpMessage()
        {
            return "Open the game mode selection screen";
        }

    }

    public class ExitCommand : ICommand
    {
        public void Execute()
        {
            Application.Exit();
        }
        public void Undo()
        {
            Application.Exit();
        }

        public string GetHelpMessage()
        {
            return "Exit program";
        }

    }

    public class OpenTutorialCommand : ICommand
    {
        public void Execute()
        {
            Tutorial tutorial = new Tutorial();
            tutorial.Show();
        }
        public void Undo()
        {
            Tutorial tutorial = new Tutorial();
            tutorial.Hide();
        }
        public string GetHelpMessage()
        {
            return "Open toturial window";
        }
    }

    public class OpenHighScoreCommand : ICommand
    {
        public void Execute()
        {
            HighScore highScore = new HighScore();
            highScore.Show();
        }
        public void Undo()
        {
            HighScore highScore = new HighScore();
            highScore.Hide();
        }

        public string GetHelpMessage()
        {
            return "Open high score window";
        }

    }

    public class OpenSettingCommand : ICommand
    {
        public void Execute()
        {
            Setting setting = new Setting();
            setting.Show();
        }
        public void Undo()
        {
            Setting setting = new Setting();
            setting.Hide();
        }

        public string GetHelpMessage()
        {
            return "Open settings window";
        }
    }

    public class OpenAboutCommand : ICommand
    {
        public void Execute()
        {
            About about = new About();
            about.Show();
        }
        public void Undo()
        {
            About about = new About();
            about.Hide();
        }

        public string GetHelpMessage()
        {
            return "Open about window";
        }
    }

}
