using Data;
using Data.Entities;
using Laboratorium_3___App.Mappers;

namespace Laboratorium_3___App.Models
{
    public class EFSoftwareService : ISoftwareService
    {
        private AppDbC _context;

        public EFSoftwareService(AppDbC context)
        {
            _context = context;
        }
        public int Add(Software software)
        {
            var c = _context.Softwares.Add(SoftwareMapper.ToEntity(software));
            _context.SaveChanges();
            return c.Entity.Id;
        }

        public void Delete(int id)
        {
            SoftwareEntity? find = _context.Softwares.Find(id);
            if (find != null)
            {
                _context.Softwares.Remove(find);
                _context.SaveChanges();
            }
        }

        public List<Software> FindAll()
        {
            return _context.Softwares.Select(c => SoftwareMapper.FromEntity(c)).ToList(); ;
        }

        public Software? FindById(int id)
        {
            return SoftwareMapper.FromEntity(_context.Softwares.Find(id));
        }

        public void Update(Software software)
        {
            _context.Softwares.Update(SoftwareMapper.ToEntity(software));
            _context.SaveChanges();
        }
    }
}
