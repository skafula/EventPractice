using System;

namespace ClassLibrary1
{
    public class Publisher
    {
        public event Action<object> EventName;

        public void RaiseEvent(Object obj)
        {
            if (EventName != null)
            {
                EventName(obj);
            }
        }
    }
}