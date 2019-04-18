using System;
using System.Collections.Generic;
using System.Text;

namespace WzorceProj
{
    class Singleton
    {
        /*Scisle zamkniety, nic nie mozna zrobic z sama klasa, ma pewne problemy
        z programowaniem watkowym, nie jest mozliwe mockowanie*/
        private static Singleton singleton;
        private Singleton()
        {

        }

        public static Singleton GetSingleton()
        {
            if (singleton == null)
            {
                singleton = new Singleton();
            }
            return singleton;
        }

    }
}
