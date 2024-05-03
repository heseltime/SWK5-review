using System;
using System.Timers;  // Import the System.Timers namespace

public delegate void NewQuoteEventHandler(Quote quote);  // Define the delegate

public interface IQuotesLogic
{
    event NewQuoteEventHandler OnNewQuote;
}

public class QuotesLogic : IQuotesLogic
{
    private List<Quote> _quotes = new List<Quote>();
    private Random _random = new Random();
    private System.Timers.Timer _timer;

    public event NewQuoteEventHandler OnNewQuote;

    public QuotesLogic()
    {
        _quotes.Add(new Quote("Be yourself; everyone else is already taken.", "Oscar Wilde"));
        _quotes.Add(new Quote("So many books, so little time.", "Frank Zappa"));
        _quotes.Add(new Quote("A room without books is like a body without a soul.", "Marcus Tullius Cicero"));

        _timer = new System.Timers.Timer(60000); // 1 minute interval
        _timer.Elapsed += HandleElapsed;
        _timer.AutoReset = true;
        _timer.Enabled = true;
    }

    private void HandleElapsed(object sender, ElapsedEventArgs e)
    {
        Quote quote = NextQuote();
        OnNewQuote?.Invoke(quote);  // Invoke the event
    }

    private Quote NextQuote()
    {
        int index = _random.Next(_quotes.Count);
        return _quotes[index];
    }

    public void Start()
    {
        _timer.Start();
    }

    public void Stop()
    {
        _timer.Stop();
    }
}
