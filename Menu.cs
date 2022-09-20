using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            string caractRow = "-";
            string caractColum = "|";
            string caractDivision = "+";
            string quebrarLinha = "\n";
            string espaco = " ";
            int qtdLinhas = 30;
            int qtdColum = 10;

            //Gera primeira linha
            DrawTopAndBottom(caractDivision, qtdLinhas, caractRow, quebrarLinha);

            //Preenche as colunas laterais
            for (int coluna = 0; coluna < qtdColum; coluna++)
            {
                Console.Write(caractColum);
                for (int inicio = 0; inicio <= qtdLinhas; inicio++)
                {
                    Console.Write(espaco);
                }
                Console.Write(caractColum);
                Console.Write(quebrarLinha);
            }

            //Gera ultima linha
            DrawTopAndBottom(caractDivision, qtdLinhas, caractRow, quebrarLinha);
        }

        public static void DrawTopAndBottom(string caractDivision, int qtdLinhas, string caractRow, string quebrarLinha)
        {
            Console.Write(caractDivision);
            for (var inicio = 0; inicio <= qtdLinhas; inicio++)
            {
                Console.Write(caractRow);
            }
            Console.Write(caractDivision);
            Console.Write(quebrarLinha);
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 0:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
                case 1:
                    Editor.Show();
                    break;
                case 2:
                    Console.WriteLine("View");
                    break;
                default:
                    Show();
                    break;
            }
        }

    }
}