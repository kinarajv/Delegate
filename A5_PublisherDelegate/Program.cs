// Delegate
public delegate void MessageHandler(string message);

public class Publisher
{
    // Delegate instance untuk mendaftarkan subscriber
    public MessageHandler MessageSent;

    public void SendMessage(string message)
    {
        MessageSent?.Invoke(message);
    }
}

public class Subscriber
{
    public void OnMessageReceived(string message)
    {
        Console.WriteLine($"Subscriber menerima pesan: {message}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber1 = new Subscriber();
        Subscriber subscriber2 = new Subscriber();

        publisher.MessageSent += subscriber1.OnMessageReceived;
        publisher.MessageSent += subscriber2.OnMessageReceived;

        publisher.SendMessage("Halo, ini pesan!");
    }
}