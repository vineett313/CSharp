using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public enum ConnectionType { SQL, XML, MySQl}

    public class SimpleConnectionFactory
    {
        public static IConnection GetConnection(ConnectionType connectionType)
        {
            IConnection connection = null;
            switch (connectionType)
            {
                case ConnectionType.SQL:
                    connection = new SQLDbConection();
                    break;
                case ConnectionType.MySQl:
                    connection = new MySqlConnection();
                    break;
                case ConnectionType.XML:
                    connection = new XMLConnection();
                    break;
                default:
                    connection = null;
                    break;
            }
            return connection;
        }
    }

    public interface IConnection
    {
        void Connect();
    }

    public class SQLDbConection : IConnection
    {
        public void Connect()
        {
            throw new NotImplementedException();
        }
    }

    public class XMLConnection : IConnection
    {
        public void Connect()
        {
            throw new NotImplementedException();
        }
    }

    public class MySqlConnection : IConnection
    {
        public void Connect()
        {
            throw new NotImplementedException();
        }
    }

}
