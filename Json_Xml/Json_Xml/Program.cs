using System.Text.Json;
namespace Json_Xml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company()
            {
                Id = 1,
                Name = "Luxe Auto",
                Cars = new List<Car>()
                {
                    new Car { Id = 1, Name = "Gentra", Modul = "Chevrolet" },
                    new Car { Id = 2, Name = "Plaid", Modul = "Tesla" },
                    new Car { Id = 3, Name = "Modul X", Modul = "Tesla" },
                    new Car { Id = 4, Name = "Model Y", Modul = "Tesla" }

                }
            };
            foreach (var car in company.Cars)
            {
                Console.WriteLine(car.Id + " > Name : " + car.Name + ", Modul : " + car.Modul);
            }
            Console.WriteLine("Which machine should be written to the json file");
            int input = int.Parse(Console.ReadLine());

            string writing;
            foreach (var car in company.Cars)
            {
                if (input == car.Id)
                {
                    string json = JsonSerializer.Serialize(car);
                    string path = "C:\\Tekshir\\Json\\.json";
                    if (!File.Exists(path))
                    {
                        File.Create(path).Close();
                        File.WriteAllText(path, json);
                    }
                }
            }
        }
        class Car
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Modul { get; set; }
        }
        class Company
        {
            public string Name { get; set; }
            public int Id { get; set; }
            public List<Car> Cars { get; set; }


            public Company() { }
            public Company(int id, string name, List<Car> cars)
            {
                Id = id;
                Name = name;
                Cars = cars;
            }
        }
    }
}