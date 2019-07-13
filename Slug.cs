using System;
using UnityEngine;

public static class Slug {
	public delegate void Logger(string message);
	public static Logger Log = m => LogMessage(LogType.Log, m);
	public static Logger LogWarning = m => LogMessage(LogType.Warning, m);
	public static Logger LogError = m => LogMessage(LogType.Error, m);

	private static void LogMessage(LogType logType, string message) {
		string msg = String.Format("{0} {1}", GetClassName(), message);
		Debug.unityLogger.Log(logType, msg);
	}

	private static string GetClassName()
	{
		Type m_ReflectedType = new System.Diagnostics.StackTrace(true).GetFrame(3).GetMethod().ReflectedType;
		return m_ReflectedType != null ? "[" + m_ReflectedType.Name + "]": "<b>[Unknown Class]</b>";
	}
}