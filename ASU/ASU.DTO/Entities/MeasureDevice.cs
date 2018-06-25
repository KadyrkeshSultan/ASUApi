using ASU.DTO.Enums;

namespace ASU.DTO.Entities
{
    /// <summary>
    /// Средство измерения
    /// </summary>
    public class MeasureDevice : BaseEntity
    {
        /// <summary>
        /// Допуск по разряду
        /// </summary>
        public string AllowedByCat { get; set; }

        /// <summary>
        /// Допуск по классу
        /// </summary>
        public string AllowedByClass { get; set; }

        /// <summary>
        /// Допуск с учетом неопределенности
        /// </summary>
        public string AllowedByRandom { get; set; }

        /// <summary>
        /// Производитель
        /// </summary>
        public string MDProducer { get; set; }
        public string MDProductionDate { get; set; }

        /// <summary>
        /// Диапозон измерений
        /// </summary>
        public string MeasurmentRange { get; set; }

        public string Number { get; set; }

        /// <summary>
        /// Обозначение
        /// </summary>
        public string QualifiedName { get; set; }

        //public string Type => $"{this.QualifiedName} - {base.Mnemo}";
        public MeasurementType MeasurementType { get; set; }
        public string MeasurementTypeId { get; set; }

        /// <summary>
        /// Межпроверочный интервал
        /// </summary>
        public VerificationGapEnum VerificationGap { get; set; }
        public MeasureDeviceType MeasureDeviceType { get; set; }
        public string MeasureDeviceTypeId { get; set; }
        /// <summary>
        /// Методика поверки
        /// </summary>
        public string VerificationProc { get; set; }

        public MeasureDevice()
        {

        }

        //public MeasureDevice(MeasureDevice item)
        //{
        //    base.OriginalId = item.Id;
        //    base.Owner = item.Owner;
        //    this.AllowedByCat = item.AllowedByCat;
        //    this.AllowedByClass = item.AllowedByClass;
        //    this.AllowedByRandom = item.AllowedByRandom;
        //    this.MDProducer = item.MDProducer;
        //    this.MDProductionDate = item.MDProductionDate;
        //    this.MeasurmentRange = item.MeasurmentRange;
        //    base.Mnemo = item.Mnemo;
        //    base.Name = item.Name;
        //    base.Note = item.Note;
        //    base.Parent = item.Parent;
        //    this.VerificationGap = item.VerificationGap;
        //    this.QualifiedName = item.QualifiedName;
        //    this.VerificationProc = item.VerificationProc;
        //}
    }
}
