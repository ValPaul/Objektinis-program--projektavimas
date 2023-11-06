using System;

namespace BombermanMultiplayer.Objects.Prototype
{
    // Define a prototype interface for cloning objects
    public interface IPrototype
    {
        IPrototype ShallowCopy();
        IPrototype DeepCopy();
    }
}