using System;

//https://www.youtube.com/watch?v=Xgs0ZD8wglg&index=3&list=PLQKPLm6pluP-KGu2u0x1LgiBZ6IkoPfPh
class GenericCaller
{
    public GenericCaller()
    {


        //var resultInt = new ResultInt() {Success =true,Data=5 };
        //var resultStr = new ResultString() { Success = true, Data = "55" };

        //Console.WriteLine(resultInt.Success);
        //Console.WriteLine(resultInt.Data);


        var result1 = new Result<Int32,string> { Success = true, Data = 5, Data2 = "Hi" };
        var result2 = new Result<string,bool> { Success = true, Data = "55", Data2 = true };
    }
}
public class Result<T,U>
{
    public bool Success { get; set; }
    public T Data { get; set; }

    public U Data2 { get; set; }
}
public class ResultPrinter
{
    public void Print<T,U>(Result<T,U> result)
    {
        Console.WriteLine(result.Success);
    }
}
//public class ResultInt
//{
//    public bool Success { get; set; }
//    public int Data { get; set; }
//}

//public class ResultString
//{
//    public bool Success { get; set; }
//    public string Data { get; set; }
//}