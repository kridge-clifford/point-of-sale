using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Utilities
{
    public class PCSerials
    {
        public static String GetDriveSerial()
        {
            try
            {
                String serial = "";
                foreach (ManagementObject device in new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive").Get())
                {
                    foreach (ManagementObject partition in new ManagementObjectSearcher("ASSOCIATORS OF {Win32_DiskDrive.DeviceID='" + device.Properties["DeviceID"].Value + "'} WHERE AssocClass = Win32_DiskDriveToDiskPartition").Get())
                    {
                        foreach (ManagementObject disk in new ManagementObjectSearcher(
                                     "ASSOCIATORS OF {Win32_DiskPartition.DeviceID='"
                                         + partition["DeviceID"]
                                         + "'} WHERE AssocClass = Win32_LogicalDiskToPartition").Get())
                        {
                            if (disk["Name"].ToString().Equals("C:"))
                            {
                                serial = device["SerialNumber"].ToString().Trim();
                            }

                        }
                    }
                }
                return serial;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string GetCpuSerial()
        {
            try
            {
                string cpuInfo = string.Empty;
                ManagementClass mc = new ManagementClass("win32_processor");
                ManagementObjectCollection moc = mc.GetInstances();

                foreach (ManagementObject mo in moc)
                {
                    cpuInfo = mo.Properties["processorID"].Value.ToString().Trim();
                    break;
                }
                return cpuInfo;
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
