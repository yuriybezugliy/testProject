using TestProject.Data.DataContext;
using TestProject.Data.Repositories.Base;
using TestProject.DomainModel.Entities;

namespace TestProject.Data.Repositories.Aircrafts
{
    class AircraftsRepository : Repository<Aircraft>, IAircraftsRepository
    {
        public AircraftsRepository(IDataContext dataContext) : base(dataContext)
        {
        }
    }
}
