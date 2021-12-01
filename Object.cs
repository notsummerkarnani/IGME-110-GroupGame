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
    // Parent class for game objects
    class Object
    {
        // Declares fields
        protected Rectangle rect;
        protected Texture2D texture;

        // Property for rect
        public Rectangle Rect
        {
            // Returns playerRect
            get { return rect; }

            // Sets rect to value
            set { rect = value; }
        }

        // Property for X value of position rect
        public int X
        {
            // Returns X position
            get { return rect.X; }

            // Sets X position to new value
            set { rect.X = value; }
        }

        // Property for Y value of position rect
        public int Y
        {
            // Returns Y position
            get { return rect.Y; }

            // Sets Y position to new value
            set { rect.Y = value; }
        }

        // Property for texture
        public Texture2D Texture
        {
            // Returns texture
            get { return texture; }

            // Sets texture to new texture
            set { texture = value; }
        }

        // Constructor, passes in health, speed, texture, and a rectangle for the game object
        public Object(Texture2D texture, Rectangle rect)
        {
            // Initializes fields
            this.texture = texture;
            this.Rect = rect;
        }
    }
}
