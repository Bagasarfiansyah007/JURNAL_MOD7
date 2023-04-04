using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace jurnal_mod7
{
    public class DataMahasiswa_1302194007
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Course> courses { get; set; }

        public DataMahasiswa_1302194007()
        {
        }

        public DataMahasiswa_1302194007 ReadJSON()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string jsonString = File.ReadAllText(path + "/jurnal7_1_1302194007.json");
            return JsonSerializer.Deserialize<DataMahasiswa_1302194007>(jsonString);
        }
    }

    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }

        public Address() { }
    }

    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }

        public Course() { }
    }
}
