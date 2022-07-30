

using FluentBuilder;
using FluentBuilder.Builder;

Product products = new Product();
User user = new User();


//Initialisation via Constructor
// Using Constructor
var shoppingCart = new ShoppingCart(Guid.NewGuid(), products, 2.0, user);


// Using Object Initializer
var shoppingCartInitializer = new ShoppingCart
{
    Id = Guid.NewGuid(),
    Items = new List<Product>(),
    Discount = 2.0,
    User = user
};


// Piecewise Object Creation
var shoppingCartPiecewise = new ShoppingCart();
shoppingCartPiecewise.Id = Guid.NewGuid();
shoppingCartPiecewise.Items = new List<Product>();
shoppingCartPiecewise.Discount = 2.0;
shoppingCartPiecewise.User = user;

// Using Builder

var shoppingCartBuilder = new ShoppingCartBuilder();
shoppingCartBuilder.AddId(Guid.NewGuid());
shoppingCartBuilder.AddItems(new List<Product>());
shoppingCartBuilder.AddDiscount(2.0);
shoppingCartBuilder.AddUser(user);
var shoppingCartBuilderObj = shoppingCartBuilder.GetShoppingCart();

// Using Fluent Builder
var shoppingCartFluentBuilder = new ShoppingCartFluentBuilder()
    .WithId(Guid.NewGuid())
    .WithItems(new List<Product>())
    .WithDiscount(2.0)
    .WithUser(user)
    .Build();



