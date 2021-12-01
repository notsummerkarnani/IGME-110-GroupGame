 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Group1Game
{
    // Player class, inherits from object class
    class Player : Object
    {
        // Declares fields
        private int health;
        private int speed;
        private int score;

        // Property for health
        public int Health
        {
            // Returns health
            get { return health; }

            // Sets health to value
            set { health = value; }
        }

        // Property for speed
        public int Speed
        {
            // Returns speed
            get { return speed; }

            // Sets speed to value
            set { speed = value; }
        }

        // Property for score
        public int Score
        {
            // Returns score
            get { return score; }

            // Sets score to value
            set { score = value; }
        }

        // Constructor, passes in health, speed, texture, and a rectangle for the game object
        // As well as the players projectile and its speed
        public Player(int health, int speed, Texture2D playerTexture, Rectangle rect)
            : base(playerTexture, rect)
        {
            // Initializes fields
            this.health = health;
            this.speed = speed;

            // Sets score to 0
            score = 0;
        }
    }
}
