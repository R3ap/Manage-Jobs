using Manage_Jobs.Model;

namespace Manage_Jobs.UI.JobOverview {
    public partial class FrmJobOverview : Form, IJobOverview {

        public Action AddJobClicked { get; set; }
        public Action<Job> EditJobClicked { get; set; }
        public Action<Job> DeleteJobClicked { get; set; }
        private List<Job> _jobList { get; set; } 
        public FrmJobOverview() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddJobClicked?.Invoke();
        }

        private void BtnEdit_Click(object sender, EventArgs e) {
            //EditJobClicked.Invoke(_jobList[jobgrid.SelectedRows[0].Index]);
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            //EditJobClicked.Invoke(_jobList[jobgrid.SelectedRows[0].Index]);
        }
    }
}