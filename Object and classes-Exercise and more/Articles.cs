using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace ConsoleApp1
{

    public class Program
    {
        static void Main(string[] args)
        {

            string[] articles = Console.ReadLine().Split(", ").ToArray();
            int counter = int.Parse(Console.ReadLine());
            Article article = new Article();
            {
                article.Title = articles[0];
                article.Content = articles[1];
                article.Author = articles[2];

            }
            for (int i = 1; i <= counter; i++)
            {
                string[] commands = Console.ReadLine().Split(": ").ToArray();

                if (commands[0] == "Edit")
                {
                    article.Edit(commands[1]);

                }
                else if (commands[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(commands[1]);
                }
                else if (commands[0] == "Rename")
                {
                    article.Rename(commands[1]);
                }
            }
            Console.WriteLine(article.ToString());


        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }


        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
        }
    }



                
            
        
    



        
    


