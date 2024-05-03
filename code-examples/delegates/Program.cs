class Program
{
    static void Main(string[] args)
    {
        QuotesLogic quotesLogic = new QuotesLogic();
        quotesLogic.OnNewQuote += (quote) => 
        {
            Console.WriteLine($"New Quote: {quote.Text} — {quote.Author}");
        };

        quotesLogic.OnNewQuote += (quote) => 
        {
            // send logic
            Console.WriteLine($"   - sending now ... sent.");
        };
        
        quotesLogic.Start();
        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
        quotesLogic.Stop();
    }
}
