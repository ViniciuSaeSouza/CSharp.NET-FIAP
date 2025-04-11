using TDSPK.Domain;
using TDSPK.Domain.Enums;

namespace TDSPK.Infrastructure.Persistence
{
    public class User : Audictor
    {

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        private readonly List<Photo> _photos = new();
        public IReadOnlyCollection<Photo> Photos => _photos.AsReadOnly();
        public User(string name)
        {
            Id = Guid.NewGuid();
            Name = name ?? throw new Exception("Nome não pode ser vazio!");
        }

        public void AddPhoto(string url, Guid id)
        {
            var photo = Photo.Create(url, id);

            _photos.Add(photo);
        }
    }
}
