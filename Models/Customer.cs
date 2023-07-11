using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DemoCorsoWPF.Models;

public class Customer : INotifyPropertyChanged
{
    private string firstName = string.Empty;
    private string lastName = string.Empty;
    private string phoneNumber = string.Empty;

    public int Id { get; init; }

    public string FirstName
    {
        get { return firstName; }
        set
        {
            if(value != firstName)
            {
                firstName = value;
                NotifyPropertyChanged();
            }
        }
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            if(value != lastName)
            {
                lastName = value;
                NotifyPropertyChanged();
            }
        }
    }

    public string PhoneNumber
    {
        get { return phoneNumber; }
        set
        {
            if(value != phoneNumber)
            {
                phoneNumber = value;
                NotifyPropertyChanged();
            }
        }
    }


    public event PropertyChangedEventHandler? PropertyChanged;

    private void NotifyPropertyChanged( [CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
