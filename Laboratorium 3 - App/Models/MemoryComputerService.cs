namespace Laboratorium_3___App.Models
{
    public class MemoryComputerService : IComputerService
    {
        private Dictionary<int, Computer> _computers = new Dictionary<int, Computer>();
       
        public int Add(Computer computer)
        {
            int id = _computers.Keys.Count != 0 ? _computers.Keys.Max() : 0;
            computer.Id = id + 1;
            _computers.Add(computer.Id, computer);
            return computer.Id;
        }

        public void Delete(int id)
        {
            _computers.Remove(id);
        }

        public List<Computer> FindAll()
        {
            return _computers.Values.ToList();
        }

        public Computer? FindById(int id)
        {
            return _computers[id];
        }

        public void Update(Computer computer)
        {
            _computers[computer.Id] = computer;
        }
    }
}
