
Fruit apple = new Fruit("apple", "red");

Console.WriteLine(apple.Name);

apple.Name = "Green Apple";
apple.Color = "Green";

Console.WriteLine(apple.Name);
Console.WriteLine(apple.Color);

Animal dog = new Dog();

dog.Eat();
dog.MakeNoise();

typeof(dog)

class Fruit {
    private string name;
    private string color;

    public string Name {
        get { return name; }
        set { name = value; }
    }

    public String Color {
        get { return color; }
        set { color = value; }
    }

    public Fruit(string name, string color) {
        this.name = name;
        this.color = color;
    }
}

interface Animal {
    void Eat();
    void MakeNoise();
}

class Dog : Animal {

    public void Eat() {
        Console.WriteLine("Dog is eating");
    }

    public void MakeNoise() {
        Console.WriteLine("Bark! Bark!");
    }
    
}