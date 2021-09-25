using UTNAvanzada2.Common.Models;

namespace UTN_Students.Models.Models
{
    public class Career : Entity
    {
        public int CareerId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public override int GetId()
        {
            return this.CareerId;
        }

        public override void SetId(int careerId)
        {
            this.CareerId = careerId;
        }
    }
}
