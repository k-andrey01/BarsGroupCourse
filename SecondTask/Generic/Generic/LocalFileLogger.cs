using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class LocalFileLogger<T> : ILogger
    {
        private String path;
        private String GenericTypeName = typeof(T).Name;
        public LocalFileLogger(String path)
        {
            this.path = path;
        }

        public void LogError(string message, Exception ex)
        {
            File.AppendAllText(path, $"[Error]: [{GenericTypeName}] : {message}. {ex.Message}\n");
        }

        public void LogInfo(string message)
        {
            File.AppendAllText(path, $"[Info]: [{GenericTypeName}] : {message}\n");
        }

        public void LogWarning(string message)
        {
            File.AppendAllText(path, $"[Warning]: [{GenericTypeName}] : {message}\n");
        }
    }
}
