using DynamicData;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace EventGenerator_2.ViewModels
{
    public class SubOutcome
    {
        public List<string> OutcomeVariants
        {
            get
            {
                return GetOutcomes();
            }
        }

        public string Mask
        {
            get
            {
                return ChangeMask();
            }
        }

        public List<string> OutcomeVariantsDesc
        {
            get
            {
                return GetOutcomesDesc();
            }
        }

        public string ChangeMask()
        {
            try
            {
                return OutcomeVariantsDesc[OutcomeVariants.IndexOf(OutcomeVariant)].Replace("\r", "") + "=" + Masks[OutcomeVariants.IndexOf(OutcomeVariant)];
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

        public string OutcomeParametr { get; set; }
        public string OutcomeVariant { get; set; }
        public ReactiveCommand<Unit, Unit> RemoveSubOutcome { get; }

        public SubOutcome(ObservableCollection<SubOutcome> subOutcomes)
        {
            RemoveSubOutcome = ReactiveCommand.Create(() =>
            {
                MainViewModel.PlaySound(0);
                subOutcomes.Remove(this);
            });
        }

        public List<string> GetOutcomes()
        {
            StreamReader outcomesList = new StreamReader(@".\trigger_outcomes\outcomes.txt",
                Encoding.Default);

            string fullText = outcomesList.ReadToEnd();

            string[] partsOfText = fullText.Split('\n');

            List<string> outcomes = new List<string>();

            foreach (string s in partsOfText)
            {
                outcomes.Add(s);
            }

            return outcomes;
        }

        public List<string> GetOutcomesDesc()
        {
            StreamReader outcomesList = new StreamReader($@".\trigger_outcomes\{MainViewModel.ChosenLanguage}\outcomes_desc.txt",
                Encoding.Default);

            string fullText = outcomesList.ReadToEnd();

            string[] partsOfText = fullText.Split('\n');

            List<string> outcomes = new List<string>();

            foreach (string s in partsOfText)
            {
                outcomes.Add(s);
            }

            return outcomes;
        }
        public List<string> GetMasks()
        {
            StreamReader outcomeMasksList = new StreamReader(@".\trigger_outcomes\outcomes_mask.txt",
                Encoding.Default);

            string fullText = outcomeMasksList.ReadToEnd();

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
