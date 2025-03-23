using DynamicData;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventGenerator_2.ViewModels
{
    public class Outcome : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<SubOutcome> SubOutcomes { get; set; }
        public ReactiveCommand<Unit, Unit> RemoveOutcome { get; }

        private string _buttonName;
        public string ButtonName
        {
            get => _buttonName;
            set
            {
                if (_buttonName != value)
                {
                    _buttonName = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _buttonText;
        public string ButtonText
        {
            get => _buttonText;
            set
            {
                if (_buttonText != value)
                {
                    _buttonText = value;
                    OnPropertyChanged();
                }
            }
        }
        public string AIChance { get; set; }
        public void AddSubOutcome()
        {
            MainViewModel.PlaySound(0);
            SubOutcomes.Add(new SubOutcome(SubOutcomes));
        }
        public Outcome(ObservableCollection<Outcome> outcomes, ObservableCollection<SubOutcome> subOutcomes)
        {
            RemoveOutcome = ReactiveCommand.Create(() =>
            {
                MainViewModel.PlaySound(0);
                outcomes.Remove(this);
            });

            SubOutcomes = subOutcomes;
        }
    }
}
