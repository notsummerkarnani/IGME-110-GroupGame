using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

/* GROUP MEMBERS:
 * Samar Karnani
 * Carter Jensen
 * Zaven Kazandjian
 * Chase Call
 */

namespace Group1Game
{
    // Enum for GameStates of the game
    public enum GameState
    {
        Menu,
        Instructions,
        Gameplay,
        Gameover
    }

    /// <summary>
    /// Game1 class
    /// </summary>
    /// 
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        // Stats generator to help decide values for health/speed fields (wont be in the final game)
        Form1 form;

        // Various Asset Fields
        // - Character Sprites
        private Texture2D playerShip;
        private Texture2D enemyShip1;
        private Texture2D enemyShip2;
        private Texture2D enemyShip3;
        private Texture2D bossShip;
        
        // - Other Visual Elements
        private Texture2D playerShot;
        private Texture2D enemyShot1;
        private Texture2D enemyShot2;
        private Texture2D enemyShot3;
        private Texture2D background;
        private Texture2D title;
        private SpriteFont menuText;
        public string menuString;
        
        // - HUD Elements
        private Texture2D health;
        private SpriteFont hudText;
        private string hudString;
        private string thisScore;
        private string waveNum;

        // - Various variables which help in Asset positioning
        private int titleCenter;
        private Rectangle playerRect;
        private Rectangle enemyRect;
        private Vector2 bgScroll1;
        private Vector2 bgScroll2;

        // Declares current GameState
        private GameState currentGameState;

        // Declares keyboardState objects
        // One for current and one for previous keyboardState
        private KeyboardState kbState;
        private KeyboardState prevKBState;

        // Declares playerManager object
        private PlayerManager player;

        // Declares enemyManager object
        private EnemyManager enemy;

        // Declares playerProjectileManager object
        private PlayerProjectileManager playerProjectiles;

        //creates a field for enemy projectiles
        private EnemyProjectileManager enemyProjectiles;

        //Declares an integer for timing of enemy bullets
        private double timer;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // Sets size of window to 900 x 800
            IsMouseVisible = true;
            graphics.PreferredBackBufferWidth = 900;
            graphics.PreferredBackBufferHeight = 800;
            graphics.ApplyChanges();

            // Initializes currentGameState to start at Menu
            currentGameState = GameState.Menu;

            titleCenter = (Window.ClientBounds.Width / 2) - 187;

            // Initializes playerRect
            // playerRect = new Rectangle(Window.ClientBounds.Width / 2, Window.ClientBounds.Height - 250, 48, 64);
            playerRect = new Rectangle(400, 600, 48, 64);

            // Initializes enemyRect
            enemyRect = new Rectangle(400, 50, 48, 64);

            // Initializes bgScroll for both background pictures
            bgScroll1 = new Vector2(0, 0);
            bgScroll2 = new Vector2(0, -700);

        //initialize timer
        timer = 3.0;


            //initialise form
            form = new Form1();

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            // Displays form
            //form.ShowDialog();

            // Loads all assets
            playerShip = Content.Load<Texture2D>("playerShip");
            enemyShip1 = Content.Load<Texture2D>("enemyShip1");
            enemyShip2 = Content.Load<Texture2D>("enemyShip2");
            enemyShip3 = Content.Load<Texture2D>("enemyShip3");
            bossShip = Content.Load<Texture2D>("bossShip");

            playerShot = Content.Load<Texture2D>("playerShot");
            enemyShot1 = Content.Load<Texture2D>("enemyShot1");
            enemyShot2 = Content.Load<Texture2D>("enemyShot2");
            enemyShot3 = Content.Load<Texture2D>("enemyShot3");
            background = Content.Load<Texture2D>("bg");
            title = Content.Load<Texture2D>("title");
            menuText = Content.Load<SpriteFont>("menuText");

            health = Content.Load<Texture2D>("health");
            hudText = Content.Load<SpriteFont>("hudText");

            // Initializes player
            player = new PlayerManager(playerShip, playerShot, true, playerRect, form.Stats["PlayerHealth"], form.Stats["PlayerSpeed"]);

            // Initializes enemie(s)
            enemy = new EnemyManager(enemyShip1, enemyShot1, true, enemyRect, form.Stats["EnemyHealth"], form.Stats["EnemySpeed"]);

            // Sets playerProjectiles equal to player's projectile manager list
            playerProjectiles = player.ProjectileManager;

            //sets nemy projectiles to it's projectile list
            enemyProjectiles = enemy.Projectiles;

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            //Update logic for changing stats (wont be in the final game)
            //player.Player.Health = form.Stats["PlayerHealth"];
            //player.Player.Speed = form.Stats["PlayerSpeed"];

            // Changes position of both background pictures to simulate a scrolling background
            // If bg1 goes off screen, resets position to the end of 2nd background
            if (bgScroll1.Y == 700)
            {
                bgScroll1.Y = -700;
            }
            // Otherwise keeps the background moving downwards
            else
            {
                bgScroll1.Y += 1;
            }

            // If bg2 goes off screen, resets position to end of 1st background
            if (bgScroll2.Y == 700)
            {
                bgScroll2.Y = -700;
            }
            // Otherwise keeps the background moving downwards
            else
            {
                bgScroll2.Y += 1;
            }

            // Gets current keyboardState
            kbState = Keyboard.GetState();

            // Finite State Machine (FSM) for currentGameState
            // Determines which GameState player is in
            switch (currentGameState)
            {
                // If player starts the game, sends player to instructions GameSate
                case (GameState.Menu):

                    // If player presses enter, sets currentGameState to Instrcutions GameState
                    if (kbState.IsKeyDown(Keys.Enter) &&
                        prevKBState.IsKeyUp(Keys.Enter))
                    {
                        currentGameState = GameState.Instructions;
                    }

                    //if player presses G, god mode will be enabled
                    if (kbState.IsKeyDown(Keys.G) &&
                        prevKBState.IsKeyUp(Keys.G) &&
                        player.GodMode == false)
                    {
                        player.GodMode = true;
                    }
                    //if player presses G and godMode is true, it will disable god mode
                    else if (kbState.IsKeyDown(Keys.G) &&
                        prevKBState.IsKeyUp(Keys.G) &&
                        player.GodMode == true)
                    {
                        player.GodMode = false;
                    }

                    break;

                // If player is finished reading instructions, sends player to the Gameplay GameState
                case (GameState.Instructions):
                    // If player presses enter, sets currentGameState to Gameplay GameState 
                    if (kbState.IsKeyDown(Keys.Enter) &&
                        prevKBState.IsKeyUp(Keys.Enter))
                    {
                        currentGameState = GameState.Gameplay;
                    }
                    break;

                // If player dies or wins the game, sends player to the Gameover GameState
                case (GameState.Gameplay):

                    // Moves player based on current kbState
                    player.Move(kbState);

                    // Moves player's projectiles
                    playerProjectiles.Move();

                    // If there are enemies alive, moves them and their projectiles and checks if enemies take damage
                    if (enemy.Enemies.Count > 0)
                    {
                        // Moves all enemies
                        enemy.Move();

                        // Moves enemy projectiles
                        enemyProjectiles.Move();

                        // Checks to see if any enemy takes any damage from player projectiles
                        enemy.TakeDamage(player.ProjectileManager.Projectiles);
                    }

                    // Checks to see if player takes any damage from enemy projectiles
                    player.TakeDamage(enemy.Projectiles.Projectiles);

                    // If space key is pressed, player shoots a projectile
                    if (kbState.IsKeyDown(Keys.Space) &&
                        prevKBState.IsKeyUp(Keys.Space))
                    {
                        player.Shoot(form.Stats["ProjectileSpeed"], form.Stats["ProjectileDamage"]);
                    }

                    // Tracks the timing of the game for indicators to enemy ai
                    timer -= gameTime.TotalGameTime.TotalSeconds;
                    int tick = (int)timer % 100;


                    // If the tick hits zero, and there are enemies alive, all enemies will fire a projectile
                    if (tick == 0.0 && enemy.Enemies.Count > 0)
                    {
                        // Each enemy shoots a projectile
                        enemy.Fire(form.Stats["ProjectileSpeed"], form.Stats["ProjectileDamage"]);
                    }

                    // If there are any enemies, checks if any enemy dies and awards player with points accordingly
                    if (enemy.Enemies.Count > 0)
                    {
                        // Increases player's score based on number of enemies killed
                        player.Player.Score = player.Player.Score + enemy.IsDead();
                    }
                    
                    //Spawns a wave of enemies if the number of enemies is 0
                    if(enemy.Enemies.Count == 0)
                    {
                        Texture2D[] enemyShips = new Texture2D[4]{ enemyShip1, enemyShip2, enemyShip3, bossShip };
                        enemy.SpawnEnemyWave(enemyShips, form);
                        player.Player.Health = form.Stats["PlayerHealth"];

                    }


                    // Below are the conditions for spawning waves of enemies
                    //switch (player.Player.Score)
                    //{
                    //    // If player's score reaches 10 (beats the first wave of enemies), spawns 2nd wave (3 enemies)
                    //    case (10):
                    //        enemy.SpawnEnemy(enemyShip2, new Rectangle(0, 0, 48, 64), form.Stats["EnemyHealth"], form.Stats["EnemySpeed"]);
                    //        enemy.SpawnEnemy(enemyShip1, new Rectangle(376, 64, 48, 64), form.Stats["EnemyHealth"], form.Stats["EnemySpeed"]);
                    //        enemy.SpawnEnemy(enemyShip3, new Rectangle(842, 128, 48, 64), form.Stats["EnemyHealth"], form.Stats["EnemySpeed"]);

                    //        // Increases player score for clearing first wave
                    //        player.Player.Score += 10;

                    //        break;

                    //    // If player's score reaches 50 (beats the second wave of enemies), spawns 3rd wave (5 enemies)
                    //    case (50):
                    //        enemy.SpawnEnemy(enemyShip2, new Rectangle(720, 0, 48, 64), form.Stats["EnemyHealth"], form.Stats["EnemySpeed"] + 1);
                    //        enemy.SpawnEnemy(enemyShip1, new Rectangle(48, 128, 48, 64), form.Stats["EnemyHealth"], form.Stats["EnemySpeed"] + 1);
                    //        enemy.SpawnEnemy(enemyShip3, new Rectangle(144, 64, 48, 64), form.Stats["EnemyHealth"], form.Stats["EnemySpeed"] + 1);
                    //        enemy.SpawnEnemy(enemyShip2, new Rectangle(528, 64, 48, 64), form.Stats["EnemyHealth"], form.Stats["EnemySpeed"] + 1);
                    //        enemy.SpawnEnemy(enemyShip1, new Rectangle(384, 0, 48, 64), form.Stats["EnemyHealth"], form.Stats["EnemySpeed"] + 1);

                    //        // Increases player score for clearing first wave
                    //        player.Player.Score += 10;

                    //        break;


                    //}

                    // If player dies, sets currentGameState to Gameover
                    if (player.IsDead())
                    {
                        currentGameState = GameState.Gameover;
                    }

                    /*// Or if player beats the boss, the player wins, and sets currentGameState to Gameover
                    if (boss.IsDead == true) 
                    {
                        // Player wins
                        player.Win == true

                        currentGameState = GameState.Gameover;
                    }
                    */
                    break;

                // If player wants to continue, sends player to the Menu GameState
                case (GameState.Gameover):
                    // If player presses enter, sets currentGameState to Menu GameState and resets game
                    if (kbState.IsKeyDown(Keys.Enter) &&
                        prevKBState.IsKeyUp(Keys.Enter))
                    {
                        currentGameState = GameState.Menu;

                        // Calls initialize and load content to reset game
                        Initialize();
                        LoadContent();
                    }
                    break;
            }

            // Background should scroll
            //bgScroll.Y += 5;

            // Saves current keyboardState as previous keyboardState after checking all input
            prevKBState = kbState;

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // Begins spriteBatch and draws both background images (using 2 images to simulate scrolling)
            spriteBatch.Begin();
            spriteBatch.Draw(background, bgScroll1, Color.White);
            spriteBatch.Draw(background, bgScroll2, Color.White);

            // Draws items based on current game state
            // Menu State
            if (currentGameState == GameState.Menu) 
            {
                // Stores start menu text in a string
                menuString = "Press Enter to start the Game.";
                
                // Draws start menu
                spriteBatch.Draw(title, new Rectangle(titleCenter, 25, 375, 230), Color.White);
                spriteBatch.DrawString(menuText, menuString, new Vector2(175, 280), Color.White);
                spriteBatch.DrawString(hudText, "God Mode: " + player.GodMode, new Vector2(50, 50), Color.White);
            }
            // Instructions state
            if(currentGameState == GameState.Instructions) 
            {
                // Stores instructions in a string
                menuString = String.Format("Press W to Move Up \n" + 
                                           "Press S to Move Down \n" + 
                                           "Press A to Move Left \n" +
                                           "Press D to Move Right \n" +
                                           "Press SPACE to Shoot \n \n" +
                                           "Avoid and Shoot Enemies to Score \n" +
                                           "Get Hit Three Times and You Lose \n \n" +
                                           "Enemies spawn in Waves \n" +
                                           "Every fifth wave a Boss spawns \n \n" +
                                           "Good Luck!");

                // Draws instructions
                spriteBatch.DrawString(menuText, menuString, new Vector2(150, 100), Color.White);
            }
            // GameState
            if(currentGameState == GameState.Gameplay) 
            {
                // Calls player's draw method and passes in sprite batch object
                player.Draw(spriteBatch);

                // Calls playerProjectileManager's draw method and passes in sprite batch object
                playerProjectiles.Draw(spriteBatch, enemy.Enemies);

                // If there are enemies alive, calls draw methods for enemies
                if (enemy.Enemies.Count > 0)
                {
                    // Calls Enemy's draw method and passes in sprite batch object
                    enemy.Draw(spriteBatch);

                    // Calls the draw on enemy projectiles
                    enemyProjectiles.Draw(spriteBatch, player.Player.Rect);
                }

                // Drawing the player's health based on how much they have
                spriteBatch.DrawString(menuText, "Health:", new Vector2(30, 692), Color.White);
                for(int i = 0; i < player.Player.Health; i++)
                {
                    spriteBatch.Draw(health, new Vector2(56 + (i * 38), 732), Color.White);
                }

                // Drawing Score
                spriteBatch.DrawString(menuText, "Score:", new Vector2(780, 692), Color.White);
                thisScore = String.Format("{0}", player.Player.Score);
                spriteBatch.DrawString(menuText, thisScore, new Vector2(800, 732), Color.White);

                // Drawing Wave Number
                spriteBatch.DrawString(menuText, "Wave:", new Vector2(425, 692), Color.White);
                waveNum = String.Format("{0}", enemy.EnemyWave);
                spriteBatch.DrawString(menuText, waveNum, new Vector2(440, 732), Color.White);

            }
            // Gameover State
            if (currentGameState == GameState.Gameover) 
            {
                // Draws game over and instructions to continue text
                spriteBatch.DrawString(menuText, "GAME OVER", new Vector2(365, 330), Color.Red);
                spriteBatch.DrawString(menuText, "Press Enter to return to the Menu",
                                       new Vector2(150, 400), Color.White);
                spriteBatch.DrawString(menuText, $"Final Score: {player.Player.Score}", new Vector2(320, 470), Color.White);
            }


            // Ends spriteBatch
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
