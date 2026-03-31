using _09_UpcastingDowncastingExplicitImplicit.Exchange;
using _09_UpcastingDowncastingExplicitImplicit.Models;

class Program
{
    static void Main(string[] args)
    {
        #region Upcasting
        //Dog dog = new Dog { AvgLifeTime = 13, Breed = "Golden", Gender = "male", Name = "Hatikp" };
        //Eagle eagle = new Eagle { AvgLifeTime = 300, FlySpeed = 100, Gender = "female" };


        ////// Upcasting implict casting
        ////Animal animal = dog;
        ////Animal animal1 = eagle;

        ////// Downcasting efplict casting 
        ////Dog dog1 = (Dog)animal;
        ////Eagle eagle1 = (Eagle)animal;

        //Animal[] animals = { eagle, dog };

        //foreach (var animal in animals)
        //{
        //    //Eagle eagle1 = (Eagle)animal;
        //    Eagle eagle1 = animal as Eagle;
        //    //eagle1.Fly();

        //    //if(eagle1 != null )
        //    //{
        //    //    eagle1.Fly
        //    //}

        //    if (animal is Eagle)
        //    {
        //        Eagle eagle2 = (Eagle)animal;
        //    }

        //} 
        #endregion

        #region Boxing Unboxing
        //Boxing
        int a = 5;
        Object b = a;

        //Unboxing
        string c = b as string;

        Test test = new Test();

        ITest itest = test;
        #endregion

        Dollar dollar = new(200);

        Manat manat = new(170);

        Dollar dollar1 = manat;
        Console.WriteLine(dollar1.USD);

        Manat manat1 = dollar;
        Console.WriteLine(manat1.AZN);

    }

    
}
#region Boxing Unboxing
public struct Test : ITest
{
    public int X { get; set; }

    public void Y()
    {
        throw new NotImplementedException();
    }
}

public interface ITest
{
    void Y();
} 
#endregion









