public delegate void MyDelegate(string message);
public class MyEventPublisher
{
	public MyDelegate MyEvent;

	public void DoSomething()
	{
		Console.WriteLine("Doing something interesting...");
		OnMyEvent("Hello, World!");
	}

	protected virtual void OnMyEvent(string message)
	{
		MyEvent?.Invoke(message);
	}
}

public class MyEventSubscriber1
{
	public void MyEventHandler(string message)
	{
		Console.WriteLine($"B1_Event handled by subscriber 1. Message: {message}");
	}
}

public class MyEventSubscriber2
{
	public void MyEventHandler(string message)
	{
		Console.WriteLine($"B1_Event handled by subscriber 2. Message: {message}");
	}

	public void MyEventHandler2(string message)
	{
		Console.WriteLine($"B1_Event handled 2 by subscriber 2. Message: {message}");
	}
}

public class Program
{
	static void Main(string[] args)
	{
		var publisher = new MyEventPublisher();
		var subscriber1 = new MyEventSubscriber1();
		var subscriber2 = new MyEventSubscriber2();
		publisher.MyEvent += subscriber1.MyEventHandler;
		publisher.MyEvent += subscriber2.MyEventHandler;
		publisher.DoSomething();
		//publisher.OnMyEvent("Hello, world!");
	}
}
