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

            int bossmana = 30;

                //big boss
            int bigbossattck = 30;
            int specialbigbossattck = 50; //minus 10

            int bigbossmana = 30;
                
            
            //character details

                //health
            float PlayerHealth = 300.0f;
            float EnemyHealth = 200.0f;
            float PlayerHealthRegen = 20;
            //_________________________________________________________________________________________________
                //player atacks and such
            int mana = 50;   //will figure out how to conbine with attack variables
            int playersattack = 20;
            int specialattack = 40; //minus 10 mana
            //_________________________________________________________________________________________________
                //levels
            int level = 0;
            int maxlevel = 100;
            maxlevel = 120;
            //maxlevelreached = level == maxlevel;
            

            //Console.Write("Level:" + level + ", Mana:" + mana + ", and Health:" + PlayerHealth + ".");  //To copy and paste

            //menu
            bool ready = true;

            //fix it where it fixes format
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello Hero " + name + "! Your starting level is " + level + " and your health right now is " + PlayerHealth + ", your goal is to reach level " + maxlevel + ".");
            Console.WriteLine("Just for reading this you got a level up!");
            level = level+1;
            Console.Write("Your current level: " + level);
            
            
           

        }
    }
}
