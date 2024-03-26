using System;
using System.Linq.Expressions;
using System.Xml.Serialization;

namespace chat_bot
{
    class Program
    {   
        static void TicketCalculator() //handles ticket calculator
        {
            int weekday_adult = 70; //defienes prices for adult tickets on weekdays
            int weekday_child = 30; //defienes prices for child tickets on weekdays
            int weekend_adult = 80; //defienes prices for adult tickets on weekends
            int weekend_child = 50; //defienes prices for child tickets on weekends
            int dayint = 0; //sets dayint value to 0 (dayint is used later)
            
            Console.WriteLine("");
            Console.Write("how many adults: ");
            int adult = Convert.ToInt32(Console.ReadLine()); //colects adult tickets
            if (adult == 0) //checks for no adult tickets
            {
                Console.WriteLine("there must be at least 1 adult ticket");
                TicketCalculator();
            }

            else if (adult >= 0)
            {
                Console.Write("how many chidren under 16: ");
                int child = Convert.ToInt32(Console.ReadLine()); //colects children tickets
                
                
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
                Console.Write("1");
                Console.ResetColor(); //converts text back to the default colour
                Console.Write("] Monday");
                Console.WriteLine("");

                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
                Console.Write("2");
                Console.ResetColor(); //converts text back to the default colour
                Console.Write("] Tuesday");
                Console.WriteLine("");

                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
                Console.Write("3");
                Console.ResetColor(); //converts text back to the default colour
                Console.Write("] Wednesday");
                Console.WriteLine("");

                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
                Console.Write("4");
                Console.ResetColor(); //converts text back to the default colour
                Console.Write("] Thursday");
                Console.WriteLine("");

                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
                Console.Write("5");
                Console.ResetColor(); //converts text back to the default colour
                Console.Write("] Friday");
                Console.WriteLine("");

                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
                Console.Write("6");
                Console.ResetColor(); //converts text back to the default colour
                Console.Write("] Saterday");
                Console.WriteLine("");

                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
                Console.Write("7");
                Console.ResetColor(); //converts text back to the default colour
                Console.Write("] Sunday");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.Write("what day are you atending the park: ");
                string day = Console.ReadLine(); //colects days atending park
                day = day.ToLower();

                switch (day) //converts day string value into a intiger value
                {
                    case "monday" or "1":
                        dayint = 1;
                        break;

                    case "tuesday" or "2":
                        dayint = 2;
                        break;
                    case "wednesday" or "3":
                        dayint = 3; 
                        break;
                    case "thursday" or "4":
                        dayint = 4;
                        break;
                    case "friday" or "5":
                        dayint = 5;
                        break;
                    case "saturday" or "6":
                        dayint = 6;
                        break;
                    case "sunday" or "7":
                        dayint = 7;
                        break;
                }
                
                if (dayint >= 1 && dayint <= 5) //calculates and prints ticket prices on weekdays
                { 
                    int adult_price = adult * weekday_adult;
                    int child_price = child * weekday_child;

                    int final_price = adult_price + child_price;
                    Console.WriteLine("the price for your trip to our parks is: £" + final_price + ".00");
                }

                else if (dayint == 6 || dayint == 7) //calculates and prints ticket prices on weekends
                {
                    int adult_price = adult * weekend_adult;
                    int child_price = child * weekend_child;

                    int final_price = adult_price + child_price;
                    Console.WriteLine("the price for your trip to our parks is: " + final_price);
                }

                else
                {
                    Console.WriteLine("somthing went wrong restarting module");
                    TicketCalculator();
                }
            }

            else //handles restarting function when input cannot be explained 
            {
                Console.WriteLine("somthing went wrong restarting module");
                TicketCalculator();
            }
        }

        static void dispfood() //handles displying food locations and prices 
        {
            Console.WriteLine("");
            Console.WriteLine("across our parks we provide a wide array of food depending on your location in the park: ");
            Console.WriteLine("");

            Console.WriteLine("where in the park do you want to eat? ");
            Console.WriteLine("your options are:");

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("1");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Adventure Alley");
            Console.WriteLine("");

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("2");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Fantasy Frontier");
            Console.WriteLine("");

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("3");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Wildlife Wonderland");
            Console.WriteLine("");

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("4");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Sci-Fi Sector");
            Console.WriteLine("");

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("5");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Enchanted Gardens");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.Write(">>> ");
            string foodchoice = Console.ReadLine(); //handles taking imputs
            foodchoice = foodchoice.ToLower(); //convets inputs to lower case 

            switch (foodchoice)
            {
                case "adventure alley" or "adventure" or "alley" or "1":
                    Console.WriteLine("");
                    Console.WriteLine("Adventure Alley: ");
                    Console.WriteLine("");
                    Console.WriteLine("Jungle Feast Food: ");
                    Console.WriteLine("Grilled Chicken Skewers:                 £6.50");
                    Console.WriteLine("Vegetable Spring Rolls:                  £4.50");
                    Console.WriteLine("Tropical Fruit Salad:                    £3.50");
                    Console.WriteLine("");
                    Console.WriteLine("Explorers' Grill Restaurant: ");
                    Console.WriteLine("Bison Burger with Fries:                 £9.50");
                    Console.WriteLine("Fish Tacos with Mango Salsa:             £8.50");
                    Console.WriteLine("Campfire BBQ Ribs:                       £10.50");
                    Console.WriteLine("");
                    break;
                        
                case "fantasy frontier" or "fantasy" or "frontier" or "2":
                    Console.WriteLine("");
                    Console.WriteLine("Fantasy Frontier: ");
                    Console.WriteLine("");
                    Console.WriteLine("Dragon's Roost: ");
                    Console.WriteLine("");
                    Console.WriteLine("Dragonfire Chili:                        £7.50");
                    Console.WriteLine("Unicorn Corn Dogs:                       £5.50");
                    Console.WriteLine("Fairy Floss (Cotton Candy):              £3.00");
                    Console.WriteLine("");
                    Console.WriteLine("Knight's Banquet Restaurant:");
                    Console.WriteLine("xcalibur Steak with Roasted Vegetables:  £15.50");
                    Console.WriteLine("Wizard's Pasta with Marinara Sauce:      £12.50");
                    Console.WriteLine("Elven Salad with Forest Berries:         £8.50");
                    Console.WriteLine("");
                    break;
            
                case "wildlife Wonderland" or "wildlife" or "wonderland" or "3":
                    Console.WriteLine("");
                    Console.WriteLine("Wildlife Wonderland: ");
                    Console.WriteLine("");
                    Console.WriteLine("Safari Snacks:");
                    Console.WriteLine("Zebra Striped Popcorn:                   £4.00");
                    Console.WriteLine("Safari Trail Mix:                        £3.50");
                    Console.WriteLine("Hippo-Size Pretzel:                      £5.00");
                    Console.WriteLine("");
                    Console.WriteLine("Jungle Oasis Restaurant:");
                    Console.WriteLine("Tandoori Chicken with Basmati Rice:      £11.50");
                    Console.WriteLine("Elephant Ear Thai Curry with Naan Bread: £10.50");
                    Console.WriteLine("Greens Salad with Coconut Dressing:      £7.50");
                    Console.WriteLine("");
                    break;
            
                case "sci-fi sector" or "sci-fi" or "sector" or "4":
                    Console.WriteLine("");
                    Console.WriteLine("Sci-Fi Sector: ");
                    Console.WriteLine("");
                    Console.WriteLine("Galactic Grub: ");
                    Console.WriteLine("Space Burger with Galactic Fries:        £8.50");
                    Console.WriteLine("Nebula Nachos:                           £6.50");
                    Console.WriteLine("Photon Pops (Glow-in-the-Dark Popcorn):  £4.00");
                    Console.WriteLine("");
                    Console.WriteLine("Alien Cafe Restaurant:");
                    Console.WriteLine("Interstellar Pizza with Rocket Pesto:    £9.50");
                    Console.WriteLine("Cyborg Stir-Fry with Cosmic Rice:        £11.50");
                    Console.WriteLine("UFO Salad with Martian Vinaigrette:      £7.50");
                    Console.WriteLine("");
                    break;
            
                case "enchanted gardens" or "enchanted" or "gardens" or "5":
                    Console.WriteLine("");
                    Console.WriteLine("Enchanted Gardens: ");
                    Console.WriteLine("");
                    Console.WriteLine("Pixie Pastries: ");
                    Console.WriteLine("Fairy Cakes (Assorted Cupcakes):         £4.50");
                    Console.WriteLine("Enchanted Eclairs:                       £3.50");
                    Console.WriteLine("Magic Muffins:                           £2.50");
                    Console.WriteLine("");
                    Console.WriteLine("Unicorn's Retreat Restaurant:");
                    Console.WriteLine("Enchanted Forest Risotto:                £12.50");
                    Console.WriteLine("Mermaid's Linguine with Seafood:         £14.50");
                    Console.WriteLine("Garden Salad with Ambrosia Dressing:     £8.50");
                    break;

                case "calculator" or "price calculator": //runs price calculator
                    TicketCalculator();
                    break;
                
                case "clear": //clears console 
                    Console.Clear();
                    disprides();
                    break;

                case "exit": //exits program and console
                    Environment.Exit(0);
                    break;

                case "help" or "-h": //displays help text
                    HelpText();
                    disprides();
                    break;

                default:
                    Console.WriteLine("");
                    Console.WriteLine("invalid sintax please input your choice again");
                    dispfood();
                break;
            }
        }

        static void disprides() //handles displaying ride names text 
        {   
            Console.WriteLine("");
            Console.WriteLine("some rides are not sutabel for children under 12:");
            Console.WriteLine("please pick from one of our sectors that have rides: ");
            Console.WriteLine("");
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("1");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Adventure Alley");
            Console.WriteLine("");

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("2");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Fantasy Frontier");
            Console.WriteLine("");

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("3");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Wildlife Wonderland");
            Console.WriteLine("");

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("4");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Sci-Fi Sector");
            Console.WriteLine("");

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("5");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Enchanted Gardens");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.Write(">>> ");
            string sectorchoice = Console.ReadLine(); //handles taking imputs
            sectorchoice = sectorchoice.ToLower(); //convets inputs to lower case

            switch (sectorchoice)
            {
                case "adventure alley" or "adventure" or "alley" or "1":
                    Console.WriteLine("");
                    Console.WriteLine("the adventuer alley douse not have any rides but there is a wide array of shops");
                    Console.WriteLine("use the shop option to display the shops in each sector");
                    break;
                
                case "fantasy frontier" or "fantasy" or "frontier" or "2":
                    Console.WriteLine("");
                    Console.WriteLine("Fantasy Frontier:"); 
                    Console.WriteLine("adult rides: ");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("child rides: ");
                    Console.WriteLine("");
                    break;
                
                case "wildlife wonderland" or "wildlife" or "wonderland" or "3":
                    Console.WriteLine("");
                    Console.WriteLine("Wildlife Wonderland:"); 
                    Console.WriteLine("adult rides: ");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("child rides: ");
                    Console.WriteLine("");
                    break;

                case "sci-fi sector" or "sci-fi" or "sector" or "sci" or "4":
                    Console.WriteLine("");
                    Console.WriteLine("Sci-Fi Sector: "); 
                    Console.WriteLine("adult rides: ");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("child rides: ");
                    Console.WriteLine("");
                    break;

                case "enchanted gardens" or "enchanted" or "gardens" or "5":
                    Console.WriteLine("");
                    Console.WriteLine("Enchanted Gardens");
                    Console.WriteLine("adult rides: ");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("child rides: ");
                    Console.WriteLine("");
                    break;

                case "calculator" or "price calculator": //runs price calculator
                    TicketCalculator();
                    break;
                
                case "clear": //clears console 
                    Console.Clear();
                    disprides();
                    break;

                case "exit": //exits program and console
                    Environment.Exit(0);
                    break;

                case "help" or "-h": //displays help text
                    HelpText();
                    disprides();
                    break;
                
                default:
                    Console.WriteLine("");
                    Console.WriteLine("invalid sintax please input your choice again");
                    disprides();
                    break;
            }
        }

        static void dispshops() //handels displaying shop info
        {
            Console.WriteLine("");
            Console.WriteLine("please pick from one of our sectors to dispaly shops: ");
            Console.WriteLine("");
             Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("1");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Adventure Alley");
            Console.WriteLine("");

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("2");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Fantasy Frontier");
            Console.WriteLine("");

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("3");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Wildlife Wonderland");
            Console.WriteLine("");

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("4");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Sci-Fi Sector");
            Console.WriteLine("");

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("5");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Enchanted Gardens");
            Console.WriteLine("");


            Console.WriteLine("");
            Console.Write(">>> ");
            string shopchoice = Console.ReadLine();
            shopchoice = shopchoice.ToLower();
            
            switch (shopchoice)
            {   
                case "adventure alley" or "adventure" or "alley" or "1":
                    Console.WriteLine("");
                    Console.WriteLine("in the Adventure Alley we have the: ");
                    Console.WriteLine("");
                    Console.WriteLine("Gear Up Outfitters: ");
                    Console.WriteLine("Offers hiking gear, backpacks, and adventure apparel");
                    Console.WriteLine("");
                    Console.WriteLine("Treasure Trove Emporium: ");
                    Console.WriteLine("Sells souvenirs, maps, and explorer-themed gifts");
                    Console.WriteLine("");
                    Console.WriteLine("Expedition Supplies Co: ");
                    Console.WriteLine("Provides camping equipment, survival tools, and outdoor accessories");
                    Console.WriteLine("");
                    Console.WriteLine("Safari Safari: ");
                    Console.WriteLine("Specializes in wildlife-themed toys, plush animals, and safari gear");
                    Console.WriteLine("");
                    Console.WriteLine("Adventure Artifacts: ");
                    Console.WriteLine("Features artifacts, fossils, and replicas from around the world");
                    break;

                case "fantasy frontier" or "fantasy" or "frontier" or "2":
                    Console.WriteLine("");
                    Console.WriteLine("in the Fantasy Frontier we have the: ");
                    Console.WriteLine("");
                    Console.WriteLine("Wizard's Wonders: ");
                    Console.WriteLine("Offers magical wands, spellbooks, and fantasy-themed collectibles.");
                    Console.WriteLine("");
                    Console.WriteLine("Dragon's Hoard: ");
                    Console.WriteLine("Sells dragon figurines, fantasy jewelry, and mystical artifacts.");
                    break;

                case "wildlife wonderland" or "wildlife" or "wonderland" or "3":
                    Console.WriteLine("");
                    Console.WriteLine("in the Wildlife Wonderland we have the: ");
                    Console.WriteLine("");
                    Console.WriteLine("Animal Kingdom Boutique:");
                    Console.WriteLine("Offers wildlife-themed clothing, stuffed animals, and educational toys.");
                    Console.WriteLine("");
                    Console.WriteLine("Nature's Treasures:");
                    Console.WriteLine("Sells nature-inspired home decor, books on wildlife, and eco-friendly gifts.");
                    break;
                    
                case "sci-fi sector" or "sci-fi" or "sector" or "4":
                    Console.WriteLine("");
                    Console.WriteLine("in the Sci-Fi Sector we have the: ");
                    Console.WriteLine("");
                    Console.WriteLine("Galaxy Gear Emporium: ");
                    Console.WriteLine("Offers futuristic gadgets, space-themed toys, and sci-fi memorabilia.");
                    Console.WriteLine("");
                    Console.WriteLine("Alien Oddities: ");
                    Console.WriteLine("Sells extraterrestrial souvenirs, UFO models, and alien-themed apparel.");
                    break;

                case "enchanted gardens" or "enchanted" or "gardens" or "5":
                    Console.WriteLine("");
                    Console.WriteLine("in the Enchanted Gardens we have the: ");
                    Console.WriteLine("");
                    Console.WriteLine("Fairy Fashions: ");
                    Console.WriteLine("Offers fairy wings, enchanted dresses, and magical accessories.");
                    Console.WriteLine("");
                    Console.WriteLine("Enchanted Elixirs: ");
                    Console.WriteLine("Sells herbal teas, potions, and mystical elixirs for relaxation and wellness.");
                    break;
                    
                case "calculator" or "price calculator": //runs price calculator
                        TicketCalculator();
                        break;
                
                case "clear": //clears console 
                    Console.Clear();
                    dispshops();
                    break;

                case "exit": //exits program and console
                    Environment.Exit(0);
                    break;

                case "help" or "-h": //displays help text
                    HelpText();
                    dispshops();
                    break;
                
                default:
                    Console.WriteLine("");
                    Console.WriteLine("invalid sintax please input your choice again");
                    dispshops();
                    break;
            }
        }

        static void logo()
        {
            string logo = @"   
             _                               _  ______          _        
            | |                             | | | ___ \        | |       
            | |     ___  __ _  ___ _ __   __| | | |_/ /_ _ _ __| | _____ 
            | |    / _ \/ _` |/ _ \ '_ \ / _` | |  __/ _` | '__| |/ / __|
            | |___|  __/ (_| |  __/ | | | (_| | | | | (_| | |  |   <\__ \
            \_____/\___|\__, |\___|_| |_|\__,_| \_|  \__,_|_|  |_|\_\___/
                         __/ |                                           
                        |___/                                            
            ";

            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.WriteLine(logo);
            Console.ResetColor(); //converts text back to the default colour
        }

        static void HelpText() //handles displaying help text 
        {
            Console.WriteLine("");
            Console.WriteLine("Frequently Used Questions:");

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("1");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Opening Times");

            Console.WriteLine("");
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("2");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Ticket Prices");

            Console.WriteLine("");
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("3");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Rides");

            Console.WriteLine("");
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("4");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Food");

            Console.WriteLine("");
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red; //converts text the colour red
            Console.Write("5");
            Console.ResetColor(); //converts text back to the default colour
            Console.Write("] Shops");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Avalible Commands:");
            Console.WriteLine("calculator       opens the price calculator");
            Console.WriteLine("clear            clears text on screen");
            Console.WriteLine("help -h          displayes this text");
            Console.WriteLine("exit             exits program");
        }

        static void Main(string[] args)
        {
            logo();
            Console.WriteLine("welcome to the Ledend Parks Chatbot sevise");
            HelpText();

            while (true)
            {
                Console.WriteLine("");
                Console.Write(">>> ");
                string choice = Console.ReadLine();
                choice = choice.ToLower();         

                switch (choice) //used to display text based on inputs above
                {
                    case "opening times" or "1": //displayes opening times
                        Console.WriteLine("");
                        Console.WriteLine("The opening times for our parks are:");
                        Console.WriteLine("");
                        Console.WriteLine("Day:             Opening times:          closing times:");
                        Console.WriteLine("Weekdays:");
                        Console.WriteLine("Monday           10:00                   20:00");
                        Console.WriteLine("Tuesday          10:00                   20:00");
                        Console.WriteLine("Wednesday        10:00                   20:00");
                        Console.WriteLine("Thersday         10:00                   20:00");
                        Console.WriteLine("Friday           10:00                   20:00");
                        Console.WriteLine("");
                        Console.WriteLine("Weekends:");
                        Console.WriteLine("Saterday         10:00                   21:00");
                        Console.WriteLine("Sunday           11:00                   19:00");
                        break;

                    case "ticket prices" or "2": //displayes ticket prices
                        Console.WriteLine("");
                        Console.WriteLine("the current ticket price are:");
                        Console.WriteLine("");
                        Console.WriteLine("week Day:");
                        Console.WriteLine("Adults:      £70.00");
                        Console.WriteLine("Children:    £30.00");
                        Console.WriteLine("");
                        Console.WriteLine("Weekend:");
                        Console.WriteLine("Adults:      £80.00");
                        Console.WriteLine("Chidren:     £50.00");
                        Console.WriteLine("");
                        Console.WriteLine("Specal Offers:");
                        Console.WriteLine("Famaly pass: £210.00");
                        Console.WriteLine("annual pass: £2500.00");
                        Console.WriteLine("");
                        Console.WriteLine("to accsess a pricing calculator enter: price calculator");
                        break;

                    case "calculator" or "price calculator": //runs price calculator
                        TicketCalculator();
                        break;

                    case "rides" or "3":
                        disprides();
                        break;

                    case "food" or "4": //runs dipfood modual
                        dispfood();    
                        break;
                    
                    case "shops" or "shop" or "5":
                        dispshops();
                        break;

                    case "clear": //clears console 
                        Console.Clear();
                        break;

                    case "exit": //exits program and console
                        Environment.Exit(0);
                        break;

                    case "help" or "-h": //displays help text
                        HelpText();
                        break;

                    default: 
                        Console.WriteLine("");
                        Console.WriteLine("im sorry i dont understand try useing the frequently used questions:");
                        HelpText();
                        break;
                }
            }
        }
    }
}