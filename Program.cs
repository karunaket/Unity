                                        /* Calculator.cs */

// using System;

// public class Calculator{


//     int a, b, result;

//     void add() 
//     {
//         result = a + b;
//         Console.WriteLine(result);
//     }
//     void sub() 
//     {
//         result = a - b;
//         Console.WriteLine(result);
//     }
//     void mul() 
//     {
//         result = a * b;
//         Console.WriteLine(result);
//     }
//     void div() 
//     {
//         result = a / b;
//         Console.WriteLine(result);
//     }

//     static void Main() 
//     {
//         Calculator object1 = new Calculator();
//         Calculator object2 = new Calculator();
//         Calculator object3 = new Calculator();
//         /* Here new Calculator makes new calculator in object named object1 and similarly object2 & object3*/

//         object1.a = 50;
//         object1.b = 25;

//         /* Here object1.a = 50 means value of a in object1( points to the class named Calculator ) is 50...Similarly it is for object1.b = 25*/

//         object1.add();

//         /* Here add() is a function which is in the class named Calculator and object1.add() is used to call the function in main function*/

//         object2.a = 50;
//         object2.b = 30;
//         object2.sub();


//         object1.sub();


//         object3.a = 70;
//         object3.b = 50;
//         object3.mul();
//     }
// }


                                        /* Cat.cs */

using System;
public class Cat{
    int size; 
    int speed; 

    void Sound()
    {
        Console.WriteLine("Meow");
    }


    static void Main() 
    {
        Cat cat1 = new Cat();
        Cat cat2 = new Cat();


        cat1.size = 3;
        cat1.speed = 10;

        cat2.size = 6;
        cat2.speed = 4;

        cat1.Sound();
        cat2.Sound();
    }
}