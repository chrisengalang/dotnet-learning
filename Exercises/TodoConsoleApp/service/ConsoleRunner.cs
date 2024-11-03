using TodoConsoleApp.model;

namespace TodoConsoleApp.service;

public class ConsoleRunner {

    private bool isRunning = true;

    private List<Todo> todos;
    
    public ConsoleRunner() {

        todos = new List<Todo>();

        while (isRunning) {
            Console.Write("Please enter a command: ");
            string[] commandString = Console.ReadLine().Split(" ");
            string command = commandString[0];

            switch (command.ToLower()) {
                case "exit":
                    isRunning = false;
                    Console.WriteLine("Exiting! Goodbye for now!");
                    break;
                case "add":
                    Console.WriteLine("Adding todo.");
                    break;
                case "delete":
                    Console.WriteLine("Deleting todo.");
                    break;
                case "update":
                    Console.WriteLine("Updating todo.");
                    break;
                case "get":
                    Console.WriteLine("Retrieving todo.");
                    break;
                case "list":
                    Console.WriteLine("List of todos.");
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }
        
    }

}