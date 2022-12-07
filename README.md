# OOPS

> C# is an object-oriented programming language. The four basic principles of object-oriented programming are:

    Abstraction Modeling the relevant attributes and interactions of entities as classes to define an abstract representation of a system.
    Encapsulation Hiding the internal state and functionality of an object and only allowing access through a public set of functions.
    Inheritance Ability to create new abstractions based on existing abstractions.
    Polymorphism Ability to implement inherited properties or methods in different ways across multiple abstractions.
    - Microsoft [link](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop)

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