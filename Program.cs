namespace flight
{
    class Program
    {   
        static int Main(string[] args)
        {
            var m = new KzkmEngine.Mesh();
            m.LoadFromMQO("resources/Cirno3.mqo");
            //return 0;
            using (var window = new KzkmEngine.Game(800, 600, "window name"))
            {
                window.Run(60.0);
            }
            return 0;
        }
    }
}
