﻿namespace AtosEntityCodeFirst.DataModels
{
    public class Email
    {
        public int id { get; set; }
        public string email { get; set; }

        public virtual Pessoa pessoa { get; set; }
    }
}
