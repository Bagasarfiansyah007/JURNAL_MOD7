using System;

namespace jurnal_mod7
{
    class Program
    {
        static void Main(string[] args)
        {

            // Soal ke satu

            DataMahasiswa_1302194007 mhs = new DataMahasiswa_1302194007().ReadJSON();
            // print all information from DataMahasiswa
            Console.WriteLine("Nama    : " + mhs.firstName + " " + mhs.lastName);
            Console.WriteLine("Age     : " + mhs.age);
            Console.WriteLine("Gender  : " + mhs.gender);
            Console.WriteLine("Address : " + mhs.address.streetAddress + ", " + mhs.address.city + ", " + mhs.address.state);
            Console.WriteLine("Course  : ");
            foreach (Course course in mhs.courses)
            {
                Console.WriteLine("- [" + course.code + "] " + course.name);
            }


            // Soal ke dua

            Console.WriteLine("---------------------------------");
            TeamMembers_1302194007 anggotaTim = new TeamMembers_1302194007().ReadJSON();
            Console.WriteLine("Team member list: ");

            // cara pertama
            foreach (TeamDetail team in anggotaTim.members)
            {
                Console.WriteLine("[" + team.nim + "] " + team.firstName + " " + team.lastName + " (" + team.age +", " + team.gender +") ");
            }

            // cara kedua
            /**for (int i = 0; i < anggotaTim.members.Count; i++)
            {
                Console.WriteLine("[" + anggotaTim.members[i].nim + "] " + anggotaTim.members[i].firstName + " " + anggotaTim.members[i].lastName
                    + " (" + anggotaTim.members[i].age + ", " + anggotaTim.members[i].gender + ") ");
            }**/
            
        }
    }
}
