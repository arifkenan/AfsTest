using Microsoft.AspNetCore.Identity;

namespace AfsTest.Models.Entities
{
    public class AppUser:IdentityUser, IBaseEntity
    {
        private DateTime _CreateDate = DateTime.Now;
        public DateTime CreateDate { get => _CreateDate; set => _CreateDate = value; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        private Status _status = Status.Active;

        public Status Status
        {
            get { return _status = Status.Active; }
            set { _status = value; }
        }

       
    }
}
