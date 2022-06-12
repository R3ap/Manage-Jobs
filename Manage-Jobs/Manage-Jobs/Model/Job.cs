using Manage_Jobs.Enums;
using System.ComponentModel.DataAnnotations;

namespace Manage_Jobs.Model {
    public class Job {
        [Key]
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Plz { get; set; }
        public string Street { get; set; }
        public string Location { get; set; }
        public DateTime JobDate { get; set; }
        public Status Status { get; set; }
        public JobType JobType { get; set; }
        public bool IsTemplateJob { get; set; }
        public string Description { get; set; }
    }
}
