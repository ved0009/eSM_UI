using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Model.Model
{
    public class Response : IDisposable
    {
        public bool success { get; set; }
        public string? message { get; set; }
        public object? responseData { get; set; }
        public int RecordsTotal { get; set; }
        public string? token { get; set; }
        public object? responseData2 { get; set; }
        public int RecordsFiltered { get; set; }
        public int Role { get; set; }
        public string? DBmessage { get; set; }
        public DateTime CurrentTime { get; set; } = DateTime.Now; // Custom format
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
    public class ESMResponse : Response
    {
        public bool IsAnyToPay { get; set; }
    }
}

