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

            //_________________________________________________________________________________________________
                //pet
            int petattack = 20;

            //_________________________________________________________________________________________________
            //Bag
            int goldcoins = 10;
            int silvercoins = 15;
            int coppercoins = 20;

            //maxlevelreached = level == maxlevel;

            //menu
            //bool ready = true;

            //this is where the start well starts to make sure to loop
            //back to here when the player dies and wants to continue.

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

            //your begining
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

                //soon to be added
                    //orc
                    //gnome
                    //dragonborn
                    //half orc
                    //other halves
                    //fae

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
                stealth = stealth + 6;
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
            Console.WriteLine(goldcoins + " gold coins");
            Console.WriteLine(silvercoins + " silver coins");
            Console.WriteLine(coppercoins + " copper coins");
            Console.WriteLine("Your goal is to reach the max level of " + maxlevel + " and defeat the Demon King with your new found powers! To save our world!");

            Console.WriteLine(" ");
            Console.WriteLine("Press [Enter] to continue.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("- Quest Recieved: Defeat the Demon King! - ");

            Console.WriteLine("A bright light blinded you after you were given the quest by the woman. When the light finally cleared you realized you were in the center of a crowd.");
            Console.WriteLine("You look around and notice that the town was a mix of races: Elves, Humans, Drawfs, and more. The crowd then departs and an Ederly Dragon Born walks inbetween the parted group.");
            Console.WriteLine("Are you a Hero? Did Goddess Cecilia send you?");

            Console.WriteLine(" ");
            Console.WriteLine("Choose 1 or 2 for your answer.");
            Console.WriteLine(" ");

            Console.WriteLine("1. Answer him honestly about what you saw and what she said.");
            Console.WriteLine("2. A Goddess? Sorry I don't know who you are talking about.");

            char queston1 = Console.ReadKey().KeyChar;

            if (queston1 == '1')
            {
                charisma = charisma + 2;
                karma = karma + 3;
                Console.WriteLine("Everyone around began cheering for finally the Hero sent by their Goddess Cecilia.");
                Console.WriteLine("The Elder grabbed your arm happily 'Since you were sent by our goddess we must treat you well!' He handed you a bag of what you presume to be a bag of coins.");
                Console.WriteLine("'Quickly we must show you to your room! And no worries its on us!' You followed the Elder to the tavern, and was greeted by the woman at the front desk.");
                Console.WriteLine("'Welcome to the Kraken Tavern, for one room its 2 silver coins!' the elderly walked up to her, 'This young " + race + " is the hero sent by the Goddess! No need to make them pay the fee!'");
                Console.WriteLine("The woman gased and quickly grabbed a set of keys behind her, 'Room 11 Hero....?' you realized that you haven't given them your name, '" + name + "' she nodded to herself 'Here you go Hero " + name + "!'");
                Console.WriteLine("You found your room, entered it then layed onto the bed, waiting for the next day to comel.");

                Console.Clear();
                goldcoins = goldcoins + 1;
                silvercoins = silvercoins + 2;
                coppercoins = coppercoins + 3;

                Console.WriteLine("Congradulations! You gained 2 charisma, 3 karma, 1 gold coin, 2 silver coins, and 3 copper coins!");
            }
            else if (queston1 == '2')
            {
                karma = karma - 1;

            }
            else
            {

            }

            Console.WriteLine("Press [Enter] to continue.");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
