using System;
using System.Collections.Generic;
using System.Text;

namespace ASU.DTO.Actors
{
    /// <summary>
    /// Заявитель
    /// </summary>
    public class Declarant : BaseActor
    {
        public string Address { get; set; }
        public string IIN { get; set; }
        public string Phone { get; set; }
    }
}
