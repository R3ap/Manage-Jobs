using Manage_Jobs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Jobs.UI.JobOverview {
    interface IJobOverview {
        Action AddJobClicked { get; set; }
        Action<Job> EditJobClicked { get; set; }
        Action<Job> DeleteJobClicked { get; set; }
    }
}
