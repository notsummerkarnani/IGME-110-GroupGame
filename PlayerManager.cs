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
    // Manager for player class, child of ObjectManager class
    class PlayerManager : ObjectManager
    {
        // Declares field for the player object, texture, and rectangle
        private Player player;
        private Texture2D playerTexture;
        private Texture2D projectileTexture;

        // Declares field for player's projectile manager
        PlayerProjectileManager projectileManager;

        // Declares field to determine if the player has god mode enabled
        private bool godMode;

        // Property for projectiles list
        public PlayerProjectileManager ProjectileManager
        {
            // Returns projectileManager object
            get { return projectileManager; }
        }

        // Property for godMode
        public bool GodMode
        {
            // Returns godMode
            get { return godMode; }
            //sets value for godMode
            set { godMode = value; }
        }

        // Constructor, Sets the fields of the parent class and the fields of this class to the parameters
        public PlayerManager(Texture2D playerTexture, Texture2D projectileTexture,
            bool enabled, Rectangle rigidBody, int health, int speed) : base(enabled, rigidBody)
        {
            // Initializes playerTexture and projectileTexture
            this.playerTexture = playerTexture;
            this.projectileTexture = projectileTexture;

            // Initializes player object
            this.player = new Player(health, speed, playerTexture, RigidBody);

            // Initializes projectile manager
            projectileManager = new PlayerProjectileManager();
        }

        /// <summary>
        /// Determines if player is dead
        /// </summary>
        /// <returns>bool indicating weather player is dead or not</returns>
        public bool IsDead()
        {
            // If player health is 0 or below 0, sets enabled to false
            if (player.Health <= 0)
            {

                //if godmode is enabled, the player won't die
                if (godMode == true)
                {
                    //keeps enabled as true, returns false for isDead
                    Enabled = true;
                    return false;
                }
                else
                {
                    // Sets enabled to false
                    Enabled = false;

                    // Returns true
                    return true;
                }
            }
            // Otherwise returns false
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Movement for player
        /// </summary>
        /// <param name="kbState"></param>
        public void Move(KeyboardState kbState)
        {
            /// If user presses W, moves player up
            /// If user presses S, moves player down
            /// If user presses A, moves player to the left
            /// If user presses D, moves player to the right
            if (kbState.IsKeyDown(Keys.W) && player.Y > 448)
            {
                player.Y = player.Y - player.Speed;
            }
            if (kbState.IsKeyDown(Keys.S) && player.Y < 600)
            {
                player.Y = player.Y + player.Speed;
            }
            if (kbState.IsKeyDown(Keys.A) && player.X > 0)
            {
                player.X = player.X - player.Speed;
            }
            if (kbState.IsKeyDown(Keys.D) && player.X < 852)
            {
                player.X = player.X + player.Speed;
            }
        }

        /// <summary>
        /// Draws player
        /// </summary>
        /// <param name="sb"></param>
        public void Draw(SpriteBatch sb)
        {
            // Draws player
            sb.Draw(player.Texture, player.Rect, Color.White);
        }

        /// <summary>
        /// Creates a projectile and adds to this objects projectiles list
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="damage"></param>
        public void Shoot(int speed, int damage)
        {
            // Creates a new projectile  (Positioned in the front middle of the player)
            Projectile projectile = new Projectile(projectileTexture,
                                                   new Rectangle(player.X + 20, player.Y - 11, 10, 10),
                                                   damage,
                                                   speed);

            // Adds projectile to the player's projectile manager
            projectileManager.Projectiles.Add(projectile);
        }

        /// <summary>
        /// Distributes damage to player if they collide with a projectile
        /// </summary>
        public void TakeDamage(List<Projectile> projectiles)
        {
            // Loops through passed in projectiles list
            for (int i = 0; i < projectiles.Count; i++)
            {
                // Checks if any projectiles in the list intersect with the player
                if (projectiles[i].Rect.Intersects(player.Rect))
                {
                    // If hit with a projectile, subtracts health from player based on
                    // the damage the projectile deals
                    player.Health = player.Health - projectiles[i].Damage;

                    // This is here for testing purposes
                    Console.WriteLine("Player health: " + player.Health);
                }
            }
        }

        //Allows changing stats in game (will be removed)
        public Player Player
        {
            get { return player; }
            set { player = value; }
        }
    }
}
