int[] arr = { 7, 6, 3, 8, 5 };
double[] arr1 = { 5.2, 4.6, 7.4, 6.4, 8.4 };
string[] arr2 = { "Apple", "Peach", "Banana", "Oragne", "Guava" };
GenericsProgramBasic.Generics<int> maxInteger = new GenericsProgramBasic.Generics<int>(arr);
GenericsProgramBasic.Generics<double> maxDouble = new GenericsProgramBasic.Generics<double>(arr1);
GenericsProgramBasic.Generics<string> maxString = new GenericsProgramBasic.Generics<string>(arr2);
Console.WriteLine("Max Integer from array is: " + maxInteger.showMax());
Console.WriteLine("Max Double from array is: " + maxDouble.showMax());
Console.WriteLine("Max String from array is: " + maxString.showMax());