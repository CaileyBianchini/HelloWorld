using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            

            //mobs attacks and such
                //mob
            int mobattacks = 15;

                //boss
            int bossattacks = 20;
            int specialbossattacks = 30; //minus 5 mana

            float bossmana = 30.0f;

                //big boss
            int bigbossattck = 30;
            int specialbigbossattck = 50; //minus 10

            float bigbossmana = 30.0f;
                
            
            //character details

                //health
            float PlayerHealth = 300.0f;
            float EnemyHealth = 200.0f;
            float PlayerHealthRegen = 20.0f;
            //_________________________________________________________________________________________________
                //player atacks and such
            float mana = 50.0f;   //will figure out how to conbine with attack variables
            int playersattack = 20;
            int specialattack = 40; //minus 10 mana
            //_________________________________________________________________________________________________
                //levels
            int level = 0;
            bool maxlevelreached = false;
            int maxlevel = 100;
            
            //maxlevelreached = level == maxlevel;

                //menu
            //bool ready = true;

            //start
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            //story
            Console.WriteLine("~~~~~~~~~~");
            Console.WriteLine("The world is a violent one. Many creatures live in this world: Humans, Elves, Drawfs, Spirits, and much more. This world use to be quite a peacefull one until the fowl Demons showed up. At first it was random killings, lone merchants traveling in between towns, farmers that where out on their feild.");
            Console.WriteLine("Everything changed when the Demon King appeared. They're random attacks became organized, the damage done tripled, and the causualties worsened. We were losing hope. That was until a profacy was shared, 'Summon a Hero and the world shall be saved.' and thus a slimmer of hope was born!");
            Console.WriteLine("~~~~~~~~~~");
             
            //start
            Console.WriteLine("You awoke in a bright marble room, standing in front of you a tall and goddess like dark elfand her eyes had galxies in them. There was a halo behing her making her even more goddess like, she gives you small smile and open her arms.");
            Console.WriteLine("'You were brought to our world to save us Hero " + name + "!'");
            Console.WriteLine("What type of Hero Class are you: ");
            string role = Console.ReadLine();
            Console.WriteLine("I'm sorry but I can't tell, what race are you?");
            string race = Console.ReadLine();
           Console.WriteLine("  ");
            Console.WriteLine("-Level Gained-");
            level = level+1;
            Console.WriteLine("     ");
            //telling the users stat

            if (role == "mage")
            {
                PlayerHealth = PlayerHealth - 50;
                mana = mana + 30;
                playersattack = playersattack - 10;


            }
            if (role == "knight")
            {

            }
            if (role == "necromancer")
            {

            }
            if (role == "bard")
            {

            }

            Console.WriteLine("Current level: " + level);
            Console.WriteLine("Hero role: " + role);
            Console.WriteLine("Race : " + race);
            Console.WriteLine("Health: " + PlayerHealth);
            Console.WriteLine("Mana: " + mana);
            Console.WriteLine("Attack: " + playersattack);
            Console.WriteLine("Special Attack: " + specialattack);
            Console.WriteLine("Your goal is to reach the max level of " + maxlevel + " and defeat the Demon King with your new found powers! To save our world!");
            
            
            
           

        }
    }
}
