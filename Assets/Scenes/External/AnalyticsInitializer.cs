using UnityEngine;
using Skidos.Core;
public class AnalyticsInitializer : MonoBehaviour
{
    private void Awake()
    {
        AnalyticsHandler handler = Object.FindAnyObjectByType<AnalyticsHandler>();
        if (handler != null)
        {
            SDKBridge.Register(handler);
        }
        else
        {
            Debug.LogError("AnalyticsHandler not found");
        }
    }
}
