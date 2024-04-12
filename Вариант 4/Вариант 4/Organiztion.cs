using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вариант_4
{
    internal class Organization
    {
        string name;
        int index;
        string countryName;
        string cityName;
        string streetName;
        int houseNumber;
        int telephone;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null || value.Length == 0)
                    throw new Exception("Name incorrect!");
                else
                    name = value;
            }
        }

        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                if (value == 0)
                    throw new Exception("Index incorrect!");
                else
                    index = value;
            }
        }

        public string CountryName
        {
            get
            {
                return countryName;
            }
            set
            {
                if (value == null || value.Length == 0)
                    throw new Exception("Country name incorrect!");
                else
                    countryName = value;
            }
        }

        public string CityName
        {
            get
            {
                return cityName;
            }
            set
            {
                if (value == null || value.Length == 0)
                    throw new Exception("City name incorrect!");
                else
                    cityName = value;
            }
        }

        public string StreetName
        {
            get
            {
                return streetName;
            }
            set
            {
                if (value == null || value.Length == 0)
                    throw new Exception("Street name incorrect!");
                else
                    streetName = value;
            }
        }

        public int HouseNumber
        {
            get
            {
                return houseNumber;
            }
            set
            {
                if (value == 0)
                    throw new Exception("House Number incorrect!");
                else
                    houseNumber = value;
            }
        }

        public int Telephone
        {
            get
            {
                return telephone;
            }
            set
            {
                if (value == 0)
                    throw new Exception("Telephone incorrect!");
                else
                    telephone = value;
            }
        }
    }

    
        }
    