extern alias Json;

namespace AliasTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Json.Newtonsoft.Json.JsonConvert.SerializeObject("Hello World!");
        }
    }
}
