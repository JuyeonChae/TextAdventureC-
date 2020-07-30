using System;
using System.Security.Cryptography.X509Certificates;

public class Person
{
	protected string name{ get; set; }
	protected int intelligence { get; set; }
	protected int age { get; set; }
	protected int money { get; set; }
	public Person(string name, int intelligence, int age, int money)
    {
		this.name = name;
		this.intelligence = intelligence;
		this.age = age;
		this.money = money;
    }
}

public class Hasheti : Person
{
	int violence;
	int socialStatus;

	public Hasheti(string name, int intelligence, int age, int money, int violence, int socialStatus) : base(name, intelligence, age, money)
	{
		this.violence = violence;
		this.socialStatus = socialStatus;
    }
}

public class Elliyah : Person
{
	int niceness;
	int curiousity;
	public Elliyah(string name, int intelligence, int age, int money, int niceness, int curiousity) : base(name, intelligence, age, money)
    {
		this.niceness = niceness;
		this.curiousity = curiousity;
    }

	public void niceUp(Elliyah target)
    {
		this.niceness += 10;
		Console.WriteLine("그녀의 착함이 +10 올라갔다!");
    }
	
	public void curiousityUp(Elliyah target)
    {
		this.curiousity += 10;
		Console.WriteLine("그녀의 호기심이 +10 올라갔다!");
    }
	
	public void intelligenceUp(Elliyah target)
    {
		this.intelligence += 10;
		Console.WriteLine("그녀의 똑똑함이 +10 올라갔다!");
    }
}

