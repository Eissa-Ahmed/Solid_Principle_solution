namespace Dependency_Inversion_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Noti noti = new Noti(new SmsService());
            noti.Notify("Hello");
        }
    }
}
