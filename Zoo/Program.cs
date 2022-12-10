using Zoo;

Console.WriteLine("Zoo demos");

// Inheritance
Cat cat = new(name: "Meeka", weight: 9.3, age: 16);
Cat cat2 = new(name: "Ivan", weight: 8.1, age: 13);
Dog dog = new("Rocky", 150.00, 16);
Mouse mouse = new(name: "mouse", 1.00, 5);

List<Animal> animalList = new();

Console.WriteLine($"Adding Animal: {cat} to list");
// Type Substitution
animalList.Add(cat);

Console.WriteLine($"Adding Animal: {cat2} to list");
animalList.Add(cat2);

Console.WriteLine($"Adding Animal: {dog} to list");
animalList.Add(dog);

Console.WriteLine($"See the weight of all our animals");

// see the weight of each animal
foreach (var animal in animalList)
{
    // example of Dynamic Binding / Dynamic Execution
    if (animal is Cat)
    {
        animal.Eat(mouse); // example of interfaces
    } else
    {
        animal.Eat(new Grass(1)); // example of interfaces
    }
    Console.WriteLine($"{animal.Name} weighs {animal.Weight} lbs.");
}