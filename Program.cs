
using System;
//클래스의 시작
class Cat
{
    public string Name;

    public Cat() { 
        console.Writeline("생성자가 호출되었습니다.")''
    }
}


class MainClass {
    public static void Main(string[] args)
    {
        Cat myCat = new Cat();

        

    }
  
}



//클래스의 끝

/*
 변수
bool boolVariable = true;
int intVariablae = 10;
float floatVariable = 3.4f;
char charVariable = 'a';
Console.WriteLine(boolVariable);
Console.WriteLine(intVariablae);
Console.WriteLine(floatVariable);
Console.WriteLine(charVariable);

조건문
if(조건식){}
else if(조건식){}
else (조건식){}
        int num = 0;
        if (num > 0)
        {
            Console.WriteLine("양수");
        }
        else if (num < 0) {
            Console.WriteLine("음수");
        } else {
            Console.WriteLine("제로");
        }

//반복문 for(초기화;조건식;반복식){반복코드}
        for (int i = 1; i < 11; i++) {
            Console.WriteLine(i);

        } 
        //while(조건식){}
class Person
{
    //property(속성)
    public string Name;
    public string Birthday;
    public string Gender;

    public void Eat()
    {
        //먹는행위
        Console.WriteLine(Name + "이(가) 아침을 먹습니다");

    }
    public void Walk()
    {
        //걷는행위
        Console.WriteLine(Name + "이(가) 걷습니다");
    }
    public void Run()
    {
        //뛰는행위
        Console.WriteLine(Name + "이(가) 뜁니다");
    }
}

*/