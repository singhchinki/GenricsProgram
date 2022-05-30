GenericsProgramBasic.Generics<int> maxInteger = new GenericsProgramBasic.Generics<int>(4, 8, 7);
GenericsProgramBasic.Generics<double> maxDouble = new GenericsProgramBasic.Generics<double>(7.5, 8.2, 4.2);
GenericsProgramBasic.Generics<string> maxString = new GenericsProgramBasic.Generics<string>("Apple", "Peach", "Banana");
Console.WriteLine("Max Integer is: " + maxInteger.showMax());
Console.WriteLine("Max Double is: " + maxDouble.showMax());
Console.WriteLine("Max String is: " + maxString.showMax());