
public class Products
{
    public Data[] data { get; set; }
}

public class Data
{
    public int id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public string isbn { get; set; }
    public string author { get; set; }
    public int listPrice { get; set; }
    public int price { get; set; }
    public int price50 { get; set; }
    public int price100 { get; set; }
    public string imageUrl { get; set; }
    public int categoryId { get; set; }
    public Category category { get; set; }
    public int coverTypeId { get; set; }
    public Covertype coverType { get; set; }
}

public class Category
{
    public int id { get; set; }
    public string name { get; set; }
    public int displayOrder { get; set; }
    public DateTime createdDateTime { get; set; }
}

public class Covertype
{
    public int id { get; set; }
    public string name { get; set; }
}
