namespace Debate.Core.EventSystem
{
    public class GameEvent
    {
        public string Name;

        public GameEvent()
        {
            Name = GetType().Name;
        }
    }
}