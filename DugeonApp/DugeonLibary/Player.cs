using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DugeonLibary
{
    public class Player : Charecter
    {
        private string _life;

        public string Name { get; set; } // NF: compiler says your overriding an inherited fie
        public int HitChance { get; set; }
        public int block { get; set; }
        public int Miss { get; set; }
        public int Limitbreak { get; set; }
        public Race CharecterRace { get; set; }
        public string WeaponName { get; set; }  // <- Your bracket escaped
        public Weapons EquippedWeapons { get; set; }


        //end of properties / fields - <- This is closing your class, and putting you rconstructor outside of your class
        public Player(string name, int hitchance, int block, int miss, int limitBreak, int life, int maxLife, Race charecterRace, Weapons equippedWeapon, string weaponName)
        {
            MaxLife = maxLife;
            Name = name;
            HitChance = hitchance;
            Block = block;
            Miss = miss;
            CharecterRace = charecterRace;
            Limitbreak = limitBreak;
            WeaponName = weaponName;
            switch (CharecterRace)
            {
                case Race.Human:
                    break;
                case Race.Dwarf:
                    break;
                case Race.Halfing:
                    break;
                case Race.Elf:
                    break;
                case Race.Gnome:
                    break;
                case Race.HalfOrc:
                    break;
                default:
                    break;
            }//end of switch 


        }//end of ctor
        //methods 
        public override string ToString()
        {
            string desecription = "";

            switch (CharecterRace)
            {
                case Race.Human:
                    desecription = "Human";
                    break;
                case Race.Dwarf:
                    desecription = "Dwarf";
                    break;
                case Race.Halfing:
                    desecription = "Halfling";
                    break;
                case Race.Elf:
                    desecription = "Elf";
                    break;
                case Race.Gnome:
                    desecription = "Gnome";
                    break;
                case Race.HalfOrc:
                    desecription = "HalfOrc";
                    break;


            }// end switch

            return string.Format("--------------------{0}----------------\nLife: {1} of {2}\nHit Chacne: {3}% " +
                "\nWeapon:\n{4}\nBlock: {5}\n Desecription {6}",
                Name,
                Life,
                CalcHitChance(),
                EquippedWeapons,
                Block,
                desecription); // I thought i did ? 

        }
    }
}










