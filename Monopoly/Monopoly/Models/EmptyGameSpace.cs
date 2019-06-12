using System;

namespace Monopoly.Models
{
    public sealed class EmptyGameSpace : IGameSpace
    {
        private static readonly Lazy<EmptyGameSpace> lazy = new Lazy<EmptyGameSpace>(() => new EmptyGameSpace());

        public int Position { get; set; }

        public static EmptyGameSpace Instance { get { return lazy.Value; } }

        private EmptyGameSpace()
        {
        }
    }
}