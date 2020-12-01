// Simple SOCKS proxy
using static System.Console;
using static CANAPE.Cli.ConsoleUtils;

//Create the SOCKS PROXY TEMPLATE
var template = new SocksProxyTemplate();
template.LocalPort = 9493;

//Create proxy instance and start
var service = template.Create();
service.start();

WriteLine("Created {0}", service);
WriteLine("Press Enter to exit...");
ReadLine();
service.Stop();

//DUMP Packets
var packets = service.Packets;
WriteLine("Captured {0} packets : ", packets.Count);
WritePackets(packets);
