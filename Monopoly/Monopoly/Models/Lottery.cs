using System;

namespace Monopoly.Models
{
    public class Lottery : IGameSpace
    {
        private static readonly Lazy<Lottery> lazy = new Lazy<Lottery>(() => new Lottery());

        public int Position { get; set; }

        public static Lottery Instance { get { return lazy.Value; } }

        private Lottery()
        {
        }
    }
}
