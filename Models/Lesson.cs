using ReactiveUI;

namespace AvaloniaItemsControlTestBed.Models
{
    public class Lesson : ReactiveObject
    {
        private string _title;
        private bool _selected;

        public string Title
        {
            get => this._title;
            set => this.RaiseAndSetIfChanged(ref this._title, value);
        }

        public bool Selected 
        { 
            get => this._selected; 
            set => this.RaiseAndSetIfChanged(ref this._selected, value);
        }
    }
}
