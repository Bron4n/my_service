using System;
using System.ServiceModel;
using WCFMyServiceLibrary;

namespace my_host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализируем службу, указываем адрес, по которому она будет доступна
            ServiceHost host = new ServiceHost(typeof(MyService), new Uri("http://localhost:8000/MyService"));
            // Добавляем конечную точку службы с заданным интерфейсом, привязкой (создаём новую) и адресом конечной точки
            host.AddServiceEndpoint(typeof(IMyService), new BasicHttpBinding(), "");
            // Запускаем службу
            host.Open();
            Console.WriteLine("Сервер запущен");
            Console.ReadLine();
            // Закрываем службу
            host.Close();
        }
    }
}
