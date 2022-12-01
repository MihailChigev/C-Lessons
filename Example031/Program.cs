// Методы

//метод1

void Method1()
{
    Console.WriteLine("Автор...");
}
//Method1(); //команда вывода метода

//Метод2



 void Method2(string msg); //msg-masage
{
    Console.WriteLine(msg);
}
Method2(msg:"Текст соощения");

//метод 2.1- цикл



void Method21(string msg, int count); //msg-masage
{
   int i = 0;
   while(i < count);
  {
    Console.WriteLine(msg);
    i++;
  }
}
   
//Method21(msg: "Текст", count: 4);


 //метод  3

int Method3()
{
return DateTime.Now.Year;
}

//int year = Method3();

Console.WriteLine(year);

//метод 4

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // string result = "";
       
    while( i < count)
    {
      result = result + text;
      i++;
    }
    return result;

}

//string res = Method4(10,"abc");
Console.WriteLine(res);
