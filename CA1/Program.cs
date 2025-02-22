﻿using System.Collections.Generic;
using System.IO;
using CA1;

class Program
{
    static void Main(string[] args)
    {


        RaceEventManager eventManager = new RaceEventManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nHorse Racing Event Manager:");
            Console.WriteLine("1. Create a new race event");
            Console.WriteLine("2. Add races to an event");
            Console.WriteLine("3. Upload a list of horses for a race");
            Console.WriteLine("4. Enter a horse in a race");
            Console.WriteLine("5. List upcoming events");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    eventManager.CreateRaceEvent();
                    break;
                case "2":
                    eventManager.AddRacesToEvent();
                    break;
                case "3":
                    eventManager.UploadHorses();
                    break;
                case "4":
                    eventManager.EnterHorseInRace();
                    break;
                case "5":
                    eventManager.ListUpcomingEvents();
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
