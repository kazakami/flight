namespace flight
{
    public class Chara : KzkmEngine.Worker
    {
        KzkmEngine.Mesh m = new KzkmEngine.Mesh();
        public Chara()
        {
            System.Console.WriteLine("fuga");
            m.LoadFromObj("resources/ente_progress_model/ente progress_export.obj");
        }
        override public void Update()
        {
        }

        override public void Draw()
        {
            m.Render();
        }
    }
}