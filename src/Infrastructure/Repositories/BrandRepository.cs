using EshopManager.Application.Interfaces.Repositories;
using EshopManager.Domain.Entities.Catalog;

namespace EshopManager.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IRepositoryAsync<Brand, int> _repository;

        public BrandRepository(IRepositoryAsync<Brand, int> repository)
        {
            _repository = repository;
        }
    }
}