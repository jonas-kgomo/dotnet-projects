using System.Collections.Generic;

namespace graphql_dotnet.Models
{
public class Products {
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    List<Products> Products { get; set; }
    
    }
}