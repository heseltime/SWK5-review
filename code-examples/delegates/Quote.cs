public class Quote
{
    public string Text { get; set; }
    public string Author { get; set; }

    public Quote(string text, string author)
    {
        Text = text;
        Author = author;
    }
}
