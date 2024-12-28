# Uninitialized Property Access in C#

This repository demonstrates a subtle bug in C# related to accessing a class property before it has been explicitly assigned a value.  Uninitialized properties default to their type's default value (0 for integers, null for references, etc.), which might not always be obvious and could lead to unexpected behavior in your application.

The `bug.cs` file contains the code demonstrating the error. The `bugSolution.cs` shows the solution and the expected outcome.