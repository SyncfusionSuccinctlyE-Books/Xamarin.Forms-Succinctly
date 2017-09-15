using MvvmSample.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmSample.ViewModel
{
    public class PersonViewModel
    {
        public ObservableCollection<Person> People { get; set; }
        public Person SelectedPerson { get; set; }

        public ICommand AddPerson { get; set; }
        public ICommand DeletePerson { get; set; }

        public PersonViewModel()
        {
            this.People = new ObservableCollection<Person>();

            // sample data
            Person person1 = 
                new Person { FullName = "Alessandro",
                    Address ="Italy",
                    DateOfBirth =new DateTime(1977,5,10) };
            Person person2 = 
                new Person { FullName = "James",
                    Address ="United States",
                    DateOfBirth =new DateTime(1960,2,1) };
            Person person3 = 
                new Person { FullName = "Jacqueline",
                    Address ="France",
                    DateOfBirth =new DateTime(1980,4,2) };

            this.People.Add(person1);
            this.People.Add(person2);
            this.People.Add(person3);

            this.AddPerson = 
                new Command(() => this.People.Add(new Person()));

            this.DeletePerson = 
                new Command<Person>((person) => this.People.Remove(person));

        }
    }
}
