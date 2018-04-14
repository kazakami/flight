namespace flight
{
    public class DefaultScene : KzkmEngine.Scene
    {
        public DefaultScene()
        {
            workerManager.AddWorker(new Chara());
        }
    }
}