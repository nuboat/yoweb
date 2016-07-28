using YoWeb.Module.Hello;

namespace YoWeb.Facade
{
    public class HelloWorld : IHelloWorld
    {
        public string Say(string name) 
        {
            return $"Hello {name}";
        }
    }
}
