namespace Laboratorium_3___App.Models
{
    public class CurrentDateTimeProviderServices : IDateTimeProvider
    {
        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }
}
