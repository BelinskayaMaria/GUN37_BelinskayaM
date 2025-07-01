using System;

struct Interval
{
    private Random random;

    public float Min { get; }
    public float Max { get; }

    public Interval(int minValue, int maxValue)
    {
        if (minValue > maxValue)
        {
            Console.WriteLine("Некорректные входные данные: minValue больше maxValue. Меняю местами.");
            int temp = minValue;
            minValue = maxValue;
            maxValue = temp;
        }

        if (minValue < 0)
        {
            Console.WriteLine("Некорректные входные данные: minValue меньше 0. Устанавливаю 0.");
            minValue = 0;
        }

        if (maxValue < 0)
        {
            Console.WriteLine("Некорректные входные данные: maxValue меньше 0. Устанавливаю 0.");
            maxValue = 0;
        }

        if (minValue == maxValue)
        {
            Console.WriteLine("Некорректные входные данные: minValue и maxValue равны. Увеличиваю max на 10.");
            maxValue += 10;
        }

        Min = minValue;
        Max = maxValue;
        random = new Random();
    }

    public float Get()
    {
        return (float)(Min + random.NextDouble() * (Max - Min));
    }

    public override string ToString()
    {
        return $"[{Min} - {Max}]";
    }
}

class Weapon
{
    public string Name { get; }
    public Interval Damage { get; private set; }
    public float Durability { get; } = 1f;

    public Weapon(string name)
    {
        Name = name;
    }

    public Weapon(string name, int minDamage, int maxDamage) : this(name)
    {
        SetDamageParams(minDamage, maxDamage);
    }

    public void SetDamageParams(int minDamage, int maxDamage)
    {
        if (minDamage > maxDamage)
        {
            Console.WriteLine($"Некорректные входные данные для оружия {Name}. MinDamage больше MaxDamage. Меняю местами.");
            int temp = minDamage;
            minDamage = maxDamage;
            maxDamage = temp;
        }

        if (minDamage < 1)
        {
            Console.WriteLine($"Для оружия {Name} форсированно установлено минимальное значение урона (1).");
            minDamage = 1;
        }

        if (maxDamage <= 1)
        {
            Console.WriteLine($"Для оружия {Name} форсированно установлено максимальное значение урона (10).");
            maxDamage = 10;
        }

        Damage = new Interval(minDamage, maxDamage);
    }

    public int GetDamage()
    {
        return (int)((Damage.Min + Damage.Max) / 2);
    }

    public override string ToString()
    {
        return $"{Name}, Damage: {Damage}, Durability: {Durability}";
    }
}

class Unit
{
    public string Name { get; }
    public Interval Damage { get; private set; }

    public Unit(string name)
    {
        Name = name;
        Damage = new Interval(0, 0);
    }

    public Unit(string name, int minDamage, int maxDamage)
    {
        Name = name;
        Damage = new Interval(minDamage, maxDamage);
    }

    public override string ToString()
    {
        return $"{Name}, Damage: {Damage}";
    }
}

struct Room
{
    public Unit Unit;
    public Weapon Weapon;

    public Room(Unit unit, Weapon weapon)
    {
        Unit = unit;
        Weapon = weapon;
    }
}

class Dungeon
{
    private Room[] rooms;

    public Dungeon()
    {
        rooms = new Room[]
        {
            new Room(new Unit("Goblin", 2, 5), new Weapon("Rusty Sword", 1, 3)),
            new Room(new Unit("Orc", 5, 10), new Weapon("Axe", 4, 8)),
            new Room(new Unit("Dragon", 10, 20), new Weapon("Fire Breath", 8, 15))
        };
    }

    public void ShowRooms()
    {
        for (int i = 0; i < rooms.Length; i++)
        {
            var room = rooms[i];
            Console.WriteLine("Unit of room: " + room.Unit);
            Console.WriteLine("Weapon of room: " + room.Weapon);
            Console.WriteLine("---");
        }
    }
}

class Program
{
    static void Main()
    {
        Dungeon dungeon = new Dungeon();
        dungeon.ShowRooms();
    }
}