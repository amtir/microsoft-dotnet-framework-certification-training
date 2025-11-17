using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace question3
{
    public partial class Form1 : Form
    {
            private readonly string _cs =
                ConfigurationManager.ConnectionStrings["EmployeeDb"].ConnectionString;

            public Form1()
            {
                InitializeComponent();

                // wire handlers if not done in designer
                btnCreate.Click += btnCreate_Click;
                btnUpdate.Click += btnUpdate_Click;
                btnDelete.Click += btnDelete_Click;
                btnReset.Click += btnReset_Click;
                dgvEmployees.CellClick += dgvEmployees_CellClick;
                this.Load += Form1_Load;
            }

            // LOAD: read all rows into grid
            private void Form1_Load(object sender, EventArgs e)
            {
                LoadEmployees();
            }

            private void LoadEmployees()
            {
                try
                {
                    using (var con = new SqlConnection(_cs))
                    using (var da = new SqlDataAdapter("SELECT Employee_Id, Name, Location, Mobile_no FROM dbo.employee ORDER BY Employee_Id", con))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        dgvEmployees.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Load failed: " + ex.Message);
                }
            }

            private void btnCreate_Click(object sender, EventArgs e)
            {
                if (!ValidateInputs(requireAll: true)) return;

                try
                {
                    using (var con = new SqlConnection(_cs))
                    using (var cmd = new SqlCommand(
                        @"INSERT INTO dbo.employee (Employee_Id, Name, Location, Mobile_no)
                      VALUES (@id, @name, @loc, @mobile)", con))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(txtEmployeeId.Text.Trim()));
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@loc", txtLocation.Text.Trim());
                        cmd.Parameters.AddWithValue("@mobile", txtMobile.Text.Trim());

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }

                    LoadEmployees();
                    ClearInputs();
                }
                catch (SqlException sx) when (sx.Number == 2627 || sx.Number == 2601) // duplicate key
                {
                    MessageBox.Show("Employee_Id already exists.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Create failed: " + ex.Message);
                }
            }

            private void btnUpdate_Click(object sender, EventArgs e)
            {
                if (!ValidateInputs(requireAll: true)) return;

                try
                {
                    using (var con = new SqlConnection(_cs))
                    using (var cmd = new SqlCommand(
                        @"UPDATE dbo.employee
                      SET Name = @name, Location = @loc, Mobile_no = @mobile
                      WHERE Employee_Id = @id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(txtEmployeeId.Text.Trim()));
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@loc", txtLocation.Text.Trim());
                        cmd.Parameters.AddWithValue("@mobile", txtMobile.Text.Trim());

                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows == 0) MessageBox.Show("No matching Employee_Id to update.");
                    }

                    LoadEmployees();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed: " + ex.Message);
                }
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                if (!int.TryParse(txtEmployeeId.Text.Trim(), out int id))
                {
                    MessageBox.Show("Enter a valid Employee_Id to delete.");
                    return;
                }

                if (MessageBox.Show($"Delete employee {id}?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                try
                {
                    using (var con = new SqlConnection(_cs))
                    using (var cmd = new SqlCommand(
                        "DELETE FROM dbo.employee WHERE Employee_Id = @id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows == 0) MessageBox.Show("No matching Employee_Id to delete.");
                    }

                    LoadEmployees();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete failed: " + ex.Message);
                }
            }

            private void btnReset_Click(object sender, EventArgs e)
            {
                ClearInputs();
                dgvEmployees.ClearSelection();
            }

            // When you click a row, populate textboxes
            private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex < 0) return;
                var row = dgvEmployees.Rows[e.RowIndex];
                txtEmployeeId.Text = row.Cells["Employee_Id"].Value?.ToString();
                txtName.Text = row.Cells["Name"].Value?.ToString();
            txtLocation.Text = row.Cells["Location"].Value?.ToString();
                txtMobile.Text = row.Cells["Mobile_no"].Value?.ToString();
            }

            private bool ValidateInputs(bool requireAll)
            {
                if (!int.TryParse(txtEmployeeId.Text.Trim(), out _))
                {
                    MessageBox.Show("Employee_Id must be a whole number.");
                    txtEmployeeId.Focus();
                    return false;
                }

                if (requireAll)
                {
                    if (string.IsNullOrWhiteSpace(txtName.Text) ||
                        string.IsNullOrWhiteSpace(txtLocation.Text) ||
                        string.IsNullOrWhiteSpace(txtMobile.Text))
                    {
                        MessageBox.Show("Please fill Name, Location and Mobile.");
                        return false;
                    }
                }
                return true;
            }

            private void ClearInputs()
            {
                txtEmployeeId.Clear();
                txtName.Clear();
            txtLocation.Clear();
                txtMobile.Clear();
                txtEmployeeId.Focus();
            }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Not used — safe to leave empty
        }
    }
    }

