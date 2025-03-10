using TDSPK.Domain;
using TDSPK.Domain.Enums;

namespace TDSPK.Infrastructure.Persistence
{
    public class User : Audictor
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public bool Status { get; set; }
    }
}
