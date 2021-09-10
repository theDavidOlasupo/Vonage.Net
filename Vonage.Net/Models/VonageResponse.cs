using System;
namespace Vonage.Net.Models
{
    public class VonageResponse
    {

        public bool IsSuccessful { get; set; }

        public string message { get; set; }

        public data data { get; set; }
    }

    public class data
    {
        public string Metadata { get; set; }

    }
}
