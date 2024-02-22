/*
 가문 대대로 맛의 비밀이 은밀하게 전해 내려오는 장인 가문. 
장인은 가문의 소중한 비법이 유출될까봐 두려웠고 자신의 정보를 3개의 접근제한자로 정리해두리고 하였습니다. 

1. public  : 개나소나 접근 쌉가능
2. private : 나만 접근해야 하는 중요한 기밀 정보
3. protected :나말고 자식도 접근해도 되는 비법. 

그래서 도둑은 함부로 아버지의  기밀, 비법전수 정보에 접근할 수가 없습니다 
 
 */

//아버지
class Father
{
    public string OOT = "white shirt and jean";
    private string secret = "some secret";
    protected string transferSecret = " sharable secret to kids";
}


class Son : Father
{
    public void fnName()
    {
        String a = OOT;
        String b = transferSecret;
        //String c = secret cannot access ! 
    }
}
class Thief
{
   public void fnName()
    {
        //kidnap the father 
        Father father = new Father();
        /*
         Thief cannot access! to our secret!
        String a = father.secret
        String a = father.transferSecret*/
    }
}
class Street
{
    static void Main()
    {
        Father father = new Father();
        string Rival;
        Rival = father.OOT;

    }
}