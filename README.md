# Uninitialized Property Access in C#

This repository demonstrates an uncommon C# bug involving accessing a class property before it has been initialized.  Uninitialized properties can lead to unpredictable results, especially in multithreaded environments or when interacting with external systems.

## Bug Description
The `bug.cs` file contains a class with a property that's accessed within a method before being assigned a value. This can result in unexpected behavior; the value may be 0, or might lead to an exception depending on the property's type and context.

## Solution
The `bugSolution.cs` file presents a solution by explicitly initializing the property in the class constructor or before its first usage.

## How to Reproduce
1. Clone this repository.
2. Open the `bug.cs` file. Note the `MyProperty` property is never initialized before it's accessed in `MyMethod`. 
3. Compile and run the code to observe the uninitialized behavior. 
4. Next, review `bugSolution.cs` to see how initialization fixes this potential issue.