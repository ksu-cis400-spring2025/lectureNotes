public class Person {
    private int _age;

    public int Age {
        get => _age;
        init {
            if (value >= 0) _age = value;
        }
    }

    public string Name {get;}

    public Address CurrentAddress { get; set; }

    public Person(string n) {
        Name = n;
    }
}

public class Address {
    public uint Number { get; }

    public string Street { get; }

    public string City { get; }

    public string State { get; }

    public Address (uint num, string street, string city, string state) {
        Number = num;
        Street = street;
        City = city;
        State = state;
    }
}