using DehasoftOne.Business.Customers;
using DehasoftOne.Business.Users;
using DehasoftOne.Entity.Customer;
using DehasoftOne.Entity.Users;

namespace DehasoftOne.Winforms
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;
        private readonly IServiceProvider _serviceProvider;
        public LoginForm(IUserService userService,IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userService=userService;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            User result=await _userService.Authenticate(tbUsername.Text, tbPassword.Text);
            if (result!=null)
            {
                MainForm mainForm = new MainForm(result,_serviceProvider);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await _userService.AddUser(new User() { Name = "Sami", Username = "admin", Password = "1" });
        }
    }
}
