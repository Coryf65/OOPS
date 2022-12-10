# OOPS

> C# is an object-oriented programming language. The four basic principles of object-oriented programming are:

    **Abstraction** Modeling the relevant attributes and interactions of entities as classes to define an abstract representation of a system.
    **Encapsulation** Hiding the internal state and functionality of an object and only allowing access through a public set of functions.
    **Inheritance** Ability to create new abstractions based on existing abstractions.
    **Polymorphism** Ability to implement inherited properties or methods in different ways across multiple abstractions.

- Microsoft [link to docs](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop)

## What is Object Orientation ?

1. Using classes as containers for related logic

	- any logic that pertains to a person resides in the person class

2. Encapsulating complexity behind a simple API (the members of a class)

	- using a car as an exmaple, When you are sitting in the car. You can see all the public API members. The gas pedal, brake pedal, steering wheel and so on. 
		If we were to open the hood of the car we can now see the complexity and hidden memebers that make up these controls. All you need to know is how to use the public simpler parts to drive car.

3. The instantiation of objects to represent seperate instances if a class

	- If we have many students we only need one class to represent a person.


## What is the point ?

- **Productivity**
	- Complexity is typically hidden behind an easy-to-understand API

- **Code reuse**
	- Through *inheritance*

- **Maintainability**
	- Through *polymorphism*

## Classes vs Object

| Class  | Object |
| ------------- | ------------- |
| "Blueprint for a building"  | "Actual building" |
| Resides in disk as a .cs file  | Created by calling a construtor |
| Always one per type | As many as your program neeeds |

## Class Members

- **Constructors**
	- Sets the *state* of the object (usually assigning values to props)

- **Fields**
	- Contains the *data* of the object

- **Properties**
	- Exposes the data of the object

- **Methods**
	- Does something to the object
	- The only place to do time-consuming operations

## Concept quick links

- [Inheritance](#inheritance)
- [Abstraction](#abstraction)
- [Polymorphism](#polymorphism)
- [Interfaces](#interfaces)
- [Static Classes](#staticclasses)


### Inheritance
---

- Concept
		
	Used primarily for code re-use (the derived classes inherits the members of the base class)

- The Is-a Rule

	A [Sub class / Derived] *is a* [Base class / Super class]
	Example: A Cat is an Animal

```C#
class Cat : Animal { }
```

- The Object class

	At the "top" of the inheritance chain is a class called object.

	Example: We have many methods without creating them. like *.ToString() .GetType()*

- Single vs. Mulitple Inheritance

	- Languages such as C# and Java support single inheritance

		A class can have *only one* direct base class

	- Languages such as C++ allows for multiple inheritance

		A class can have *multiple* direct base classes

- Inheritance and Constructors

### Abstraction
---

The meaning of abstraction is, you don't need to explain everything. In our real life, we have vehicles such as cars, motorcycles and scooters. People only know how to drive these vehicles. It's not necessary to know how the vehicle runs or how petrol or diesel works in that vehicle.
 
So when we define an abstract we don't need to explain everything. It's a type of class, but you cannot create an instance (object) of it. In other words you cannot create an instance of the class. Now you might ask why do we not create an instance of an abstract class? The answer is that when we create or define an abstract class, it's not complete.
 
You must inherit this class and define its methods and properties on this new derived class.

- Abstract Classes

	- Used only to provide code reuse to derived classes. Has code that is useful to the sub classes.
		Like a note to other devs saying please do not instaniate this class but use it to inherit from only.

	- Can *not* be instantiated

	- By specifying a class as abstract you say
			
	"This class exists only to be inherited from"

	we do not need instances of **Animal** but the **Cat** which inherits from **Animal**

```C#
abstract class Animal {}
```

- Abstract Members

	- Only *abstract classes* may contain abstract members

	- Abstract members *are not* implemented

	- Overriding an abstract *member* **is Mandatory**

		for example if we created a sub class of *SportsCar* we would need to implement the Start method

```C#
abstract class Car
{
  public int Speed { get; set; }
  public abstract void Start(); // don't implement'
}
```

### Polymorphism
---

A means of executing type specific code (without type checking)

1. Type substitution
		
	Base classes can be substituted by more derived classes

	> more examples in the Zoo project

	*example*
```C#
class Car
{
  public int Speed { get; set; }
}

class SportsCar : Car
{

}

static void StopCar(Car car)
{
  car.Speed = 0;
}

StopCar(new Car());

// Type Substitution, pass any class that inherits 'Car'
// The sports car is a car
StopCar(new SportsCar());
```

2. Virtual Members

	allows derived classes to override / specialize functionality

	overriding a virtual member is *optional*

	Think of **virtual** as optionally override-able

	*example:*
```C#
class Car
{
  public int Speed { get; set; }

  public virtual void Start()
  {
    Speed = 50;
  }
}

class SportsCar : Car
{
  // Overriding the method
  public override void Start()
  {
    Speed = 100;
  }
}
```

3. Dynamic Bindings

	When using type substitution, the "most overridden" member is called automatically

```csharp
Car[] cars new Car[2];
cars[0] = new Car();
cars[1] = new SportsCar();

foreach (Car car in cars)
{
  // Dynamic Binding
  // so now the car's speed will be 100 if it's a sports car
  car.Start();
}
```

### Interfaces
---

	"An interface is an API contract..."
	
	"Classes can implement as many contracts as they see fit..."

1. Creating an Interface

	- Prefixed by "I", ususally not Nouns like Methods

	- Members are implicitly public (and abstract)

*example*
```C#
interface IStartable
{
   void Start();
}
```

2. Implementing Interface

	- *Implemented* by a class using a colon (as many as you like)

	- Compiler verifies fulfillment of the contract

	- contains no 'code', no concrete implementation, just definitions

```C#
class Car : Vehicle, IStartable
{
  public int Speed { get; set; }

  public void Start()
  {
    Speed = 50;
  }
}

interface IStartable
{
  void Start();
}
```

3. What's the point?

	- Allows us to be more pragmatic about our requirements
		Focus on what classes *can do*, rather than who they inherit from...

	example: If you needed help gardening. It does not matter if your friend has been gardening for generations. All that matters is that you can garden.

```C#
void StartSomething(IStartable startable)
{
  startable.Start();
}

StartSomething(new Car());
StartSomething(new Vacation());
StartSomething(new Program());
```

4. a Few Popular Interfaces in **.Net**

- IEnumerable
	- GetEnumerator() (we are able to use a foreach loop with this Interface)

- ICollection
	- Count (we can always see how many items are in the given collection) etc

- IList
	- Add(), Clear(), etc

- IComparable
	- CompareTo() (compare 2 instance of a class to another for example to sort alphabetically)

some examples in the Zoo project

5. More Notes on Interfaces

- Interfaces can implement other interfaces

	- Just to be D.R.Y.

- Explicit interface implementation

	- To resolve name collisions
	- If we have 2 interfaces that have the same method. We have to specify which is for which interface.

- Default Interface Methods (seldom do, but possible)

	- Not to break current implementations

	- Have a method in the interface have a default implementation

### Static Classes
___

- The effects of making a **class** static

	[x] The class may *only* contain static members
	[x] The class **cannot** be instantiated
	[x] The class **cannot** be derived from

- Static Members

	- static members are class members rather than object members.

- Calling Static Members

```C#
class Person
{
  public string Name { get; set; }
  public static int InstanceCount { get; set; }

  public Person()
  {
    InstanceCount++;
  }
}

// Non static members are called on objects, **Console** class
Person person = new();
Console.WriteLine(person.Name);

// static members are called on the class
Console.WriteLine(Person.InstanceCount);

```

- Writing Utility Classes

- Static Constructors

---
- [back to top](#oops)