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
    /// <summary>
    /// Enum for keeping track of which way enemies are currently moving
    /// </summary>
    public enum Movement
    {
        Left,
        Right
    }

    // Class for enemy, inherits game object class
    class Enemy : Object
    {
        // Declares fields
        private int health;
        private int speed;

        // Declares enum object to keep track of enemy movement
        Movement movement;

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

        // Property for movement
        public Movement Movement
        {
            // Returns movemet
            get { return movement; }

            // Sets movement to value
            set { movement = value; }
        }

        // Constructor, passes in health, speed, texture, and a rectangle for the enemy
        public Enemy(int health, int speed, Texture2D texture, Rectangle rect)
            : base(texture, rect)
        {
            // Initializes fields
            this.health = health;
            this.speed = speed;

            // Initializes movement enum
            movement = new Movement();

            // Sets movement to right
            movement = Movement.Right;
        }
    }
}
