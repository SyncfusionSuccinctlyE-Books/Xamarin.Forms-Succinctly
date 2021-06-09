using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataBinding
{
    public class PeopleModel
    {
        public ObservableCollection<Person> People { get; set; }

        public Person SelectedPerson { get; set; }

        public PeopleModel()
        {
            this.People = new ObservableCollection<Person>();
            Person person1 = new Person { FullName = "Alessandro", DateOfBirth = new DateTime(1977, 05, 10) };
            Person person2 = new Person { FullName = "James", DateOfBirth = new DateTime(1980, 02, 03) };
            Person person3 = new Person { FullName = "Jacqueline", DateOfBirth = new DateTime(1982, 04, 06) };

            People.Add(person1);
            People.Add(person2);
            People.Add(person3);
        }
    }
}
