using System;
using System.Collections.Generic;

namespace Device_Management_App.Classes
{
    public partial class User
    {
        public User()
        {
            DeviceManagers = new HashSet<DeviceManager>();
        }

        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long Telephone { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }

        public virtual ICollection<DeviceManager> DeviceManagers { get; set; }
    }
}
