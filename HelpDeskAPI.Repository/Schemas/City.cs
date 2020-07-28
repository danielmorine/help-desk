namespace HelpDeskAPI.Repository.Schemas
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public int StateID { get; set; }

        public virtual Address Address { get; set; }
    }
}
