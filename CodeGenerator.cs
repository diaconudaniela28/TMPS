using System;
using System.Collections.Generic;
using System.Text;

namespace Generator
{
    class CodeGenerator
    {
        private static CodeGenerator instance = null;
        private static object locker = new object();

        public int Number { get; set; }

        private CodeGenerator()
        {
            Console.WriteLine("Generatorul de cod a fost creat");
        }

        public static CodeGenerator GetInstance()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                        instance = new CodeGenerator();
                }
            }
            return instance;
        }

        public void StartGenerate(string numberCode)
        {
            Console.WriteLine($"Utilizati codul: {numberCode}");
        }
    }

}
