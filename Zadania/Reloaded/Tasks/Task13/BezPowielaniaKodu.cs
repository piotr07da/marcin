using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task13
{
    public class BezPowielaniaKodu
    {
        public void Test()
        {
            int x1, x2, x3, x4, x5, x6;
            
            x1 = WriteMessageAndReturnMessageLength(1, "wiadomość pierwsza");
            x2 = WriteMessageAndReturnMessageLength(2, "wiadomość   druga");
            x3 = WriteMessageAndReturnMessageLength(3, "wiadomość trzecia");
            x4 = WriteMessageAndReturnMessageLength(4, "wiadomość czwarta");
            x5 = WriteMessageAndReturnMessageLength(5, "wiadomość piąta");
            x6 = WriteMessageAndReturnMessageLength(6, "wiadomość szósta");

            Console.WriteLine(x1 + x2 + x3 + x4 + x5 + x6);
        }

        private int WriteMessageAndReturnMessageLength(int messageNumber, string message)
        {
            Console.WriteLine(messageNumber + ".");
            Console.WriteLine("******************");
            Console.WriteLine(message);
            Console.WriteLine("##################");

            return message.Length;
        }
    }
}
