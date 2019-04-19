﻿using UnityEngine;

namespace TouhouHeartstone.OldFrontend
{
    public class DebugUtils
    {
        public static void Log(string message, UnityEngine.Object context = null)
        {
            Debug.Log("[Frontend]" + message, context);
        }

        public static void LogDebug(string message, UnityEngine.Object context = null)
        {
            Debug.Log($"<color=grey>[Frontend]{message}</color>", context);
        }

        public static void LogNoImpl(string message, UnityEngine.Object context = null)
        {
            Debug.Log($"<color=yellow>[Frontend][NoImpl]{message}</color>", context);
        }

        public static void LogWarning(string message, UnityEngine.Object context = null)
        {
            Debug.LogWarning("[Frontend]" + message, context);
        }
    }
}