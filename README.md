## Singleton Pattern:
In certain situations, such as managing a database connection, logging, or configuration settings, we want to ensure that only one instance of a class is created throughout the application's lifecycle. If multiple instances were created, it could lead to issues like:

Inconsistent state: If multiple instances represent the same concept, they may hold different data.

Resource conflicts: If multiple instances of a resource-heavy class are created, it can lead to performance degradation

## Builder Design Pattern: 
When an object requires many parameters, especially optional ones, the constructor can become hard to use or maintain. This issue can lead to:
- Long constructor parameter list.
- Difficulty in understanding which values are optional or required.
- Lack of flexiblity when it comes to setting only some values.

Solution : Separates the construction of an object from its representation, offering a fluent interface for creating complex objects. 

## Abstract factory pattern
Provides an interface for creating families of related objects without specifying their concrete classes.

Using the abstract factory pattern, we create interfaces for each product (Engine, HeadLight) and provide a family of concrete implementations for each Car(e.g., NissanEngine, ToyotaEngine, etc.). 
#### The abstract factory provides a way to create a suite of related objects without knowing the exace type of objects that will be created. 


