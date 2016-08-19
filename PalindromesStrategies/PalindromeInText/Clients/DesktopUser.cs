using PalindromesStrategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromesStrategy.Clients
{
    public class DesktopUser
    {
        private IApp Application { get; set; }

        public string Name { get; private set; }

        public string Hostname
        {
            get
            {
                return Environment.MachineName;
            }
        }

        public DesktopUser(string username, IApp application)
        {
            Name = username;
            Application = application;
        }

        public void Launch()
        {
            Application.Execute();
        }

        public void Close()
        {
            Application = null;
        }

        public override string ToString()
        {
            return $"Desktop user name: {Name} on Host: {Hostname}";
        }
    }
}
