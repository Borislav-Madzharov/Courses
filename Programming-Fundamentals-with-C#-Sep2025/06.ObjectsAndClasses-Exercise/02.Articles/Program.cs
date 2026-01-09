using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
some title, some content, some author
3
Edit: better content
ChangeAuthor:  better author
Rename: better title

 
 
 */


namespace _02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] aruguments = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToArray();
            int editCount = int.Parse(Console.ReadLine());
            string title = aruguments[0];
            string content = aruguments[1];
            string author = aruguments[2];

            Article article = new Article();
            article.Title = title;
            article.Content = content;
            article.Author = author;

            for (int i = 0; i < editCount; i++)
            {
                string[] actions = Console.ReadLine().Split(new string[] { ": " }, StringSplitOptions.None);

                if (actions[0] == "Edit")
                {
                    article.Edit(actions[1]);
                }
                else if (actions[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(actions[1]);
                }
                else if (actions[0] == "Rename")
                {
                    article.ChangeTitle(actions[1]);
                }

            }
            Console.WriteLine(article);



        }
    }

    public class Article
    {
        public string Title;
        public string Content;
        public string Author;

        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void ChangeTitle(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }

}
