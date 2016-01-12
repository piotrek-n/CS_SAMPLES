using CS_ADVANCE.MichaelLam._05_ObserverPattern.Observer;
using CS_ADVANCE.MichaelLam._05_ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam._05_ObserverPattern
{
    public static class _05_ObserverPattern
    {
        public static void Caller()
        {
            YouTubeChannel channel = new YouTubeChannel();

            CS_ADVANCE.MichaelLam._05_ObserverPattern.Observer.ISubsciber Joey = new User();
            CS_ADVANCE.MichaelLam._05_ObserverPattern.Observer.ISubsciber Alex = new User();
            CS_ADVANCE.MichaelLam._05_ObserverPattern.Observer.ISubsciber Gai = new Moderator();

            channel.Subscribe(Joey);
            channel.Subscribe(Alex);
            channel.Subscribe(Gai);

            channel.NotifySubscibers();

            Console.ReadLine();

        }
    }
}
