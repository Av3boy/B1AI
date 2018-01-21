using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace BIA_
{
    class Workstation
    {

        public static void shutdown()
        {

            if (Program.admin)
            {
                Program.speaker.Speak("Workstation will shutdown in few seconds.");
                Process.Start("shutdown", "/s /t 10");
                Environment.Exit(0);
            }

            if (!Program.admin)
            {
                Program.speaker.Speak("I am sorry, but you are not confirmed your identity.");
                Program.speaker.Speak("Do you want confirm your identity now ?");

                while(!Program.admin)
                {

                    if (Program.Yes.Contains(Program.reconized, StringComparer.OrdinalIgnoreCase))
                    {
                        Program.reconized = "";
                        AdminIdentity.check();
                    }

                    if (Program.No.Contains(Program.reconized, StringComparer.OrdinalIgnoreCase))
                    {
                        Program.speaker.Speak("Okay, Operation aborted.");
                        Program.reconized = "";
                        Commands.commands();
                    }
                }
            }
        }

        public static void WakeOnLan(byte[] mac)
        {
            byte[] macaddress = new byte[] { 0x00, 0x30, 0x84, 0x79, 0xAA, 0xE3 };
            WakeOnLan(macaddress);

            UdpClient client = new UdpClient();
            client.Connect(IPAddress.Broadcast, 40000);

            byte[] packet = new byte[17 * 6];

            for (int i = 0; i < 6; i++)
                packet[i] = 0xFF;

            for (int i = 1; i <= 16; i++)
                for (int j = 0; j < 6; j++)
                    packet[i * 6 + j] = mac[j];

            client.Send(packet, packet.Length);
        }
    }
}
