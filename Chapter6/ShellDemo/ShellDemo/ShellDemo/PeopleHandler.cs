using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ShellDemo
{
    //public class PeopleSearchHandler : SearchHandler
    //{
    //    protected override void OnQueryChanged(string oldValue, string newValue)
    //    {
    //        base.OnQueryChanged(oldValue, newValue);

    //        if (string.IsNullOrWhiteSpace(newValue))
    //        {
    //            ItemsSource = null;
    //        }
    //        else
    //        {
    //            ItemsSource = YourCollection
    //                .Where(p => p.YourProperty.ToLower().Contains(newValue.ToLower()))
    //                .ToList();
    //        }
    //    }

    //    protected override async void OnItemSelected(object item)
    //    {
    //        base.OnItemSelected(item);

    //        await (App.Current.MainPage as Shell).GoToAsync($"ObjectDetails?name={((YourObject)item).YourProperty}");
    //    }
    //}
}
