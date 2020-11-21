using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV.BLL;
using QLTV.DTO;
using Microsoft.Reporting.WinForms;

namespace QLTV.Reports
{
    public partial class frmTraSach : UserControl
    {
        TraSach_BLL tsBUS = new TraSach_BLL();

        public frmTraSach()
        {
            InitializeComponent();
        }

        
    }
}
