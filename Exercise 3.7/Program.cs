using System;

namespace Exercise_3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter URL: ");
            string urlStr = Console.ReadLine();
            Uri url = new UriBuilder(urlStr).Uri;

            RobotsTxtParser parser = new RobotsTxtParser(url);

            Console.WriteLine("\nAllowed URLs:");
            foreach (var path in parser.AllowedUrls)
            {
                Console.WriteLine(path);
            }
    
            Console.WriteLine("\nDisallowed URLs:");
            foreach (var path in parser.DisallowedUrls)
            {
                Console.WriteLine(path);
            }

            Console.WriteLine();
            if (parser.IsUrlAllowed(url))
                Console.WriteLine(url.ToString() + " is allowed");
            else
                Console.WriteLine(url.ToString() + " is not allowed");
}
    }
}
