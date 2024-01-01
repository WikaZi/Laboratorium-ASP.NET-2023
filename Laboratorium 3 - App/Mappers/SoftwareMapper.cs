using Data.Entities;
using Laboratorium_3___App.Models;

namespace Laboratorium_3___App.Mappers
{
    public class SoftwareMapper
    {
        public static Software FromEntity(SoftwareEntity entity)
        {
            return new Software()
            {
                Id = entity.Id,
                Name = entity.Name,
                Version = entity.Version
            };
        }

        public static SoftwareEntity ToEntity(Software model)
        {
            return new SoftwareEntity()
            {
                Id = model.Id,
                Name = model.Name,
                Version = model.Version
            };
        }

    }
}
