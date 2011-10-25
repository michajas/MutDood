using MutDood.Storage.Interfaces.Strategy;

namespace MutDood.Storage.Strategies.Speed
{
    public class Engine : IEngine
    {
        private Engine()
        {
            
        }
        public static IEngine Create()
        {
            return new Engine();
        }
    }
}