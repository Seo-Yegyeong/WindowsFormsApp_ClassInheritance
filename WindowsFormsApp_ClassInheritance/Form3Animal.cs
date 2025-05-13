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
    public partial class Form3Animal : Form
    {
        public Form3Animal()
        {
            InitializeComponent();

            //Case #1. Dog
            Animal animal = new Dog();
            animal.Speak();
            // animal.Shout(); //Dog()의 method 사용 불가. 아래와 같이 다운캐스팅 해줘야 함.
            ((Dog)animal).Shout();

            //Case #2. Cat
            animal = new Cat();
            animal.Speak();
            // animal.Cry(); //Cat()의 method 사용 불가. 아래와 같이 다운캐스팅 해줘야 함.
            ((Cat)animal).Cry();

            //Case #3. Bird
            animal = new Bird();
            animal.Speak();
            // animal.Sing(); //Bird()의 method 사용 불가. 아래와 같이 다운캐스팅 해줘야 함.
            ((Bird)animal).Sing();


        }
    }
}
