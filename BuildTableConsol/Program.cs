using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassAndEnum
{
    class Program
    {
        // Збираємо новий стіл
        static Table BuildTable()
        {
            Console.WriteLine();
            Console.WriteLine("Build you table.\n");

            Table newTable = new Table();

            bool repeat;
            // вибираємо матеріал стола
            Console.WriteLine("Chooce material.\n");
            do
            {
                repeat = false;
                int tableMaterial;

                Console.WriteLine("1: Wood\n2: Glass \n3: Steal");

                int.TryParse(Console.ReadLine(), out tableMaterial);

                switch (tableMaterial)
                {
                    case 1:
                        newTable.material = Material.Wood;
                        break;
                    case 2:
                        newTable.material = Material.Glass;
                        break;
                    case 3:
                        newTable.material = Material.Steel;
                        break;
                    default:
                        Console.WriteLine("Choose correct option number !!!");
                        repeat = true;
                        break;
                }

            } while (repeat == true);
            // вибираємо колір стола
            Console.WriteLine("Chooce color");
            do
            {
                repeat = false;
                int tableColor;

                Console.WriteLine("1: Red\n2: Broun \n3: White");

                int.TryParse(Console.ReadLine(), out tableColor);

                switch (tableColor)
                {
                    case 1:
                        newTable.color = Color.Red;
                        break;
                    case 2:
                        newTable.color = Color.Broun;
                        break;
                    case 3:
                        newTable.color = Color.Whine;
                        break;
                    default:
                        Console.WriteLine("Choose correct option number !!!");
                        repeat = true;
                        break;

                }

            } while (repeat == true);
            // вибираємо кількість ножок стола
            Console.WriteLine("Chooce value legs");
            do
            {
                repeat = false;
                int numberOfLegs;

                Console.WriteLine("1: Three\n2: Four \n3: Five");

                int.TryParse(Console.ReadLine(), out numberOfLegs);

                switch (numberOfLegs)
                {
                    case 1:
                        newTable.legs = Legs.Three;
                        break;
                    case 2:
                        newTable.legs = Legs.Four;
                        break;
                    case 3:
                        newTable.legs = Legs.Five;
                        break;
                    default:
                        Console.WriteLine("Choose correct option number !!!");
                        repeat = true;
                        break;
                }

            } while (repeat == true);

            return newTable;
        }
        // Друкуємо в консоль зібраний стіл
        static void Print(Table newTable)
        {
            Console.WriteLine($"You table is {newTable.material}|{newTable.color}|legs {newTable.legs}");
            BuildNext();
        }
        // запитуємо чи будемо збирати новий стіл
        static void BuildNext()
        {
            Console.WriteLine("You want build new table? \nYes|No \n");
            bool repeat;
            do
            {
                repeat = false;

                string wantBuildNext = Console.ReadLine();
                wantBuildNext = wantBuildNext.ToLower();

                if (wantBuildNext == "yes")
                {
                    Console.Clear();
                    Table nextTable = BuildTable();
                    Print(nextTable);
                }
                else if (wantBuildNext == "no")
                {
                    Console.WriteLine("So sad, good luck.");
                }
                else
                {
                    Console.WriteLine("Wrong command!!! Try again ;)");
                    repeat = true;
                }

            } while (repeat == true);
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"You wanna build table? \nYes|No");

            bool repeat;

            do
            {
                repeat = false;

                string wantBuildNext = Console.ReadLine();
                wantBuildNext = wantBuildNext.ToLower();

                if (wantBuildNext == "yes")
                {
                    Table firstTable = BuildTable();
                    Print(firstTable);
                }
                else if (wantBuildNext == "no")
                {
                    Console.WriteLine("So sad, good luck.");
                }
                else
                {
                    Console.WriteLine("Wrong command!!! Try again ;)");
                    repeat = true;
                }

            } while (repeat == true);


        }


    }

}

