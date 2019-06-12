using System;

namespace Monopoly.Models
{
    public class Jail : IGameSpace
    {
        private static readonly Lazy<Jail> lazy = new Lazy<Jail>(() => new Jail());

        public int Position { get; set; }

        public static Jail Instance { get { return lazy.Value; } }

        private Jail()
        {
        }
    }
}
