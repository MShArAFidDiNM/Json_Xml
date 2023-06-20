using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace Json_Xml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] - JSON           [2] - XML");
            int input =  int.Parse(Console.ReadLine());
            if (input == 1 )
            {
                Json();
            }
        }
        public static void Json()
        {
            Employe employee = new Employe
            {
                EmployeName = "Employee"
            };

            var department = new Department
            {
                DepartmentName = "Department",
                EmployeName = "Employe"
            };

            string path = "C:\\Tekshir\\Json\\1.json";
            if (File.Exists(path))
            {
                    string text =  File.ReadAllText(path);
                    var desirilazer = JsonSerializer.Deserialize<Department>(text);
                    Console.WriteLine(desirilazer);
               
            }
            else
            { 
                File.Create(path).Close();
                string jsonString = JsonSerializer.Serialize(department);
                Console.WriteLine("Created");

                File.WriteAllText(path, jsonString);
            }                   
        }
    }
}