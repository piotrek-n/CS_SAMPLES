using CS_ADVANCE.MichaelLam._05_ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam._05_ObserverPattern.Subject
{
    public class YouTubeChannel
    {
        private IList<ISubsciber> _subscribers = new List<ISubsciber>();
        public void Subscribe(ISubsciber s)
        {
            _subscribers.Add(s);
        }
        public void Unsubscribe(ISubsciber s)
        {
            _subscribers.Remove(s);
        }

        public void NotifySubscibers()
        {
            foreach (var item in _subscribers)
            {
                item.Notify();
            }
        }

    }
}
