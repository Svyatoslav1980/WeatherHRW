using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WeatherHRW
{
    class Request
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public Request(DateTime date, string description)
        {
            this.Date = date;
            this.Description = description;
        }
    }
}
