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
    // Class for managing enemy projectiles
    class EnemyProjectileManager
    {

        // Declares a list of projectiles
        private List<Projectile> projectiles;

        // Property for projectiles list
        public List<Projectile> Projectiles
        {
            // Returns projectiles list
            get { return projectiles; }

            // Sets a projectile in the list to a value
            set { projectiles = value; }
        }

        // Default constructor
        public EnemyProjectileManager()
        {
            // Initializes list of projectiles
            projectiles = new List<Projectile>();
        }

        /// <summary>
        /// Movement for projectiles
        /// </summary>
        public void Move()
        {
            // Loops through projectiles list and changes position of each
            for (int i = 0; i < projectiles.Count; i++)
            {
                // Changes Y position of projectile based on projectiles speed
                projectiles[i].Y = projectiles[i].Y + projectiles[i].Speed;
            }
        }

        /// <summary>
        /// Draws all projectiles
        /// </summary>
        /// <param name="sb"></param>
        public void Draw(SpriteBatch sb, Rectangle rect)
        {
            // Loops through projectiles list and draws each projectile
            for (int i = 0; i < projectiles.Count; i++)
            {
                //if the projectile isn't colliding with the passed in rectangle
                if (!projectiles[i].Rect.Intersects(rect))
                {
                    // Draws projectile
                    sb.Draw(projectiles[i].Texture, projectiles[i].Rect, Color.White);
                }
                //if the projectile is colliding, remove it from the list
                else
                {
                    projectiles.RemoveAt(i);

                    // Decreases i by 1 to make sure that no projectiles are missed
                    i--;
                }
            }
        }
    }
}
