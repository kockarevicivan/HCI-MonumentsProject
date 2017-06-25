using HCI.MonumentsProject.Commons;
using HCI.MonumentsProject.Domain.Factories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HCI.MonumentsProject.Domain.Entities
{
    [Serializable]
    public class UnitOfWork
    {
        private static UnitOfWork _instance;
        private Serializer _serializer;
        internal List<Observer> _observers;

        private UnitOfWork()
        {
            _serializer = new Serializer();

            _observers = new List<Observer>();

            Monuments = _serializer.DeSerializeObject<List<Monument>>("monuments.bin");
            MonumentTypes = _serializer.DeSerializeObject<List<MonumentType>>("monument_types.bin");
            Positions = _serializer.DeSerializeObject<List<Position>>("positions.bin");
            Tags = _serializer.DeSerializeObject<List<Tag>>("tags.bin");
            MonumentTags = _serializer.DeSerializeObject<List<MonumentTag>>("monument_tags.bin");

            //Monuments = new MonumentFactory().Create();
            //MonumentTypes = new MonumentTypeFactory().Create();
            //Positions = new PositionFactory().Create();
            //Tags = new TagFactory().Create();
            //MonumentTags = new MonumentTagFactory().Create();

            InitializeCustomFields();

            Attach(new FileObserver(this));
        }

        public List<Monument> Monuments { get; set; }
        public List<MonumentType> MonumentTypes { get; set; }
        public List<Position> Positions { get; set; }
        public List<Tag> Tags { get; set; }
        public List<MonumentTag> MonumentTags { get; set; }

        public static UnitOfWork GetInstance()
        {
            return _instance = _instance == null ? new UnitOfWork() : _instance;
        }

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            //_serializer.SerializeObject(Monuments, "monuments.bin");
            //_serializer.SerializeObject(MonumentTypes, "monument_types.bin");
            //_serializer.SerializeObject(Positions, "positions.bin");
            //_serializer.SerializeObject(Tags, "tags.bin");
            //_serializer.SerializeObject(MonumentTags, "monument_tags.bin");

            foreach (var o in _observers)
            {
                o.Update();
            }

            _instance = new UnitOfWork();
        }

        private void InitializeCustomFields()
        {
            foreach (var m in Monuments)
            {
                m.MonumentType = MonumentTypes.Where(mt => mt.Id == m.MonumentTypeId).FirstOrDefault();
                m.Tags = Tags.Where(t =>
                    MonumentTags
                    .Where(mt => mt.MonumentId == m.Id)
                    .Select(mt => mt.TagId)
                    .Contains(t.Id))
                    .ToList();
            }

            foreach (var p in Positions)
            {
                p.Monument = Monuments.Where(m => m.Id == p.MonumentId).FirstOrDefault();
            }
        }
    }
}
