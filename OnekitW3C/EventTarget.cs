using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;

namespace cn.onekit.w3c
{
    public interface EventTarget
    {
    }
    static public class EventTarget_
    {
        static Dictionary<int, Dictionary<string, Dictionary<int, EventListener>>> allTypeListeners = new Dictionary<int, Dictionary<string, Dictionary<int, EventListener>>>();

        //void addEventListener(string type, EventListener listener, Map<string,Boolean> options);
        public static void addEventListener(this Element THIS, string type, EventListener listener, bool useCapture)
        {
            if (!allTypeListeners.ContainsKey(THIS.GetHashCode()))
            {
                allTypeListeners.Add(THIS.GetHashCode(), new Dictionary<string, Dictionary<int, EventListener>>());
            }
            Dictionary<string, Dictionary<int, EventListener>> typeListeners = allTypeListeners[THIS.GetHashCode()];
            if (!typeListeners.ContainsKey(type))
            {
                typeListeners.Add(type, new Dictionary<int, EventListener>());
            }
            typeListeners[type].Add(listener.GetHashCode(), listener);
        }
        public static void addEventListener(this Element THIS, string type, EventListener listener)
        {
            addEventListener(THIS, type, listener, false);
        }
        //void removeEventListener(string type, EventListener listener, Map<string,Boolean> options);
        public static void removeEventListener(this Element THIS, string type, EventListener listener, bool useCapture)
        {
            Dictionary<string, Dictionary<int, EventListener>> typeListeners = allTypeListeners[THIS.GetHashCode()];
            typeListeners[type].Remove(listener.GetHashCode());
        }

        public static void removeEventListener(this Element THIS, string type, EventListener listener)
        {
            removeEventListener(THIS, type, listener, false);
        }

        public static bool dispatchEvent(this Element THIS, Event evt)
        {
            Dictionary<string, Dictionary<int, EventListener>> typeListeners = allTypeListeners[THIS.GetHashCode()];
            if (!typeListeners.ContainsKey("change"))
            {
                return false;
            }
            foreach (EventListener listener in typeListeners["change"].Values)
            {
                listener.handleEvent(evt);
            }

            return false;
        }

    }
}
