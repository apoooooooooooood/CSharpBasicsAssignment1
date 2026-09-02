1. The .csproj file contains the four required properties from Part A:
   - TargetFramework
   - ImplicitUsings
   - Nullable
   - OutputType

2. No, #region and #endregion do not change the compiled output.
   They are only used to organize and collapse sections of code in the IDE,
   making the code easier to navigate and read.

3. I would use /// XML documentation comments when I want to document
   public classes, methods, properties,...........
   They can be used by IDEs such as Visual Studio to show documentation.
   Plain // comments are better for normal implementation notes.

4. C# does not have true global variables because they can create
   uncontrolled shared state and make code harder to maintain and test.
   The closest equivalent is a static field or property inside a static
   class. It can be accessed without creating an object.