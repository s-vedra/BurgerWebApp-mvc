using BurgerWebApp.DomainModels;

namespace BurgerWebApp.DataAccess
{
    public static class StorageDb
    {
        public static List<Size> Sizes = new List<Size>()
        {
            new Size(IdGenerator.GenerateId(), "Small", 50),
            new Size(IdGenerator.GenerateId(), "Medium", 70),
            new Size(IdGenerator.GenerateId(), "Large", 100),
        };

        public static List<Burger> Burgers = new List<Burger>()
        {
            new Burger(IdGenerator.GenerateId(),"Hamburger",100,false,true,"https://tastesbetterfromscratch.com/wp-content/uploads/2020/06/Classic-Juicy-Hamburger-Recipe-Square.jpg",false),
            new Burger(IdGenerator.GenerateId(),"Cheeseburger",120,false,true,"https://www.kitchensanctuary.com/wp-content/uploads/2021/05/Double-Cheeseburger-square-FS-42.jpg",false),
            new Burger(IdGenerator.GenerateId(),"Chickenburger",120,false,true,"https://images.unsplash.com/photo-1590498403794-fd0ebd0db70c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",false),
            new Burger(IdGenerator.GenerateId(),"Vegeterian Dish",220,true,true,"https://images.immediate.co.uk/production/volatile/sites/30/2020/08/halloumi-burger-4fdad97.jpg",false),
            new Burger(IdGenerator.GenerateId(),"Veggie Burger",250,true,true,"https://thedinnerbell.recipes/wp-content/uploads/2019/11/Edamame-Mushroom-Veggie-Burgers-9.jpg",true)
        };
        public static List<Extra> ExtraItems = new List<Extra>()
        {
            new Extra(IdGenerator.GenerateId(),"Small Fries",Sizes[0],"https://images.immediate.co.uk/production/volatile/sites/30/2021/03/French-fries-b9e3e0c.jpg"),
            new Extra(IdGenerator.GenerateId(),"Medium Fries",Sizes[1],"https://images.immediate.co.uk/production/volatile/sites/30/2021/03/French-fries-b9e3e0c.jpg"),
            new Extra(IdGenerator.GenerateId(),"Large Fries",Sizes[2],"https://images.immediate.co.uk/production/volatile/sites/30/2021/03/French-fries-b9e3e0c.jpg"),
            new Extra(IdGenerator.GenerateId(),"Small Coke",Sizes[0],"https://www.kwiberry.com/pohojar/2022/02/000145352.jpeg"),
            new Extra(IdGenerator.GenerateId(),"Medium Coke",Sizes[1],"https://www.kwiberry.com/pohojar/2022/02/000145352.jpeg"),
            new Extra(IdGenerator.GenerateId(),"Large Coke",Sizes[2],"https://www.kwiberry.com/pohojar/2022/02/000145352.jpeg"),
        };
        public static List<Order> Order = new List<Order>();
        public static List<Cart> Cart = new List<Cart>();
        public static List<Location> BurgerLocations = new List<Location>()
        {
            new Location(IdGenerator.GenerateId(),"Hamm Burger","BurgerStreet1", new DateTime(2022, 1, 1, 8, 00, 00),new DateTime(2022, 1, 1, 23, 00, 00)),
            new Location(IdGenerator.GenerateId(),"Burger Place","BurgerStreet2",new DateTime(2022, 1, 1, 8, 00, 00),new DateTime(2022, 1, 1, 23, 00, 00)),
            new Location(IdGenerator.GenerateId(),"Burger Palace","BurgerStreet3",new DateTime(2022, 1, 1, 8, 00, 00),new DateTime(2022, 1, 1, 23, 00, 00)),
            new Location(IdGenerator.GenerateId(),"Burger World","BurgerStreet4",new DateTime(2022, 1, 1, 8, 00, 00),new DateTime(2022, 1, 1, 23, 00, 00)),
            new Location(IdGenerator.GenerateId(),"Burger Place Two","BurgerStreet5",new DateTime(2022, 1, 1, 8, 00, 00),new DateTime(2022, 1, 1, 23, 00, 00))
        };
    }
}
