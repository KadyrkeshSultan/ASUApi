using System;

namespace ASU.DTO.Entities
{
    /// <summary>
    /// Средство поверки
    /// </summary>
    public class VerificationDevice : BaseEntity
    {
        public string AdditionalInfo { get; set; }
        
        //TODO: в поверки можно выбирать множество
        public string DKP { get; set; }
        public DateTime? ExpirationDate { get; set; }

        public VerificationDevice()
        {

        }
    }
}
