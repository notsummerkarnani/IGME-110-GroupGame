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
    // Manager for enemy class, child of ObjectManager class
    class EnemyManager : ObjectManager
    {
        // Declares field for the enemy object, texture, rectangle, projectiles, and enemies list
        private Enemy enemy;
        private Texture2D enemyTexture;
        private Texture2D projectileTexture;
        private EnemyProjectileManager projectiles;
        private List<Enemy> enemies;
        private int enemyWaveNumber;
        private int bossNumber;

        public EnemyProjectileManager Projectiles
        {
            get { return projectiles; }
        }

        // Constructor, Sets the fields of the parent class and the fields of this class to the parameters
        public EnemyManager(Texture2D enemyTexture, Texture2D projectileTexture,
            bool enabled, Rectangle rigidBody, int health, int speed) : base(enabled, rigidBody)
        {
            // Initialzes fields
            this.enemyTexture = enemyTexture;
            this.projectileTexture = projectileTexture;
            this.enemy = new Enemy(health, speed, enemyTexture, RigidBody);
            projectiles = new EnemyProjectileManager();

            // Initializes enemies list
            enemies = new List<Enemy>();

            // Adds newly created enemy to enemies list
            enemies.Add(this.enemy);
        }

        // Property for enemies list
        public List<Enemy> Enemies
        {
            // Returns enemies list
            get { return enemies; }
        }

        // Property which returns wave number
        public int EnemyWave { get { return enemyWaveNumber; } }

        /// <summary>
        /// Determines if any enemy is dead and awards player points
        /// </summary>
        /// <returns>Points to add to the player's score (based on # of enemies killed)</returns>
        public int IsDead()
        {
            // Creates local variable to hold the # of points to award the player
            int points = 0;

            // Loops through enemies list and checks if any enemy is dead
            for (int i = 0; i < enemies.Count; i++)
            {
                // If enemy health is 0 or below 0, removes enemy from enemies list
                if (enemies[i].Health <= 0)
                {
                    // Removes enemy from enemies list
                    enemies.RemoveAt(i);

                    // Decreases i by 1 to make sure no enemies are missed
                    i--;

                    // Adds 10 to the points that will be awarded to player
                    points = points + 10;
                }
            }

            // Returns points to add to player score
            return points;
        }

        /// <summary>
        /// Moves all enemies left, right, or down
        /// </summary>
        public void Move()
        {
            // Loops through all enemies and moves them left or right or down
            for (int i = 0; i < enemies.Count; i++)
            {
                // If an enemy is moving right and hits the end of the screen,
                // moves the enemy down if they are above 640 on the y-axis,
                // and sets their movement to left
                if (enemies[i].Movement == Movement.Right && enemies[i].X >= 852)
                {
                    // If the enemy is above 640 on the y-axis, moves the enemy down by 64 (one row down) 
                    if (enemies[i].Y < 320)
                    {
                        enemies[i].Y += 64;
                    }

                    // Sets the enemies movement to left
                    enemies[i].Movement = Movement.Left;
                }
                // If an enemy is moving left and hits the end of the screen,
                // moves the enemy down if they are above 640 on the y-axis,
                // and sets their movement to right 
                else if (enemies[i].Movement == Movement.Left && enemies[i].X <= 0)
                {
                    // If the enemy is above 640 on the y-axis, moves the enemy down by 64 (one row down)
                    if (enemies[i].Y < 320)
                    {
                        enemies[i].Y += 64;
                    }

                    // Sets the enemies movement to right
                    enemies[i].Movement = Movement.Right;
                }
                // Otherwise move the enemy based on their current movement state (left or right)
                else
                {
                    // If the enemy is currently moving right, moves the enemy right on the x-axis based on enemy's speed
                    if (enemies[i].Movement == Movement.Right)
                    {
                        enemies[i].X += enemies[i].Speed;
                    }
                    // If the enemy is currently moving left, moves the enemy left on the x-axis based on enemy's speed
                    else
                    {
                        enemies[i].X -= enemies[i].Speed;
                    }
                }
            }
        }

        /// <summary>
        /// Creates a projectile and adds to each enemies projectiles list
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="damage"></param>
        public void Fire(int speed, int damage)
        {
            // Loops through list of enemies
            for (int i = 0; i < enemies.Count; i++)
            {
                // Creates a new projectile  (Positioned in the front middle of the enemy)
                Projectile projectile = new Projectile(projectileTexture,
                                                       new Rectangle(enemies[i].X + 20, enemies[i].Y + 75, 10, 10),
                                                       damage,
                                                       speed);

                // Adds projectile to the enemy's projectile manager
                projectiles.Projectiles.Add(projectile);
            }
        }

        /// <summary>
        /// Distributes damage to an enemy if they collide with a projectile
        /// </summary>
        public void TakeDamage(List<Projectile> projectiles)
        {
            // Loops through passed in projectiles list
            for (int i = 0; i < projectiles.Count; i++)
            {
                // Loops through enemies list
                for (int j = 0; j < enemies.Count; j++)
                {
                    // Checks if any projectiles in the list intersect with the enemy
                    if (projectiles[i].Rect.Intersects(enemies[j].Rect))
                    {
                        // If hit with a projectile, subtracts health from enemy based on
                        // the damage the projectile deals
                        enemies[j].Health = enemies[j].Health - projectiles[i].Damage;

                        // This is here for testing purposes
                        Console.WriteLine("Enemy " + (j + 1) + " health: " + enemies[j].Health);
                    }
                }
            }
        }

        /// <summary>
        /// Draws all enemies
        /// </summary>
        /// <param name="sb"></param>
        public void Draw(SpriteBatch sb)
        {
            // Loops through enemies list and draws all enemies
            for (int i = 0; i < enemies.Count; i++)
            {
                // Draws enemy
                sb.Draw(enemies[i].Texture, enemies[i].Rect, Color.White);
            }
        }

        /// <summary>
        /// Creates a new enemy object and adds it to the enemies list
        /// </summary>
        public void SpawnEnemy(Texture2D enemyTexture, Rectangle rect, int health, int speed)
        {
            // Creates a new enemy
            Enemy enemy = new Enemy(health, speed, enemyTexture, rect);

            // Adds newly created enemy to enemies list
            enemies.Add(enemy);
        }

        /// <summary>
        /// Spanws a wave of enemies and spawns a boss every 5th wave
        /// </summary>
        /// <param name="enemyTextures"></param>
        /// <param name="form"></param>
        public void SpawnEnemyWave(Texture2D[] enemyTextures, Form1 form)
        {
            //to help decide which enemy texture we should use
            enemyWaveNumber++;
            Random rng = new Random();

            if (enemyWaveNumber > 7)
            {
                enemyWaveNumber = 7;
            }

            if (enemyWaveNumber % 5 != 0)       //checks for every 5th wave 
            {
                for (int i = 0; i < enemyWaveNumber; i++)
                {
                    // Creates a new enemy and changes the health and speed of the enemy for each new wave
                    Enemy enemy = new Enemy(form.Stats["EnemyHealth"] + enemyWaveNumber,
                        form.Stats["EnemySpeed"] + enemyWaveNumber,
                        enemyTextures[rng.Next(0, 3)], new Rectangle(rng.Next(0, 800),
                        rng.Next(0, 200), 48, 64));

                    // Adds newly created enemy to enemies list
                    enemies.Add(enemy);
                }
            }
            else //creates a boss every 5th wave 
            {
                Enemy enemy = new Enemy(form.Stats["BossHealth"] +(5*bossNumber),
                        form.Stats["BossSpeed"],
                        enemyTextures[3], new Rectangle(rng.Next(0, 800),
                        rng.Next(0, 200), 96, 128));

                enemies.Add(enemy);
                bossNumber++;           //helps increase the boss health every time it spawns
            }

        }
    }
}
