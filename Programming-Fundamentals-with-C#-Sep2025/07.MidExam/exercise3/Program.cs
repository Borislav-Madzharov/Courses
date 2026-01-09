using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Spam Hello How are you
end

Chat Hello
Chat darling
Edit darling Darling
Spam how are you
Delete Darling
end


 
 */


namespace exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();

            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split(' ');

                if (input[0] == "Chat")
                {
                    Chat(chat, input[1]);
                }
                else if (input[0] == "Delete")
                {
                    Delete(chat, input[1]);
                }
                else if (input[0] == "Edit")
                {
                    Edit(chat, input[1], input[2]);
                }
                else if (input[0] == "Pin")
                {
                    Pin(chat, input[1]);
                }
                else if (input[0] == "Spam")
                {
                    List<string> spamMessage = new List<string>();

                    for (int i = 1; i < input.Length; i++)
                    {
                        spamMessage.Add(input[i]);
                    }
                    Spam(chat, spamMessage);

                }

            }

            Console.WriteLine(string.Join("\n", chat));







        }

        static string Chat(List<string> chat, string text)
        {
            chat.Add(text);

            return "";
        }
        static string Delete(List<string> chat, string text)
        {
            if (chat.Contains(text))
            {
                chat.RemoveAt(chat.IndexOf(text));
            }

            return "";
        }
        static string Edit(List<string> chat, string text, string newText)
        {
            if (chat.Contains(text))
            {
                chat[chat.IndexOf(text)] = newText;
            }

            return "";
        }
        static string Pin(List<string> chat, string text)
        {
            if (chat.Contains(text))
            {
                string movingTextVar = text;
                chat.RemoveAt(chat.IndexOf(text));
                chat.Add(movingTextVar);
            }

            return "";
        }
        static string Spam(List<string> chat, List<string> spamMessage)
        {
            chat.AddRange(spamMessage);

            return "";
        }

    }
}
