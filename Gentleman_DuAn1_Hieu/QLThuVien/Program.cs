using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<<< HEAD:FormDangNhap/FormDangNhap/Program.cs
namespace FormDangNhap
========
namespace QLThuVien
>>>>>>>> remotes/origin/hieu:Gentleman_DuAn1_Hieu/QLThuVien/Program.cs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<<< HEAD:FormDangNhap/FormDangNhap/Program.cs
            Application.Run(new Form3());
========
            Application.Run(new QLNhanVien());
>>>>>>>> remotes/origin/hieu:Gentleman_DuAn1_Hieu/QLThuVien/Program.cs
        }
    }
}
