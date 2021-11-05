using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemas_operativos
{
    public partial class frmSO : Form
    {
        public frmSO()
        {
            InitializeComponent();
        }
        public static string GetOSFriendlyName()
        {
            string result = string.Empty;
            var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                        select x.GetPropertyValue("Caption")).FirstOrDefault();
            return name != null ? name.ToString() : "Unknown";
        }
        private void frmSO_Load(object sender, EventArgs e)
        {



        }

        private void informacionDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpwindows.Visible = true;
            lblWindows.Text = GetOSFriendlyName();
            lblVWindows.Text = "System.Environment.OSVersion:\n\n" + System.Environment.OSVersion.ToString();
            label1.Text = "Version del sistema operativo";

        }

        private void pausarUnProcesoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarVersion_Click(object sender, EventArgs e)
        {
            grpwindows.Visible = false;
        }

        private void btnAceptHardware_Click(object sender, EventArgs e)
        {
            grpHardware.Visible = false;
        }
        public void Hardware()
        {
            ManagementScope scope = new ManagementScope("\\root\\cimv2");
            //Crear un objeto para consultar una tabla del namespace
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_LogicalDisk where drivetype=3");
            //Ejecutar el query
            ManagementObjectSearcher mos = new ManagementObjectSearcher(scope, query);

            //Iterar en los resultados del query
            foreach (ManagementObject item in mos.Get())
            {
                long hddSizeBytes = Int64.Parse(item["Size"].ToString());
                double hddSizeGBytes = hddSizeBytes / 1024 / 1024 / 1024;
                lvHardware.Items.Add("Tamaño = " + hddSizeGBytes + "Gb");
            }
            String path = "HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0";
            RegistryKey key = Registry.LocalMachine.OpenSubKey(path);
            String processor = key.GetValue("ProcessorNameString").ToString();
            lvHardware.Items.Add("Procesador=" + processor);
        }
        private void hardwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hardware();
            grpHardware.Visible = true;

        }

        private void btnAceptarSoftware_Click(object sender, EventArgs e)
        {
            grpSoftware.Visible = false;
        }

        public void Software()
        {
            label1.Text = "Aplicaciones Instaladas";

            ManagementObjectSearcher objColProducts = new ManagementObjectSearcher("SELECT * FROM Win32_Product");

            // Recorremos los elementos obtenidos mostrándolos en la consola
            foreach (ManagementObject objProduct in objColProducts.Get())
            {

                lvSoftware.Items.Add(objProduct["Name"].ToString());
            }
        }
        private void softwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Software();
            grpSoftware.Visible = true;

        }

        private void btnAceptarSoftwares_Click(object sender, EventArgs e)
        {
            grpSoftware.Visible = false;
        }

        private void lblProcesos_Click(object sender, EventArgs e)
        {

        }
        public void procesos()
        {
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_Process");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                lbxProcesos.Items.Add(queryObj["Caption"].ToString());
            }
        }
        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            procesos();
            grpProcesos.Visible = true;
        }

        private void BtnAceptarProcesos_Click(object sender, EventArgs e)
        {
            grpProcesos.Visible = false;
        }
        public void monitoreo()
        {
            PerformanceCounter cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";
            int count = 0;
            while (count != 10)
            {
                count++;
                lvMonitoreo.Items.Add(cpuCounter.NextValue() + "%");
                Thread.Sleep(1000);
            }
        }
        private void monitoreoDeRecursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpMonitoreo.Visible = true;
            monitoreo();
        }

        private void btnAceptarMonitoreo_Click(object sender, EventArgs e)
        {
            grpMonitoreo.Visible = false;
        }

        private void redesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAceptarRedes.Visible = true;
            label1.Text = "Redes en mi area";
            ListView lvRed = new ListView();
            lvRed.Bounds = new Rectangle(new Point(100, 100), new Size(600, 200));

            // Set the view to show details.
            lvRed.View = View.List;

            this.Controls.Add(lvRed);
            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();

            IPEndPoint[] endPoints = ipProperties.GetActiveTcpListeners();
            TcpConnectionInformation[] tcpConnections = ipProperties.GetActiveTcpConnections();

            foreach (TcpConnectionInformation info in tcpConnections)
            {
                lvRed.Items.Add("Local : " + info.LocalEndPoint.Address.ToString()
                + ":" + info.LocalEndPoint.Port.ToString()
                + "\nRemote : " + info.RemoteEndPoint.Address.ToString()
                + ":" + info.RemoteEndPoint.Port.ToString()
                + "\nState : " + info.State.ToString() + "\n\n");
                Thread.Sleep(100);
            }


        }

        private void concurrenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpConcurrencia.Visible = true;
        }

        private void btnAceptarConcurrencia_Click(object sender, EventArgs e)
        {
            grpConcurrencia.Visible = false;
        }

        private async Task addlv(String platillo,int noPlatillo,String bebida,int noBebida)
        {
            String res =await prepareAsync(platillo, Convert.ToString(noPlatillo));
            lvOrdenes.Items.Add(res);
            
             String res1 =await prepareAsync(bebida, Convert.ToString(noBebida));
            lvOrdenes.Items.Add(res1);
            /*
            var res = new Task[1];
            Task.WaitAll(res);
            */
        }
        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            String platillo = cbxMenu.Text;
            String bebida = cbxBebida.Text;
            int noPlatillo = Convert.ToInt32(txtCantidadPlatillo.Text);
            int noBebida = Convert.ToInt32(txtCantidadBebida.Text);
            if (noPlatillo > 0 || noBebida > 0)
            {

                addlv(platillo, noPlatillo,bebida,noBebida);
              
            }
            else
            {
                lblNotificationOrden.Text = "no puede generar orden";
            }

        }

        
       
        static async Task<String> prepareAsync(string cocinar, String tiempo)
        {
          int  tiemp = Convert.ToInt32(tiempo);
            await Task.Delay( tiemp*1000);
            String ar = cocinar + " Tiempo en se tardo en minutos" + tiempo;
            
            return ar;
        }
    }
}
