using System;

namespace Slk.Models
{
    public abstract class AppEntity
    {
        public int Id { get; set; }
        public virtual string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public EnumRStates RecordState { get; set; }
    }
}