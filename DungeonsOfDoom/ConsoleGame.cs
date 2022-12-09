namespace DungeonsOfDoom
{
    internal class ConsoleGame
    {
        Player player;
        Room[,] world;
        Random random = new Random();

        /// <summary>
        /// Main Game loop
        /// </summary>
        public void Play()
        {
            CreatePlayer();
            CreateWorld();

            do
            {
                Console.Clear();
                DisplayWorld();
                DisplayStats();
                AskForMovement();
            } while (player.IsAlive);

            GameOver();
        }

        /// <summary>
        /// Spawns a player
        /// </summary>
        private void CreatePlayer()
        {
            player = new Player(30, 0, 0);
        }

        /// <summary>
        /// Generates the game room
        /// </summary>
        private void CreateWorld()
        {
            world = new Room[20, 5];
            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    world[x, y] = new Room();

                    int percentage = random.Next(0, 100);
                    if (percentage < 5) // 50% it's an ogre
                        world[x, y].Monster = new Ogre();
                    else if (percentage < 10) // 10% it's a skeleton
                        world[x, y].Monster = new Skeleton();                            
                    else if (percentage < 20)
                        world[x, y].Item = new Item("Sword");
                }
            }
        }

        /// <summary>
        /// Renders the game room to the console window
        /// </summary>
        private void DisplayWorld()
        {
            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    Room room = world[x, y];
                    if (player.X == x && player.Y == y)
                        Console.Write("P");
                    else if (room.Monster != null)
                        Console.Write("M");
                    else if (room.Item != null)
                        Console.Write("I");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
        }

        private void DisplayStats()
        {
            Console.WriteLine($"Health: {player.Health}");
        }

        private void AskForMovement()
        {
            int newX = player.X;
            int newY = player.Y;
            bool isValidKey = true;

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.RightArrow: newX++; break;
                case ConsoleKey.LeftArrow: newX--; break;
                case ConsoleKey.UpArrow: newY--; break;
                case ConsoleKey.DownArrow: newY++; break;
                default: isValidKey = false; break;
            }

            if (isValidKey &&
                newX >= 0 && newX < world.GetLength(0) &&
                newY >= 0 && newY < world.GetLength(1))
            {
                player.X = newX;
                player.Y = newY;
            }
        }

        private void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Game over...");
            Console.ReadKey();
            Play();
        }
    }
}