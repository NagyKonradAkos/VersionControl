using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excelke = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace Excel
{
    public partial class Form1 : Form
    {
        RealEstateEntities context = new RealEstateEntities();
        List<Flat> Flats;
        Excelke.Application xlApp;
        Excelke.Workbook xlWB;
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            Flats = context.Flats.ToList();
        }
    }
}
