using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection; //Excelhez ez a két névtér kell

namespace ExcelExport
{
    public partial class Form1 : Form
    {
        

        RealEstateEntities1 context = new RealEstateEntities1();
        List<Flat> lakasok;
        public Form1()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.DataSource = lakasok;
        }

        public void LoadData()
        {
            lakasok = context.Flats.ToList();
        }
    }
}
