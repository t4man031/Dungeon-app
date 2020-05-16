using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DugeonLibary
{
    public class Weapons
    {
        private int _maxDamage;
        private int _minDamage;
        private string _weaponCategory;
        private int _elemtalMagicDmg;
        public int BonusHitChance { get; set; }
        public int MaxDamage { get; set; }
        public bool TwoHanded { get; set; }
        public bool Sheilded { get; set; }
        public string Name { get; set; }
        public string WeaponName // NF: change this to weapon category, also it should be typed as a list: List<string>
        {
            get { return _weaponCategory; }
            set
            {
                List<string> _weaponName = new List<string>() {
                    "sword",
                    "Axe",
                    "Bow",
                    "Claymore",
                    "BasterSword",
                };
            }

        }
        public int ElemtalMagicDmg
        {
            get { return _elemtalMagicDmg; }

            set
            {
                if (_elemtalMagicDmg == MaxDamage)
                {
                    _elemtalMagicDmg = 10 * MaxDamage;
                }
                else
                {
                    _elemtalMagicDmg = 0;
                }
            }
        }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }

            }
        }

        public Weapons(int minDamage, int maxDamage, string name, int bounusHitChance, bool twoHanded, bool sheilded, string weaponName)
        {
            _maxDamage = maxDamage; //0
            _minDamage = minDamage; //1 <- NF: Did you mean _minDamage? 
            WeaponName = weaponName; //2
            BonusHitChance = bounusHitChance; //3
            Name = name; //4
            TwoHanded = twoHanded; //5
            Sheilded = sheilded; //6

        }

        public int getWeaponAttack()
        {
            int damage = new Random().Next(_minDamage, _maxDamage);
            if (damage == _maxDamage)
            {
                damage = damage * ElemtalMagicDmg;
            }
            return damage;
        }

        public override string ToString()
        {
            return string.Format("{0}/t{1} to {2} Damage\nBonus Hit Chance: {3}% \t {4} ", Name, MinDamage, MaxDamage, BonusHitChance, TwoHanded, Sheilded ? "Two Handed" : "Shield");
        }

    }
}