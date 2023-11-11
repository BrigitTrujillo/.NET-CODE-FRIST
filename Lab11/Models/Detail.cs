namespace Lab11.Models
{
    public class Detail
    {
        public int DetailId { get;set;}
        public float Price { get;set;}
        public float SubTotal { get;set;}


        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public int InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }


    }
}
