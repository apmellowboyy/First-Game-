using System;
namespace greatAdventure
{
    class versionOne
    {
        static void Main(string[] args)
        {
            int lives = 0, magic = 0, health = 0, direction = 0, round = 0;
            Random r = new Random();
            bool win = false;
            Console.Write("What is the name of your character? ");
            string name = Console.ReadLine();
            initValues(ref lives, ref magic, ref health, r);
            while (lives > 0 && magic > 0 && health > 0 && win==false)
            {
                direction = chooseDirection();
                /* the direction impacts the number passed to the actions method
                 * if they choose left, they will only receive bad outcomes
                 * if they choose right, they have a better chance of receiving 
                 * good outcomes along with the bad outcomes */
                if (direction == 1)
                    actions(r.Next(4), ref lives, ref magic, ref health);
                else
                    actions(r.Next(10), ref lives, ref magic, ref health);
                checkResults(ref round, ref lives, ref magic, ref health, ref win);
            }
            if (win)
                Console.WriteLine("Congratulations on successfully completing your journey!");
            else if (lives <= 0)
                Console.WriteLine("You lost too many lives and did not complete your journey");
            else if (magic <= 0)
                Console.WriteLine("You don't have any magic left and cannot complete your journey");
            else
                Console.WriteLine("You are in poor health and had to stop your journey before it's completion");



            static void checkResults(ref int round, ref int lives, ref int magic, ref int health, ref bool win)
            {
                Console.WriteLine($"~~~~~~~~~ROUND {round}~~~~~~~~~");
                Console.WriteLine("");
                Console.WriteLine($"Lives={lives}");
                Console.WriteLine($"Magic={magic}");
                Console.WriteLine($"Health={health}");
                round++;
                if (round >= 25)
                    win = true;
                return;

            }
        }

        private static int chooseDirection()
        {

            Console.WriteLine("You have come to a crossroad, enter 1 to travel left, 2 to travel right, 3 to travel straight, 4 to travel back.");
            int direction = int.Parse(Console.ReadLine());
            while (direction != 1 && direction != 2 && direction !=3 && direction !=4)
            {
                Console.WriteLine("You entered an invalid number, please enter 1 to travel left or a 2 to travel right.");
                direction = int.Parse(Console.ReadLine());
            }
            return direction;
        }

        private static void initValues(ref int lives, ref int magic, ref int health, Random r)
        {
            lives = r.Next(10) + 1;
            magic = r.Next(15) + 5;
            health = r.Next(14) +5;
            return;
        }

        private static void actions(int num, ref int lives, ref int magic, ref int health)
        {


            switch (num)
            {
                case 0:
                    Console.WriteLine("You met three bears who were not happy that their porridge was gone.");
                    
                    Console.WriteLine("You lose 1 unit of health, 1 unit of magic and 1 unit of life.");
                    health -= 1;
                    magic -= 1;
                    lives -=1;
                    break;
                case 1:
                    Console.WriteLine("You were abducted by flying monkeys and had to be rescued by a young girl and a dog.");
                    
                    Console.WriteLine("You lost 2 units of health, 2 units of magic and 1 unit of life.");
                    health -= 2;
                    magic -= 2;
                    lives -= 1;
                    break;
                case 2:
                    Console.WriteLine("You ran into Yugi who use his Blue Eyes White Dragon on you");
                    
                    Console.WriteLine("You lost 2 units of health, 2 units of magic, and 2 units of lives.");
                    health -= 2;
                    magic -= 2;
                    lives -= 2;
                    break;
                case 3:
                    Console.WriteLine("You found a fingerboard and failed a kickflip.");
                    
                    Console.WriteLine("You lost 2 units of lives you poser.");
                    lives -= 2;
                    break;

                case 4:
                    Console.WriteLine("You came across a long John Silvers, ain't no way you're eating that!");
                    
                    Console.WriteLine("You lost 5 units health from voluntary starvation.");
                    health -= 5;
                    break;
                case 5:
                    Console.WriteLine("You saved a fellow traveler from a headless horseman.");
                    
                    Console.WriteLine("The traveler granted you 2 units of health, 2 units of magic and 6 units of lives.");
                    health += 2;
                    magic += 2;
                    lives += 2;
                    break;
                case 6:
                    Console.WriteLine("You babysat for a women who lived in a house that resembled a shoe (she had a lot of kids).");
                    
                    Console.WriteLine("You gain 3 units of health and 3 units of magic");
                    health += 3;
                    magic += 3;
                    break;
                case 7:
                    Console.WriteLine("You came across a Taco Bell, had yourself a nacho cheese gordita.");
                    
                    Console.WriteLine("You gained 5 units of health and 5 units of lives.");
                    health +=5;
                    lives+=5;
                    break;

                case 8:
                    Console.WriteLine("You homebrewed a kids PSP");
                    Console.WriteLine("You gained 5 units of magic and 2 units of lives.");
                    magic += 5;
                    lives += 2;
                    break;

                case 9:
                    Console.WriteLine("You came across Mewtwo who landed a critical Psycho Cut on you.");
                    Console.WriteLine("You lost 4 units of lives.");
                    lives -=4;
                    break;
                    case 10:
                    Console.WriteLine("You found the hoolihan room.");
                    Console.WriteLine("You gained 30 units of lives, 30 units of magic and units of health.");
                    health += 30;
                    magic += 30;
                    lives +=30;
                    break;
                    case 11:
                    Console.WriteLine("You came across a pair of Jordan Sneakers.");
                    Console.WriteLine("You gained 10 units of magic and 4 units of lives.");
                    magic +=10;
                    lives += 4;
                    break;
                    case 12:
                    Console.WriteLine("You came across Pyramid Head, he then slashed you with his sword.");
                    
                    Console.WriteLine("You lost 3 units of lives.");
                    lives -=3;
                        break;
                    case 13:
                    Console.WriteLine("You came across Tom Cruise, he gave you water from The Fountain of Youth.");
                    
                    Console.WriteLine("You gained 10 units of lives and 10 units of health.");
                    lives +=10;
                    health+=10;
                        break;
                    case 14:
                    Console.WriteLine("You fell flat on your face and broke your nose!");
                    
                    Console.WriteLine("You lost 6 units of health.");
                    health -=6;
                    break;
                    case 15:
                    Console.WriteLine("You found an Arbys, and it made you sick to your stomach.");
                    
                    Console.WriteLine("You lost 10 units of health, 6 units of magic, and 4 units of lives.");
                    health -=10;
                    magic -=6;
                    lives -=4;
                    break;
                case 16:
                    Console.WriteLine("HEY...VSAUCE..Michael here..");
                    Console.WriteLine("You gained 10 units of lives");
                    lives +=10;
                    break;
                    case 17:
                    Console.WriteLine("You ran into a Pokemon Center.");
                    Console.WriteLine("You gained 5 units of magic, and 5 units of lives");
                    lives +=5;
                    magic +=5;
                    break;
                    case 18:
                    Console.WriteLine("You ran into a Skate 3 trickliner.");
                    Console.WriteLine("You lost 5 lives");
                    lives-=5;
                    break;
                    case 19:
                    Console.WriteLine("You stubbed your toe on a rock.");
                    Console.WriteLine("You lost 2 health");
                    health-=2;
                    break;


                default:
                    Console.WriteLine("You saved a unicorn from a mean wizard.");
                    
                    Console.WriteLine("You gain 2 units of lives and 2 units of magic.");
                    magic += 2;
                    lives += 2;
                    break;
            }
        }
    }
}


