namespace FluentBuilder;

public class ShoppingCart
{
    public ShoppingCart(Guid newGuid, Product products, double discount, User user)
    {
        throw new NotImplementedException();
    }

    public ShoppingCart()
    {
        throw new NotImplementedException();
    }

    public Guid Id { get; set; }

    public List<Product> Items { get; set; }

    public double Discount { get; set; }

    public User User { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Items: {Items.Count}, Discount: {Discount}, User: {User.Email}";
    }
}

public class User
{
    public string Email { get; set; }
}

public class Product
{
}