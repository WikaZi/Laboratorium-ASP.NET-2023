using Data.Entities;
using Laboratorium_3___App.Models;

namespace Laboratorium_3___App.Mappers
{
    public class ComputerMapper
    {
        public static Computer FromEntity(ComputerEntity entity)
        {
            return new Computer()
            {
                Id = entity.Id,
                Name = entity.Name,
                Processor = entity.Processor,
                Memory = entity.Memory,
                GraphicsCard = entity.GraphicsCard,
                Producer = entity.Producer,
                DateOfProduction = entity.DateOfProduction,

                
            };
        }

        public static ComputerEntity ToEntity(Computer model)
        {
            return new ComputerEntity()
            {
                Id = model.Id,
                Name = model.Name,
                Processor = model.Processor,
                Memory = model.Memory,
                GraphicsCard = model.GraphicsCard,
                Producer = model.Producer,
                DateOfProduction = model.DateOfProduction,
               
            };
        }
    }
}
