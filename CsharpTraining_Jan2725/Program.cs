// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics.Metrics;
using System.Text;
using CsharpTraining_Jan2725;

// STRING BUILDER PROGRAMS

//StringBuilder sb1 = new StringBuilder("Welcome to C# ");
//sb1.Append("it is amazing ");
//sb1 = sb1.AppendLine("Good for practice");
//string st = sb1.ToString();
//Console.WriteLine(sb1.ToString());
//Console.WriteLine(st);

//string str = "Hello harry";
//str = "good afternoon";
//Console.WriteLine(str);

//int a = 100;
//object obj = a;

//int b = (int)obj;
//Console.WriteLine(obj);
//Console.WriteLine(b);

//_____________________________________________________________________
// JackedArray.cs

//JackedArray obj = new JackedArray();
//int[][] array = new int[][]
//{
//    new int[] { 3, 5, 7, },
//    new int[] { 1, 0, 2, 4, 6 },
//    new int[] { 1, 6 },
//    new int[] { 1, 0, 2, 4, 6, 45, 67, 78 }
//};
//obj.jackedArray(array);
//_____________________________________________________________________

// Seprate even and odd elements 

//CsharpTraining_Jan2725.Array obj = new CsharpTraining_Jan2725.Array();
//Console.WriteLine("Enter the size of the array");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[size];

//Console.WriteLine("Enter the array elements");

//for(int i = 0; i < array.Length; i++)
//{
//    array[i] = Convert.ToInt32(Console.ReadLine());

//}
//obj.array(array);

//_______________________________________________________________________

//Console.WriteLine("Enter the size of the arrray");
//int size = Convert.ToInt32(Console.ReadLine());

//// Declaring and allocating memory to the array 

//int[] array = new int[size];

//Console.WriteLine("Enter the array elements");
//for(int i = 0; i < array.Length; i++)
//{
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}
//MoveZero.moveZero(array);

//_________________________________________________________________________

//Exp obj = new Exp();
//obj.id = 27;
//obj.name = "Dudu";
//Console.WriteLine("Program Start");
////Console.WriteLine(obj);
//Console.WriteLine(obj.id);
//Console.WriteLine(obj.name);
//Console.WriteLine("Program End");

//_________________________________________________________________________

//Console.WriteLine("Program Started");
//TwodArrays obj = new TwodArrays();
////int[,] array = new int[,] { { 2, 3, 4 }, { 6, 4, 2 }, { 9, 2, 7 }, { 1, 10, 15 } };
//Console.WriteLine("Enter the row memory allocation");
//int size1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the  coloumn memory allocation");
//int size2 = Convert.ToInt32(Console.ReadLine());
//int[,] array = new int[size1,size2];
//obj.TwodArray(array);
//Console.WriteLine("Program Ended");

//__________________________________________________________________________

//Console.WriteLine("Program started");
//MissingNumber obj = new MissingNumber();
//Console.WriteLine("Enter the size of the array");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] array  = new int[size];
//Console.WriteLine("Enter the array elements");
//for(int i = 0; i < array.Length; i++)
//{
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}
//obj.missingNummber(array);
//Console.WriteLine("Program Ended");

//____________________________________________________________________________

//Animal obj = new Dog();
//Console.WriteLine("Enter the name of the dog");
//obj.Name = Console.ReadLine(); // Fixed typo in "Shephard"
//Console.WriteLine(obj.Name);
//obj.eat();

//____________________________________________________________________________

//Console.WriteLine("Program Started");
//StaticClassConstructor obj = new StaticClassConstructor(56);
//Console.WriteLine(obj.y);
//obj.name = "yamal";
//Console.WriteLine(obj.name);
//Console.WriteLine("Program ended");

//____________________________________________________________________________

//Console.WriteLine("Enter the name");
//string name = Console.ReadLine();   
//Constructor obj = new Constructor(name);
//Console.WriteLine("My name is " + obj.name);

//_____________________________________________________________________________

//Person obj1 = new Person();
//obj1.Greet();
//Student obj2 = new Student();
//obj2.Greet();
//obj2.showAge(23);
//Teacher obj3 = new Teacher();
//obj3.setAge(30);
//obj3.Greet();
//obj3.Explain();

//_____________________________________________________________________________

//PhotoBook obj  = new PhotoBook();
//Console.WriteLine("Enter the number of the pages that you want in the album");
//int pages = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"The total number of pages in photo book {obj.GetNumberPages(pages)}");

//BigPhotoBook obj3 = new BigPhotoBook(24);

//____________________________________________________________________________

//Concatenate obj = new Concatenate();
//Console.WriteLine("Enter the size of the array");
//int size = Convert.ToInt32(Console.ReadLine());
//string[] array = new string[size];
//Console.WriteLine("Enter the string elements inside the array");
//for(int i = 0; i < array.Length; i++)
//{
//    array[i] = Console.ReadLine();
//}
//obj.concatenateArray(array);

//_____________________________________________________________________________

//Max obj = new Max();
//Console.WriteLine("Enter the size of the array");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[size];

//Console.WriteLine("Enter the array elements");
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine(obj.maxElement(array));

//______________________________________________________________________________

//MissingNumber obj = new MissingNumber();
//Console.WriteLine("Enter the size of the array");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[size];
//Console.WriteLine("Enter the array elements");
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine(obj.missingNumber(array));

//______________________________________________________________________________

//Console.WriteLine("Enter the size of the array");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[size];
//Console.WriteLine("Enter the array elements");
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}
//MoveZero.moveZero(array); 

//__________________________________________________________________________________

//Console.WriteLine("Enter the size of theh array");
//int size1 = Convert.ToInt32(Console.ReadLine());
//int size2 = Convert.ToInt32(Console.ReadLine());

//int[] array1 = new int[size1];
//int [] array2 = new int[size2];

//Console.WriteLine("Enter the first array elements");
//for(int i =0; i < array1.Length; i++)
//{
//    array1[i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("Enter the second array elements");

//for(int i = 0; i < array2.Length; i++)
//{
//    array2[i] = Convert.ToInt32(Console.ReadLine());
//}
//IntersectiomArray obj = new IntersectiomArray();
//Console.WriteLine(obj.Intersection(array1, array2));

//___________________________________________________________________________________

//Console.WriteLine("Enter the size1 of the array");
//int size1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the size2 of the array");
//int size2 = Convert.ToInt32(Console.ReadLine());

//int[] array1 = new int[size1];
//int[] array2 = new int[size2];

//Console.WriteLine("Enter the first array elemensts");
//for(int i = 0; i < array1.Length; i++)
//{
//    array1[i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("Enter the second array elements");
//for(int i = 0; i < array2.Length; i++)
//{
//    array2[i] = Convert.ToInt32(Console.ReadLine());
//}
//IntersectiomArray obj = new IntersectiomArray();
//obj.Intersection(array1, array2);

//____________________________________________________________________________________

//Console.WriteLine("Enter the size of the array");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[size];

//Console.WriteLine("Enter the array elements");
//for(int i = 0; i < array.Length; i++)
//{
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}
//ThirdMaximum obj = new ThirdMaximum();
//Console.WriteLine($"Third max elements in the array is: {obj.ThirdMax(array)}");

//Console.WriteLine("Program ended");

//______________________________________________________________________________________

//int[] array = {4,3,2,7,8,2,3,1};
//DisappearArray obj = new DisappearArray();
//obj.DisappearArra(array);

//______________________________________________________________________________________

//List<int> list = new List<int>();
//Console.WriteLine("Enter the total number that you want to insert in the list");
//int size = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the number that you want to insert in the list");
//for (int i = 0; i < size; i++)
//{
//    int num = Convert.ToInt32(Console.ReadLine());
//    list.Add(num);
//}
//Console.WriteLine("The entered user numbers in the list");
//for (int i = 0; i < size; i++)
//{
//    Console.WriteLine(list[i]);
//}

//______________________________________________________________________________________

//Console.WriteLine("Enter the size of the array");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[size];

//Console.WriteLine("Enter the array element");
//for(int i = 0; i < array.Length; i++)
//{
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}
//SecondMax obj = new SecondMax();
//Console.WriteLine($"Second Maximum elements is {obj.SecMax(array)}");
//Console.WriteLine("Program ended");

//_______________________________________________________________________________________

//Console.WriteLine("Program Started");

//DelegatesDemo obj = new DelegatesDemo();
//GetMethod del = new GetMethod(obj.Method1);
////del += new GetMethod(obj.Method2);
//del += new GetMethod(obj.Method3);
//del += new GetMethod(obj.Method4);
//del += new GetMethod(obj.Method5);

//Console.WriteLine("Calling all the methods in the class at a time");

//del();

//Console.WriteLine("Program ended");

//________________________________________________________________________________________

//Console.WriteLine("Program started");

//MyStruct myStruct = new MyStruct(100);
//myStruct.Method1();
//myStruct.x = 200;
//myStruct.Method1();

//MyStruct myStruct1;
//myStruct1.x = 500;

//myStruct1.Method1();
//Console.WriteLine("Program ended");

//__________________________________________________________________________________________

//Console.WriteLine("Enter the size of the array");
//int size = Convert.ToInt32(Console.ReadLine());

//int[] array = new int[size];

//Console.WriteLine("Enter the elements of the array");
//for(int i = 0; i < array.Length; i++)
//{
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("Enter the target number");
//int target = Convert.ToInt32(Console.ReadLine());
//IndexesOfSubArray.SubArray(array, target); 

//__________________________________________________________________________________________

//Console.WriteLine("Program Started");
//Console.WriteLine("Enter the size of the array");
//int size = Convert.ToInt32(Console.ReadLine());

//int[] array = new int[size];

//Console.WriteLine("Enter the array elements");

//for(int i = 0; i < array.Length; i++)
//{
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}
//MissingNumbers.MissingNumber(array);
//Console.WriteLine("Program ended");

//___________________________________________________________________________________________

//Console.WriteLine("Enter the size of the array");
//int size = Convert.ToInt32(Console.ReadLine());

//int[] array = new int[size];

//Console.WriteLine("Enter the array elements");

//for(int i = 0; i < array.Length; i++)
//{
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}
//Kdanes.Kdane(array);

//____________________________________________________________________________________________

//Console.WriteLine("Program started");
//Console.WriteLine("Enter the size of the array");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[size];

//Console.WriteLine("Enter the array elements");
//for(int i = 0; i < array.Length; i++)
//{
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}
//ArrayLeaders.ArrayLead(array);
//Console.WriteLine("Program Ended");

//____________________________________________________________________________________________

//Console.WriteLine("Program started");
//Console.WriteLine("Enter the size of the array");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[size];

//Console.WriteLine("Enter the array elements");
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}
//ArrayLeaders.Max(array);
//Console.WriteLine("Program Ended");

//____________________________________________________________________________________________

//Console.WriteLine("Program Started");
//Console.WriteLine("Enter the size of the array");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[size];

//Console.WriteLine("Enter the array elements");
//for(int i = 0; i < array.Length; i++)
//{
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}
//ArrayGreaterOrEqual.GreaterOrEqual(array);
//Console.WriteLine("Program Ended");

//_____________________________________________________________________________________________

// Console.WriteLine("Program Started");
// Console.WriteLine("Enetr the size of the array");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];

// Console.WriteLine("enter the array elemnts");
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// CountLeaders.CountLead(array);
// Console.WriteLine("Program eneded");