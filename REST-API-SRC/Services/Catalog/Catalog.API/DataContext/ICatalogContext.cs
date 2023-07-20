using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.DataContext
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }

    }
}
