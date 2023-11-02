using SingleResponsibilityPrinciple.Example2;

internal class Program
{
    private static void Main(string[] args)
    {

        MobileStore store = new MobileStore(
             new ConsolePhoneReader(), new GeneralPhoneBinder(),
             new GeneralPhoneValidator(), new TextPhoneSaver());
        store.Process();

        Console.WriteLine("Hello, World!");
    }
}