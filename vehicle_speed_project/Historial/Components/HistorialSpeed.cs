using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vehicle_speed_project.Historial.Components
{
    public partial class HistorialSpeed : Form
    {
        DataTable tableHistorial;

        public HistorialSpeed()
        {
            InitializeComponent();
            dataGridView1.DataSource = createColumnDataGridView("historial");
            tableHistorial = createColumnDataGridView("historial");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            
            dataGridView1.RowTemplate.Height = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.AllowUserToAddRows = false;
        }

        public void addData(
            string datatime,
            string path,
            string plate,
            string model,
            string mark,
            string category,
            string speed,
            string statePlate
            )
        {

            DataRow dtRow = tableHistorial.NewRow();

            Image image = Image.FromFile(path, true);

            dtRow["Fecha y Hora"] = datatime;
            dtRow["Vehículo"] = image;
            dtRow["Placa"] = plate;
            dtRow["Modelo"] = model;
            dtRow["Marca"] = mark;
            dtRow["Categoría"] = category;
            dtRow["Velocidad"] = speed;
            dtRow["Estado de placa"] = statePlate;

            tableHistorial.Rows.Add(dtRow);
            dataGridView1.DataSource = tableHistorial;
        }

        private DataTable createColumnDataGridView(string nameTable)
        {
            DataTable dataTable = new DataTable(nameTable);
            DataColumn dtColumn;

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Fecha y Hora";
            dtColumn.Caption = "datatime";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Image);
            dtColumn.ColumnName = "Vehículo";
            dtColumn.Caption = "vehicle";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Placa";
            dtColumn.Caption = "plate";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Modelo";
            dtColumn.Caption = "model";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Marca";
            dtColumn.Caption = "mark";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Categoría";
            dtColumn.Caption = "category";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Velocidad";
            dtColumn.Caption = "speed";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Estado de placa";
            dtColumn.Caption = "statePlate";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            dataTable.Columns.Add(dtColumn);

            return dataTable;
        }
    }
}
