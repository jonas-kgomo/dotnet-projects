using System.Collections.Generic;

namespace graphql_dotnet.Models
{
public class Category {
    public int id { get; set; }
    public string Name { get; set; }
    List<Products> Products { get; set; }
    
    }
}