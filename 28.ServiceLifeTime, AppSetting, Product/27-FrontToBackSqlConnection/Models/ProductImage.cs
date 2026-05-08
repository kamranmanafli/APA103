namespace _27_FrontToBackSqlConnection.Models
{
    public class ProductImage : BaseEntity
    {
        public string Images { get; set; }
        public bool? isPrimary { get; set; }
        public int ProductId { get; set; }
        public Product Products { get; set; }
    }
}
