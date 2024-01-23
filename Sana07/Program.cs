using Library;
ShoppingCart cart = new ShoppingCart();
try
{
    Product p1 = new Book("Book", 2, 3, "Murdery", "I", "Murder Mystory");
    Product p2 = new Charger("Lenovo charger", 1, 2, 171.5M, "Laptop Charger");
    Product p3 = new Screen("Samsung a17", 110.4M, 2, 1920, 1080);
    cart.AddProduct(p1);
    cart.AddProduct(p2);
    cart.AddProduct(p3);
} catch (NegativeNumberException) 
{
    Console.WriteLine("Negative number are not accessed");
} catch (EmptyStringException)
{
    Console.WriteLine("All String have to contain value(not empty)");
} catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine(cart.Display());
Console.WriteLine($"Total Sum: {cart.CalculateSum()}");
