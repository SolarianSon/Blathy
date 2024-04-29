namespace Amoba
{
    class GameState
    {
        public GameState(string name, string[] tableRows)
        {
            Name = "name";
            Table = new string[4][];
            for(int rowIndex = 0; rowIndex < 4; rowIndex++)
            {
                Table[rowIndex] = tableRows[rowIndex].Split(';');
            }
            MarkingTable = new bool[4,4];
        }
        public string Name {get; set;}
        public string[][] Table { get; private set; }
        public bool[,] MarkingTable { get; private set; }
        public void StepSigning (char position)
        {
            var value = position.ToString();
            for(int rowIndex = 0; rowIndex < 4; rowIndex++)
            {
                for(int colIndex = 0; colIndex < 4; colIndex++)
                {
                    if (Table[rowIndex][colIndex] == value)
                    {
                        MarkingTable[rowIndex, colIndex] = true;
                    }
                }
            }
        }
        public enum CheckState
        {
            Player1Won = 1,
            Player2Won = 2,
            Undecided = 0,
            Unfinished = -1
        }
        public bool CheckState2()
        {
            
            int rowIndex = 0;
            int colIndex = 0;
            while (rowIndex < 4)
            {
                while (colIndex < 4 && MarkingTable[rowIndex, colIndex])
                {
                    colIndex++;
                }
                if (colIndex == 4) return true;
                else colIndex = 0;
                rowIndex++;
            }

            colIndex = 0;
            rowIndex = 0;
            while (colIndex < 4)
            {
                while (rowIndex < 4 && MarkingTable[rowIndex, colIndex])
                {
                    rowIndex++;
                }
                if (rowIndex == 4) return true;
                else rowIndex = 0;
                colIndex++;
            }

            int i = 0;
            while (i < 4 && MarkingTable[i, i])
            {
                i++;
            }
            if (i == 4) return true;
            i = 0;
            while (i < 4 && MarkingTable[i, 3 - i]) i++;
            if (i == 4) return true;
            else return false;    
        }
    }
    internal class Program
    {
        const string playersPath = "C:\\_04.28\\beadando\\megoldas\\forras\\";
        static void Main(string[] args)
        {
            List<GameState> players = new List<GameState>();
            var names = File.ReadAllLines(playersPath + "gameStates.txt");
            foreach (var name in names)
            {
                var tableRows = File.ReadAllLines(playersPath + name);
                players.Add(new GameState(name, tableRows));
            }
            Console.WriteLine("6. feladat");
            /*Console.WriteLine("        Első játékos " + ... +"esetben nyert.");
            Console.WriteLine("        Második játékos " + ... +"esetben nyert.");
            Console.WriteLine(... +"esetben döntetlen eredmény született");
            Console.WriteLine(... +"esetben még nincsen teljesen lejátszva");*/
        }


    }
}
