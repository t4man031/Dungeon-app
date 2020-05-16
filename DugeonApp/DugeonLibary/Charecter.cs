using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DugeonLibary
{
    public abstract class Charecter
    {
        private int _life;

        public string Name { get; set; }
        public int Hitchance { get; set; }
        public int Block { get; set; }
        public int MaxLife { get; set; }

        public int Life;

        public int MyProperty
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {

                    _life = value;


                }
                else
                {
                    _life = MaxLife;
                }




            }
        }
        public int CalcBlock()
        {
            return Block;
        }
        public int CalchitChance()
        {
            return Hitchance;

        }
        public int CalcHitChance()
        {
            return Hitchance;
        }
        public int CalcDamage()
        {
            return 0;
        }








    }




}

