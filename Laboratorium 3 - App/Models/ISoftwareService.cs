namespace Laboratorium_3___App.Models
{
    public interface ISoftwareService
    {
        int Add(Software software);
        void Delete(int id);
        void Update(Software software);

        List<Software> FindAll();
        Software? FindById(int id);
    }
}
