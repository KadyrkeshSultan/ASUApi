using ASU.DTO.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASU.Web.Models
{
    public class MeasureDeviceTypeView
    {
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        public string Name { get; set; }

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

        [Required]
        [MinLength(1)]
        /// <summary>
        /// Производитель
        /// </summary>
        public string MDProducer { get; set; }

        [Required]
        [MinLength(1)]
        /// <summary>
        /// Диапозон измерений
        /// </summary>
        public string MeasurmentRange { get; set; }

        /// <summary>
        /// Обозначение
        /// </summary>
        public string QualifiedName { get; set; }

        //public string Type => $"{this.QualifiedName} - {base.Mnemo}";
        public MeasurementTypeView MeasurementType { get; set; }
        public int MeasurementTypeId { get; set; }

        /// <summary>
        /// Межпроверочный интервал
        /// </summary>
        public VerificationGapEnum VerificationGap { get; set; }

        [Required]
        [MinLength(1)]
        /// <summary>
        /// Методика поверки
        /// </summary>
        public string VerificationProc { get; set; }
    }
}
