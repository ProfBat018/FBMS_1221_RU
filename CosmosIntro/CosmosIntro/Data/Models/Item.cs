namespace CosmosIntro.Data.Models;

public class Item : IEntity
{
    public string id;
    public string categoryId;
    public string categoryName;
    public string sku;
    public string name;
    public string description;
    public double price;
    public     Tags[] tags;
    public string _rid;
    public string _self;
    public string _etag;
    public string _attachments;
    public int _ts;
}

public class Tags
{
    public string id;
    public string name;
}

