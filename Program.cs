using System;

namespace LargerWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentText = Console.ReadLine();
            string[] words = currentText.Split(' ');            //separa a string em um vetor
            string aux = "";
            string hold = "";

            foreach(string word in words)                       //Verifica cada palavra do vetor
            {
                
                foreach(char ch in word)
                {
                    if(Char.IsLetter(ch))
                    {
                        hold = hold + ch;
                    }
                }

                if(hold.Length > aux.Length)                   //Garante que aux vai receber o valor de 
                {                                              //hold e após isso hold volta a ser
                    aux = hold;                                // uma string vazia.
                    hold = "";                                 
                }
            }

            Console.WriteLine(aux);
        }
    }
}
