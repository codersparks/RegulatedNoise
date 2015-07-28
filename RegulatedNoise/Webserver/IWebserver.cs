using System.Net;

namespace RegulatedNoise.Webserver
{
    interface IWebserver
    {
        string BackgroundColour { get; set; }
        string ForegroundColour { get; set; }
        string styleName { get; set; }

        bool Running { get;}


        bool Start(IPAddress ipAddress, int port, int maxNOfCon, string contentPath, Form1 callingForm);
        void Stop();
    }
}