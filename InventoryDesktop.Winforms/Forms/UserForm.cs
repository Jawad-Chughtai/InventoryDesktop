using InventoryDesktop.Applications.Users;
using InventoryDesktop.EntityFramework.Users;
using InventoryDesktop.Winforms.Enums;

namespace InventoryDesktop.Winforms.Forms
{
    public partial class UserForm : Form
    {
        private readonly UserService _userService = new();
        private User? _user = null;
        MainForm? _mainForm = null;

        public UserForm()
        {
            InitializeComponent();
        }

        private async void UserForm_Load(object sender, EventArgs e)
        {
            loginWithUser.Visible = false;
            fnameTextbox.Select();
            await GetListAsync();
            InitRoles();

            _mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (_mainForm != null && _mainForm._loggedInUser.Role.Contains(UserRoles.SuperAdmin))
            {
                loginWithUser.Visible = true;
            }
        }

        private void InitDataGridView()
        {
            datagrid.AutoGenerateColumns = false;
            datagrid.Columns.Clear();

            datagrid.Columns.Add("id", "Id");
            datagrid.Columns.Add("name", "Full Name");
            datagrid.Columns.Add("username", "Username");
            datagrid.Columns.Add("role", "Role");
            datagrid.Columns.Add("creationtime", "Creation Time");

            datagrid.Columns["id"].DataPropertyName = "Id";
            datagrid.Columns["name"].DataPropertyName = "FullName";
            datagrid.Columns["username"].DataPropertyName = "Username";
            datagrid.Columns["role"].DataPropertyName = "Role";
            datagrid.Columns["creationtime"].DataPropertyName = "CreationTimeString";

            datagrid.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid.Columns["creationtime"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid.Columns["creationtime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid.Columns["id"].Width = 100;
            datagrid.CurrentCell = null;
        }

        private void InitRoles()
        {
            List<string> roles = new()
            {
                UserRoles.Admin,
                UserRoles.User
            };

            roleCombobox.DataSource = roles;
            roleCombobox.SelectedItem = UserRoles.User;
        }

        private async Task GetListAsync()
        {
            var data = await _userService.GetListAsync();
            datagrid.DataSource = data;
            InitDataGridView();
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidForm())
                {
                    return;
                }
                if (saveButton.Text == SaveButtonText.Save)
                {
                    _user = new User
                    {
                        FirstName = fnameTextbox.Text,
                        LastName = lnameTextbox.Text,
                        Username = usernameTextbox.Text,
                        Password = passwordTextbox.Text,
                        Role = roleCombobox.SelectedItem.ToString()
                    };

                    await _userService.CreateAsync(_user);

                }
                else
                {
                    var id = _user.Id;
                    _user = new User
                    {
                        Id = id,
                        FirstName = fnameTextbox.Text,
                        LastName = lnameTextbox.Text,
                        Username = usernameTextbox.Text,
                        Password = passwordTextbox.Text,
                        Role = roleCombobox.SelectedItem.ToString()
                    };

                    var updatedUser = await _userService.UpdateAsync(_user);

                    _mainForm?.SetUpUser(updatedUser);
                }

                ResetForm();
                await GetListAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _user = null;
            }
        }

        private bool IsValidForm()
        {
            ResetErrorLabels();

            if (string.IsNullOrWhiteSpace(fnameTextbox.Text))
            {
                fnameErrorLabel.Visible = true;
                return false;
            }
            else if (string.IsNullOrWhiteSpace(lnameTextbox.Text))
            {
                lnameErrorLabel.Visible = true;
                return false;
            }
            else if (string.IsNullOrWhiteSpace(usernameTextbox.Text))
            {
                usernameErrorLabel.Visible = true;
                return false;
            }
            else if (string.IsNullOrWhiteSpace(passwordTextbox.Text))
            {
                passwordErrorLabel.Visible = true;
                return false;
            }
            else if (string.IsNullOrWhiteSpace(roleCombobox.SelectedItem.ToString()))
            {
                roleErrorLabel.Visible = true;
                return false;
            }
            else return true;
        }

        private void ResetErrorLabels()
        {
            fnameErrorLabel.Visible = false;
            lnameErrorLabel.Visible = false;
            usernameErrorLabel.Visible = false;
            passwordErrorLabel.Visible = false;
            roleErrorLabel.Visible = false;
        }

        private void ResetForm()
        {
            _user = null;

            fnameTextbox.Text = null;
            lnameTextbox.Text = null;
            usernameTextbox.Text = null;
            passwordTextbox.Text = null;
            roleCombobox.SelectedItem = UserRoles.User;

            saveButton.Text = SaveButtonText.Save;
            ResetErrorLabels();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedCells.Count > 0)
            {
                await SetSelectedUser();
                fnameTextbox.Text = _user.FirstName;
                lnameTextbox.Text = _user.LastName;
                usernameTextbox.Text = _user.Username;
                passwordTextbox.Text = _user.Password;
                roleCombobox.SelectedItem = _user.Role;

                saveButton.Text = SaveButtonText.Update;
            }
        }

        private async Task SetSelectedUser()
        {
            try
            {
                int rowIndex = datagrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = datagrid.Rows[rowIndex];
                datagrid.CurrentCell = null;

                _user = await _userService.GetAsync((int)selectedRow.Cells["id"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (datagrid.SelectedCells.Count > 0)
                {
                    await SetSelectedUser();
                    if (MessageBox.Show($"Are you sure you want to delete {_user?.FullName}", "Confirm Deletion",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        await _userService.DeleteAsync(_user.Id);
                        await GetListAsync();
                    }
                    else
                    {
                        _user = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void LoginWithUser_Click(object sender, EventArgs e)
        {
            try
            {
                _mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                if (_mainForm != null && _mainForm._loggedInUser.Role.Contains(UserRoles.SuperAdmin))
                {
                    if (datagrid.SelectedCells.Count > 0)
                    {
                        int rowIndex = datagrid.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = datagrid.Rows[rowIndex];
                        datagrid.CurrentCell = null;

                        _user = await _userService.GetAsync((int)selectedRow.Cells["id"].Value);
                        _mainForm.IsSuperAdmin = true;
                        _mainForm.SetUpUser(_user);
                        UserForm_Load(sender, e);
                    }
                }
            }
            catch
            {
                Application.Restart();
            }
        }
    }
}
