using System;
using System.ServiceModel;
using WCFMyServiceLibrary;

namespace my_client
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаём адрес нашей службы
            Uri tcpUri = new Uri("http://localhost:8000/MyService");
            // Создаём сетевой адрес, с которым клиент будет взаимодействовать
            EndpointAddress address = new EndpointAddress(tcpUri);
            BasicHttpBinding binding = new BasicHttpBinding();
            // Данный класс используется клиентами для отправки сообщений
            ChannelFactory<IMyService> factory = new ChannelFactory<IMyService>(binding, address);
            // Открываем канал для общения клиента с со службой
            IMyService service = factory.CreateChannel();
            service.WriteToFile("1");
            service.WriteToFile("2");
            service.WriteToFile("3");

            Console.WriteLine("Текст записан в файл.");

            // Читаем из файла
            Console.WriteLine(service.ReadFromFile());

            Console.ReadLine();
        }
    }
}
