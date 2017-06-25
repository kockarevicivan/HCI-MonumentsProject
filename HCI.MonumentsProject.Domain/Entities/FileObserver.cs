using HCI.MonumentsProject.Commons;

namespace HCI.MonumentsProject.Domain.Entities
{
    public class FileObserver : Observer
    {
        private UnitOfWork _context;
        private Serializer _serializer;

        public FileObserver(UnitOfWork context)
        {
            _serializer = new Serializer();
            _context = context;
        }

        public override void Update()
        {
            _serializer.SerializeObject(_context.Monuments, "monuments.bin");
            _serializer.SerializeObject(_context.MonumentTypes, "monument_types.bin");
            _serializer.SerializeObject(_context.Positions, "positions.bin");
            _serializer.SerializeObject(_context.Tags, "tags.bin");
            _serializer.SerializeObject(_context.MonumentTags, "monument_tags.bin");
        }
    }
}
