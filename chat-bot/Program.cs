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
        static void dispfood()
        {
            Console.WriteLine("");
                        Console.WriteLine("across our parks we provide a wide array of food depending on your location in the park: ");
                        Console.WriteLine("");

                        Console.WriteLine("where in the park do you want to eat? ");
                        Console.WriteLine("your options are:");
                        Console.WriteLine("Adventure Alley");
                        Console.WriteLine("Fantasy Frontier");
                        Console.WriteLine("Wildlife Wonderland");
                        Console.WriteLine("Sci-Fi Sector");
                        Console.WriteLine("Enchanted Gardens");

                        Console.WriteLine("");
                        Console.Write(">>> ");
                        string foodchoice = Console.ReadLine();
                        foodchoice = foodchoice.ToLower();         

                        
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
        }
        static void HelpText() //handles displaying help text 
        {
            Console.WriteLine("");
            Console.WriteLine("Frequently Used Questions:");
            Console.WriteLine("opening times \nticket prices \nrides \nfood");
            Console.WriteLine("");
            Console.WriteLine("Avalible Commands:");
            Console.WriteLine("calculator       opens the price calculator");
            Console.WriteLine("clear            clears text on screen");
            Console.WriteLine("help -h          displayes this text");
            Console.WriteLine("exit             exits program");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to the Ledend Parks Chatbot sevise");
            HelpText();

            while (true)
            {
                Console.WriteLine("");
                Console.Write(">>> ");

                string choice = Console.ReadLine();
                choice = choice.ToLower();         

                switch (choice) //used to display text based on inputs above
                {
                    case "opening times": //displayes opening times
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

                    case "ticket prices": //displayes ticket prices
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

                    case "rides":
                        Console.WriteLine("");
                        Console.WriteLine("some rides are not sutabel for children under 12:");
                        Console.WriteLine("");
                        Console.WriteLine("adult rides: ");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("child rides: ");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        break;

                    case "food":
                        dispfood();
                        
                        break;

                    case "clear":
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