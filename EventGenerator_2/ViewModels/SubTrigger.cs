using Avalonia.Interactivity;
using MsBox.Avalonia.Enums;
using MsBox.Avalonia;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using DynamicData;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EventGenerator_2.ViewModels
{
    public class SubTrigger : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int Logic { get; set; }
        public string TriggerParametr { get; set; }

        public string _triggerVariant;
        public string TriggerVariant
        {
            get => _triggerVariant;
            set
            {
                if (_triggerVariant != value)
                {
                    _triggerVariant = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Mask
        {
            get
            {
                return ChangeMask();
            }
        }

        public string ChangeMask()
        {
            try
            {
                return TriggerVariantsDesc[TriggerVariants.IndexOf(TriggerVariant)].Replace("\r", "") + "=" + Masks[TriggerVariants.IndexOf(TriggerVariant)];
            }
            catch
            {
                return "Выберите условие";
            }
        }

        public List<string> Masks
        {
            get
            {
                return GetMasks();
            }
        }

        public ReactiveCommand<Unit, Unit> RemoveSubTrigger { get; }

        public SubTrigger(ObservableCollection<SubTrigger> subTriggers)
        {
            RemoveSubTrigger = ReactiveCommand.Create(() =>
            {
                MainViewModel.PlaySound(0);
                subTriggers.Remove(this);
            });
        }
        /*public SubTrigger(ObservableCollection<SubTrigger> subTriggers, int logic, 
            string triggerVariant, string triggerParametr)
        {
            RemoveSubTrigger = ReactiveCommand.Create(() =>
            {
                MainViewModel.PlaySound(0);
                subTriggers.Remove(this);
            });

            Logic = logic;
            TriggerVariant = triggerVariant;
            TriggerParametr = triggerParametr;
        }*/
        public List<string> TriggerVariants
        {
            get
            {
                return GetTriggers();
            }
        }
        public List<string> TriggerVariantsDesc
        {
            get
            {
                return GetTriggersDesc();
            }
        }
        public string[] TriggerLogic
        {
            get
            {
                return new string[] { "AND", "OR", "AND NOT", "OR NOT" };
            }
        }

        public List<string> GetTriggers()
        {
            StreamReader triggersList = new StreamReader(@".\trigger_outcomes\triggers.txt",
                Encoding.Default);

            string fullText = triggersList.ReadToEnd();

            string[] partsOfText = fullText.Split('\n');

            List<string> triggers = new List<string>();

            foreach (string s in partsOfText)
            {
                triggers.Add(s);
            }

            return triggers;
        }
        public List<string> GetTriggersDesc()
        {
            StreamReader triggersList = new StreamReader($@".\trigger_outcomes\{MainViewModel.ChosenLanguage}\triggers_desc.txt",
                Encoding.Default);

            string fullText = triggersList.ReadToEnd();

            string[] partsOfText = fullText.Split('\n');

            List<string> triggers = new List<string>();

            foreach (string s in partsOfText)
            {
                triggers.Add(s);
            }

            return triggers;
        }
        public List<string> GetMasks()
        {
            StreamReader triggerMasksList = new StreamReader(@".\trigger_outcomes\triggers_mask.txt",
                Encoding.Default);

            string fullText = triggerMasksList.ReadToEnd();

            string[] partsOfText = fullText.Split('\n');

            List<string> masks = new List<string>();

            foreach (string s in partsOfText)
            {
                masks.Add(s);
            }

            return masks;
        }
    }
}
