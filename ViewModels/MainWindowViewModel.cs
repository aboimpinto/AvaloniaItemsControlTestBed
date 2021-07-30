using System.Collections.ObjectModel;
using AvaloniaItemsControlTestBed.Models;

namespace AvaloniaItemsControlTestBed.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Lesson> LessonList { get; private set; }

        public MainWindowViewModel()
        {
            this.LessonList = new ObservableCollection<Lesson>
            {
                new Lesson { Title = "Title1", Selected = false },
                new Lesson { Title = "Title2", Selected = true },
                new Lesson { Title = "Title3", Selected = false },
            };
        }
    }
}
