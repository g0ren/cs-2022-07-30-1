using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Введите сумму займа");
    Int32 x=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите процент");
    Double p=Convert.ToDouble(Console.ReadLine())/100+1;
    Console.WriteLine("Введите максимальную сумму");
    Int32 y=Convert.ToInt32(Console.ReadLine());
    Int32 count=0;
    while(x<y){
      x=Convert.ToInt32(x*p);
      ++count;
    }
    Console.WriteLine("Сумма займа превысит максимальную через {0} дней",count);
  }
}