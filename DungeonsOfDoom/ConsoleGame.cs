namespace DungeonsOfDoom
{
    internal class ConsoleGame
    {
        Player player;
        Room[,] world;
        Random random = new();

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
                        world[x, y].Monster = new Ogre();  // example of type substitution
                    else if (percentage < 10) // 10% it's a skeleton
                        world[x, y].Monster = new Skeleton();                            
                    else if (percentage < 12)
                        world[x, y].Item = new TeleportPotion();
                    else if (percentage < 15)
                        world[x, y].Item = new Potion();
                    else if (percentage < 20)
                        world[x, y].Item = new Sword();
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

        /// <summary>
        /// Displays players stats
        /// </summary>
        private void DisplayStats()
        {
            Console.WriteLine("______________________");
            Console.WriteLine($"Health: {player.Health}");
            Console.WriteLine($"Damage: {player.Damage}");

            foreach (Item item in player.Backpack)
            {
                Console.WriteLine(item.Name);
            }
        }

        /// <summary>
        /// Handles player movements
        /// </summary>
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

                EnterRoom();
            }
        }

        /// <summary>
        /// Player has entered the room
        /// </summary>
        private void EnterRoom()
        {
            Room currentRoom = world[player.X, player.Y];
            Monster monster = currentRoom.Monster;

            // handle monster in the room
            if (monster is not null)
            {
                // monster will attack
                AttackResult attackResult = monster.Attack(player);
                Console.WriteLine($"Monster damaged player for '{attackResult.Damage}' damage...");
                Console.ReadKey(true);

                if (player.IsAlive)
                {
                    attackResult = player.Attack(monster);
                    Console.WriteLine($"Player damaged monster for '{attackResult.Damage}' damage...");
                    Console.ReadKey(true);
                }

                if (!monster.IsAlive)
                    currentRoom.Monster = null;
            }

            if (currentRoom.Item is not null)
            {
                // player wants to pick up this item
                player.Backpack.Add(currentRoom.Item); // example of type substitution

                currentRoom.Item.Use(player);

                currentRoom.Item = null; // removes item from the world
            }
        }

        /// <summary>
        /// Game ends handle all logic here
        /// </summary>
        private void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Game over...");
            Console.ReadKey();
            Play();
        }
    }
}