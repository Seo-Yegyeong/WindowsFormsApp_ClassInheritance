using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_ClassInheritance
{
    public partial class Form2Weapon : Form
    {
        public Form2Weapon()
        {
            InitializeComponent();
            Sword sword = new Sword();
            sword.Name = "롱소드";
            sword.Attact(); //call the parent's method
            sword.Sharp(); //call the method in child

            Console.WriteLine("==========================");

            /*
             #2. 업캐스팅: "자식(Sword)" 클래스를 "부모(Weapon)" 클래스 타입으로. 자식 클래스의 고유 기능은 숨겨지고, 부모 클래스의 메서드만 사용할 수 있다.)
             왜 써?
             => 다형성 통해 여러 자식 객체를 부모 타임 하나로 통합하여
                유연하고 재사용 가능한 코드로 작성하기 위해.
             방식 3가지?
             1. 묵시적 업캐스팅 (중간에 변수를 할용해서 사용함)
                Sword sword = new Sword();
                Weapon weapon1 = sword; //Call the parent's method
                weapon1.Attact();
                //weapon1.Sharp(); // Nope. Error 발생. 부모 클래스로 덮어지기 때문에 자식의 클래스 사용 X
                Weapon 
             2. 다이렉트(=묵시적) 업캐스팅 (바로 대입하는 방식, 가장 많이 쓰임)
                Weapon weapon2 = new Gun();
                weapon2.Name = "Ak-47";
                weapon2.Attact()
                //weapon2.Reload(); // 자식 고유 메서드 호출. 에러 발생
             3. 명시적 업캐스팅 (형변환 기호 사용, 잘 안 씀)
                Weapon weapon3 = (Weapon)new Bow();
                weapon.Name = "";
            */
        }
    }
}
