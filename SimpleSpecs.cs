using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSpecs
{
    public partial class SimpleSpecs : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public SimpleSpecs()
        {
            InitializeComponent();
        }



        private void titleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void titleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void titleLabel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }



        private void closeLabel_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void closeLabel_MouseHover(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.FromArgb(227, 0, 0);
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void closeLabel_MouseDown(object sender, MouseEventArgs e)
        {
            closeLabel.BackColor = Color.FromArgb(200, 0, 0);
        }

        private void closeLabel_MouseUp(object sender, MouseEventArgs e)
        {
            closeLabel.BackColor = Color.FromArgb(255, 0, 0);
        }



        private void advancedModeToggle_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("changed");
        }



        private List<PropertyData> GetInfo(string query)
        {
            List<PropertyData> info = new List<PropertyData>();

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(String.Format("SELECT * FROM {0}", query));
                foreach (ManagementObject obj in searcher.Get())
                {
                    PropertyDataCollection props = obj.Properties;
                    foreach (PropertyData data in props)
                    {
                        info.Add(data);
                    }
                }
            }
            catch (Exception ex)
            { }

            return info;
        }

        private List<string> GetCPU()
        {
            /**
             * CPU
             */
            List<PropertyData> processorInfo = GetInfo("Win32_Processor");
            List<string> cpu = new List<string>();

            // Name
            object name = processorInfo.Find(i => i.Name == "Name").Value;
            cpu.Add(String.Format("Name: {0}", name));

            // Cores
            object cores = processorInfo.Find(i => i.Name == "NumberOfCores").Value;
            cpu.Add(String.Format("Cores: {0}", cores));

            // Logical Processors
            object logicalProcessors = processorInfo.Find(i => i.Name == "NumberOfLogicalProcessors").Value;
            cpu.Add(String.Format("Logical Processors: {0}", logicalProcessors));

            // Clock Speed
            object clockSpeed = processorInfo.Find(i => i.Name == "CurrentClockSpeed").Value;
            cpu.Add(String.Format("Clock Speed: {0} GHz", 0.001f * int.Parse(clockSpeed.ToString())));


            return cpu;
        }

        private List<string> GetGPU()
        {
            /**
             * GPU
             */
            List<PropertyData> videoControllerInfo = GetInfo("Win32_VideoController");
            List<string> gpu = new List<string>();

            // Name
            object name = videoControllerInfo.Find(i => i.Name == "Name").Value;
            gpu.Add($"Name: {name}");

            // Resolution
            object horizontalResolution = videoControllerInfo.Find(i => i.Name == "CurrentHorizontalResolution").Value;
            object verticalResolution = videoControllerInfo.Find(i => i.Name == "CurrentVerticalResolution").Value;
            gpu.Add($"Resolution: {horizontalResolution}x{verticalResolution}");

            // Driver Version
            object driverVersion = videoControllerInfo.Find(i => i.Name == "DriverVersion").Value;
            gpu.Add($"Driver Version: {driverVersion}");

            // Driver Date
            string driverDate = videoControllerInfo.Find(i => i.Name == "DriverDate").Value.ToString();
            string year = driverDate.Substring(0, 4);
            string month = driverDate.Substring(4, 2);
            string day = driverDate.Substring(6, 2);
            gpu.Add($"Driver Date: {day}/{month}/{year}");


            return gpu;
        }

        private string MemFormat(object kb)
        {
            Int64 gb = Int64.Parse(kb.ToString()) / 1000 / 1000;
            if (gb >= 1000)
            {
                return $"{gb / 1000} TB";
            }

            return $"{gb} GB";
        }

        private List<string> GetMemory()
        {
            /**
             * Memory
             */
            List<PropertyData> videoControllerInfo = GetInfo("Win32_OperatingSystem");
            List<string> memory = new List<string>();

            // Total Visible Memory
            object totalVisibleMemory = videoControllerInfo.Find(i => i.Name == "TotalVisibleMemorySize").Value;
            memory.Add($"Total Visible Memory: {MemFormat(totalVisibleMemory)}");

            // Free Physical Memory
            object freePhysicalMemory = videoControllerInfo.Find(i => i.Name == "FreePhysicalMemory").Value;
            memory.Add($"Free Physical Memory: {MemFormat(freePhysicalMemory)}");

            // Total Virtual Memory Size
            object totalVirtualMemorySize = videoControllerInfo.Find(i => i.Name == "TotalVirtualMemorySize").Value;
            memory.Add($"Total Virtual Memory Size: {MemFormat(totalVisibleMemory)}");

            // Free Virtual Memory
            object freeVirtualMemory = videoControllerInfo.Find(i => i.Name == "FreeVirtualMemory").Value;
            memory.Add($"Free Virtual Memory: {MemFormat(totalVisibleMemory)}");


            return memory;
        }

        private List<string> GetStorage()
        {
            /**
             * Storage
             */
            System.IO.DriveInfo[] drives = System.IO.DriveInfo.GetDrives();
            List<string> storage = new List<string>();

            // Drive Count
            int driveCount = drives.Length;
            storage.Add($"Drive Count: {driveCount}");

            // Total Storage
            Int64 totalStorage = drives.Select(x => x.TotalSize).Aggregate((x, y) => x + y);
            storage.Add($"Total Storage: {MemFormat(totalStorage / 1000)}");

            // Free Storage
            Int64 freeStorage = drives.Select(x => x.TotalFreeSpace).Aggregate((x, y) => x + y);
            storage.Add($"Free Storage: {MemFormat(freeStorage / 1000)}");

            // Used Storage
            double usedStorage = ((double)(totalStorage - freeStorage) / totalStorage) * 100;
            storage.Add($"Used Storage: {Math.Round(usedStorage, 0)}%");


            return storage;
        }

        private void SimpleSpecs_Load(object sender, EventArgs e)
        {
            // Update CPU Info
            List<string> cpu = GetCPU();
            cpuLabel.Text = String.Join("\n", cpu);

            // Update GPU Info
            List<string> gpu = GetGPU();
            gpuLabel.Text = String.Join("\n", gpu);

            // Update Memory
            List<string> memory = GetMemory();
            memoryLabel.Text = String.Join("\n", memory);

            // Update Storage
            List<string> storage = GetStorage();
            storageLabel.Text = String.Join("\n", storage);
        }
    }
}
