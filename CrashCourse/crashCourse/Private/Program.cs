/*
 
 접근제한자 private -GET SET 과 속성 

접근제어란?
메모리는 보유한 객체를 이용해서 멤버에 점(.)찍고 접근할 수 있는지 없는지의  제어를 말한다 

예를 들면, 아래의 코드에 나와있는 [GirlFriend none]에는 '나이' 와 '무게' 라는 정보가 담겨 있는데, 
public 으로 선언된 'GF Age' 라는 정보는 'none.Age' 로 접근할 수 있지만, 
private로 선언된 'GF weight' 라는 정보는  none.weight로 접근할 수 없다. 
 
 */

class GirlFriend
{
    public int age = 25;
    private int weight = 60;
    public int property 
    {
        get { return weight; }
        set { weight = value; }
    }


    /*
    //set 함수 
    public void setWeight(int x)
    {
        weight = x;
    }



    public int getWeight()
    {
        return weight;
    }*/


}

class Program
{
    static void Main(string[] args)
    { 
        GirlFriend none = new GirlFriend();
        Console.WriteLine($"age : {none.age}");

        //none.setWeight(50);
        //int weight = none.getWeight();

        none.property = 100;    //auto set
        int a = none.property;  //auto get

        Console.WriteLine($"My girlfriend's weight is {a}kg");//100
        Console.ReadLine();
    }
}