// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

// ServiceCollection services = new ServiceCollection();
// // services.AddTransient<TestService>();
// services.AddScoped<TestService>();

// using(ServiceProvider sp = services.BuildServiceProvider()){
//     // TestService testService = sp.GetService<TestService>();
//     // testService.Name = "Lily";
//     // testService.SayHi();

//     // TestService testService1 = sp.GetService<TestService>();
//     // System.Console.WriteLine(object.ReferenceEquals(testService, testService1));
//     // testService.Name = "Lily";
//     // testService.SayHi();

//     TestService t1;

//     using(IServiceScope scope1 = sp.CreateScope()){
        
//         TestService testService1 = scope1.ServiceProvider.GetService<TestService>();
//         TestService testService2 = scope1.ServiceProvider.GetService<TestService>();

//         t1 = testService1;

//         System.Console.WriteLine(object.ReferenceEquals(testService1, testService2)); 
//     };

//     using(IServiceScope scope2 = sp.CreateScope()){
        
//         TestService testService1 = scope2.ServiceProvider.GetService<TestService>();
//         TestService testService2 = scope2.ServiceProvider.GetService<TestService>();

//         System.Console.WriteLine(object.ReferenceEquals(testService1, testService2)); 
//         System.Console.WriteLine(object.ReferenceEquals(testService1, t1)); 
//     };

// }

ServiceCollection services = new ServiceCollection();
// services.AddScoped<ITestService, TestService>();
services.AddScoped(typeof(ITestService), typeof(TestService));
services.AddScoped(typeof(ITestService), typeof(TestService1));
// services.AddSingleton(typeof(ITestService), new TestService());

using(ServiceProvider sp = services.BuildServiceProvider()){
    // ITestService testService = sp.GetService<TestService>();
    // ITestService t1 = (ITestService)sp.GetService(typeof(ITestService));
    // ITestService t1 = (ITestService)sp.GetRequiredService(typeof(ITestService));
    // t1.Name = "TestService";
    // t1.SayHi();
    // System.Console.WriteLine(t1.GetType());

     IEnumerable<ITestService> tests = sp.GetServices<ITestService>();

     foreach (ITestService test in tests){
        System.Console.WriteLine(test.GetType());
     }

     System.Console.WriteLine(sp.GetService(typeof(ITestService)));
}


public interface ITestService {
    public string Name { get; set; }

    public void SayHi();
}

public class TestService : ITestService, IDisposable
{
    public string Name { get; set; }

    public void Dispose()
    {
        System.Console.WriteLine("Dispose");
    }

    public void SayHi()
    {
        System.Console.WriteLine("Hi" + Name);
    }
}

public class TestService1 : ITestService, IDisposable
{
    public string Name { get; set; }

    public void Dispose()
    {
        System.Console.WriteLine("Dispose");
    }

    public void SayHi()
    {
        System.Console.WriteLine("Hi" + Name);
    }
}
