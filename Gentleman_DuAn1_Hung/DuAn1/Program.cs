using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<<< HEAD:Gentleman_DuAn1_Hieu/QLThuVien/Program.cs
<<<<<<<< HEAD:FormDangNhap/FormDangNhap/Program.cs
namespace FormDangNhap
========
namespace QLThuVien
>>>>>>>> remotes/origin/hieu:Gentleman_DuAn1_Hieu/QLThuVien/Program.cs
========
namespace DuAn1
>>>>>>>> remotes/origin/hung:Gentleman_DuAn1_Hung/DuAn1/Program.cs
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<<< HEAD:Gentleman_DuAn1_Hieu/QLThuVien/Program.cs
<<<<<<<< HEAD:FormDangNhap/FormDangNhap/Program.cs
            Application.Run(new Form3());
========
            Application.Run(new QLNhanVien());
>>>>>>>> remotes/origin/hieu:Gentleman_DuAn1_Hieu/QLThuVien/Program.cs
========
            Application.Run(new Sach());
>>>>>>>> remotes/origin/hung:Gentleman_DuAn1_Hung/DuAn1/Program.cs
        }
    }
}
