using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class A
    {
        private int a;
        public void setInt(int a)
        {
            this.a = a;
        }

        public int getInt()
        {
            return a;
        }
        //コンストラクタ
        public A()
        {

        }
        public A(int a)
        {
            setInt(a);
        }
        public static void staMsg()
        {
            Console.WriteLine("staticMethod");
        }
    }

    public class AA
    {
        public virtual void XX() //virtual オーバーライドを許可
        {
            Console.WriteLine("スーパークラス");
        }

    }

    public class BB : AA //継承
    {
        public override void XX()
        {
            Console.WriteLine("サブクラス");
        }
    }

    public abstract class AbsClass //抽象クラス
    {
        public abstract void YY(); //抽象メソッド
    }
    public class CC : AbsClass
    {
        public override void YY()
        {
            Console.WriteLine("抽象クラスのメソッドをオーバーライド");
        }
    }

    interface Inter
    {
        void GG();
    }
    public class DD : Inter
    {
        public void GG()
        {
            Console.WriteLine("interfaceのメソッドを実装");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            A ClassA = new A();
            ClassA.setInt(50);
            int x = ClassA.getInt();
            Console.WriteLine(x);
            //型名で参照
            A.staMsg();

            A ClassA2 = new A(100);
            Console.WriteLine(ClassA2.getInt());

            AA aa = new AA();
            aa.XX();
            aa = new BB();
            aa.XX();
            
        }
    }

    
}
