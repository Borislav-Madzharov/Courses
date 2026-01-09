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
            int editCount = int.Parse(Console.ReadLine());


            List<Article> articles = new List<Article>();

            for (int i = 0; i < editCount; i++)
            {
                string[] aruguments = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToArray();
                string title = aruguments[0];
                string content = aruguments[1];
                string author = aruguments[2];

                Article article = new Article();
                article.Title = title;
                article.Content = content;
                article.Author = author;

                articles.Add(article);


            }

            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }




        }
    }

    public class Article
    {
        public string Title;
        public string Content;
        public string Author;

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }

}
