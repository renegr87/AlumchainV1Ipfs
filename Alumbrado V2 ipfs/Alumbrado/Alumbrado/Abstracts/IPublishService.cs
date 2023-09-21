using Alumbrado.Models;

namespace Alumbrado.Abstracts
{
    public interface IPublishService
    {
        public Reading[] LoadReadings(string source);

        public bool ValidateReadings(Reading[] readings);
    }
}
