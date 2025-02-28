using TDSPK.Domain;
using TDSPK.Domain.Enums;

namespace TDSPK.Persistence
{
    public class User : Audictor
    {
        public int Id { get; private set; }
        public string Name { get; set; }
    }
}
