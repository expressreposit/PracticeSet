using MultipleInterfaceImplements.Repositories.Interface;

namespace MultipleInterfaceImplements.Repositories
{
    public class FileLogger : ICustomLogger
    {
        public bool Write(string data)
        {
            throw new NotImplementedException();
        }
    }
    public class DbLogger : ICustomLogger
    {
        public bool Write(string data)
        {
            throw new System.NotImplementedException();
        }
    }
    public class EventLogger : ICustomLogger
    {
        public bool Write(string data)
        {
            throw new System.NotImplementedException();
        }
    }
}
