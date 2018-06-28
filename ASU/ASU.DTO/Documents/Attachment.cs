using ASU.DTO.Entities;

namespace ASU.DTO.Documents
{
    /// <summary>
    /// Вложение (файл)
    /// </summary>
    public class Attachment : BaseDTO
    {
        public string File { get; set; }
        public byte[] FileData { get; set; }
        public string Name { get; set; }

        public Attachment()
        {

        }
    }
}
