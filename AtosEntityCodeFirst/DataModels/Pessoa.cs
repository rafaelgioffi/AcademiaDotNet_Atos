namespace AtosEntityCodeFirst.DataModels
{
    public class Pessoa
    {
        public int id { get; set; }
        public string nome { get; set; }

        public virtual ICollection<Email> Emails { get; set; }
    }
}
