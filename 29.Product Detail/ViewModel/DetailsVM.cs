using _27_FrontToBackSqlConnection.Models;

namespace _27_FrontToBackSqlConnection.ViewModel
{
    public class DetailsVM
    {
        public Product Product { get; set; }
        public List<Product> RelatedProducts { get; set; }
    }
}
