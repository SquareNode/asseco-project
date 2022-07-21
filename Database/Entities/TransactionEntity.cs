namespace projekat.Database.Entities {
    public class TransactionEntity {
        public string id  {get; set;}
        public string beneficiaryName{ get; set; }

        public DateTime date {get; set;}

        public char direction { get; set; }

        public double amount {get; set; }

        public string description {get; set;}

        public string currency {get; set ;}
        public int mcc  {get; set;}

        public string kind {get; set;}
    }
}