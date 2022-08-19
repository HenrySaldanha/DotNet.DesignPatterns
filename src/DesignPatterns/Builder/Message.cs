namespace DesignPatterns.Builder;
internal class Message
{
    public Message(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; set; }
    public string Sender { get; set; }
    public string Recipient { get; set; }
    public string ImageUrl { get; set; }
    public string Text { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}\n"+ 
               $"Sender: {Sender}\n" + 
               $"Recipient: {Recipient}\n" + 
               $"Text: {Text}\n" +
               $"ImageUrl: {ImageUrl}\n";
    }
}