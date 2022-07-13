namespace BurgerWebApp.DomainModels
{
    public class Extra
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public decimal Price { get; set; }
        public string Image { get; set; }
        public int SizeId { get; set; }
        public Size Size { get; set; }
        public Extra()
        {

        }
        public Extra(string name, string imageUrl, int sizeId)
        {

            Name = name;
            Image = imageUrl;
            SizeId = sizeId;
        }
    }
}

