using System;
using System.Linq;

namespace ASU.DTO.Actors
{
    /// <summary>
    /// Поверщик
    /// </summary>
    public class Verificator : BaseActor
    {
        public string Address { get; set; }
        public string Certificate { get; set; }
        public string CertificateShort => Verificator.CertificateShortStatic(this.Certificate);
        public string Code { get; set; }
        public string Director { get; set; }
        public bool IsCheckAuthor { get; set; }
        public string Phone { get; set; }

        //public override string RoleMnemo => "ActorRoles_Verificator";

        public static string CertificateShortStatic(string certificate)
        {
            if (string.IsNullOrEmpty(certificate))
                return null;

            char[] chrArray = new char[] { ' ' };
            return certificate
                .Split(chrArray, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.ToUpperInvariant())
                .FirstOrDefault(t => t.Contains("KZ"));
        }

        public static bool IsCode(string search)
        {
            if (string.IsNullOrEmpty(search) || search.Length != 2)
                return false;

            return search.All(p => char.IsLetter(p));
        }
    }
}
