namespace Вариант_4
{
    internal static class Program
    {
        class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Organization organization = new Organization();
                    Console.WriteLine("Название вашей организации:");
                    organization.Name = Console.ReadLine();
                    Console.WriteLine("Почтовый индекс вашей организации: ");
                    organization.Index = int.Parse(Console.ReadLine());
                    Console.WriteLine("В каком стране находитсяваша организация:");
                    organization.CountryName = Console.ReadLine();
                    Console.WriteLine("В каком городе она находится?");
                    organization.CityName = Console.ReadLine();
                    Console.WriteLine("Укажите на какой улице находится ваша организация:");
                    organization.StreetName = Console.ReadLine();
                    Console.WriteLine("Укажите номер дома:");
                    organization.HouseNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите номер телефона:");
                    organization.Telephone = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ваша организация: \n");
                    Console.WriteLine("Название: " + organization.Name);
                    Console.WriteLine("Почтовый индекс: " + organization.Index);
                    Console.WriteLine("Страна: " + organization.CountryName);
                    Console.WriteLine("Город: " + organization.CityName);
                    Console.WriteLine("Улица, дом: " + organization.StreetName + ", " + organization.HouseNumber);
                    Console.WriteLine("Номер телефона: " + organization.Telephone);
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверно задано значение!");
                }

                Console.ReadKey();
            }
        }
    }
}
