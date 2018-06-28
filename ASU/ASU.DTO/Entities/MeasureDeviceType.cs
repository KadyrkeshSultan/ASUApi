using ASU.DTO.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASU.DTO.Entities
{
    /// <summary>
    /// Тип средства измерения
    /// </summary>
    public class MeasureDeviceType : BaseEntity
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

        /// <summary>
        /// Диапозон измерений
        /// </summary>
        public string MeasurmentRange { get; set; }

        /// <summary>
        /// Обозначение
        /// </summary>
        public string QualifiedName { get; set; }

        //public string Type => $"{this.QualifiedName} - {base.Mnemo}";
        public MeasurementType MeasurementType { get; set; }
        public int MeasurementTypeId { get; set; }

        /// <summary>
        /// Межпроверочный интервал
        /// </summary>
        public VerificationGapEnum VerificationGap { get; set; }

        /// <summary>
        /// Методика поверки
        /// </summary>
        public string VerificationProc { get; set; }

        public MeasureDeviceType()
        {

        }
    }
}
