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
    // Class for projectiles, inherits from object class
    class Projectile : Object
    {
        // Declares fields
        private int damage;
        private int speed;

        // Property for damage
        public int Damage
        {
            // Returns damage
            get { return damage; }

            // Sets damage to new value
            set { damage = value; }
        }

        // Property for speed
        public int Speed
        {
            // Returns speed
            get { return speed; }

            // Sets speed to new value
            set { speed = value; }
        }

        // Constructor
        public Projectile(Texture2D texture, Rectangle rect, int damage, int speed)
            : base (texture, rect)
        {
            // Initializes damage and speed of projectile
            this.damage = damage;
            this.speed = speed;
        }
    }
}
