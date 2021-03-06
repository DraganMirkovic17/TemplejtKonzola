﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;


namespace ServerKonzola
{
    public class Server
    {
        Socket soket;

        public bool pokreniServer()
        {
            try
            {
                soket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
                //broj telefona kod servera je zapravo IpEndPoint
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, 20000);
                soket.Bind(ep);

                ThreadStart ts = osluskuj;
                new Thread(ts).Start();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool zaustaviServer()
        {
            try
            {
                soket.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        void osluskuj()
        {
            try
            {
                while (true)
                {
                    soket.Listen(8);
                    Socket klijent = soket.Accept();
                    NetworkStream tok = new NetworkStream(klijent);
                    new NitKlijenta(tok);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
