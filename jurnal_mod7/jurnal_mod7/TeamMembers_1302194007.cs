using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace jurnal_mod7
{
    public class TeamMembers_1302194007
    {
        public List<TeamDetail> members { get; set; }

        public TeamMembers_1302194007()
        {
        }

        public TeamMembers_1302194007 ReadJSON()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string jsonString = File.ReadAllText(path + "/jurnal7_2_1302194007.json");
            return JsonSerializer.Deserialize<TeamMembers_1302194007>(jsonString);
        }
    }
    public class TeamDetail
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }

        public TeamDetail() { }
    }
}