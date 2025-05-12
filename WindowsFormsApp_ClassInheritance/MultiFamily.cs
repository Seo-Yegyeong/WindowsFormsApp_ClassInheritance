using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_ClassInheritance
{
    // Grand Parent -> Parent -> Children -> Grand Children

    // Note : internal class GrandParent 이고, public cllass Parent 인 경우 에러가 난다. 왜냐하면 Parent는 외부에 공개된 클래스인데, 그 기반 클래스 GrandParent는 외부에서 접근할 수 없으므로 컴파일 오류.
    public class GrandParent
    {
        public GrandParent() {
            Console.WriteLine("GrandParent Constructor !");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello~ I'm a grandma");
        }
    }

    public class Parent : GrandParent
    {
        public Parent()
        {
            Console.WriteLine("Parent Constructor !");
        }

        public void SayHello1()
        {
            Console.WriteLine("Hello~ I'm a mother");
        }
    }

    public class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Child Constructor !");
        }

        public void SayHello2()
        {
            Console.WriteLine("Hello~ I'm a daughter");
        }
    }

    public class GrandChild : Child
    {
        public GrandChild()
        {
            Console.WriteLine("GrandChild Constructor !");
        }

        public void SayHello3()
        {
            Console.WriteLine("Hello~ I'm a grand daughter");
        }
    }


}
