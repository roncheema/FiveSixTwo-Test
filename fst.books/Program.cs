using fst.books.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace fst.books
{
    class Program
    {
        static void Main(string[] args)
        {
            Task T = new Task(ApiCall);
            T.Start();
            Console.WriteLine("Json data........");
            Console.ReadLine();
        }

        static async void ApiCall()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    await client.GetAsync("https://www.googleapis.com/books/v1/volumes?q=rowling");

                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                string responseBody2 = "[" + responseBody + "]";

                var result = JsonConvert.DeserializeObject<IList<RootObject>>(responseBody2);
                foreach (var item in result)
                {
                    foreach (var book in item.items)
                    {
                        Console.WriteLine("{0}, {1}, {2}, {3}", book.volumeInfo.title, book.volumeInfo.pageCount, book.accessInfo.epub.isAvailable, book.volumeInfo.averageRating);
                        
                    }
                }
            }
            
        }
    }
}
