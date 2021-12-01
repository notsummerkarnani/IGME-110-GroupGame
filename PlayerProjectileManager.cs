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
    // Class that manages player projectiles
    class PlayerProjectileManager
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
        public PlayerProjectileManager()
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
                projectiles[i].Y = projectiles[i].Y - projectiles[i].Speed;
            }
        }

        
        public void Draw(SpriteBatch sb, List<Enemy> enemies)
        {
            // Loops through projectiles list and draws each projectile
            for (int i = 0; i < projectiles.Count; i++)
            {
                for (int j = 0; j < enemies.Count; j++)
                {
                    // Removes projectile if colliding with any enemy rectangles
                    if (projectiles[i].Rect.Intersects(enemies[j].Rect))
                    {
                        // Removes projectile
                        projectiles.RemoveAt(i);

                        // Decreases i by 1 so no projectiles are missed

                        // Ends current loop in the for loop
                        return;
                    }
                }

                // Draws the projectile if the projectile is not intersecting with any enemies
                sb.Draw(projectiles[i].Texture, projectiles[i].Rect, Color.White);
            }
        }

    }
}
