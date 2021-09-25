using UTNAvanzada2.Common.Models;

namespace UTN_Students.Models.Models
{
    public class JobPosition : Entity
    {
        public int JobPositionId { get; set; }
        public int CareerId { get; set; }
        public string Description { get; set; }

        public override int GetId()
        {
            return this.JobPositionId;
        }

        public override void SetId(int jobPositionId)
        {
            this.JobPositionId = jobPositionId;
        }
    }
}
