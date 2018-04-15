namespace flight
{
    public class Chara : KzkmEngine.Worker
    {
        KzkmEngine.Mesh m = new KzkmEngine.Mesh();
        double x = 0;
        public Chara()
        {
            System.Console.WriteLine("fuga");
            m.LoadFromObj("resources/ente_progress_model/ente progress_export.obj");
        }
        override public void Update()
        {
            x += 0.1;
        }

        override public void Draw()
        {
            m.Render(x, 0, 0);
        }
    }
}