/*
 -- 되도 않는 스토리 텔링 -- 
엣날  많은 재산을 가진 할아버지가 살았습니다.
그러나 할아버지가 구조체로 선언이 되어 있었기에
아버지와 손자는 그재산을 사용할 수가 없었답니다.

 */

//구조체  vs 클래스
class ABC
{
    public int variable;
}

//1.할아버지 구조체 
//struct GrandFather
//{
//    public void GFproperty()
//    {
//        Console.WriteLine("GF property");
//    }
//}

class GrandFather
{
    public void GFproperty()
    {
        Console.WriteLine("GF property");
    }
}


//2.아버지 구조체 
//struct Father :GrandFather  struct cannot inherite 가 우선 안됨. 
//struct Father
//{
//    public void Fproperty()
//    {
//        Console.WriteLine("F property");
//    }
//}


class Father : GrandFather
{
    public void Fproperty()
    {
        Console.WriteLine("F property");
    }
}


//3.아들 구조체 
//struct Son
//{
//    public void Sproperty()
//    {
//        Console.WriteLine("S property");
//    }
//}
class Son : Father
{
    public void SProperty()
    {
        Console.WriteLine("S Property");
    }
}

class Program
{
    static void Main()
    {
        int a = 10; //값타입 변수: a 에 바로 10 이라는 값을 할당할수  있습니다 

        //ABC b.variable = 10; // 참고타입 :10을  assign 할수없는 이유는 아직 10이 들어갈 메모리가 할당되지 않았기 때문입니다.
        ABC b = new ABC(); //new 라는 키워드를 이용에서 메모리를 먼저 할당 해야합니다. 
        b.variable = 10; //10을 할당했습니다.


        //구조체 : 값타입 (int a= 10)

        //GrandFather OG;
        //OG.GFproperty();


        //Father papa;
        //papa.Fproperty();

        //Son mySon;
        //mySon.Sproperty();


        //클래스 

        GrandFather OG;
        OG = new GrandFather(); //new 키워드써서 메모리를 할당 
        Console.WriteLine("From Grand Father -------------------");
        OG.GFproperty();


        Father Papa;
        Papa = new Father(); //new 키워드써서 메모리를 할당 
        Console.WriteLine("From Father -------------------");
        Papa.GFproperty(); //할아버지 돈도 상속받음 ㄱㅇㄷ
        Papa.Fproperty();



        Son Me;
        Me = new Son(); //new 키워드써서 메모리를 할당 
        Console.WriteLine("From Son  -------------------");
        Me.GFproperty(); //할아버지 돈도 상속받음 ㄱㅇㄷ
        Me.Fproperty(); //아빠 돈도 받음 ㄱㅇㄷ 
        Me.SProperty();//내돈 



        Console.ReadKey();



    }
}