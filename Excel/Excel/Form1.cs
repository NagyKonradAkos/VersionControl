﻿using System;
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
        Excelke.Worksheet xlSheet;
        public Form1()
        {
            InitializeComponent();
            LoadData();
            CreateExcel();
        }

        void LoadData()
        {
            Flats = context.Flats.ToList();
        }

        void CreateTable()
        {
            string[] headers = new string[]
            {
                "Kód",
                "Eladó",
                "Oldal",
                "Kerültet",
                "Lift",
                "Szobák száma",
                "Alapterület (m2)",
                "Ár (mft)",
                "Négyzetméterár (Ft/m2)"


            };
            for (int i = 0; i < headers.Length; i++)
            {
                xlSheet.Cells[i + 1, 1] = headers[i];
            };

            object[,] values = new object[Flats.Count, headers.Length];
        }

        void CreateExcel()
        {
            try
            {
                xlApp = new Excelke.Application();

                xlWB = xlApp.Workbooks.Add(Missing.Value);

                xlSheet = xlWB.ActiveSheet;
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }
    }
}
