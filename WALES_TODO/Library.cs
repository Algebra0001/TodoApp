using DataLayer;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Todo_Context;

namespace WALES_TODO
{
    internal class Library
    {
        public static async Task<DataTable> GetAllDataFromDataBaseAsync()
        {
            try
            {
                using var context = new TodoContextLayer();
                var loadTodo = await context.Todo.ToListAsync();
                DataTable dataTable = new();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Task", typeof(string));
                dataTable.Columns.Add("DueDate", typeof(DateTime));
                dataTable.Columns.Add("IsDone", typeof(bool));


                foreach (var todo in loadTodo)
                {
                    dataTable.Rows.Add(todo.Id, todo.TASK, todo.DueDate, todo.IsDone);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new DataTable();
            }
        }


        public static async Task<DataTable> LoadSearchByTextDataFromDBAsync(string searchText)
        {
            try
            {
                using var db = new TodoContextLayer();
                var loadTodo = await db.Todo.Where(key => key.TASK.Contains(searchText)).ToListAsync();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Task", typeof(string));
                dataTable.Columns.Add("DueDate", typeof(DateTime));
                dataTable.Columns.Add("IsDone", typeof(bool));
                foreach (var todo in loadTodo)
                {
                    dataTable.Rows.Add(todo.Id, todo.TASK, todo.DueDate, todo.IsDone);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new DataTable();
            }
        }


        public static async Task<int> AddTask(Todo MyTask)
        {
            try
            {
                using var context = new TodoContextLayer();
                if (string.IsNullOrWhiteSpace(MyTask.TASK))
                {
                    throw new Exception("Task name cannot be empty or whitespace.");
                }
                if (Regex.IsMatch(MyTask.TASK, @"\d"))
                {
                    throw new Exception("Task name cannot contain digits.");
                }
                var AddTaskToDb = await context.AddAsync(MyTask);
                int output = await context.SaveChangesAsync();
                MessageBox.Show("Task successfully added!");
                return output;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return default;
            }
        }

        public static async Task DeleteTask(List<int> ids)
        {
            try
            {
                if (ids == null || ids.Count == 0)
                {
                    throw new Exception("You must select at least one task to delete.");
                }

                using (var context = new TodoContextLayer())
                {
                    foreach (var id in ids)
                    {
                        var todoItem = await context.Todo.FindAsync(id);
                        if (todoItem == null)
                        {
                            continue;
                        }
                        context.Todo.Remove(todoItem);
                    }
                    await context.SaveChangesAsync();
                }

                MessageBox.Show(@"
Tasks successfully deleted.,
refresh to see the updates!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static async Task<int> UpdateToDB(Todo myTask)
        {

            try
            {
                using (var context = new TodoContextLayer())
                {
                    context.Entry(myTask).State = EntityState.Modified;
                    int result = await context.SaveChangesAsync();
                    return result;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
    }
}
