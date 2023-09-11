namespace design_patterns.Mediator
{
    public abstract class UIControl : EventHandler
    {
        private List<EventHandler> eventHandlers = new List<EventHandler>();

        public void AddEventHandler(EventHandler observer)
        {
            eventHandlers.Add(observer);
        }
        protected void NotifyEventHandlers()
        {
            foreach (EventHandler @event in eventHandlers)
            {
                @event.Handle();
            }
        }
        public void Handle()
        {
            throw new NotImplementedException();
        }


    }
}
