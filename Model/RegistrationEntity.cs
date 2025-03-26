namespace RegistrationAPI.Model
{
    public class RegistrationEntity
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string NPWP { get; set; }
        public string DirectorName { get; set; }
        public string PICName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string NPWPFilePath { get; set; }
        public string PowerOfAttorneyFilePath { get; set; }
    }
}
