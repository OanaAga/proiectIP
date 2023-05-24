using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace proiectState
{
    public abstract class IState
    {
        private static IState _currentState = null;
       
        public static void SetState(IState s,Action function)
        {
            _currentState = s;
            Console.WriteLine("");
            function();
        }
        public abstract Action CreeazaFereastra(Form1 form);


    }
}
