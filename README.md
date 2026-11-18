task 1

Shallow Copy changed because it only copies the memory reference (address) of the inner Address object rather than creating a new instance.
As a result, both the original and the shallow-copied customer objects point to the exact same Address in memory, 
so modifying the city in the original object directly affects the shallow copy.

Deep Copy did not change because it explicitly creates a completely new Address instance in memory with its own independent allocation.
This ensures that the copied customer has its own separate address object, 
meaning any changes made to the original customer's address will not affect the deep copy.

Why does C# not allow a class to inherit from two classes?

Answer: To avoid the "Diamond Problem" (ambiguity issues), which happens when two parent classes have methods with the same signature,
making it confusing for the child class to know which one to inherit. 

Why is explicit implementation needed here?

Answer: It is needed because the Duck implements multiple interfaces (IFlyable and ISwimmable) that share the exact same method signature (Move()). 
Explicit implementation allows us to separate them and provide distinct behavior for each interface without naming conflicts.

1. What is the difference between a record and a normal class? Why are records a good fit for data objects?
The difference: Records compare values automatically (Value Equality) and come with a built-in ToString(),
whereas normal classes compare memory references and require extra code to do the same.

Why they fit data: They cut down on boilerplate code and let us focus purely on holding data safely and cleanly.

Theory Questions 

20. What is the difference between a shallow copy and a deep copy?
Shallow Copy: Copies only the top-level references (so modifying nested objects will still affect the original).

Deep Copy: Completely duplicates everything , creating a 100% independent and separate copy in memory.

21. What is the difference between method overriding and method hiding?
Overriding (override): Resolves at runtime based on the actual object type (supporting polymorphism).

Hiding (new): Just hides the parent method based on the compile-time variable type.

22. When does the dynamic keyword resolve a method call?
It resolves at runtime rather than compile-time, bypassing static type checking until the program is actually running.

23. Can a C# class implement more than one interface? More than one class?
Multiple interfaces? Yes, a class can implement as many interfaces as it needs.

Multiple classes? No, C# does not support multiple class inheritance to avoid issues like the Diamond Problem.

24. Is a record a value type or a reference type by default?
It is a reference type by default (stored on the heap), but it gives you value-based equality out of the box.
