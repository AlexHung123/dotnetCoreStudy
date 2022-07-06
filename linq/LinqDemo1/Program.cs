// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] nums = new int[]{3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};

IEnumerable<int> result = nums.Where(i => i > 10);

IEnumerable<int> result1 = MyWhere2(nums, i => i > 10);

foreach (int i in result1){
    System.Console.WriteLine(i);
}


static IEnumerable<int> MyWhere1(IEnumerable<int> items, Func<int, bool> f){
    List<int> result = new List<int>();
    foreach(int i in items){
        if(f(i)){
            result.Add(i);
        }
    }
    return result;
}

static IEnumerable<int> MyWhere2(IEnumerable<int> items, Func<int, bool> f){
    foreach(int i in items){
        if(f(i)){
            yield return i;
        }
    }
}
