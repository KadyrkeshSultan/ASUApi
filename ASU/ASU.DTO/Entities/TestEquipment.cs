namespace ASU.DTO.Entities
{
    /// <summary>
    /// Испытательное оборудование
    /// </summary>
    public class TestEquipment : BaseEntity
    {
        //TODO : Country
        public string TECoutry { get; set; }

        //TODO : Manufacture
        public string TEManufatureDate { get; set; }

        public string TEModel { get; set; }
        public string TEProducer { get; set; }
        public string TEWorkNumber { get; set; }

        public TestEquipment()
        {

        }

        //public TestEquipment(TestEquipment testEquipment)
        //{
        //    base.Name = testEquipment.Name;
        //    this.TEModel = testEquipment.TEModel;
        //    this.TEWorkNumber = testEquipment.TEWorkNumber;
        //    this.TEProducer = testEquipment.TEProducer;
        //    this.TECoutry = testEquipment.TECoutry;
        //    this.TEManufatureDate = testEquipment.TEManufatureDate;
        //}
    }
}
