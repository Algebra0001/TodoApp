using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo_Context;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WALES_TODO
{
    public partial class EditForm : Form
    {
        public int id;
        public EditForm(int id, string Task, DateTime date, bool check)
        {
            InitializeComponent();
            EditText.Text = Task;
            dateTime.Value = date;
            statusBox.Checked = check;
            this.id = id;
        }

        private async void EditForm_Load(object sender, EventArgs e)
        {
            var todo = new Todo()
            {
                TASK = EditText.Text,
                DueDate = dateTime.Value,
                IsDone = statusBox.Checked,
                Id = id,
            };
            await Library.UpdateToDB(todo);
            
        }

        private async void UpdateBtn_Click(object sender, EventArgs e)
        {

            var todo = new Todo()
            {

                TASK = EditText.Text,
                DueDate = dateTime.Value,
                IsDone = statusBox.Checked,
                Id = id,
            };
            await Library.UpdateToDB(todo);
            this.Close();
            
        }
    }
}
