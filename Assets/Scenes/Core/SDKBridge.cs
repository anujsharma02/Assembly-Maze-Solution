using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
namespace Skidos.Core
{
    public class SDKBridge : MonoBehaviour
    {

        private static IAnalyticsBridge _analytics;

        // connection from External folder
        public static void Register(IAnalyticsBridge analytics)
        {
            _analytics = analytics;
        }
        private void Start()
        {
            LogEvent("TestEvent", new Dictionary<string, object>()
{
{"P1",1},
{"P2",2.0},
{"P3","3"},
});
        }

        private void LogEvent(string eventName, Dictionary<string, object> parameters)
        {
            if (_analytics == null)
            {
                UnityEngine.Debug.LogWarning("Analytics not found");
                return;
            }

            //Execution time check
            Stopwatch sw = Stopwatch.StartNew();
            _analytics.LogEvent(eventName, parameters);
            sw.Stop();

            UnityEngine.Debug.Log(
                $"LogEvent took {sw.ElapsedTicks} ticks ({sw.ElapsedMilliseconds} ms)"
            );
        }
    }
}