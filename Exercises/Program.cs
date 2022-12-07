using Exercises;

Console.WriteLine("-- Exercises 1 --");

Guitar jackson = new(brand: "Jackson", bodyStyle: Guitar.bodyStyle.SuperStrat, price: 799.00);
Guitar ibanez = new(brand: "Ibanez", bodyStyle: Guitar.bodyStyle.Stratocaster, price: 250.00);
Guitar esp = new(brand: "ESP", bodyStyle: Guitar.bodyStyle.LesPaul, price: 1400.00);

Console.WriteLine($"Guitar 1: {jackson.Brand}\nGuitar 2: {ibanez.Brand}");

Musician ben = new(name: "Benjamin Burnley", guitar: esp);

ben.Plays();