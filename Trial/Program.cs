class MainProgram 
{
	static void Main(string[] args) 
	{
		Publisher myPublisher = new Publisher();
		Subscriber mySubscriber = new Subscriber();
		SecondSub mySecondSub = new SecondSub();
		myPublisher.myDelegate += mySubscriber.Notification;
		myPublisher.myDelegate += mySecondSub.Notification;
		string result = myPublisher.myDelegate("Running on ");
	}
}

public class Publisher 
{
	public delegate string MyDelegate(string message);
	public MyDelegate myDelegate;
}

public class Subscriber
{
	public string Notification(string message) 
	{
		return message + "First Subscriber";
	}
}

public class SecondSub
{
	public string Notification(string message)
	{
		return message + "Second subscriber";
	}
}
