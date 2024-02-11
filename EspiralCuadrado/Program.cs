
namespace EspiralCuadrado
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                //Console.ForegroundColor = ConsoleColor.White;
                

                //EstablecerTamanio();
                CentrarCursor();
                GenerarEspiral(3);

            } while (true);



        }

        private static void CentrarCursor()
        {
            int X = Console.WindowWidth / 2;
            int Y = Console.WindowHeight / 2;

            Console.SetCursorPosition(X, Y);
        }

        private static void GenerarEspiral(uint numero_vueltas)
        {
            Derecha('*', 10/2);
            Arriba('*', 10/2);
        }

        private static void Derecha(char caracter, int numero)
        {
            for (int i = 0; i < numero; i++)
            {
                
                Console.Write(caracter + " ");

            }
        }

        private static void Arriba(char caracter, int numero)
        {
            (int cW, int cH) = Console.GetCursorPosition();
            for (int i = 0; i < numero; i++)
            {
                Console.SetCursorPosition(cW-1, cH - 1);
                Console.Write(caracter);
                (_, cH) = Console.GetCursorPosition();
            }
        }

        //private static void EstablecerTamanio()
        //{
        //    var width = 800;
        //    var height = 800;
        //    Console.SetBufferSize(width, height);
        //    Console.WriteLine("{0} {1}", Console.WindowWidth,
        //                          Console.WindowHeight);
        //    Console.WriteLine("");
        //    Console.ReadKey(true);
        //}

    }
}
