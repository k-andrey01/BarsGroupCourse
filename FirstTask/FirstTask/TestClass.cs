using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    internal class TestClass
    {
        public event EventHandler<char> OnKeyPressed;

        public void Run()
        {
            bool cPressed = false;
            while (!cPressed)
            {
                var key = Console.ReadKey();
                OnKeyPressed?.Invoke(this, key.KeyChar);
                if ((key.KeyChar.Equals('c'))||(key.KeyChar.Equals('с')))
                    cPressed= true;
            }
            Console.WriteLine("Exit from programm");
        }
    }
}
