// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// string filename = @"C:\Users\yifen\Desktop\alextest\a.txt";
// File.WriteAllText(filename, "hello");
// string s = File.ReadAllText(filename);
// System.Console.WriteLine(s);

// string filename = @"C:\Users\yifen\Desktop\alextest\a.txt";
// await File.WriteAllTextAsync(filename, "hello world");
// string a = await File.ReadAllTextAsync(filename);
// System.Console.WriteLine(a);
using System.Text;

// DownloadHtml();

// await ChangeThread();
// System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

// await CalcAsyncV2(10);

// System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

// string a = await ReadAllTextAsync(0);

// string b = await ReadAllTextAsyncV2(0);

// System.Console.WriteLine(a);

// System.Console.WriteLine("finished");

// await DownloadHtmlAsync("https://www.google.com", @"C:\Users\yifen\Desktop\alextest\a.txt");

// System.Console.WriteLine("finished");

// ThreadPool.QueueUserWorkItem(async (obj) =>{
//     while(true){
//         await File.WriteAllTextAsync(@"C:\Users\yifen\Desktop\alextest\a.txt", "hello world");
//     }
// });

//demo for cancellation token
// CancellationTokenSource tokenSource = new CancellationTokenSource();
// tokenSource.CancelAfter(1000);
// await DownloadAsync2("https://www.google.com", 10, tokenSource.Token);

//when all tasks
string[] files = Directory.GetFiles(@"C:\Users\yifen\Desktop\alextest");
Task<int>[] countsTask  = new Task<int>[files.Length];

for (int i = 0; i < files.Length; i++){
    string file = files[i];
    Task<int> t = ReadCharsCount(file);
    countsTask[i] = t;
}

int[] counts = await Task.WhenAll(countsTask);
int c = counts.Sum();



static async Task DownloadHtmlAsync(string url, string filename){
    using(HttpClient client = new HttpClient()){
        string htmlContent = await client.GetStringAsync(url);
        //string filename = @"C:\Users\yifen\Desktop\alextest\a.txt";
        await File.WriteAllTextAsync(filename, htmlContent);
    }
}

static void DownloadHtml(){
    File.WriteAllTextAsync(@"C:\Users\yifen\Desktop\alextest\a.txt", "aaa").Wait();
}

static async Task ChangeThread(){
    System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    StringBuilder sb = new StringBuilder();
    for (int i=0; i<10; i++){
        sb.Append("xxxxx");
    }
    await File.WriteAllTextAsync(@"C:\Users\yifen\Desktop\alextest\a.txt", sb.ToString());
    System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
}

static async Task<double> CalcAsync(int n){
    // System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    // double result = 0;
    // Random rand = new Random();

    // for (var i = 0; i < n*n; i++){
    //     result += rand.NextDouble();
    // }

    // return result;   
    return await Task.Run(() => {
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        double result = 0;
        Random rand = new Random();

        for (var i = 0; i < n*n; i++){
            result += rand.NextDouble();
        }
        //package double to Task
        return Task.FromResult(result);
    });
}


static Task<double> CalcAsyncV2(int n){

    return Task.Run(() => {
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        double result = 0;
        Random rand = new Random();

        for (var i = 0; i < n*n; i++){
            result += rand.NextDouble();
        }
        return result;
    });
}

static async Task<string> ReadAllTextAsync(int num){
    if(num == 0){
        return await File.ReadAllTextAsync(@"C:\Users\yifen\Desktop\alextest\a.txt");
    }else {
        return await File.ReadAllTextAsync(@"C:\Users\yifen\Desktop\alextest\a.txt");
    }
}

static Task<string> ReadAllTextAsyncV2(int num){
    if(num == 0){
        return File.ReadAllTextAsync(@"C:\Users\yifen\Desktop\alextest\a.txt");
    }else {
        return File.ReadAllTextAsync(@"C:\Users\yifen\Desktop\alextest\a.txt");
    }
}

//cancellationToken
static async Task DownloadAsync(string url, int n){
    for(var i = 0; i < n; i++){
        using(HttpClient client = new HttpClient()){
            string html = await client.GetStringAsync(url);
            System.Console.WriteLine($"{DateTime.Now.ToString()}");
        }
    }
}

static async Task DownloadAsync2(string url, int n, CancellationToken cancellationToken){
    for(var i = 0; i < n; i++){
        using(HttpClient client = new HttpClient()){
            string html = await client.GetStringAsync(url);
            System.Console.WriteLine($"{DateTime.Now.ToString()}");
            // if(cancellationToken.IsCancellationRequested){
            //     System.Console.WriteLine("request canneled");
            //     break;
            // }

            cancellationToken.ThrowIfCancellationRequested();
        }
    }
}

static async Task DownloadAsync3(string url, int n, CancellationToken cancellationToken){
    for(var i = 0; i < n; i++){
        using(HttpClient client = new HttpClient()){
            var resp = await client.GetAsync(url, cancellationToken);
            var html = await resp.Content.ReadAsStringAsync();
            System.Console.WriteLine($"{DateTime.Now.ToString()}");
            // if(cancellationToken.IsCancellationRequested){
            //     System.Console.WriteLine("request canneled");
            //     break;
            // }

            cancellationToken.ThrowIfCancellationRequested();
        }
    }
}

static async Task<int> ReadCharsCount(string fileName){
    string s = await File.ReadAllTextAsync(fileName);
    return s.Length;
}



