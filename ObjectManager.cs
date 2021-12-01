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
    // Manager class for game objects
    abstract class ObjectManager
    {
        // Field for if the object is enabled in the game or not
        protected bool enabled;

        // Field for the collider and rigidbody of the object
        protected Rectangle rigidBody;

        // Property for Enabled
        public bool Enabled
        {
            get { return enabled; }

            set { enabled = value; }
        }

        // Property for RigidBody
        public Rectangle RigidBody
        {
            get { return rigidBody; }

            set { rigidBody = value; }
        }

        // Sets the values of the fields to parameters put into the object
        public ObjectManager(bool enabled, Rectangle rigidBody)
        {
            this.enabled = enabled;
            this.rigidBody = rigidBody;
        }



    }
}
