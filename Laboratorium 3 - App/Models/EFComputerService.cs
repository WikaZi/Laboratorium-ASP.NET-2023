using Data.Entities;
using Data;
using Laboratorium_3___App.Mappers;

namespace Laboratorium_3___App.Models
{
    public class EFComputerService : IComputerService
    {
        private AppDbC _context;

        public EFComputerService(AppDbC context)
        {
            _context = context;
        }

        public int Add(Computer computer)
        {
            var e = _context.Computers.Add(ComputerMapper.ToEntity(computer));
            _context.SaveChanges();
            return e.Entity.Id;
        }

        public void Delete(int id)
        {
            ComputerEntity? find = _context.Computers.Find(id);
            if (find != null)
            {
                _context.Computers.Remove(find);
            }
        }

        public List<Computer> FindAll()
        {
            return _context.Computers.Select(e => ComputerMapper.FromEntity(e)).ToList(); ;
        }

        public Computer? FindById(int id)
        {
            return ComputerMapper.FromEntity(_context.Computers.Find(id));
        }

        public void Update(Computer computer)
        {
            _context.Computers.Update(ComputerMapper.ToEntity(computer));
            _context.SaveChanges();
        }
    }
}
