using System.Collections.Generic;

namespace Skidos.Core
{
    public interface IAnalyticsBridge
    {
        void LogEvent(string eventName, Dictionary<string, object> parameters);
    }
}