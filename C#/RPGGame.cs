// See https://aka.ms/new-console-template for more information
using System;
public class Driver
{
    static int input_choice;

    public class AllEntities
    {
        public double health, damage, speed, stamina;
    }

    public class Characters : AllEntities
    {
        public double max_health, max_stamina, exp, gold;
        public int level, first_skill, second_skill, ultimate_skill;
        public string name, job;
    }


    public class Archer : Characters
    {
        
        public Archer()
        {
            this.max_health = 100;
            this.health = 100;
            this.damage = 80;
            this.speed = 100;
            this.exp = 0;
            this.level = 1;
            this.job = "Archer";
            this.name = "";
            this.first_skill = 10;
            this.second_skill = 10;
            this.ultimate_skill = 1;
            this.gold = 0;
            this.stamina = 20;
            this.max_stamina = 20;
        }
        
        
        public string showStats()
        {
            return String.Format(@"
--------------------------
GENERAL STATS
--------------------------
Health: {0}
Damage: {1}
Speed: {2}
Gold: {3}
Exp: {4}
Level: {5}
--------------------------
CHARACTER CREDENTIALS
--------------------------
Job: {6}
Name: {7}
--------------------------
SKILL CHARGES AND STAMINA
--------------------------
First Skill: {8}
Second Skill: {9}
Ultimate Skill: {10}
Current Stamina: {11}", health, damage, speed, gold, exp, level, job, name, first_skill, second_skill, ultimate_skill, stamina);
        }
        
        
        public double FirstSkill()
        {
            Console.WriteLine("You did a Multi-Shot! -" + (10 + (0.20 * damage)));
            return 10 + (0.20 * damage);
        }
        
        
        public double SecondSkill()
        {
            Console.WriteLine("You did a Power Shot! -" + (20 + (0.20 * damage)));
            return 20 + (0.20 * damage);
        }


        public double UltimateSkill()
        {
            Console.WriteLine("You did a Kill Shot! -" + (30 + (0.20 * damage)));
            return 30 + (0.20 * damage);
        }
    }
    
    
    public class Warrior : Characters
    {
        
        public Warrior()
        {
            this.max_health = 120;
            this.health = 120;
            this.damage = 90;
            this.speed = 75;
            this.exp = 0;
            this.level = 1;
            this.job = "Warrior";
            this.name = "";
            this.first_skill = 10;
            this.second_skill = 10;
            this.ultimate_skill = 1;
            this.gold = 0;
            this.stamina = 20;
            this.max_stamina = 20;
        }
        
        
        public string showStats()
        {
            return String.Format(@"
--------------------------
GENERAL STATS
--------------------------
Health: {0}
Damage: {1}
Speed: {2}
Gold: {3}
Exp: {4}
Level: {5}
--------------------------
CHARACTER CREDENTIALS
--------------------------
Job: {6}
Name: {7}
--------------------------
SKILL CHARGES AND STAMINA
--------------------------
First Skill: {8}
Second Skill: {9}
Ultimate Skill: {10}
Current Stamina: {11}", health, damage, speed, gold, exp, level, job, name, first_skill, second_skill, ultimate_skill, stamina);
        }        
        public double FirstSkill()
        {
            Console.WriteLine("You did a Blade Thrust! -" + (10 + (0.20 * damage)));
            return 10 + (0.20 * damage);
        }

        public double SecondSkill()
        {
            Console.WriteLine("You bashed the enemy's head! -" + (20 + (0.20 * damage)));
            return 20 + (0.20 * damage);
        }
        public double UltimateSkill()
        {
            Console.WriteLine("You did a Blade Dance! -" + (30 + (0.20 * damage)));
            return 30 + (0.20 * damage);
        }
    }
    
    
    public class Mage : Characters
    {   
        
        public Mage()
        {
            this.max_health = 80;
            this.health = 70;
            this.damage = 120;
            this.speed = 90;
            this.exp = 0;
            this.level = 1;
            this.job = "Mage";
            this.name = "";
            this.first_skill = 10;
            this.second_skill = 10;
            this.ultimate_skill = 1;
            this.gold = 0;
            this.stamina = 20;
            this.max_stamina = 20;
        }


        public double FirstSkill()
        {
            Console.WriteLine("You did an Icicle Rain! -" + (10 + (0.20 * damage)));
            return 10 + (0.20 * damage);
        }

        public double SecondSkill()
        {
            Console.WriteLine("You shot a fireball! -" + (20 + (0.20 * damage)));
            return 20 + (0.20 * damage);
        }
        public double UltimateSkill()
        {
            Console.WriteLine("You casted a Tornado! -" + (30 + (0.20 * damage)));
            return 30 + (0.20 * damage);
        }
        
        
        public string showStats()
        {
            return String.Format(@"
--------------------------
GENERAL STATS
--------------------------
Health: {0}
Damage: {1}
Speed: {2}
Gold: {3}
Exp: {4}
Level: {5}
--------------------------
CHARACTER CREDENTIALS
--------------------------
Job: {6}
Name: {7}
--------------------------
SKILL CHARGES AND STAMINA
--------------------------
First Skill: {8}
Second Skill: {9}
Ultimate Skill: {10}
Current Stamina: {11}", health, damage, speed, gold, exp, level, job, name, first_skill, second_skill, ultimate_skill, stamina);
        }    
    }
    
    
    public class Assassin : Characters
    {   
        public Assassin()
        {
            this.max_health = 90;
            this.health = 90;
            this.damage = 110;
            this.speed = 130;
            this.exp = 0;
            this.level = 1;
            this.job = "Assassin";
            this.name = "";
            this.first_skill = 10;
            this.second_skill = 10;
            this.ultimate_skill = 1;
            this.gold = 0;
            this.stamina = 20;
            this.max_stamina = 20;
        }
        

        public double FirstSkill()
        {
            Console.WriteLine("You used Cutthroat! -" + (10 + (0.20 * damage)));
            return 10 + (0.20 * damage);
        }

        public double SecondSkill()
        {
            Console.WriteLine("You shot two deadly needles! -" + (20 + (0.20 * damage)));
            return 20 + (0.20 * damage);
        }
        public double UltimateSkill()
        {
            Console.WriteLine("You used Heart Pierce! -" + (30 + (0.20 * damage)));
            return 30 + (0.20 * damage);
        }

        
        public string showStats()
        {
            return String.Format(@"
--------------------------
GENERAL STATS
--------------------------
Health: {0}
Damage: {1}
Speed: {2}
Gold: {3}
Exp: {4}
Level: {5}
--------------------------
CHARACTER CREDENTIALS
--------------------------
Job: {6}
Name: {7}
--------------------------
SKILL CHARGES AND STAMINA
--------------------------
First Skill: {8}
Second Skill: {9}
Ultimate Skill: {10}
Current Stamina: {11}", health, damage, speed, gold, exp, level, job, name, first_skill, second_skill, ultimate_skill, stamina);
        }
    }

//stamina is kinda useless for enemies cuz i only put one skill for each enemy so i'm not putting it T^T
    public class GoblinScout : AllEntities
    {
        public GoblinScout()
        {
            this.health = 80;
            this.damage = 10;
            this.speed = 80;
        }
        
        public int XP()
        {
            Console.WriteLine("You gained 25 XP");
            return 25;
        }

        public int Gold()
        {
            Console.WriteLine("You gained 25 Gold");
            return 25;
        }
        
        
        public double FirstSkill()
        {
            Console.WriteLine("The Goblin Scout stabs you! -" + (20 + (0.20 * damage)));
            return 20 + (0.20 * damage);
        }
    }
    
    
    public class OrcWarrior : AllEntities
    {
        public OrcWarrior()
        {
            this.health = 190;
            this.damage = 35;
            this.speed = 70;
        }
        public int XP()
        {
            Console.WriteLine("You gained 40 XP");
            return 40;
        }


        public int Gold()
        {
            Console.WriteLine("You gained 40 Gold");
            return 40;
        }


        public double FirstSkill()
        {
            Console.WriteLine("The Orc Warrior Ultra Bonks you! -" + (20 + (0.20 * damage)));
            return 20 + (0.20 * damage);
        }
    }
    
    
    public class FireElemental : AllEntities
    {      
        public FireElemental()
        {
            this.health = 100;
            this.damage = 80;
            this.speed = 120;
        }
        
        
        public int XP()
        {
            Console.WriteLine("You gained 60 XP");
            return 60;
        }

        public int Gold()
        {
            Console.WriteLine("You gained 60 Gold");
            return 60;
        }


        public double FirstSkill()
        {
            Console.WriteLine("The Fire Elemental pukes magma on you! -" + (20 + (0.20 * damage)));
            return 20 + (0.20 * damage);
        }
    }

    public class IceMage : AllEntities
    {   
        public IceMage()
        {
            this.health = 180;
            this.damage = 100;
            this.speed = 90;
        }

        public int XP()
        {
            Console.WriteLine("You gained 80 XP");
            return 80;
        }


        public int Gold()
        {
            Console.WriteLine("You gained 80 Gold");
            return 80;
        }

        public double FirstSkill()
        {
            Console.WriteLine("The Ice Mage Throws a 5 pesos block of ice to you! -" + (20 + (0.20 * damage)));
            return 20 + (0.20 * damage);
        }
    }

    public class DarkOverlord : AllEntities
    {
        public DarkOverlord()
        {
            this.health = 400;
            this.damage = 100;
            this.speed = 120;
        }
        public int XP()
        {
            Console.WriteLine("You gained 90 XP");
            return 90;
        }


        public int Gold()
        {
            Console.WriteLine("You gained 90 Gold");
            return 90;
        }


        public double FirstSkill()
        {
            Console.WriteLine("The Dark Overlord does Drain Touch! The enemy's health increased to 20.   -" + (20 + (0.20 * damage)));
            health += 20;
            return 20 + (0.20 * damage);
        }
    }


    public static void Main()
    {
        Console.WriteLine("Welcome to the Kingdom of Eldoria, a realm steeped in rich history and vibrant culture. Nestled between towering mountains and lush forests, Eldoria stands as a beacon of prosperity and unity among its inhabitants. The kingdom is governed by a wise and just monarch, King Aldric, who has ruled with benevolence and foresight for many years.");
        Console.WriteLine("Press enter to Continue...");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Despite its idyllic facade, Eldoria faces constant threats from various hostile entities lurking beyond its borders. Mobs of goblins, orcs, elemental creatures, and dark forces have been sighted in the wilderness surrounding the kingdom, posing a significant danger to its citizens.");
        Console.WriteLine("Press enter to Continue...");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("The origins of these mobs are shrouded in mystery, but rumors abound of dark sorcery and ancient curses that have awakened these malevolent beings from their slumber. Some whisper of a sinister force amassing power in the shadows, seeking to plunge Eldoria into chaos and darkness.");
        Console.WriteLine("Press enter to Continue...");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("To safeguard the kingdom and its people, brave adventurers like yourself have taken up arms to confront these threats head-on. Tasked with vanquishing these mobs and uncovering the truth behind their sudden appearance, you embark on perilous quests to defend Eldoria and restore peace to the land.");
        Console.WriteLine("Press enter to Continue...");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine(@"
-------------------
CHOOSE YOUR CLASS
-------------------
1: Archer
2: Warrior
3: Mage
4: Assassin");
        input_choice = Convert.ToInt32(Console.ReadLine());
        if(input_choice == 1)
        {
            Archer user = new Archer();
            Console.WriteLine("Set your username: ");
            user.name = Console.ReadLine();
            Console.WriteLine("Your username is: " + user.name);
            DefaultActions(user);
        }
        else if(input_choice == 2)
        {
            Warrior user = new Warrior();
            Console.WriteLine("Set your username: ");
            user.name = Console.ReadLine();
            Console.WriteLine("Your username is: " + user.name);
            DefaultActions(user);
        }
        else if(input_choice == 3)
        {
            Mage user = new Mage();
            Console.WriteLine("Set your username: ");
            user.name = Console.ReadLine();
            Console.WriteLine("Your username is: " + user.name);
            DefaultActions(user); 
        }
        else if(input_choice == 4)
        {
            Assassin user = new Assassin();
            Console.WriteLine("Set your username: ");
            user.name = Console.ReadLine();
            Console.WriteLine("Your username is: " + user.name);
            DefaultActions(user);           
        }
        else
        {
            Console.WriteLine("Invalid Choice");
            Main();
        }
    }
    
    
    public static void DefaultActions(dynamic user)
    {
        Console.WriteLine(@"
------------------------
CHOOSE YOUR ACTION
------------------------
1: Check Guild Missions
2: Check Stats
3: Go to Guild Medical Facility
4: Check what the merchant sells
5: Exit the game
------------------------");
        input_choice = Convert.ToInt32(Console.ReadLine());
        switch(input_choice)
        {
            case 1:
                CheckGuildMissions(user);
                DefaultActions(user);
                break;

            case 2:
                Console.WriteLine(user.showStats());
                DefaultActions(user);
                break;

            case 3:
                Console.WriteLine(@"
----------------------------------
GUILD MEDICAL FACILITY
----------------------------------
1: Heal to full health 20G
2: Restore Skill Charges and stamina 10G
3: Exit Guild Medical Facility");
                input_choice = Convert.ToInt32(Console.ReadLine());
                switch(input_choice)
                {
                    case 1:
                        if(user.gold >= 20)
                        {
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("You are now healed to full health!");
                            Console.WriteLine("----------------------------------");
                            user.health = user.max_health;
                            user.gold -= 20;
                            DefaultActions(user);
                        }
                        else
                        {
                            Console.WriteLine("------------------");                         
                            Console.WriteLine("Not Enough Money!");
                            Console.WriteLine("------------------");
                            DefaultActions(user);
                        }
                        break;
                    case 2:
                        if(user.gold >= 10)
                        {
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("Your skill charges and stamina are now all full");
                            Console.WriteLine("--------------------------------------------------");
                            user.first_skill = 10;  
                            user.second_skill = 10;
                            user.ultimate_skill = 1;
                            user.stamina = user.max_stamina;
                            user.gold -= 10;
                            DefaultActions(user);
                        }
                        else
                        {
                            Console.WriteLine("------------------");                         
                            Console.WriteLine("Not Enough Money!");
                            Console.WriteLine("------------------");
                            DefaultActions(user);
                        }
                        break;
                        
                    case 3:
                        DefaultActions(user);
                        break;
                }
                break;
            case 4:
                if(user.level < 6)
                {
                    Console.WriteLine(@"
----------------------------------
MERCHANT
----------------------------------
1: Permanent Damage +5 Potion 100G
2: Restart Life Potion 0G
3: 100 XP Potion 75G
4: Exit Shop");
                    input_choice = Convert.ToInt32(Console.ReadLine());
                    switch(input_choice)
                    {
                        case 1:
                        if(user.gold >= 70)
                        {
                            Console.WriteLine("---------------------");                         
                            Console.WriteLine("Purchase Successful!");
                            Console.WriteLine("---------------------");
                            Console.WriteLine("Increased Damage to 10 Permanently!");
                            user.damage += 10;
                            user.gold -= 70;
                            DefaultActions(user);
                        }
                        else
                        {
                            Console.WriteLine("------------------");                         
                            Console.WriteLine("Not Enough Money!");
                            Console.WriteLine("------------------");
                            DefaultActions(user);
                        }
                        break;

                        case 2:
                            Console.WriteLine("Press enter to continue...");
                            Console.ReadLine();
                            Main();
                            break;
                        
                        case 3:
                            if(user.gold >= 50)
                            {
                                Console.WriteLine("---------------------");                         
                                Console.WriteLine("Purchase Successful!");
                                Console.WriteLine("---------------------");
                                Console.WriteLine("Increased XP to 100 Permanently!");
                                user.exp += 100;
                                user.gold -= 50;
                                if(user.exp >= 150)
                                {
                                    user.max_health += 20;
                                    user.health += 20;
                                    user.damage += 10;
                                    user.speed += 5;
                                    user.exp -= 150;
                                    user.level += 1;
                                    Console.WriteLine("You levelled up!");
                                }
                                DefaultActions(user);
                            }
                            else
                            {
                                Console.WriteLine("------------------");                         
                                Console.WriteLine("Not Enough Money!");
                                Console.WriteLine("------------------");
                                DefaultActions(user);
                            }
                            break;
                        
                        case 4:
                            DefaultActions(user);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Merchant");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("1: Restart Life Potion 0G");
                    Console.WriteLine("2: Exit Merchant");

                    input_choice = Convert.ToInt32(Console.ReadLine());
                    switch(input_choice)
                    {
                        case 1:
                            Console.WriteLine("Press enter to continue...");
                            Console.ReadLine();
                            Main();
                            break;
                        
                        case 2:
                            DefaultActions(user);
                            break;
                    }
                }
                break;
            case 5:
                Console.WriteLine("Bye");
                Environment.Exit(0);
                break;
            
            default:
                DefaultActions(user);
                break;
        }
        Console.Clear();
    }
    
   //Guild Missions 
    public static void CheckGuildMissions(dynamic user)
    {
        Console.WriteLine(@"
------------------------
CHOOSE YOUR ACTIONS
------------------------
1: Kill Scout Goblin that is spying in our kingdom.
---------- Reward: 25XP
---------- Health: 80
---------- Damage: 10
---------- Speed: 80
2: Clear the orc warrior that is residing beside the house of the inhabitant of our kingdom
---------- Reward: 40XP
---------- Health: 190
---------- Damage: 35
---------- Speed: 70
3: Kill the fire elemental that's been setting fire on the crops of our kingdom.
---------- Reward: 60XP
---------- Health: 100
---------- Damage: 80
---------- Speed: 120
4: Kill the Ice Mage that's been spotted by our kingdom's scout in the east.
---------- Reward: 80XP
---------- Health: 180
---------- Damage: 100
---------- Speed: 90
5: A boss level entity suddenly appeared in the forest in far west of our kingdom, kill it before it reaches here.
---------- Reward: 90XP
---------- Health: 400
---------- Damage: 100
---------- Speed: 120
---------- Dev's tip: He has a lifesteal so make sure that your damage and health way higher than his
6: Exit");
        input_choice = Convert.ToInt32(Console.ReadLine());
        switch(input_choice)
        {
            case 1:
                GoblinMission(user);
                break;
            
            case 2:
                OrcWarriorMission(user);
                break;

            case 3:
                FireElementalMission(user);
                break;

            case 4:
                IceMageMission(user);
                break;
            
            case 5:
                DarkOverlordMission(user);
                break;
                
            case 6:
                DefaultActions(user);
                break;

            default:
                CheckGuildMissions(user);
                break;
        }
    }
    
    //Fight Scene Enemy First
    public static void FightSceneEnemyFirst(dynamic user, dynamic enemy)
    {
        while(user.health > 0 && enemy.health > 0)
        {
            if(enemy.health > 0)
            {
                user.health -= enemy.FirstSkill();
                Console.WriteLine("Your Health is: " + user.health);
                user.stamina += 5;
                Console.WriteLine("User's Stamina is: " + user.stamina);
            }

            if(user.health <= 0 || enemy.health <=0)
            {
                break;
            }

            if(user is Archer)
            {
            Console.WriteLine(@"
---------------
SKILLS
---------------
1: Multi-shot (Consumes 5 Stamina)
2: Power Shot (Consumes 10 Stamina)
3: Kill Shot (Consumes 15 Stamina)
");
            }

            else if(user is Warrior)
            {
            Console.WriteLine(@"
---------------
SKILLS
---------------
1: Blade Thrust (Consumes 5 Stamina)
2: Skull Bash (Consumes 10 Stamina)
3: Blade Dance (Consumes 15 Stamina)
");
            }


            else if(user is Mage)
            {
            Console.WriteLine(@"
---------------
SKILLS
---------------
1: Icicle Rain (Consumes 5 Stamina)
2: Fireball (Consumes 10 Stamina)
3: Tornado (Consumes 15 Stamina)
");
            }


            else if(user is Assassin)
            {
            Console.WriteLine(@"
---------------
SKILLS
---------------
1: Cutthroat (Consumes 5 Stamina)
2: Double Needle (Consumes 10 Stamina)
3: Heart Pierce (Consumes 15 Stamina)
");
            }
            input_choice = Convert.ToInt32(Console.ReadLine());
            switch(input_choice)
            {
                case 1:
                    if(user.first_skill < 1)
                    {
                        Console.WriteLine("Not enough skill charges!");
                    }
                    else
                    {
                        if(user.stamina >= 5)
                        {
                            enemy.health -= user.FirstSkill();
                            user.first_skill -= 1;
                            user.stamina -= 5;
                        }
                        else
                            Console.WriteLine("Not enough stamina!");
                    }
                    break;
                    
                case 2:
                    if(user.second_skill < 1)
                    {
                        Console.WriteLine("Not enough skill charges!");
                    }
                    else
                    {
                        if(user.stamina >= 10)
                        {
                            enemy.health -= user.SecondSkill();
                            user.second_skill -= 1;
                            user.stamina -= 10;
                        }
                        else
                            Console.WriteLine("Not enough stamina!");
                    }
                    break;

                case 3:
                    if(user.ultimate_skill < 1)
                    {
                        Console.WriteLine("Not enough skill charges!");
                    }
                    else
                    {
                        if(user.stamina >= 15)
                        {
                            user.ultimate_skill -= 1;
                            user.stamina -= 15;
                            enemy.health -= user.UltimateSkill();
                        }

                        else
                            Console.WriteLine("Not enough stamina!");
                    }
                    break;
            }
            Console.WriteLine("Enemy's Health is: " + enemy.health);
        }
        if (user.health <= 0)
        {
            Console.WriteLine("You Died.");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.WriteLine(@"
---------------
Exit or Restart?
---------------
1: Restart
2: Exit Game");
            input_choice = Convert.ToInt32(Console.ReadLine());
            switch(input_choice)
            {
                case 1:
                    Main();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }
        }

        else if(enemy.health <= 0)
        {
            user.exp += enemy.XP();
            user.gold += enemy.Gold();
        }
    }
    
    // Fight Scene User First
    public static void FightSceneUserFirst(dynamic user, dynamic enemy)
    {
        while(user.health > 0 && enemy.health > 0)
        {
            Console.WriteLine("User's Stamina is: " + user.stamina);
            if(user is Archer)
            {
            Console.WriteLine(@"
---------------
SKILLS
---------------
1: Multi-shot (Consumes 5 Stamina)
2: Power Shot (Consumes 10 Stamina)
3: Kill Shot (Consumes 15 Stamina)
");
            }

            else if(user is Warrior)
            {
            Console.WriteLine(@"
---------------
SKILLS
---------------
1: Blade Thrust (Consumes 5 Stamina)
2: Skull Bash (Consumes 10 Stamina)
3: Blade Dance (Consumes 15 Stamina)
");
            }


            else if(user is Mage)
            {
            Console.WriteLine(@"
---------------
SKILLS
---------------
1: Icicle Rain (Consumes 5 Stamina)
2: Fireball (Consumes 10 Stamina)
3: Tornado (Consumes 15 Stamina)
");
            }


            else if(user is Assassin)
            {
            Console.WriteLine(@"
---------------
SKILLS
---------------
1: Cutthroat (Consumes 5 Stamina)
2: Double Needle (Consumes 10 Stamina)
3: Heart Pierce (Consumes 15 Stamina)
");
            }

            input_choice = Convert.ToInt32(Console.ReadLine());
            switch(input_choice)
            {
                case 1:
                    if(user.first_skill < 1)
                    {
                        Console.WriteLine("Not enough skill charges!");
                    }
                    else
                    {
                        if(user.stamina >= 5)
                        {
                            enemy.health -= user.FirstSkill();
                            user.first_skill -= 1;
                            user.stamina -= 5;
                        }
                        else
                            Console.WriteLine("Not enough stamina!");
                    }
                    break;
                    
                case 2:
                    if(user.second_skill < 1)
                    {
                        Console.WriteLine("Not enough skill charges!");
                    }
                    else
                    {
                        if(user.stamina >= 10)
                        {
                            enemy.health -= user.SecondSkill();
                            user.second_skill -= 1;
                            user.stamina -= 10;
                        }
                        else
                            Console.WriteLine("Not enough stamina!");
                    }
                    break;

                case 3:
                    if(user.ultimate_skill < 1)
                    {
                        Console.WriteLine("Not enough skill charges!");
                    }
                    else
                    {
                        if(user.stamina >= 15)
                        {
                            user.ultimate_skill -= 1;
                            user.stamina -= 15;
                            enemy.health -= user.UltimateSkill();
                        }

                        else
                            Console.WriteLine("Not enough stamina!");
                    }
                    break;
            }
            Console.WriteLine("Enemy's Health is: " + enemy.health);
            if(enemy.health > 0)
            {
                user.health -= enemy.FirstSkill();
                Console.WriteLine("Your Health is: " + user.health);   
            }
            user.stamina += 5;
        }
        if (user.health <= 0)
        {
            Console.WriteLine("You Died.");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.WriteLine(@"
---------------
Exit or Restart?
---------------
1: Restart
2: Exit Game");
            input_choice = Convert.ToInt32(Console.ReadLine());
            switch(input_choice)
            {
                case 1:
                    Main();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }
        }

        else if (enemy.health <= 0)
        {
            user.exp += enemy.XP();
            user.gold += enemy.Gold();
        }
    }
    
    //Missions
    public static void GoblinMission(dynamic user)
    {
        GoblinScout enemy = new GoblinScout();
        Console.WriteLine("You went and looked for the Goblin Scout...");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
        Console.WriteLine("You found the Goblin Scout that's been spying on us!");
        if(enemy.speed > user.speed)
        {
            FightSceneEnemyFirst(user, enemy);
            enemy = null;
        }
        
        else if(enemy.speed <= user.speed)
        {
            FightSceneUserFirst(user, enemy);
            enemy = null;
        }

        if(user.exp >= 150)
        {
            user.max_health += 20;
            user.health += 20;
            user.damage += 10;
            user.speed += 5;
            user.exp -= 150;
            user.level += 1;
            Console.WriteLine("You levelled up!");
        }
    }


    public static void OrcWarriorMission(dynamic user)
    {
        OrcWarrior enemy = new OrcWarrior();
        Console.WriteLine("You went and looked for the Orc Warrior...");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
        Console.WriteLine("You found the Orc Warrior and he's now charging towards you!");
        if(enemy.speed > user.speed)
        {
            FightSceneEnemyFirst(user, enemy);
            enemy = null;
        }
        
        else if(enemy.speed < user.speed)
        {
            FightSceneUserFirst(user, enemy);
            enemy = null;
        }

        if(user.exp >= 150)
        {
            user.max_health += 20;
            user.health += 20;
            user.damage += 10;
            user.speed += 5;
            user.exp -= 150;
            user.level += 1;
            Console.WriteLine("You levelled up!");
        }
    }


    public static void FireElementalMission(dynamic user)
    {
        Console.WriteLine("You went and looked for the Fire Elemental that's been burning crops in our kingdom...");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
        Console.WriteLine("You found the Fire Elemental and he's about to burn some crops again. Hurry!");
        FireElemental enemy = new FireElemental();
        if(enemy.speed > user.speed)
        {
            FightSceneEnemyFirst(user, enemy);
            enemy = null;
        }
        
        else if(enemy.speed <= user.speed)
        {
            FightSceneUserFirst(user, enemy);
            enemy = null;
        }

        if(user.exp >= 150)
        {
            user.max_health += 20;
            user.health += 20;
            user.damage += 10;
            user.speed += 5;
            user.exp -= 150;
            user.level += 1;
            Console.WriteLine("You levelled up!");
        }
    }


    public static void IceMageMission(dynamic user)
    {
        Console.WriteLine("You went and looked for the Ice Mage...");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
        Console.WriteLine("You found the Ice Mage! Make an action before she does something cruel!");
        IceMage enemy = new IceMage();
        if(enemy.speed > user.speed)
        {
            FightSceneEnemyFirst(user, enemy);
            enemy = null;
        }
        
        else if(enemy.speed <= user.speed)
        {
            FightSceneUserFirst(user, enemy);
            enemy = null;
        }

        if(user.exp >= 150)
        {
            user.max_health += 20;
            user.health += 20;
            user.damage += 10;
            user.speed += 5;
            user.exp -= 150;
            user.level += 1;
            Console.WriteLine("You levelled up!");
        }
    }


    public static void DarkOverlordMission(dynamic user)
    {
        Console.WriteLine("You went and looked for the Dark Overlord...");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
        Console.WriteLine("You found the Dark Overlord and he's emanating a threatening dark power!");
        DarkOverlord enemy = new DarkOverlord();
        if(enemy.speed > user.speed)
        {
            FightSceneEnemyFirst(user, enemy);
            enemy = null;
        }
        
        else if(enemy.speed < user.speed)
        {
            FightSceneUserFirst(user, enemy);
            enemy = null;
        }

        if(user.exp >= 150)
        {
            user.max_health += 20;
            user.health += 20;
            user.damage += 10;
            user.speed += 5;
            user.exp -= 150;
            user.level += 1;
            Console.WriteLine("You levelled up!");
        }
    }
}
