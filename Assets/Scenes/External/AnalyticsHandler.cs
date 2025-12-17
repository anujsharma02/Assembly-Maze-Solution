using System.Collections.Generic;
using UnityEngine;
using System.Text;
using Skidos.Core;

public class AnalyticsHandler : MonoBehaviour, IAnalyticsBridge
{
    public void LogEvent(string eventName, Dictionary<string, object> parameters)
    {
        Debug.Log($"Event logged -> {eventName}, parameters {parameters} ");

        // StringBuilder sb = new StringBuilder();
        // foreach (var _val in parameters)
        // {
        //     sb.Append($"[{_val.Key}:{_val.Value}] ");
        // }
        // Debug.Log(sb.ToString());
    }
}
