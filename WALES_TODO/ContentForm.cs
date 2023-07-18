using DataLayer;
using Microsoft.VisualBasic;
using System.Data;
using System.Windows.Forms;

namespace WALES_TODO
{
    public partial class ContentForm : Form
    {
        public ContentForm()
        {
            InitializeComponent();
            BindData();
        }


        public async void BindData()
        {
            DataTable dataTable = await Library.GetAllDataFromDataBaseAsync();
            DataSpace.DataSource = dataTable;
        }

        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            DataTable dataTable = await Library.LoadSearchByTextDataFromDBAsync(TextToSearch.Text);
            DataSpace.DataSource = dataTable;
        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            var task = TaskText.Text;
            var dates = dateTime.Value;
            var status = statusbox.Checked;


            var todo = new Todo()
            {
                TASK = task,
                DueDate = dates,
                IsDone = status,
            };

            if(task != null)
            {
                var success = await Library.AddTask(todo);
                if(success > 0)
                    TaskText.Clear();
                statusbox.Checked = false;
            }
            BindData();
        }

        // When the user clicks the Delete button, get the list of selected task IDs and pass them to the DeleteTasks method
        private async void DelBtn_Click(object sender, EventArgs e)
        {
            List<int> selectedIds = new List<int>();
            foreach (DataGridViewRow row in DataSpace.Rows)
            {
                bool isDone = Convert.ToBoolean(row.Cells["IsDone"].Value);
                if (isDone)
                {
                    int id = Convert.ToInt32(row.Cells["Id"].Value);
                    selectedIds.Add(id);
                }
            }

            if (selectedIds.Count == 0)
            {
                MessageBox.Show("You must select at least one task to delete.");
                return;
            }

            await Library.DeleteTask(selectedIds);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var editForm = new EditForm((int)DataSpace.CurrentRow.Cells["Id"].Value, (string)DataSpace.CurrentRow.Cells["Task"].Value, (DateTime)DataSpace.CurrentRow.Cells["DueDate"].Value, (bool)DataSpace.CurrentRow.Cells["IsDone"].Value); 
            editForm.ShowDialog();
        }

        private async void RefreshBtn_Click(object sender, EventArgs e)
        {
            DataTable dataTable = await Library.GetAllDataFromDataBaseAsync();
            DataSpace.DataSource = dataTable;

        }
    }
}