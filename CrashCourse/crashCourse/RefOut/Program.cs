/*
Background Story:
Craig has drunk all of his dad's whisky, and now he's in big trouble! 
If Craig's dad finds out what Craig did, you know Craig will be in trouble. 
So Craig decided to fill the whisky bottle with beer, 
but because he passed (called) beer by value, 
the original whisky bottle is not being filled! (not being mutated)
 */


/*
Additional Note
C# has two methods for call by reference: ref and out.

Here's the difference:

ref: ref is used when passing an address from outside the function to inside the function. 
     It's a reference keyword used for passing addresses into functions.

out: out is used when an address needs to be returned from inside the function to outside the function. 
     It's a reference keyword used for passing addresses out of functions.

Additionally:

Both ref and out variables MUST BE initialized BEFORE being passed into the function.
Failure to initialize ref or out variables may result in passing garbage values into the function.
 
 
 */



class Swap
{
    public void SwapWithBeer( int whisky)
    {
        int beer = 1000;//cc
        whisky = beer;
    }
    public void SwapWithBeerByUsingRef(ref int whisky)
    {
        int beer = 1000;//cc
        whisky = beer;
    }
}


class BadCraig 
{
    public static void Main()
    {
        int leftOverWhisky = 0; //Craig just finished all the whisky!

        Swap action = new Swap();
        action.SwapWithBeer( leftOverWhisky);
        Console.WriteLine("Left Over Whisky :  " + leftOverWhisky);//0 Oh on! its not filling the whisky bottle why?
        /* 
          Passing by value : you are only sending the value, so the original value will never change. 
          Passing by reference: Allows a method to modify the original variable directly rather than a copy.
          
          Craig only sent the value not the reference. 
          use 'Ref' keyword
         */

        Swap usingRef = new Swap();
        usingRef.SwapWithBeerByUsingRef(ref leftOverWhisky);
        Console.WriteLine($"Now Left Over whisky is {leftOverWhisky}! " +
            $"\npassing by reference allows a method to modify the original variable directly!");



        //--------------- Additional Note 
        static void insideOfFn(ref int x)
        {
            x = 1000;
        }

        static void outsideOfFn(out int x)
        {
            //if this method is empty it will error. because of out
            x = -1000;
        }


        /*
          int x1; // no value is assigned AKA this is garbage.
          insideOfFn(ref x1); // as you see the red line under x1 it does not take garbage
        */

        int x1 = 0; //always set default value 
        insideOfFn(ref x1);
        Console.WriteLine("insideOfFn(ref x1) : {0}", x1);//1000

        outsideOfFn(out x1);
        Console.WriteLine("outsideOfFn(out x1) : {0}", x1);//-1000


        Console.ReadKey();

    }
}