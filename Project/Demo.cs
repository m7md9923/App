namespace Project;


class Demo
{
    /// <summary>
    /// this func can sum two integers
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns>the result= num1+num2</returns>
    static int Sum(int num1 , int num2)
    {
        return num1 + num2;
    }
    
    static void Main(string[] args)
    {
        #region sum
        int x  = 5 , y = 10; 
        int sum = Sum(x,y);
        Console.WriteLine("the sum = " + sum);
        #endregion
        
        #region Name Conversion
        // Pascal Case [c#]
        // Mohamed Nasr El-Din
        // camelCase [js]
        // mohamed Nasr El-Din
        // Kebab Case
        // Mohamed-Nasr-El-Din
        // Snack Case
        // Mohamed_Nasr_El-Din
        #endregion
        
        #region Variables declaration and naming convention

        //int studentAge = 20; //4 bytes in stack [value = 20]
        //Console.WriteLine(studentAge);

        //int _number; //invalid
        //int  number = 20; //valid
        //int @class = 200; // if u wanna use c# keyword
        //int @struct = 200;
        //Console.WriteLine(@class);

        //PascalCase => MyName [C# Code [Project name , Solution name]]
        //camelCase => myName [Variables]
        //snake_case => my_name
        //kebab-case => my-name

        #endregion

        Point P1;
        // allocate 4 bytes in stack
        P1 = new Point();
        // 1- allocate required bytes in heap [8-bytes]
        // 2- initialize each feild with the default val based on datatype
        // 3- call user defined constructor if exists
        // 4- assign reference to the object in the heap 
        
        Console.WriteLine(P1.x);
        Console.WriteLine(P1.y);
        Console.WriteLine();

        Point P2 = new Point() { x = 5, y = 10 };
        //Console.WriteLine(P2.x);
        //Console.WriteLine(P2.y);
        //Console.WriteLine();
        
        P1 = P2; //X = 5 , Y = 10
        Console.WriteLine(P1.x);
        Console.WriteLine(P1.y);
        Console.WriteLine(P2.x);
        Console.WriteLine(P2.y);
        
        int X; //CLR WILL ALLOCATE 4 UNINITIALIZED BYTES IN STACK
        // int --> C# KEYWORD
        X = 5;
        //Console.WriteLine(X);
        Int32 Y = 10;
        //Console.WriteLine(Y);
        Y = X;
        //Console.WriteLine(Y);
        X++;
        Console.WriteLine(X);
        Console.WriteLine(Y);

        #region Refernce type
        Point P11;
        //Clr will allocate 4 bytes in stack
        //Clr will allocate 0 bytes in heap
        //P1 refer to null [default value for refernce type]
        P11 = new Point();
        //New
        //Clr will allocate numeber of bytes needed for the object in the heap
        //Clr will intialize the data of the object with the default value of its datatype
        //Clr will call the user defined constructor [If exists]
        //Assign the refernce to the data in the heap
        Point P22 = new Point(); //Unreachable object
        P22 = P11;
        P22.x = 10;
        Console.WriteLine(P11.x);
        Console.WriteLine(P22.x);
        #endregion


    }
}