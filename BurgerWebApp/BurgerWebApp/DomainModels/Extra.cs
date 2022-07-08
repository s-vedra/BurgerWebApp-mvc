namespace BurgerWebApp.DomainModels
{
    public class Extra
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Size SizeId { get; set; }
        public string Image { get; set; }
        public Extra()
        {

        }
        public Extra(int id, string name, Size sizeId, string imageUrl)
        {
            Id = id;
            Name = name;
            SizeId = sizeId;
            Image = imageUrl;
        }
    }
}
