using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DugeonLibary
{
    public class Combat : Room
    {
        public static void DoAttack(Charecter attacker, Charecter defender)
        {
            Random rand = new Random();
            int diceroll = rand.Next(1, 1101);
            System.Threading.Thread.Sleep(30);
            if (diceroll <= attacker.CalchitChance() - defender.CalcBlock())
            {
                int damageDealt = attacker.CalcDamage();

                defender.Life -= damageDealt;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("{0} hit {1} for {2} damage!", attacker.Name, defender.Name, damageDealt);

            }

            else
            {

                Console.WriteLine("{0} missed!", attacker.Name);

            }

        }

        public static void DoBattle(Player player, Monster monster)
        {
            DoAttack(player, monster);// <----- need to figure out why syntax errors are freaking out. 

            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }


        }

    }
}

