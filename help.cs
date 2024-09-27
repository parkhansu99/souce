using System;
using System.Reflection;

public class Example
{
    public void Method1() { }
    public void Method2() { }
}

public class Program
{
    public static void Main()
    {
        Type type = typeof(Example);
        MethodInfo[] methods = type.GetMethods();
        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);  // 메소드 이름 출력
        }
    }
}
