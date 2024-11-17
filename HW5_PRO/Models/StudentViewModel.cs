﻿namespace HW5_PRO.Models
{
    public class StudentViewModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Group { get; set; }
        public int[] Grades { get; set; }
        public List<string> LanguagesOfProgramming { get; set; }

        public double AvarageGrade => Grades?.Average() ?? 0;
        public int LanguagesOfProgrammingCount => LanguagesOfProgramming?.Count() ?? 0;
    }
}

//Обработка POST-запросов с данными формы при помощи контроллеров Задание
//1. Создать проект ASP.Net Core с реализацией паттерна MVC.
//2. Используя контроллеры, реализовать обработку POST-запросов с данными формы, обеспечив следующую функциональность приложения:
//-Во время запуска приложения отображается форма с полями и элементами для вводу следующей информации:
//a) имя пользователя;
//b) фамилия пользователя;
//c) группа, в которой учится пользователь;
//d) оценки пользователя по трем предметам;
//f) языки программирования, которыми владеет пользователь.
//- После отправки данных формы должна появиться страница со следующей информацией: фамилия и имя пользователя, средний балл,
//языки программирования, которые знает пользователь, а также их количество.