namespace flight
{
    class Program
    {   
        static int Main(string[] args)
        {
            KzkmEngine.Game.Start("default", new DefaultScene());
            return 0;
        }
    }
}
