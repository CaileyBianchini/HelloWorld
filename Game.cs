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
            float EnemyHealth = 100.0f;

                //boss
            int bossattacks = 20;
            int specialbossattacks = 30; //minus 5 mana
            
            float bossmana = 30.0f;
            float BossHealth = 150.0f;

                //big boss
            int bigbossattck = 30;
            int specialbigbossattck = 50; //minus 10
            float bigbossmana = 30.0f;
            float BigBossHealth;
                
            
            //character details

                //health
            float PlayerHealth = 100.0f;
            float PlayerHealthRegen = 20.0f;
            //_________________________________________________________________________________________________
                //player atacks and such
            float mana = 50.0f;   //will figure out how to conbine with attack variables
            int playersattack = 20;
            int specialattack = 40; //minus 10 mana
            //_________________________________________________________________________________________________
                //levels
            int level = 0;
            //bool maxlevelreached = false;
            int maxlevel = 100;
            //_________________________________________________________________________________________________
                //other stats
            int charisma = 20;
            float karma = 2.0f;
            int luck = 5;
            float stealth = 2.0f;


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

            //this can be copy and pasted to help out the screen
            Console.WriteLine("Press [Enter] to continue.");
            Console.ReadLine();
            Console.Clear();


            //this is where the start well starts to make sure to loop
            //back to here when the player dies and wants to continue.

            //start
            Console.WriteLine("You awoke in a bright marble room, standing in front of you a tall and goddess like dark elfand her eyes had galxies in them. There was a halo behing her making her even more goddess like, she gives you small smile and open her arms.");
            Console.WriteLine("'You were brought to our world to save us Hero " + name + "!'");
            Console.WriteLine("  ");
            Console.WriteLine("Make sure you write the full word and all lower case!");
            Console.WriteLine("What type of Hero Class are you: ");
            string role = Console.ReadLine();
            Console.WriteLine("I'm sorry but I can't tell, what race are you?");
            string race = Console.ReadLine();
           Console.WriteLine("  ");
            Console.WriteLine("-Level Gained-");
            level = level+1;
            Console.WriteLine("     ");

            //role

                //soon to be added
                    //ranger
                    //warlock
                    //monk
                    //sorcerer
                    //wizard
                    //barbarian
                    //cleric
                    //druid
                    //fighter

            if (role =="mage")
            {
                PlayerHealth = PlayerHealth - 50;
                mana = mana + 30;
                playersattack =playersattack - 10;
                specialattack = specialattack + 30;
                stealth = stealth + 1;


            }
            if (role =="knight")
            {
                PlayerHealth = PlayerHealth + 60;
                PlayerHealthRegen = PlayerHealthRegen + 10;
                luck = luck + 5;
                stealth = stealth - 1;
            }
            if (role =="necromancer")
            {
                karma = karma - 1;
                charisma = charisma - 5;
                luck = luck - 3;
                PlayerHealth = PlayerHealth - 45;
                mana = mana + 30;
                playersattack = playersattack - 10;
                specialattack = specialattack + 20;
                stealth = stealth + 3;
            }
            if (role =="bard")
            {
                karma = karma + 3;
                charisma = charisma + 5;
                PlayerHealth = PlayerHealth - 75;
                mana = mana + 15;
                stealth = stealth + 1;

            }

            //race

            if (race == "human") 
            {
                PlayerHealth = PlayerHealth - 20;
                mana = mana - 50;
            }
            if (race == "drawf")
            {
                PlayerHealth = PlayerHealth + 20;
                playersattack = playersattack + 20;
                mana -= mana * 0.5f;
            }
            if (race == "elf")
            {
                luck = luck + 3;
                karma = karma + 3;
                mana = mana * 2;
                charisma = charisma + 2;
                PlayerHealth = PlayerHealth + 40;
                PlayerHealthRegen = PlayerHealthRegen + 10;
                playersattack = playersattack / 2;
                specialattack = specialattack + 30;
            }
            if (race == "halfling")
            {
                PlayerHealth = PlayerHealth / 2;
            }



            Console.WriteLine("Current level: " + level);
            Console.WriteLine("Hero role: " + role);
            Console.WriteLine("Race : " + race);
            Console.WriteLine("Health: " + PlayerHealth);
            Console.WriteLine("Mana: " + mana);
            Console.WriteLine("Attack: " + playersattack);
            Console.WriteLine("Special Attack: " + specialattack);
            Console.WriteLine("Stealth: " + stealth);
            Console.WriteLine("Karma: " + karma);
            Console.WriteLine("Charisma: " + charisma);
            Console.WriteLine("Luck: " + luck);
            Console.WriteLine("Your goal is to reach the max level of " + maxlevel + " and defeat the Demon King with your new found powers! To save our world!");

            Console.WriteLine(" ");
            Console.WriteLine("Press [Enter] to continue.");
            Console.ReadLine();

            
            
            
           

        }
    }
}
