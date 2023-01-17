namespace Domain
{
    public class Groceries
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public double JmfrPris { get; set; }
        public string BrandName { get; set; }
        public string Category { get; set; }
        public string Info { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Img_url { get; set; }
    }
}