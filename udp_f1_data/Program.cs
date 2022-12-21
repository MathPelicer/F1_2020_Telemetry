using Codemasters.F1_2020;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;

namespace udp_f1_data
{
    class UDPListener
    {
        private const int listenPort = 20777;

        private static void StartListening()
        {
            var udpClient = new UdpClient(listenPort);
            var ep = new IPEndPoint(IPAddress.Any, listenPort);

            try
            {
                Console.WriteLine("waiting for data...");
                while (true)
                {
                    byte[] bytes = udpClient.Receive(ref ep);
                    var pt = CodemastersToolkit.GetPacketType(bytes);

                    if (pt.ToString() == "CarTelemetry")
                    {
                        TelemetryPacket tp = new TelemetryPacket();
                        var playerIndex = tp.PlayerCarIndex;
                        tp.LoadBytes(bytes);
                        Console.Clear();

                        //foreach (TelemetryPacket.CarTelemetryData ctd in tp.FieldTelemetryData)
                        //{

                        Console.WriteLine($"Speed: {tp.FieldTelemetryData[playerIndex].SpeedKph.ToString()}");
                        Console.WriteLine($"Gear: {tp.FieldTelemetryData[playerIndex].Gear.ToString()}");
                        //}     
                    }
                }
            }
            catch (SocketException exception)
            {
                Console.WriteLine(exception);
            }
            finally
            {
                udpClient.Close();
            }
        }
        public static void Main()
        {
            StartListening();
        }
    }
}