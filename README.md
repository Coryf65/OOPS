# OOPS

> using C# and .Net to learn more about OOP while taking notes to help myself out

1. DungeonsOfDoom, a C# Console App Game
2. Excercises, some demos and tests, a C# Console App
3. Zoo, practice implementing new lessons,a C# Console App

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
- [Static Classes](#static-classes)
- [Class Libraries](#class-libraries)
- [Reference and Value Types](#reference-and-value-types)


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

The meaning of abstraction is, you don't need to explain everything. In our real life, we have vehicles such as cars, motorcycles?and scooters. People only know how to drive these vehicles. It's not necessary to know how the vehicle runs or how petrol or diesel works in that vehicle.
?
So when we define an abstract we don't need to explain everything. It's a type of class, but you cannot create an instance (object) of it. In other words you cannot create an instance of the class. Now you might ask why do we not create an instance of an abstract class? The answer is that when we create or define an abstract class, it's not complete.
?
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

	- [x] The class may *only* contain static members
	- [x] The class **cannot** be instantiated
	- [x] The class **cannot** be derived from

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

- The main purpose for static classes

	- writing utility / helper classes (like the 'Console', 'File', 'String' classes)

*example*
```C#
static class StringUtils
{
  public static bool IsNumeric(string value)
  {
    return int.TryParse(value, out int i);
  }
}

bool b1 StringUtils.IsNumeric("Test"); // false
bool b1 StringUtils.IsNumeric("10"); // true
```

- Static Constructors

	- called automatically before the class is "touched", no access modifiers and no parameters

```C#
class Person
{
  static Person()
  {
    // Run any code in here to initialize static members
  }
}
```

- Why are these Static ?

1. Console.WriteLine()

<details><summary>Answer for #1</summary>
<p>
We only use the Console in a Console App. We only have One Console so there is no confusion as to which one we are reffering to.
</p>
</details>

2. Math.Abs(int value)

<details><summary>Answer for #2</summary>
<p>
If we had 2 instances of this class and pass in the same value. We would expect the same output. All Math operations are shared and work in one way.
</p>
</details>

3. string.IsNullOrEmpty(string value)

<details><summary>Answer for #3</summary>
<p>
If the string was null we wanted to check we would get a runtime error, a Null reference Exception
</p>
</details>

4. Program.Main(string[] args) // the main method

<details><summary>Answer for #4</summary>
<p>
We don't call main the runtime calls this. It sets up an entry point for us. No point to have multiple entry points would be confusing.
</p>
</details>

### Class Libraries
---

- Your project must add a reference to the Class Library. Just because they are in the same solution does not allow them to talk with one another.

1. Namespaces
	
	- Used to group related classes together (system.io, for reading and writing files)
	- Minimizes the risk of name collisions
	- Typically matches the physical folder structure on disk (kinda of like directories for files, used to organize!)

2. Referencing Types in Namespaces

	- Qualify the full path or use a *using* statement

```C#
// Option 1: Fully qualified path
People.Person p = new();

// Option 2: a Using Statement
using People

Person p = new();
```

3. When to Create Class Libraries

	- Whenever you need to use the same classes in multiple projects. (like a Logger for logging to files or the console)

4. Using Types in Class Libraries

5. Namespaces and Class Libraries

	- No specific rules apply to namespaces and class libraries
	- Typically the namespace matches the name of the class library

6. Internal vs Public

- Internal types and members - Can be reached from within the same project

- Public types and members - Can also be reached from any project that references the project

### Reference and Value Types
---

- differences

| Referece Types  | Value Types |
| --------------  | ----------- |
| Type created using the *class* keyword  | Type created using the *struct* keyword (i.e: int, double, DateTime) |
| *Points* to a value | **Contains** a value |
| Default value: null | "Actual" default values (int = 0, bool = false) |

- Structs and Inheritance

	- **Structs** implicitly inherit System.ValueType
	- **Structs** can implement interfaces
	- **Structs** cannot be made abstract
	- **Structs** are implicitly sealed

- When to use which? (classes vs structs)

	- "Since pretty much all simple types have a;ready been defined in the base class library, we can create a class"

- Boxing

	- Done (implicitly) when a value type is treated as a reference type:

```C#
static void Main(string[] args)
{
  Foo(10); // Boxing the int as an object
}

static void Foo(object value)
{
	// some code here
}
```

- UnBoxing

	- Done (explicitly) when a reference type is cast into a value type:

```C#
static void Main(string[] args)
{
  Foo(10); // Boxing the int as an object
}

static void Foo(object value)
{
	// UnBoxing the object (by casting it back into it's original type)
	int myInt = (int)value;
}
```

> Ususally useful if we are using some code out of our control where we can work around the limitations

- Nullable Value Types

	- A generic type that allows for nullable value types.. 
	( Nullable<int>, int?)

- Nullable Reference Types

	- an opt-in feature starting in *C# 8*

	- Per file using **#nullable enable**

	- Per project using **<Nullable>enable</Nullable>**


---
- [back to top](#oops)