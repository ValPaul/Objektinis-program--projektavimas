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
    }

    public class ExitCommand : ICommand
    {
        public void Execute()
        {
            Application.Exit();
        }
    }

    public class OpenTutorialCommand : ICommand
    {
        public void Execute()
        {
            Tutorial tutorial = new Tutorial();
            tutorial.Show();
        }
    }

    public class OpenHighScoreCommand : ICommand
    {
        public void Execute()
        {
            HighScore highScore = new HighScore();
            highScore.Show();
        }
    }

    public class OpenSettingCommand : ICommand
    {
        public void Execute()
        {
            Setting setting = new Setting();
            setting.Show();
        }
    }

    public class OpenAboutCommand : ICommand
    {
        public void Execute()
        {
            About about = new About();
            about.Show();
        }
    }

}
