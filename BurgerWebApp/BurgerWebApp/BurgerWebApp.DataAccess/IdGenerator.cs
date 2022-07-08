namespace BurgerWebApp.DataAccess
{
    public class IdGenerator
    {
        public static int GenerateId()
        {
            return new Random().Next(1, int.MaxValue);
        }
    }
}
