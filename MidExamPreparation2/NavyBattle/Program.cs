namespace NavyBattle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] battlefield = new char[size, size];

            int submarineRow = -1;
            int submarineCol = -1;

            int minesToBlow = 3;
            int cruisersToDestroy = 3;
            
            for (int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    battlefield[row, col] = input[col];
                    if (input[col] == 'S')
                    {
                        submarineRow = row;
                        submarineCol = col;
                    }
                }
            }

                string direction = Console.ReadLine();

            while(true)
            {
                battlefield[submarineRow, submarineCol] = '-';

                switch (direction)
                {
                    case "up":
                        submarineRow--;
                        break;
                    case "down":
                        submarineRow++;
                        break;
                    case "left":
                        submarineCol--;
                        break;
                    case "right":
                        submarineCol++;
                        break;
                }

                if (battlefield[submarineRow, submarineCol] == '*')
                {
                    minesToBlow--;
                }
                if (battlefield[submarineRow, submarineCol] == 'C')
                {
                    cruisersToDestroy--;
                }


                if (minesToBlow == 0)
                {
                    battlefield[submarineRow, submarineCol] = 'S';
                    Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarineRow}, {submarineCol}]!");
                    break;
                }
                if(cruisersToDestroy == 0)
                {
                    battlefield[submarineRow, submarineCol] = 'S';
                    Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                    break;
                }



                direction = Console.ReadLine();
            }


            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(battlefield[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}