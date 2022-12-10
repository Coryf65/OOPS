# OOPS

> C# is an object-oriented programming language. The four basic principles of object-oriented programming are:

    Abstraction Modeling the relevant attributes and interactions of entities as classes to define an abstract representation of a system.
    Encapsulation Hiding the internal state and functionality of an object and only allowing access through a public set of functions.
    Inheritance Ability to create new abstractions based on existing abstractions.
    Polymorphism Ability to implement inherited properties or methods in different ways across multiple abstractions.

Microsoft definition [link](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop)

## What is Object Orientation ?

1. Using classes as containers for related logic

	- any logic that pertains to a person resides in the person class

2. Encapsulating complexity behind a simple API (the members of a class)

	- using a car as an exmaple, When you are sitting in the car. You can see all the public API members. The gas pedal, brake pedal, steering wheel and so on. 
		If we were to open the hood of the car we can now see the complexity and hidden memebers that make up these controls. All you need to know is how to use the public simpler parts to drive car.

3. The instantiation of objects to represent seperate instances if a class

	- If we have many students we only need one class to represent a person.


## What is the point ?

- Productivity
	Complexity is typically hidden behind an easy-to-understand API

- Code reuse
	Through *inheritance*

- Maintainability
	Through *polymorphism*

## Classes vs Object

| Class  | Object |
| ------------- | ------------- |
| "Blueprint for a building"  | "Actual building" |
| Resides in disk as a .cs file  | Created by calling a construtor |
| Always one per type | As many as your program neeeds |

## Class Members

- Constructors
	Sets the *state* of the object (usually assigning values to props)

- Fields
	Contains the *data* of the object

- Properties
	Exposes the data of the object

- Methods
	Does something to the object
	The only place to do time-consuming operations

### Inheritance

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

### Polymorphism

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

4. Abstract Members