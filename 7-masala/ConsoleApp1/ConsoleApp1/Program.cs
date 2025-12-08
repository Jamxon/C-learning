class  Program
{
    static void Main(string[] args)
    {
        Dog dogs = new Dog();
        Console.WriteLine(dogs.Woow());
        Cat cat = new Cat();
        cat.Meow();
    }
}

interface Animals
{
    static string Speak(string text)
    {
        return text;
    }
}

class Dog : Animals
{ 
    public string Woow()
    {
        return Animals.Speak("Woow");
    }
}

class Cat : Animals
{
    public virtual void Meow()
    {
        Console.WriteLine(Animals.Speak("Meow"));
    }
}