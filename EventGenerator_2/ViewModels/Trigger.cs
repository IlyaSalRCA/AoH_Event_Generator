using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DynamicData;
using ReactiveUI;
using System.Reactive;
using Microsoft.VisualBasic;

namespace EventGenerator_2.ViewModels
{
    public class Trigger
    {

        public int Logic { get; set; }
        public ReactiveCommand<Unit, Unit> RemoveTrigger { get; }
        public ObservableCollection<SubTrigger> SubTriggers { get; set; }

        public string[] TriggerLogic
        {
            get
            {
                return new string[] { "AND", "OR", "AND NOT", "OR NOT" };
            }
        }
        public Trigger(ObservableCollection<Trigger> triggers, ObservableCollection<SubTrigger> subTriggers)
        {
            RemoveTrigger = ReactiveCommand.Create(() =>
            {
                MainViewModel.PlaySound(0);
                triggers.Remove(this);
            });

            SubTriggers = subTriggers;
        }
        /*public Trigger(ObservableCollection<Trigger> triggers, ObservableCollection<SubTrigger> subTriggers, int logic, int subLogic,
            string triggerVariant, string triggerParametr)
        {
            RemoveTrigger = ReactiveCommand.Create(() =>
            {
                MainViewModel.PlaySound(0);
                triggers.Remove(this);
            });

            SubTriggers = subTriggers;
            AddSubTrigger(subLogic, triggerVariant, triggerParametr);
            Logic = logic;
        }*/
        public void AddSubTrigger()
        {
            MainViewModel.PlaySound(0);
            SubTriggers.Add(new SubTrigger(SubTriggers));
        }

        /*public void AddSubTrigger(int logic,
            string triggerVariant, string triggerParametr)
        {
            MainViewModel.PlaySound(0);
            SubTriggers.Add(new SubTrigger(SubTriggers,logic, triggerVariant, triggerParametr));
        }*/
    }
}
