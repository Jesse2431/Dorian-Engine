using DorianEngine.Entities;

namespace DorianEngine.Component
{
    public abstract class BaseComponent
    {
        // General data
        public bool IsEnabled = true;
        public Entity Entity;
    }
}