using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Game
    {
        #region Fields
        private readonly List<int> _highscores = new(); //es readonly para que no lo puedan cambiar
        private Dice _dice1, _dice2;
        #endregion
        #region Properties
        public int Eye1 => _dice1.Dots;
        public int Eye2 => _dice2.Dots;
        public bool HasSnakeEyes => Eye1 == 1 && Eye2 == 1;
        public IReadOnlyList<int> HighScores => _highscores.AsReadOnly();
        public int Total { get; private set; }
        #endregion
        #region Constructors
        public Game()
        {
            Initialize();
        }
        public void Initialize()
        {
            _dice1 = new();
            _dice2 = new();
        }
        #endregion
        public void Play()
        {
            _dice1.Roll();
            _dice2.Roll();
            if (HasSnakeEyes)
            {
                _highscores.Add(Total);
                Total = 0;
            }
            else
            {
                Total += Eye1 + Eye2;
            }
        }

        public void Restart()
        {
            Initialize();
        }
    }
}
