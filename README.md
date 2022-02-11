# .NET
A few .NET exercises using VisualCode for Digital Innovation One's "Object Orientation Programming with C#" course. Since VisualCode was used (instead of Visual Studio), the solution and projects were created manually (using console commands) at a 'lower level' than normally seen while navigating with Visual Studio for project and solution management. I separated each exercises by project, as listed below.

## Setup

- Installed .Net.
- `dotnet new sln --name DIO_DotNet`
- `dotnet new console`
- `dotnet sln add .\A_FirstProject\A_FirstProject.csproj` (and so on for following projects)
- `dotnet run` (for testing each project)

## VSCode Extensions Used 

- C#
- C# Extensions
- vscode-icons

## Projects

1. A_FirstProject: A simple object instanciation and method evocation excercise. The original model presented uses getters and setters, but I chose to use a constructor to populate object atributes instead. 
2. B_SecondProject: An encapsulation excercise for the creation of a rectangle with private attributes and a public method that returns it's area after checking if width and height have valid values. Again, favoured the constructor instead of getters and setters. 
3. C_ThirdProject: An inheritance exercise which sees the creation of a 'student' class and a 'teacher' class inheriting a few attributes from the 'person' class. Also applies the concept of polimorphism, with different "presentation" methods for each child of 'person'.
4. D_FourthProject: An abstract class exercise. An abstract 'account' was created with an abstract 'withdraw' method, and standard 'deposit' and 'show balance' methods. Two classes inherit from this class, each with it's own withdraw method, with different fees.
5. E_FifthProject: A 'File', 'Directory' and 'Path' exercise. Includes directory and file listing, creation, reading, writing, moving, deleting, etc. Including 'writeall' and stream methods.
6. F_SixthProject: A constructor exercise (creating a singleton class with a private constructor), with getters and setters.

### Note to Self: Study 'Path.Combine' before using paths in the future.