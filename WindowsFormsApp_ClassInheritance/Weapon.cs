using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_ClassInheritance
{
    #region Parent Class
    public class Weapon
    {
        protected int damage; //자기 클래스와 자식 클래스만 이용할 수 있는 값
        public string Name { get; set; }


        public Weapon() { }
        public Weapon(int damage)
        {
            this.damage = damage;
        }
        public void Attact()
        {
            Console.WriteLine($"{Name}(으)로 공격!");
        }

        // [Add] Damage Return Method (Arrow Function)
        public int AttactPower() => damage;
    }
    #endregion


    #region Child Class
    public class Sword : Weapon //검
    {
        //protected int attact_range;
        public Sword() { }
        public Sword(int damage) : base(damage) { }

        public void Sharp()
        {
            Console.WriteLine("검이 날카롭게 빛납니다.");
        }
    }

    public class Gun : Weapon //총
    {
        // [Add] Attact Abailable range
        int attact_range = 1;

            public void Reload()
        {
            Console.WriteLine("총을 재장전합니다.");
        }

        // [Add]
        public int Slash(int range)
        {
            if (this.attact_range >= range)
            {
                return this.damage;
            }
            return 0;
        }
    }

    public class Bow : Weapon //활
    {
        public void Aim()
        {
            Console.WriteLine("활을 당겨 조준합니다.");
        }
    }
    #endregion
}
