using System;
using RefactoreProductIncapApp.Model;
class program
{
    public static void Main()
    {
        Product rice;
        rice = new Product();
        rice.SetId(1001);
        rice.SetName("Rice");
        rice.SetPrice(85);
        rice.SetDiscountPercentage(20);
        Console.WriteLine("Id is {0}\nProduct name is {1}\nThe price is: {2}.Kg\n Discount Percentage is: {3}%\nAfter Discount Price is: {4}", rice.GetId(),rice.GetName(),rice.GetPrice(),rice.GetDiscountPercentage(),rice.DiscountCalculate());
        Console.WriteLine();
        Product sugar;
        sugar = new Product();
        sugar.SetId(1002);
        sugar.SetName("Sugar");
        sugar.SetPrice(40);
        sugar.SetDiscountPercentage(101);
        Console.WriteLine("Id is {0}\nProduct name is {1}\nThe price is: {2}\n Discount Percentage is: {3}%\nAfter Discount Price is: {4}", sugar.GetId(), sugar.GetName(), sugar.GetPrice(), sugar.GetDiscountPercentage(), sugar.DiscountCalculate());

    }


}