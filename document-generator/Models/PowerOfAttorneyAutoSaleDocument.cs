﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace document_generator.Models
{
    public class PowerOfAttorneyAutoSaleDocument
    {
        public string DoveritelFullName { get; set; }

        //public string DoveritelFirstName { get; set; } // Имя

        //public string DoveritelLastName { get; set; } // Фамилия

        //public string DoveritelMiddleName { get; set; } // Отчество

        public string DoveritelBirthDate { get; set; } // Дата рождения 07.01.1951

        public string DoveritelBirthPlace { get; set; } // Место рождения область

        public string DoveritelTheActualAddress { get; set; } // фактический адрес
        public string DoveritelIIN { get; set; }

        public string DoverenniiFullName { get; set; }

        //public string DoverenniiFirstName { get; set; } // Имя
    
        //public string DoverenniiLastName { get; set; } // Фамилия

        //public string DoverenniiMiddleName { get; set; } // Отчество

        public string DoverenniiBirthDate { get; set; } // Дата рождения 07.01.1951

        public string DoverenniiBirthPlace { get; set; } // Место рождения область

        public string DoverenniiTheActualAddress { get; set; } // фактический адрес
        public string DoverenniiIIN { get; set; }

        public SubjectOfThePowerOfAttorney Subject { get; set; } // 

    }

    //Предмет доверенности
    public class SubjectOfThePowerOfAttorney
    {
        public string VehiclePassportIssued { get; set; } // Паспорт транспортного средства / Cвидетельство о регистрации тс ГАИ УВД  ДВД
        public string VehiclePassportId { get; set; } // МF № 00061435
        public string DateOfIssue { get; set; } // дата выдачи

        public string Mark { get; set; } // марка машины BMW 520

        public string Release { get; set; } // год выпуска 
       

        public string IdentificationNumber { get; set; }

        public string CarBody { get; set; } // Кузов

        public string Chassis // Шасси автомобиля (ящик) номер, если номер Не Установлен то Н.У.
        {
            get;set;
            //get
            //{
            //    if (Chassis != null && Chassis != "")
            //        return Chassis;
            //    else
            //        return "Н.У.";

            //}
            //set
            //{
            //    Chassis = value;
            //}
        }

        public string RegistrationPlate { get; set; } // Регистрационный номерной знак  
    }

}
