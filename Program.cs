namespace flight
{
    class Program
    {   
        static int Main(string[] args)
        {
            //var m = new KzkmEngine.Mesh();
            //m.LoadFromObj("resources/ente_progress_model/ente progress_export.obj");
            //return 0;
            using (var window = new KzkmEngine.Game(800, 600, "window name", "default", new DefaultScene()))
            {
                window.Run(60.0);
            }
            return 0;
        }
    }
}
