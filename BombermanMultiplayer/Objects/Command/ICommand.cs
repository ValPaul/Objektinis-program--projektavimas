﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.Command
{
    public interface ICommand
    {
        void Execute();

        void Undo();

        string GetHelpMessage(); //reiktu defaulto bet tada .NET reiks kelti ir tai yra tikrai ne idealu :D
    }
}
