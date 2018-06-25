using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASU.Web.Models
{
    public class VerificationDeviceView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DKP { get; set; }
        public string Desc { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
