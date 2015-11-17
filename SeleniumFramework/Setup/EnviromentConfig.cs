using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;




namespace SeleniumFramework.Setup
{
    
    class EnviromentConfig{

       
        internal static void GetOperatingSystem(out string operatingSystem) {
            operatingSystem = Environment.OSVersion.ToString();
            if (operatingSystem.ToUpper().Contains("LINUX")) {
                operatingSystem = "LINUX";
            }
            else if (operatingSystem.ToUpper().Contains("MAC")) {
                operatingSystem = "MAC";
            }
            else{
                operatingSystem = "WINDOWS";
            }
        }

        internal static void ReturnOSDriverBinaryPath(out string driverBinaryPath)
        {
            driverBinaryPath = "";       
            string parentworkingDir = Directory.GetParent(new FileInfo(".").DirectoryName).ToString();
            string filepath = Path.DirectorySeparatorChar + "DriverBinaries" + 
                Path.DirectorySeparatorChar + "{0}" +Path.DirectorySeparatorChar;
            string OSversion;
            GetOperatingSystem(out OSversion);
            switch (OSversion.ToUpper())
            {
                case "LINUX":
                    driverBinaryPath = parentworkingDir + String.Format(filepath, "Linux");
                    break;

                case "MAC":
                    driverBinaryPath = parentworkingDir + String.Format(filepath, "Mac");
                    break;

                case "WINDOWS":
                        driverBinaryPath = parentworkingDir + String.Format(filepath, "Windows");
                    break;
                    
            }

        }
 }
}
