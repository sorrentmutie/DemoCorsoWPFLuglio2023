using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DemoCorsoWPF.Models;

public class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected virtual void SetProperty<T>(ref T member, T val,
        [CallerMemberName] string propertyName = "")
    {
        if (object.Equals(member, val)) return;
        member = val;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }


}
