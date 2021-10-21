using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Dice
    {
        #region Fields
        private Random _randomizer = new();
        #endregion
        #region Properties
        public int Dots { get; private set; }
        #endregion
        #region Methods
        public Dice()
        {
            Dots = 6;
        }
        public void Roll()
        {
            Dots = _randomizer.Next(1, 6 + 1);
        }
        #endregion
    }
}
