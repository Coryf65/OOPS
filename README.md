# C#, .NET and OOP

> using C# and .Net to learn more about OOP while taking notes to help myself out. This also contains any notes that help me clarify C# .NET and OOP.

### Code examples:

1. DungeonsOfDoom, a C# Console App Game
2. Excercises, some demos and tests, a C# Console App
3. Zoo, practice implementing new lessons, a C# Console App
4. OODemo an example of the wrong kind of inheritance, C# console app
5. BetterOODemo an example of imporving the inheritance using interfaces too, C# console app

> C# is an object-oriented programming language. The four basic principles of object-oriented programming are:
> - **Abstraction** Modeling the relevant attributes and interactions of entities as classes to define an abstract representation of a system.
> - **Encapsulation** Hiding the internal state and functionality of an object and only allowing access through a public set of functions.
> - **Inheritance** Ability to create new abstractions based on existing abstractions.
> - **Polymorphism** Ability to implement inherited properties or methods in different ways across multiple abstractions.

> definition by: Microsoft [link to docs](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop)

## Concept quick links

- [The C# Language](#the-c-language)
- [.NET, .NET Core, .NET Framework, .NET Standard](#net)
- [Different Application Types / Models](#net-application-models)
- [Types](#types)
- [Access Modifiers](#access-modifiers)
- [Collections](#collections)
- [Inheritance](#inheritance)
- [Abstraction](#abstraction)
- [Polymorphism](#polymorphism)
- [Interfaces](#interfaces)
- [Static Classes](#static-classes)
- [Lambdas](#lambdas)
- [Extension Methods](#extension-methods)
- [Class Libraries](#class-libraries)
- [Reference and Value Types](#reference-and-value-types)
- [Reflection](#reflection)

## The C# Language

What is C#?

> It is an object-oriented programming language created by Microsoft that runs on the .NET Framework.
> C# has roots from the C family, and the language is close to other popular languages like C++ and Java.
> The first version was released in year 2002. The latest version, C# 11, was released in November 2022.
>
> C# is used for:
>
>		Mobile applications
>		Desktop applications
>		Web applications
>		Web services
>		Web sites
>		Games
>		VR
>		Database applications
>		And much, much more!
> definition from [W3 Schools](https://www.w3schools.com/cs/cs_intro.php)

### Types

1. Simple Types 
	___
	- Singed integral: `sbyte`, `short`, `int`, `long`
	- Unsigned integral: `byte`, `ushort`, `uint`, `ulong`
	- Unicode characters: `char` "a UTF-16 code unit"
	- IEEE binary floating-point: `float`, `double`
	- High-Precision decimal floating-point: `decimal`
	- Boolean: `bool` "containing values of `true` or `false`"
	- Enum Types
		- user defined `enum name {...}`
		- example:
		```C#
		public enum SomeRootVegetable
		{
			HorseRadish,
			Radish,
			Turnip
		}
		```
	- Struct types
		- user defined `struct name {...}`
		- example:
		```C#
		public struct Point
		{
			public double X { get; }
			public double Y { get; }

			public Point(double x, double y) => (X, Y) = (x, y);
		}
		```
	- Nullable Value types
		- example:
		```C#
		int? optionalInt = default; 
		optionalInt = 5;
		string? optionalText = default;
		optionalText = "Hello World.";
		```
	- Tuple value types
		- user defined `(T1, T2, ...)`
		- example: 
		```C#
		(double Sum, int Count) t2 = (4.5, 3);
		Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
		//Output:
		//Sum of 3 elements is 4.5.
		```
2. Reference Types
	___
	- Class types
		- *Top Level class* `object`
		- Unicode strings: `string name = "some text";`
		- user defined types in the form of `class ClassName {...}`
	- Interface types
		- user defined `interface IName {...}`
	- Array types
		- Single-dimensional, multi-dimensional, and jagged. For example: `int[]`, `int[,]`, and `int[][]`
	- Delegate types
		- user defined `delegate int Name(...)`


## .NET

### What is .NET?

- NET is a free, cross-platform, open source developer platform for building many different types of applications.

![image](https://user-images.githubusercontent.com/20805058/228349772-6d96c2fd-349c-4d0b-8a2f-513014a4146e.png)

- With .NET, you can use multiple languages, editors, and libraries to build for web, mobile, desktop, games, IoT, and more.

### What is .NET Framework?

- .NET Framework is the original .NET implementation. It supports running websites, services, desktop apps, and more on Windows. Microsoft released .NET Framework in the early 1990s.

- The .NET Framework was the initial flavor of .NET. It provides the developer with a set of APIs for the most common programming needs and interacts with the underlying operating system. It runs only on Windows, and its lifecycle is coming to an the end right now, after the release of .NET 5.

### Mono

- The Mono project brings .NET to Linux machines. It is the best known porting project based on the .NET standard specifications. Even if Mono's aim is to run on Linux applications built for the .NET Framework and vice versa, the compatibility is not always guaranteed. There are a couple of reasons for this: some .NET Framework features are too tied to the Windows operating system, and often the Mono implementation lags behind the newest .NET Framework features.

### What is .NET Core

- Microsoft launched .NET Core in late 2014 to enable cross-platform support for .NET developers. The company released the newest version of the .NET Core, .NET 5.0, in November 2020 and renamed it .NET. The term .NET in this article refers to .NET 5.0. .NET Core is open-source on GitHub.

- .NET Core is a complete rewriting of the .NET Framework with the cross-platform goal in mind. Its redesigned architecture defines a minimal feature set as the common core across Windows, Linux, and Mac platforms. The rest of the features can be downloaded as library packages.

### What is .NET Standard

- .NET Standard is a formal specification of different functions (called APIs). Different .NET implementations can reuse the same code and libraries. Each implementation uses both .NET standard APIs and unique APIs specific to the operating systems it runs on.

- The .NET Standard is not another .NET implementation. It is a formal specification of .NET APIs that helps to create cross-platform libraries. If a platform supports a given .NET Standard version, then a library supporting the same version will run on it, regardless of the device type and the framework implementation (.NET Framework, Mono, .NET Core).

### .NET

- Since the beginning, the .NET term has been used to indicate the universal development platform. However, many implementations arose since then, so the .NET name created ambiguities. .NET 5 aims to make concrete the initial vision of a universal development platform. It replaces the current existing implementations: .NET Framework, .NET Core, and even Mono. So, from .NET 5 on, only .NET will exist as a name and as a platform.

### What is the .NET runtime

The .NET runtime, also called Common Language Runtime (CLR), compiles and executes .NET programs on different operating systems.

#### Just-in-time compilation

The CLR compiles code as the developer writes it. During compilation, CLR translates the code into Common Intermediate Language (CIL). For example, code written in C# has English-like syntax and words. .NET compiles or translates this code into CIL. CIL code looks different because it is a lower-level machine code language.

#### Execution

.NET runtime manages the execution of CIL code. CIL is cross-platform compatible, and any operating system can process it. Cross-platform compatibility refers to an application’s ability to run on multiple different operating systems with minimal modifications. For example, an application in C# can run on Windows, Linux, or macOS without any code modifications. Such an application is called a cross-platform application.

### What are .NET application model frameworks?

The application model frameworks are a collection of developer tools and libraries that support fast and efficient .NET project development. Different frameworks exist for different types of applications, such as those listed below.

#### Web applications

The ASP.NET framework extends the .NET developer platform specifically for building web-based applications. It supports web technologies such as REST APIS, HTML, CSS, and JavaScript. It provides a built-in user database with multi-factor and external authentication. ASP.NET supports industry-standard authentication protocols with a built-in security mechanism to protect your .NET apps from cyberattacks.

#### Mobile applications

You can use Xamarin/Mono to run .NET apps on all the major mobile operating systems, including iOS and Android. Xamarin includes Xamarin.Forms, an open-source mobile user interface framework. .NET developers use Xamarin.forms to create a consistent user experience across mobile platforms. All .NET apps can look the same, even on different mobile devices.

#### Desktop applications

You can use Xamarin for desktop application development. Additionally, Universal Windows Platform extends .NET Windows 10 application development. Windows Presentation Foundation and Windows Forms are other frameworks for user interface design on Windows.

#### Other applications

With ML.NET, you can develop and integrate custom machine learning models into your .NET applications. You can use .NET IoT Libraries to develop applications on sensors and other smart devices. For any solutions not available in the frameworks, you can find many specific function libraries on the public NuGet repository. You can use Nuget to create, share, and use many .NET libraries for almost any purpose.

## .NET Application Models 

Above the core components, you have the different application model frameworks, that is, the libraries that offer support for developing different types of applications. So, for example, you have

- ASP.NET: The framework that allows you to build web applications and web APIs.

- Windows Presentation Foundation (WPF): A graphical user interface for Windows desktop applications.

- Xamarin: The framework for building cross-platform mobile, TV, and desktop applications.

- Blazor: The framework to build client web applications by using C#. It also allows you to generate client web apps in WebAssembly code.

- ML.NET: The machine learning framework that simplifies the integration of machine learning models in your .NET application.

## Access Modifiers

- **public**: The type or member can be accessed by any other code in the same assembly or another assembly that references it. The accessibility level of public members of a type is controlled by the accessibility level of the type itself.
- **private**: The type or member can be accessed only by code in the same class or struct.
- **protected**: The type or member can be accessed only by code in the same class, or in a class that is derived from that class.
- **internal**: The type or member can be accessed by any code in the same assembly, but not from another assembly. In other words, internal types or members can be accessed from code that is part of the same compilation.
- **protected internal**: The type or member can be accessed by any code in the assembly in which it's declared, or from within a derived class in another assembly.
- **private protected**: The type or member can be accessed by types derived from the class that are declared within its containing assembly.

## Collections
___

For many applications, you want to create and manage groups of related objects. There are two ways to group objects: by creating arrays of objects, and by creating collections of objects.

### Arrays

Arrays are most useful for creating and working with a fixed number of strongly typed objects. For information about arrays, see [Arrays](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/).

```C#
// Declare a single-dimensional array of 5 integers.
int[] array1 = new int[5];

// Declare and set array element values.
int[] array2 = new int[] { 1, 3, 5, 7, 9 };

// Alternative syntax.
int[] array3 = { 1, 2, 3, 4, 5, 6 };

// Declare a two dimensional array.
int[,] multiDimensionalArray1 = new int[2, 3];

// Declare and set array element values.
int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

// Declare a jagged array.
int[][] jaggedArray = new int[6][];

// Set the values of the first array in the jagged array structure.
jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
```



### Collections

Collections provide a more flexible way to work with groups of objects. Unlike arrays, the group of objects you work with can grow and shrink dynamically as the needs of the application change. For some collections, you can assign a key to any object that you put into the collection so that you can quickly retrieve the object by using the key.

A collection is a class, so you must declare an instance of the class before you can add elements to that collection.

If your collection contains elements of only one data type, you can use one of the classes in the System.Collections.Generic namespace. A generic collection enforces type safety so that no other data type can be added to it. When you retrieve an element from a generic collection, you do not have to determine its data type or convert it.

Common Collection Types


- [System.Collections.Generic classes](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic?view=net-7.0)
- [System.Collections.Concurrent classes](https://learn.microsoft.com/en-us/dotnet/api/system.collections.concurrent?view=net-7.0)
- [System.Collections classes](https://learn.microsoft.com/en-us/dotnet/api/system.collections?view=net-7.0)


The following example creates a list of strings and then iterates through the strings by using a foreach statement.

```C#
// Create a list of strings.
var salmons = new List<string>();
salmons.Add("chinook");
salmons.Add("coho");
salmons.Add("pink");
salmons.Add("sockeye");

// or setup in the initializer
var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

// Remove an element from the list by specifying
// the object.
salmons.Remove("coho");

// Iterate through the list.
foreach (var salmon in salmons)
{
    Console.Write(salmon + " ");
}
// Output: chinook pink sockeye

```



## What is Object Orientation ?
___

C# is an object-oriented programming language. The four basic principles of object-oriented programming are:

  - **Abstraction** Modeling the relevant attributes and interactions of entities as classes to define an abstract representation of a system.
  - **Encapsulation** Hiding the internal state and functionality of an object and only allowing access through a public set of functions.
  - **Inheritance** Ability to create new abstractions based on existing abstractions.
  - **Polymorphism** Ability to implement inherited properties or methods in different ways across multiple abstractions.


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

### Inheritance
---

**Concept**

Used primarily for code re-use (the derived classes inherits the members of the base class)

- The *Is-a* Rule

	A [Sub class / Derived] *is a* [Base class / Super class]
	Example: A Cat is an Animal

```C#
class Cat : Animal { }
```

- Is **NOT** code-sharing

- Needs to share common logic

- Sharing just props or method signatures is not enough

- Inheritance can put you in a corner

	- example in : OODEMO, there we have a `RentalBoat` and a `RentalCar` that inherit from `RentalVehicle`.
	but we get stuck with how things are designed and may not need all parts. A Sailboat does not have an engine so we 
	had to override the start and stop engine to throw an error. Which could create institutional knowledge
	to know never to call those from a sailboat. Which could be the same fo from class that sends data to a DB. Where 
	one person may know not to call certains methods but not another person.

- need to ask the question what is the point of doing inheritance when implementing it

a. The Object class

	At the "top" of the inheritance chain is a class called object.

	Example: We have many methods without creating them. like *.ToString() .GetType()*

b. Single vs. Mulitple Inheritance

	- Languages such as C# and Java support single inheritance

		A class can have *only one* direct base class

	- Languages such as C++ allows for multiple inheritance

		A class can have *multiple* direct base classes


### Abstraction
---

**Concept** 

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

**Concept**

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

### Lambdas
---

You use a lambda expression to create an anonymous function. Use the lambda declaration operator => to separate the lambda's parameter list from its body. A lambda expression can be of any of the following two forms...

1. Expression Lambdas: `(input-parameters) => expression`

2. Statement Lambdas: `(input-parameters) => { <sequence-of-statements> }`

examples:

Any lambda expression can be converted to a delegate type. The delegate type to which a lambda expression can be converted is defined by the types of its parameters and return value. If a lambda expression doesn't return a value, it can be converted to one of the Action delegate types; otherwise, it can be converted to one of the Func delegate types. For example, a lambda expression that has two parameters and returns no value can be converted to an Action<T1,T2> delegate. A lambda expression that has one parameter and returns a value can be converted to a Func<T,TResult> delegate. In the following example, the lambda expression x => x * x, which specifies a parameter that's named x and returns the value of x squared, is assigned to a variable of a delegate type:

```C#
Func<int, int> square = x => x * x;
Console.WriteLine(square(5));
// Output:
// 25
```

Expression lambdas can also be converted to the expression tree types, as the following example shows:
```C#
System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
Console.WriteLine(e);
// Output:
// x => (x * x)
```

You can use lambda expressions in any code that requires instances of delegate types or expression trees, for example as an argument to the Task.Run(Action) method to pass the code that should be executed in the background. You can also use lambda expressions when you write LINQ in C#, as the following example shows:
```C#
int[] numbers = { 2, 3, 4, 5 };
var squaredNumbers = numbers.Select(x => x * x);
Console.WriteLine(string.Join(" ", squaredNumbers));
// Output:
// 4 9 16 25

```

The body of a statement lambda can consist of any number of statements; however, in practice there are typically no more than two or three.
```C#
Action<string> greet = name =>
{
    string greeting = $"Hello {name}!";
    Console.WriteLine(greeting);
};
greet("World");
// Output:
// Hello World!
```

### Extension Methods
---

Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type. Extension methods are static methods, but they're called as if they were instance methods on the extended type. For client code written in C#, F# and Visual Basic, there's no apparent difference between calling an extension method and the methods defined in a type.

example:

```C#
public static int WordCount(this string str)
{
    return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
}
```

calling it
```C#
string s = "Hello Extension Methods";
int i = s.WordCount();
```

another example of creating a greater than extension method:

```C#
public static class IntExtensions
{
	public static bool IsGreaterThan(this int i, int value)
	{
	    return i > value;
	}
}
```

```C#
static void Main(string[] args)
{
	int i = 10;

	bool result = i.IsGreaterThan(100); 

	Console.WriteLine(result);
}
```

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

additional example of boxing and unboxing:

```C#
int i = 123;
object o = i;    // Boxing
int j = (int)o;  // Unboxing
```

> Usually useful if we are using some code out of our control where we can work around the limitations

- Nullable Value Types
	- A generic type that allows for nullable value types.. 
	( Nullable<int>, int?)

- Nullable Reference Types
	- an opt-in feature starting in *C# 8*
	- Per file using **#nullable enable**
	- Per project using **<Nullable>enable</Nullable>**

## Reflection

Attributes provide a powerful method of associating metadata, or declarative information, with code (assemblies, types, methods, properties, and so forth). After an attribute is associated with a program entity, the attribute can be queried at run time by using a technique called reflection.

example: getting the type of a variable

```C#
// Using GetType to obtain type information:
int i = 42;
Type type = i.GetType();
Console.WriteLine(type);
```
	
```C#
// Using Reflection to get information of an Assembly:
Assembly info = typeof(int).Assembly;
Console.WriteLine(info);
```

- [back to top](#oops)
