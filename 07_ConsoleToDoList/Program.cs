using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConsoleToDoList
{
    class Program
    {
        private static List<string> todos = new List<string>();
        static void Main(string[] args)
        {
            MenuActions currentAction = MenuActions.Help;
            string param = "";

            do
            {
                (currentAction, param) = GetMenuAction();
                Console.WriteLine();
                switch (currentAction)
                {
                    case MenuActions.Add:
                        AddToDo(param);
                        break;
                    case MenuActions.Print:
                        Print(3);
                        break;
                    case MenuActions.PrintAll:
                        break;
                    case MenuActions.Done:
                        Done(param);
                        break;
                    case MenuActions.Exit:
                        break;
                    case MenuActions.Help:
                        PrintHelp();
                        break;
                    case MenuActions.Clear:;
                        Clear();
                        break;
                }
                Console.WriteLine();
            } while (currentAction != MenuActions.Exit);
        }

        private static (MenuActions action, string param) GetMenuAction()
        {
            MenuActions action = MenuActions.Help;

            Console.Write("What would you like to do: ");
            string fullAction = Console.ReadLine();
            string actionString = fullAction;
            string param = "";

            if (fullAction.IndexOf(' ') >= 0)
            {
                actionString = fullAction.Substring(0, fullAction.IndexOf(' '));
                param = fullAction.Substring(fullAction.IndexOf(' ') + 1);
            }

            if(Enum.TryParse(actionString, out action) == false)
            {
                action = MenuActions.Help;
            }

            /*switch (action.ToLower())
            {
                case "add":
                    output = MenuActions.Add;
                    break;
                case "Print":
                    output = MenuActions.Print;
                    break;
                case "PrintAll":
                    output = MenuActions.PrintAll;
                    break;
                case "Done":
                    output = MenuActions.Done;
                    break;
                case "Exit":
                    output = MenuActions.Exit;
                    break;
                case "Help":
                    output = MenuActions.Help;
                    break;
                default:
                    break;
            }*/
        }

        private static void PrintHelp()
        {
            Console.WriteLine();
            Console.WriteLine("Action list: ");
            Console.WriteLine("Add - Add an item to the list.");
            Console.WriteLine("Print - print the top 3 todos.");
            Console.WriteLine("PrintAll - Print all of the todos.");
            Console.WriteLine("Done - Complete the aplication.");
            Console.WriteLine("ReOrder - Changes the order of a todo.");
            Console.WriteLine("Clear - Clears the screen.");
            Console.WriteLine("Exit - Exit the aplication");
            Console.WriteLine("Help - get help.");
            Console.WriteLine();
        }
        private static void AddToDo(string todo)
        {
            todos.Add(todo);
        }

        private static void Print(int count = 0)
        {
            if(count == 0 || count > todos.Count)
            {
                count = todos.Count;
            }
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine($"{ i }: { todos[i] }");
            }
        }
        
        private static void Done(string todoNumber)
        {
            if(int.TryParse(todoNumber, out int todo))
            {
                todos.RemoveAt(todo);
            }
            else
            {
                Console.WriteLine("That was an invalid todo number");
            }
        }
        private static void Clear()
        {
            Console.Clear();
        }
        private static void ReOrder(string parameters)
        {
            string[] paramSet = parameters.Split(' ');
            if (paramSet.Length != 2)
            {
                Console.WriteLine("You need to pass in the correct number of parameters");
                return;

            }

            int from = 0;
            int to = 0;
            if (int.TryParse(paramSet[0], out from) == false)
            {
                Console.Write("You need to pass a valid from number");
                return;
            }
            if (int.TryParse(paramSet[1], out to) == false)
            {
                Console.Write("You need to pass a valid from number");
                return;
            }

            if(from < 0 || from > todos.Count - 1)
            {
                Console.WriteLine("From is not in a valid range");
                return;
            }
            if (to < 0 || to > todos.Count - 1)
            {
                Console.WriteLine("To is not in a valid range");
                return;
            }
            string todo = todos[from];
            todos.RemoveAt(from);
            todos.Insert(to, todo);
        }
    }
    public enum MenuActions
    {
        Add, Print, PrintAll, Done, ReOrder, Exit, Help, Clear
    }
}
