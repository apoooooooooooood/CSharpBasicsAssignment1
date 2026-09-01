// csproj : هو ملف إعدادات الـproject.
// بيحدد نوع المشروع، ونسخة الـ.NET اللي المشروع بيستهدفها، 
// وكمان إعدادات زي OutputType و TargetFramework و ImplicitUsings و Nullable.

// Program.cs : ده ملف الكود الأساسي بتاع الـConsole Application.
// وبما إننا بنستخدم Top-Level Statements، مش محتاجين نكتب class Program أو Main.

// obj/ : ده فولدر بيحتوي على Intermediate/temporary build files
// اللي بيتم إنشاؤها أثناء عملية الـBuild.

// bin/ : ده فولدر بيحتوي على الـoutput files بعد ما أعمل Build للـproject بتاعي.
// زي الـ.exe والـ.dll.

// SLNX : المشروع بيستخدم الـnewer .slnx solution format.
// ومن مميزاته إنه أبسط في الـstructure وأسهل في القراءة والمراجعة مع Git.

//Console.WriteLine("=== PART A: Project & Structure ===");
//Console.WriteLine("CSharpBasicsAssignment is ready.");


namespace CSharpBasicsAssignment;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PART B: C# Basics ===");
            RunTypesDemo();


        }
        //part B:  Variables, Types & Casting 
        static void RunTypesDemo()
        {
            // Step 1: Basic Types
            Console.WriteLine("=== Step 1: Basic Types ===");

            int myInt = 42;
            long myLong = 9_000_000_000L;
            double myDouble = 3.14159;
            decimal myDecimal = 19.99m;
            bool myBool = true;
            char myChar = 'A';
            string myString = "Hello, C#";
            var myInferred = 100;

            Console.WriteLine($"int:    {myInt}     -> {myInt.GetType()}");
            Console.WriteLine($"long:   {myLong}    -> {myLong.GetType()}");
            Console.WriteLine($"double: {myDouble}  -> {myDouble.GetType()}");
            Console.WriteLine($"decimal:{myDecimal} -> {myDecimal.GetType()}");
            Console.WriteLine($"bool:   {myBool}    -> {myBool.GetType()}");
            Console.WriteLine($"char:   {myChar}    -> {myChar.GetType()}");
            Console.WriteLine($"string: {myString}  -> {myString.GetType()}");
            Console.WriteLine($"var:    {myInferred}-> {myInferred.GetType()}");

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("=== Step 2: Implicit Conversion ===");
            int smallNumber = 123;
            long bigNumber = smallNumber; // implicit int -> long
            Console.WriteLine($"int {smallNumber} implicitly converted to long: {bigNumber}");

            char letter = 'Z';
            int letterAsInt = letter; // implicit char -> int
            Console.WriteLine($"char '{letter}' implicitly converted to int: {letterAsInt}");

            // هنا عادي نفع ان احنا نحط ال int في long لان هما الاتنين اولا بيشيلو نفس النوع 
            //ثانيا ال int بيشيل لحد 4 bytes لكل ال long بيشيل لحد 8 bytes وده مش هيسبب مشكله

            //اما ان احنا نحط كاركتر في انتجر برضو عادي لان ال السي شارب داخليا 
            // بيحول الكاركتر لرقم حسب جدول الـASCII وده بيخليه يتحول لانتجر من غير مشاكل   


            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("=== Step 3: Explicit Conversion ===");

            double myDoubleValue = 9.78;
            int x = (int)myDoubleValue; // explicit double -> int
            int y = Convert.ToInt32(myDoubleValue);
            Console.WriteLine($"double {myDoubleValue} explicitly converted to int: {x}");
            Console.WriteLine($"double {myDoubleValue} explicitly converted to int using Convert.ToInt32: {y}");

            // truncates the decimal part and returns only the integer part of the number.
            //Rounding: Convert.ToInt32 rounds the number to the nearest integer.

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"=== Step 4: computing the values ===");
            Console.WriteLine(5 / 2);// integer division, result is 2
            Console.WriteLine((double)5 / 2);// explicit conversion to double, result is 2.5
            // in the first one, both operands are integers, so the result is also an integer (truncated)
            // in the second one, we explicitly convert 5 to double, so the result is a double (not truncated)

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"=== Step 5: Boxing and Unboxing ===");
            int n = 5;
            object obj = n; // Boxing: converting value type to reference type
            Console.WriteLine($"Boxing: int {n} boxed to object: {obj} ");
            int unboxed = (int)obj; // Unboxing: converting reference type to value type
            Console.WriteLine($"Unboxing : object {obj} unboxed to int: {unboxed} ");

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"=== Step 6: Parsing ===");
            string s = "123";
            int mm = int.Parse(s); // parsing string to int
            Console.WriteLine($"Parsing: string \"{s}\" parsed to int: {mm} ");
            string s2 = "abc";
            if (int.TryParse(s2, out int m))
            {
                Console.WriteLine($"Parsing: string \"{s2}\" parsed to int: {m} ");

            }
            else
            {
                Console.WriteLine($"Parsing: string \"{s2}\" could not be parsed to int.");

            }

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"=== Step 7: Float to Decimal Conversion ===");
            float f = 5.5f;

            // decimal d = f;   // Dont allow implicit conversion from float to decimal
            // float cannot be implicitly converted to decimal because
            // the conversion may result in a loss of precision, so an explicit cast is required.
            decimal d = (decimal)f;   // ✅ Explicit conversion
            Console.WriteLine($"Explicit conversion: float {f} explicitly converted to decimal: {d} ");
            
        }

    }
