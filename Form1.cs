using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laboratorio_1___repaso
{
    public partial class Form1 : Form
    {
        readonly string[] Months = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

        const string baseEmployeeInf = "Lista de empleados y su información:", baseEmployeeMonthInf = "Información de los empleados; horas trabajadas por mes:";
        List<EmployeeSalary> EmployeesList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void cbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbEmployeeSalary.Text = "Sueldo del empleado: Q" + EmployeesList[cbEmpleados.SelectedIndex].TotalSalary.ToString();
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            /*CARGA LOS ARCHIVOS .emp Y .memp PARA SER LEÍDOS Y SI  NO EXISTEN LOS CREA*/
            /*HE DECIDIDO ESTABLECER UNA EXTENSIÓN PROPIA PARA ESTOS ARCHIVOS YA QUE CON LA EXTENSIÓN TÍPICA .txt*/
            /*PUEDEN HABER CAMBIOS EN EL FORMATO POR PARTE DEL USUARIO*/
            FileStream stream1, stream2;
            EmployeesList = new List<EmployeeSalary>();

            try
            {
                stream1 = new FileStream("EmpleadosInf.emp", FileMode.Open, FileAccess.Read);
                using(StreamReader archive = new StreamReader(stream1))
                {
                    while(!archive.EndOfStream)
                    {
                        string str = archive.ReadLine();
                       
                        if(!str.Contains(baseEmployeeInf) && str != "")
                        {
                            //MessageBox.Show("str = " + str);
                            string[] data = str.Split('-');
                            List<string> values = new List<string>();
                            foreach(string s in data)
                            {
                                string res = s;
                                res = s[0] == ' ' ? s.Remove(0, 1) : s;
                                res = res[res.Length - 1] == ' ' ? res.Remove(res.Length - 1, 1) : res;
                                values.Add(res);
                                //MessageBox.Show("[" + res + "]");
                            }
                            EmployeesList.Add(new EmployeeSalary(Convert.ToInt32(values[0]), values[1], Convert.ToDouble(values[2])));
                        }
                    }
                }

                MessageBox.Show("Datos del empleado leidos correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("No existe el archivo de los datos del empleado. A continuación se creará uno nuevo", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

                FileStream stream = new FileStream("EmpleadosInf.emp", FileMode.Create, FileAccess.Write);
                using(StreamWriter archive = new StreamWriter(stream))
                {
                    archive.WriteLine(baseEmployeeInf + "\n");
                }
            }

            try
            {
                stream2 = new FileStream("EmpleadosInfMes.memp", FileMode.Open, FileAccess.Read);

                using (StreamReader archive = new StreamReader(stream2))
                {
                    int cont = 0;
                    while (!archive.EndOfStream)
                    {
                        string str = archive.ReadLine();

                        if (!str.Contains(baseEmployeeMonthInf) && str != "")
                        {
                            //MessageBox.Show("str = " + str);
                            string[] data = str.Split('-');
                            List<string> values = new List<string>();
                            foreach (string s in data)
                            {
                                string res = s;
                                res = s[0] == ' ' ? s.Remove(0, 1) : s;
                                res = res[res.Length - 1] == ' ' ? res.Remove(res.Length - 1, 1) : res;
                                values.Add(res);
                                //MessageBox.Show("[" + res + "]");
                            }
                            EmployeesList[cont].HoursOfMonth = Convert.ToInt32(values[1]);
                            EmployeesList[cont].WorkedMonth = Convert.ToSByte(values[2]);
                            EmployeesList[cont].TotalSalary = EmployeesList[cont].HourlyWage * EmployeesList[cont].HoursOfMonth;
                            cont++;
                        }
                    }
                }

                MessageBox.Show("Datos del mes del empleado leidos correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("err: " + ex);
                MessageBox.Show("No existe el archivo de información del mes del empleado. A continuación se creará uno nuevo", "No existe archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                FileStream stream = new FileStream("EmpleadosInfMes.memp", FileMode.Create, FileAccess.Write);
                using (StreamWriter archive = new StreamWriter(stream))
                {
                    archive.WriteLine(baseEmployeeMonthInf + "\n");
                }
            }

            if(cbEmpleados.Items.Count >= 1) cbEmpleados.Items.Clear();
            if (dgvEmployeeInf.Rows.Count >= 1) dgvEmployeeInf.Rows.Clear();
            if (dgvEmployeeMonthInf.Rows.Count >= 1) dgvEmployeeMonthInf.Rows.Clear();

            /*CARGANDO LOS DATOS AL FORMULARIO*/
            foreach (EmployeeSalary em in EmployeesList)
            {
                cbEmpleados.Items.Add(em.Name);
                dgvEmployeeInf.Rows.Add(em.Id, em.Name, "Q" + em.HourlyWage);
                dgvEmployeeMonthInf.Rows.Add(em.Id, em.HoursOfMonth, Months[em.WorkedMonth-1], "Q" + em.TotalSalary);
            }
            cbEmpleados.SelectedIndex = 0;
        }
    }
}

