using TDSPK.Domain.Enums;

namespace TDSPK.Domain
{
    public class Audictor
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateModified{ get; set; }
        public UserStatus Status { get; protected set; }

    }
}
