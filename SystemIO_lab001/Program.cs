using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SystemIO_lab001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _myPath = Path.GetTempPath();
            Console.WriteLine("Путь к папке \"TEMP\" = {0}", _myPath);
            _myPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine("Путь к папке \"Мои документы\" = {0}", _myPath);
            _myPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            Console.WriteLine("Путь к папке \"Профиль текущего пользователя\" = {0}", _myPath);
        }
    }
}
