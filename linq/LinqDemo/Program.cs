// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// D1 d = F1;
// d();

// Func<int, int, int> func1 = F2;
// int sum = func1(1, 2);
// System.Console.WriteLine(sum);


// static void F1(){
//     System.Console.WriteLine("This is F1");
// }

// static int F2(int i, int j){
//     return i + j;
// }

// delegate void D1();

// delegate int D2(int i, int j);

Action f1 = delegate() {
    System.Console.WriteLine("this is f1"); 
};

Action f2 = ()=> System.Console.WriteLine("this is f1"); 

f1();

Func<int, int, int> f3 = delegate(int i, int j) {
    return i + j;
};

Func<int, int, int> f4 = (i, j) => i + j;

Func<int, bool> f66 = delegate(int i){
    return i > 0;
};

Func<int, bool> f67 = i => i > 0;

Func<int, bool> f68 = delegate(int i){
    return i > 5;
};






