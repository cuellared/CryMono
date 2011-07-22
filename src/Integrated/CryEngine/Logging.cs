﻿using System;
using System.Runtime.CompilerServices;

namespace CryEngine
{
    public class CryConsole
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern protected static void _LogAlways(string msg);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern protected static void _Log(string msg);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern protected static void _CryWarning(string msg);

        /// <summary>
        /// Logs a message to the console
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void Log(string format, params object[] args)
        {
            _Log(String.Format(format, args));
        }

        /// <summary>
        /// Logs a message to the console
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void Log(string msg)
        {
           _Log(msg);
        }

        /// <summary>
        /// Logs a message to the console, regardless of log_verbosity settings
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void LogAlways(string format, params object[] args)
        {
            _LogAlways(String.Format(format, args));
        }

        /// <summary>
        /// Logs a message to the console, regardless of log_verbosity settings
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void LogAlways(string msg)
        {
            _LogAlways(msg);
        }

        /// <summary>
        /// Logs a warning message to the console
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void CryWarning(string format, params object[] args)
        {
            _CryWarning(String.Format(format, args));
        }

        /// <summary>
        /// Logs a warning message to the console
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void CryWarning(string msg)
        {
            _CryWarning(msg);
        }
    }
}
