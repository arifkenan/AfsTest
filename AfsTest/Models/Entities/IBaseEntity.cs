namespace AfsTest.Models.Entities
{


    public enum Status
    {
        Active = 1,
        Modified = 2,
        Delete = 3
    }

    public interface IBaseEntity
    {
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }
    }
}
