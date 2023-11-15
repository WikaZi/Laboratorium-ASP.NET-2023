using Data.Entities;
using Laboratorium_3___App.Models;

namespace Laboratorium_3___App.Mappers
{
    public class ContactMapper
    {
        public static Contact FromEntity(ContactEntity entity)
        {
            return new Contact()
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                Phone = entity.Phone,
                Birth = entity.Birth,
                OrganizationId = entity.OrganizationId,
            };
        }

        public static ContactEntity ToEntity(Contact model)
        {
            return new ContactEntity()
            {
                Id = model.Id,
                Name = model.Name,
                Email = model.Email,
                Phone = model.Phone,
                Birth = model.Birth,
                OrganizationId = model.OrganizationId,
            };
        }
    }
}
