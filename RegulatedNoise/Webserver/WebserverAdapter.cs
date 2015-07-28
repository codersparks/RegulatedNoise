using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using RegulatedNoise.Webserver;


namespace RegulatedNoise.Webserver
{

    class WebserverAdapter : Webserver.IWebserver
    {

        Webserver.IWebserver _server;

        public WebserverAdapter()
        {
            _server = new SimpleWebserver();
        }

        public WebserverAdapter(WebserverType type) {

            switch(type)
            {
                case WebserverType.SIMPLE:
                    _server = new SimpleWebserver();
                    break;
                case WebserverType.BOOTSTRAP:
                    _server = new BootstrapWebserver();
                    break;
            }
        }

        public string BackgroundColour
        {
            get
            {
                return _server.BackgroundColour;
            }

            set
            {
                _server.BackgroundColour = value;
            }
        }

        public string ForegroundColour
        {
            get
            {
                return _server.ForegroundColour;
            }

            set
            {
                _server.ForegroundColour = value;
            }
        }

        public bool Running
        {
            get
            {
                return _server.Running;
            }

        }

        public string styleName
        {
            get
            {
                return _server.styleName;
            }

            set
            {
                _server.styleName = value;
            }
        }

        public bool Start(IPAddress ipAddress, int port, int maxNOfCon, string contentPath, Form1 callingForm)
        {
            return _server.Start(ipAddress, port, maxNOfCon, contentPath, callingForm);
        }

        public void Stop()
        {
            _server.Stop();
        }
    }

    public enum WebserverType
    {
        SIMPLE,
        BOOTSTRAP
    }
}
