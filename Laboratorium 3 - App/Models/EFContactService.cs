using Data.Entities;
using Data;
using Laboratorium_3___App.Mappers;

namespace Laboratorium_3___App.Models
{
    public class EFContactService : IContactService
    {
        private AppDbContext _context;

        public EFContactService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Contact contact)
        {
            var e = _context.Contacts.Add(ContactMapper.ToEntity(contact));
            _context.SaveChanges();
            return e.Entity.Id;
        }

        public void Delete(int id)
        {
            //ContactEntity? find = _context.Contacts.Find(id);
            //if (find != null)
            //{
            //    _context.Contacts.Remove(find);
            //}
            var find = _context.Contacts.Find(id);
            if (find is not null)
            {
                _context.Contacts.Remove(find);
                _context.SaveChanges();
            }
        }

        public List<Contact> FindAll()
        {
            return _context.Contacts.Select(e => ContactMapper.FromEntity(e)).ToList(); ;
        }

        public List<OrganizationEntity> FindAllOrganizations()
        {
           return _context.Organizations.ToList();

        }

        public Contact? FindById(int id)
        {
            return ContactMapper.FromEntity(_context.Contacts.Find(id));
        }

        public void Update(Contact contact)
        {
            _context.Contacts.Update(ContactMapper.ToEntity(contact));
        }
        public PagingList<Contact> FindPage(int page, int size)
        {
            return PagingList<Contact>.Create(
                (p, s) =>
                    _context.Contacts
                    .OrderBy(c => c.Name)
                    .Skip((p - 1) * s)
                    .Take(s)
                    .Select(ContactMapper.FromEntity)
                    .ToList()
                ,
                page,
                size,
                _context.Contacts.Count()
                );
        }

    }
}
