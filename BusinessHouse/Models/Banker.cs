namespace BusinessHouse.Models
{
    public static class Banker
    {
        public static int Balance { get; set; }
        static Banker()
        {
            Balance = 5000;
        }
    }
}
