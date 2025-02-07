namespace Open_Closed
{
    internal class Program
    {
        private readonly ILog _log;

        public Program(ILog log)
        {
            _log = log;
        }

        //static void Main(string[] args, LogType type)
        void Main(string[] args)
        {
            //if (type == LogType.DbLog)
            //{
            //    DbLog dbLog = new DbLog();
            //    dbLog.Log("");
            //}else if(type == LogType.XMLLog)
            //{
            //    XMLLog xmlLog = new XMLLog();
            //    xmlLog.Log("");
            //}

            //ILog _log = new XMLLog();
            _log.Log("");

            Console.WriteLine("Hello, World!");
        }

        public interface ILog
        {
            void Log(string message);
        }

        public class DbLog : ILog
        {
            public void Log(string value)
            {

            }
        }

        public class XMLLog : ILog
        {
            public void Log(string value)
            {

            }
        }

        public class txtLog : ILog
        {
            public void Log(string message)
            {
                throw new NotImplementedException();
            }
        }

        //public enum LogType
        //{
        //    DbLog,
        //    XMLLog
        //}
    }
}
