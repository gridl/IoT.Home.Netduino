using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

using System.IO;
using HttpLibrary;

using HomeStation.InfraRed.Encoder;
using HomeStation.InfraRed.Decoder;
using HomeStation.TempHumid;
//using HomeStation.WebServer;

namespace Home
{
    public class Program
    {
        static HttpServer Server;//server object
        static Credential ServerCredential;//server security
        static Configuration ServerConfiguration;//configuration settings
        static DHTSensorScan _DHTSensorScan;//humidity & temperature

        public static void Main()
        {
            // Humidity and Temperature
            var RHT03 = new Dht22Sensor(Pins.GPIO_PIN_D0, Pins.GPIO_PIN_D1, PullUpResistor.Internal);
            _DHTSensorScan = new DHTSensorScan(RHT03);

            //IRRX: Infrared Decoder
            NecProtocolDecoder decoder = new NecProtocolDecoder(Pins.GPIO_PIN_D7);
            NecProtocolDecoder.OnIRCommandReceived += NecDecoder_OnIRCommandReceived;

            //IRTX: Infrared Encoder
            var irtx = new InfraredTransmitter(Pins.GPIO_PIN_D8);
            var codec = new InfraredCodecNEC(irtx);

            Thread.Sleep(1000);

            // Web Server
            ServerConfiguration = new Configuration(80);
            ServerCredential = new Credential("Jose Motta", "admin", "admin");
            Server = new HttpServer(ServerConfiguration, ServerCredential, @"\SD\");
            Server.OnServerError += new OnServerErrorDelegate(Server_OnServerError);
            Server.OnRequestReceived += new OnRequestReceivedDelegate(Server_OnRequestReceived);
            Server.Start();

            //// Web Server
            //WebServer w = new WebServer(80, 10000);
            //w.Start();
            //w.CommandReceived += delegate(object o, WebServer.WebServerEventArgs e)
            //{
            //    //WebServer.OutPutStream(e.response, e.rawURL);
            //    //if (RHT03.Read())
            //    {
            //        var temperatureCelsius = _DHTSensorScan.Temperature;
            //        var humidity = _DHTSensorScan.Humidity;
            //        string answer = "DHT Sensor: RH = " + humidity.ToString("F1") + "%  Temp = " + temperatureCelsius.ToString("F1") + "°C ";
            //        Debug.Print(answer);
            //        WebServer.OutPutStream(e.response, answer);

            //        //string s = e.rawURL;

            //        //codec.Send(0xFF, 0x0D); // leds on
            //        //Thread.Sleep(1000);
            //        //codec.Send(0xFF, 0x1F); // leds off
            //    }
            //};

            // Loop forever reading Humidity & Temperature
            _DHTSensorScan.GatherInput();
        }

        static void Server_OnRequestReceived(HttpRequest Request, HttpResponse Response)
        {
            if (Request.RequestedFile != null)
            {
                string FullFileName = Request.FilesPath + Request.RequestedFile;
                if (File.Exists(FullFileName))
                {
                    Response.WriteFile(FullFileName);
                }
                else
                {
                    Response.WriteNotFound();
                }
            }
            else
            {
                var temperatureCelsius = _DHTSensorScan.Temperature;
                var humidity = _DHTSensorScan.Humidity;
                string answer = "DHT Sensor: RH = " + humidity.ToString("F1") + "%  Temp = " + temperatureCelsius.ToString("F1") + "°C ";

                Response.WriteFilesList(answer);

                //Response.WriteFile(Request.FilesPath + "home.html"); // TODO: produto
            }
        }

        static void Server_OnServerError(ErrorEventArgs e)
        {
            Debug.Print(e.EventMessage);
        }

        static void NecDecoder_OnIRCommandReceived(UInt32 irData)
        {
            Debug.Print("Ir Command Received: " + UlongToHexString((ulong)irData));
        }

        // Hex to string. Codes make more sense in hex as they are really four bytes
        public static string UlongToHexString(ulong val)
        {
            string s = "";
            for (int i = 0; i < 8; i++)
            {
                ulong x = val & (ulong)0x0000000F;
                val = val >> 4;
                switch (x)
                {
                    case 0: s = '0' + s; break;
                    case 1: s = '1' + s; break;
                    case 2: s = '2' + s; break;
                    case 3: s = '3' + s; break;
                    case 4: s = '4' + s; break;
                    case 5: s = '5' + s; break;
                    case 6: s = '6' + s; break;
                    case 7: s = '7' + s; break;
                    case 8: s = '8' + s; break;
                    case 9: s = '9' + s; break;
                    case 10: s = 'A' + s; break;
                    case 11: s = 'B' + s; break;
                    case 12: s = 'C' + s; break;
                    case 13: s = 'D' + s; break;
                    case 14: s = 'E' + s; break;
                    case 15: s = 'F' + s; break;
                }
            }
            return s;
        }
    }
}