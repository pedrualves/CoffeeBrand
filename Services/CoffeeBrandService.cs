namespace CoffeeBrand.Services;
public class CoffeeBrandService : ICoffeeBrandService
{
    public IEnumerable<CoffeeBrand> GetCoffeeBrands()
    {
        CoffeeBrand starbucks = new()
        {
            Id = 1,
            Name = "Starbucks",
            Origin = "Seattle, Washington, USA",
            RoastLevel = "Medium",
            Description = "Starbucks is one of the largest coffeehouse chains in the world, known for its wide range of coffee beverages and global presence."
        };

        CoffeeBrand lavazza = new()
        {
            Id = 2,
            Name = "Lavazza",
            Origin = "Turin, Italy",
            RoastLevel = "Dark",
            Description = "Lavazza is an Italian coffee brand, one of the most popular in the country, offering a variety of coffee blends and products."
        };

        CoffeeBrand peetsCoffee = new()
        {
            Id = 3,
            Name = "Peet's Coffee",
            Origin = "Berkeley, California, USA",
            RoastLevel = "FullCity",
            Description = "Peet's Coffee is a specialty coffee roaster and retailer, known for its commitment to high-quality, freshly roasted coffee."
        };

        List<CoffeeBrand> coffeeBrands = new()
        {
            starbucks,
            lavazza,
            peetsCoffee
        };

        return coffeeBrands;
    }

}