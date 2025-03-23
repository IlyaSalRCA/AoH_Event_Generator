using MsBox.Avalonia.Enums;
using MsBox.Avalonia;
using System.Collections.ObjectModel;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace EventGenerator_2.ViewModels;

public class MainViewModel : ViewModelBase, INotifyPropertyChanged
{
    private static Dictionary<string, string> dictionary;
    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    public void LoadLanguage(string chosenLanguage)
    {

        PlaySound(0);
        var json = File.ReadAllText($@".\languages\{chosenLanguage}.json");
        if (json != null)
            dictionary = JsonSerializer.Deserialize<Dictionary<string, string>>(json);

        TitleTab = GetString("TitleTab");
        PreviewTab = GetString("PreviewTab");
        ChosenLang = GetString("ChosenLang");
        TriggerTab = GetString("TriggerTab");
        OutcomeTab = GetString("OutcomeTab");
        EventIDtext = GetString("EventID");
        EventTitle = GetString("EventTitle");
        EventDescription = GetString("EventDescription");
        ImageIDtext = GetString("ImageID");
        ShowInMissions = GetString("ShowInMissions");
        MissionsIDtext = GetString("MissionsID");
        OnlyOnce = GetString("OnlyOnce");
        PossibleToRun = GetString("PossibleToRun");
        PopUp = GetString("PopUp");
        Add = GetString("Add");
        CreateEventtext = GetString("CreateEvent");
        CommonText = GetString("CommonText");
        GlobalText = GetString("GlobalText");
        SiegeText = GetString("SiegeText");
        ShowPathText = GetString("ShowPathText");
        TranslButText = GetString("TranslButText");
        TranslLang = GetString("TranslLang");
        Clear = GetString("Clear");
        //ExampleText = GetString("ExampleText");
    }

    public void ChangeLang()
    {
        LoadLanguage(ChosenLanguage);
        File.WriteAllText($@".\languages\currentLanguage.txt", ChosenLanguageINDX.ToString());
    }

    public string GetString(string key)
    {
        if (dictionary != null && dictionary.ContainsKey(key))
        {
            return dictionary[key];
        }
        return $"#{key}#"; // Возвращаем ключ, если строка не найдена
    }
    public static int ChosenLanguageINDX { get; set; }

    public static string ChosenLanguage
    {
        get
        {
            try
            {
                return Languages[ChosenLanguageINDX].Replace("\r", "");
            }
            catch
            {
                return Languages[0].Replace("\r", "");
            }
        }
    }

    /*private string _exampleText;
    public string ExampleText
    {
        get => _exampleText;
        set
        {
            if (_exampleText != value)
            {
                _exampleText = value;
                OnPropertyChanged();
            }
        }
    }

    private string [] _exampleList;
    public string [] ExampleList
    {
        get => _exampleList;
        set
        {
            if (_exampleList != value)
            {
                _exampleList = value;
                OnPropertyChanged();
            }
        }
    }

    private string _example;
    public string Example
    {
        get => _example;
        set
        {
            if (_example != value)
            {
                _example = value;
                OnPropertyChanged();
                FullExample(Example);
            }
        }
    }

    public void FullExample(string example)
    {
        try
        {
            switch (example)
            {
                case "Default":
                    ClearFields();
                    Triggers.Clear();
                    Outcomes.Clear();
                    IsPossibleToRun = true;
                    break;
                case "AddGold":
                    EventID = "AddGold";
                    Title = "AddGold.t";
                    Description = "AddGold.d";
                    ImageID = "0";
                    MissionImageID = "0";
                    IsPossibleToRun = true;

                    Trigger addGold = new Trigger(Triggers, new ObservableCollection<SubTrigger>(), 1, 1, "is_civ", "rus");

                    Triggers.Add(addGold);

                    break;
                case "ImpossibleToRun":
                    EventID = "ImpossibleToRun";
                    Title = "ImpossibleToRun.t";
                    Description = "ImpossibleToRun.d";
                    ImageID = "1";
                    MissionImageID = "1";
                    IsPossibleToRun = false;
                    break;
                case "DeclareWar":
                    EventID = "DeclareWar";
                    Title = "DeclareWar.t";
                    Description = "DeclareWar.d";
                    ImageID = "2";
                    MissionImageID = "2";
                    IsPossibleToRun = true;
                    break;
                default:
                    ClearFields();
                    Triggers.Clear();
                    Outcomes.Clear();
                    IsPossibleToRun = true;
                    break;
            }
        }
        catch
        {

        }
    }*/

    private string _clear;
    public string Clear
    {
        get => _clear;
        set
        {
            if (_clear != value)
            {
                _clear = value;
                OnPropertyChanged();
            }
        }
    }
    private string _titleTab;
    public string TitleTab
    {
        get => _titleTab;
        set
        {
            if (_titleTab != value)
            {
                _titleTab = value;
                OnPropertyChanged();
            }
        }
    }
    private string _triggerTab;
    public string TriggerTab
    {
        get => _triggerTab;
        set
        {
            if (_triggerTab != value)
            {
                _triggerTab = value;
                OnPropertyChanged();
            }
        }
    }
    private string _outcomeTab;
    public string OutcomeTab
    {
        get => _outcomeTab;
        set
        {
            if (_outcomeTab != value)
            {
                _outcomeTab = value;
                OnPropertyChanged();
            }
        }
    }

    private string _previewTab;
    public string PreviewTab
    {
        get => _previewTab;
        set
        {
            if (_previewTab != value)
            {
                _previewTab = value;
                OnPropertyChanged();
            }
        }
    }

    private string _chosenLang;
    public string ChosenLang
    {
        get => _chosenLang;
        set
        {
            if (_chosenLang != value)
            {
                _chosenLang = value;
                OnPropertyChanged();
            }
        }
    }
    private string _eventIDText;
    public string EventIDtext
    {
        get => _eventIDText;
        set
        {
            if (_eventIDText != value)
            {
                _eventIDText = value;
                OnPropertyChanged();
            }
        }
    }
    private string _eventTitle;
    public string EventTitle
    {
        get => _eventTitle;
        set
        {
            if (_eventTitle != value)
            {
                _eventTitle = value;
                OnPropertyChanged();
            }
        }
    }
    private string _eventDescription;
    public string EventDescription
    {
        get => _eventDescription;
        set
        {
            if (_eventDescription != value)
            {
                _eventDescription = value;
                OnPropertyChanged();
            }
        }
    }
    private string _imageIDtext;
    public string ImageIDtext
    {
        get => _imageIDtext;
        set
        {
            if (_imageIDtext != value)
            {
                _imageIDtext = value;
                OnPropertyChanged();
            }
        }
    }
    private string _showInMissions;
    public string ShowInMissions
    {
        get => _showInMissions;
        set
        {
            if (_showInMissions != value)
            {
                _showInMissions = value;
                OnPropertyChanged();
            }
        }
    }
    private string _missionIDtext;
    public string MissionsIDtext
    {
        get => _missionIDtext;
        set
        {
            if (_missionIDtext != value)
            {
                _missionIDtext = value;
                OnPropertyChanged();
            }
        }
    }
    private string _onlyOnce;
    public string OnlyOnce
    {
        get => _onlyOnce;
        set
        {
            if (_onlyOnce != value)
            {
                _onlyOnce = value;
                OnPropertyChanged();
            }
        }
    }
    private string _possibleToRun;
    public string PossibleToRun
    {
        get => _possibleToRun;
        set
        {
            if (_possibleToRun != value)
            {
                _possibleToRun = value;
                OnPropertyChanged();
            }
        }
    }
    private string _popUp;
    public string PopUp
    {
        get => _popUp;
        set
        {
            if (_popUp != value)
            {
                _popUp = value;
                OnPropertyChanged();
            }
        }
    }
    private string _add;
    public string Add
    {
        get => _add;
        set
        {
            if (_add != value)
            {
                _add = value;
                OnPropertyChanged();
            }
        }
    }
    private string _createEventText;
    public string CreateEventtext
    {
        get => _createEventText;
        set
        {
            if (_createEventText != value)
            {
                _createEventText = value;
                OnPropertyChanged();
            }
        }
    }

    private string _commonText;
    public string CommonText
    {
        get => _commonText;
        set
        {
            if (_commonText != value)
            {
                _commonText = value;
                OnPropertyChanged();
            }
        }
    }

    private string _globalText;
    public string GlobalText
    {
        get => _globalText;
        set
        {
            if (_globalText != value)
            {
                _globalText = value;
                OnPropertyChanged();
            }
        }
    }

    private string _siegeText;
    public string SiegeText
    {
        get => _siegeText;
        set
        {
            if (_siegeText != value)
            {
                _siegeText = value;
                OnPropertyChanged();
            }
        }
    }

    private string _showPathText;
    public string ShowPathText
    {
        get => _showPathText;
        set
        {
            if (_showPathText != value)
            {
                _showPathText = value;
                OnPropertyChanged();
            }
        }
    }

    private string _translLang;
    public string TranslLang
    {
        get => _translLang;
        set
        {
            if (_translLang != value)
            {
                _translLang = value;
                OnPropertyChanged();
            }
        }
    }

    private string _translButText;
    public string TranslButText
    {
        get => _translButText;
        set
        {
            if (_translButText != value)
            {
                _translButText = value;
                OnPropertyChanged();
            }
        }
    }

    public static List<string> Languages
    {
        get
        {
            return GetLanguages();
        }
    }
    private string _eventID;
    public string EventID
    {
        get => _eventID;
        set
        {
            if (_eventID != value)
            {
                _eventID = value;
                OnPropertyChanged();
            }
        }
    }
    private string _title;
    public string Title
    {
        get => _title;
        set
        {
            if (_title != value)
            {
                _title = value;
                OnPropertyChanged();
            }
        }
    }
    private string _desc;
    public string Description
    {
        get => _desc;
        set
        {
            if (_desc != value)
            {
                _desc = value;
                OnPropertyChanged();
            }
        }
    }
    private string _imageID;
    public string ImageID
    {
        get => _imageID;
        set
        {
            if (_imageID != value)
            {
                _imageID = value;
                OnPropertyChanged();
            }
        }
    }
    public bool IsMissionShow { get; set; }
    private string _misImID;
    public string MissionImageID
    {
        get => _misImID;
        set
        {
            if (_misImID != value)
            {
                _misImID = value;
                OnPropertyChanged();
            }
        }
    }
    public bool IsOnlyOnce { get; set; }
    public bool _isPossibleToRun;
    public bool IsPossibleToRun
    {
        get => _isPossibleToRun;
        set
        {
            if (_isPossibleToRun != value)
            {
                _isPossibleToRun = value;
                OnPropertyChanged();
            }
        }
    }
    public bool IsPopUp { get; set; }
    public ObservableCollection<Trigger> Triggers { get; set; }
    public ObservableCollection<Outcome> Outcomes { get; set; }
    public string[] TriggerLogic { get; }

    public bool IsCommon { get; set; }
    public bool IsGlobal { get; set; }
    public bool IsSiege { get; set; }
    public bool IsShowPath { get; set; }
    public string TranslateTitle { get; set; }
    public string TranslateDesc { get; set; }
    public string TranslateLang { get; set; }

    public MainViewModel()
    {
        dictionary = new Dictionary<string, string>();
        Triggers = new ObservableCollection<Trigger> { };
        Outcomes = new ObservableCollection<Outcome> { };

        TriggerLogic = new string[]
        {
            "AND",
            "OR",
            "AND NOT",
            "OR NOT"
        };

        IsCommon = true;
        IsPossibleToRun = true;

        if (!File.Exists($@".\languages\currentLanguage.txt") || File.ReadAllText($@".\languages\currentLanguage.txt") == "")
        {
            FileStream fs = File.Create($@".\languages\currentLanguage.txt");
            fs.Dispose();
            File.WriteAllText($@".\languages\currentLanguage.txt", ChosenLanguageINDX.ToString());
        }
        else
        {
            ChosenLanguageINDX = int.Parse(File.ReadAllText($@".\languages\currentLanguage.txt"));
        }

        ChangeLang();

        //ExampleList = ["Default", "AddGold", "ImpossibleToRun", "DeclareWar"];
        //Example = "Default";
    }

    public void AddTrigger()
    {
        PlaySound(0);
        Triggers.Add(new Trigger(Triggers, new ObservableCollection<SubTrigger>()));
    }
    public void AddOutcome()
    {
        PlaySound(0);
        Outcomes.Add(new Outcome(Outcomes, new ObservableCollection<SubOutcome>()));
    }

    public void CreateEvent()
    {
        PlaySound(0);
        if (CheckFullness())
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@".\events");
            string title = MakeTitle();
            string trigger = MakeTrigger();
            string outcome = MakeOutcome();

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            DirectoryInfo dirInfoCom = new DirectoryInfo(@".\events\common");
            DirectoryInfo dirInfoGlo = new DirectoryInfo(@".\events\global");
            DirectoryInfo dirInfoSie = new DirectoryInfo(@".\events\siege");

            if (!dirInfoCom.Exists)
            {
                dirInfoCom.Create();
            }
            if (!dirInfoGlo.Exists)
            {
                dirInfoGlo.Create();
            }
            if (!dirInfoSie.Exists)
            {
                dirInfoSie.Create();
            }

            if (IsCommon)
            {
                if (!File.Exists($@".\events\common\{EventID}.txt"))
                {
                    PlaySound(1);
                    FileStream fs = File.Create($@".\events\common\{EventID}.txt");
                    fs.Dispose();
                    File.AppendAllText($@".\events\common\{EventID}.txt", title + trigger + outcome);
                    FillList("common", EventID);

                    if (IsShowPath)
                    {
                        var box = MessageBoxManager
                    .GetMessageBoxStandard(GetString("Success"), $"{GetString("EvCr")} \n {dirInfoCom.FullName}",
                        ButtonEnum.Ok);
                        box.ShowAsync();
                        box = null;
                    }
                }
                else
                {
                    PlaySound(2);
                    var box = MessageBoxManager
                .GetMessageBoxStandard(GetString("Err000"), GetString("Err015"),
                    ButtonEnum.Ok);
                    box.ShowAsync();
                    box = null;
                }
            }
            else if (IsGlobal)
            {
                if (!File.Exists($@".\events\global\{EventID}.txt"))
                {
                    PlaySound(1);
                    FileStream fs = File.Create($@".\events\global\{EventID}.txt");
                    fs.Dispose();
                    File.AppendAllText($@".\events\global\{EventID}.txt", title + trigger + outcome);
                    FillList("global", EventID);

                    if (IsShowPath)
                    {
                        var box = MessageBoxManager
                    .GetMessageBoxStandard(GetString("Success"), $"{GetString("EvCr")} \n {dirInfoGlo.FullName}",
                        ButtonEnum.Ok);
                        box.ShowAsync();
                        box = null;
                    }
                }
                else
                {
                    PlaySound(2);
                    var box = MessageBoxManager
                .GetMessageBoxStandard(GetString("Err000"), GetString("Err015"),
                    ButtonEnum.Ok);
                    box.ShowAsync();
                    box = null;
                }
            }
            else if (IsSiege)
            {
                if (!File.Exists($@".\events\siege\{EventID}.txt"))
                {
                    PlaySound(1);
                    FileStream fs = File.Create($@".\events\siege\{EventID}.txt");
                    fs.Dispose();
                    File.AppendAllText($@".\events\siege\{EventID}.txt", title + trigger + outcome);
                    FillList("siege", EventID);

                    if (IsShowPath)
                    {
                        var box = MessageBoxManager
                    .GetMessageBoxStandard(GetString("Success"), $"{GetString("EvCr")} \n {dirInfoSie.FullName}",
                        ButtonEnum.Ok);
                        box.ShowAsync();
                        box = null;
                    }
                }
                else
                {
                    PlaySound(2);
                    var box = MessageBoxManager
                .GetMessageBoxStandard(GetString("Err000"), GetString("Err015"),
                    ButtonEnum.Ok);
                    box.ShowAsync();
                    box = null;
                }
            }
            else
            {
                if (!File.Exists($@".\events\common\{EventID}.txt"))
                {
                    PlaySound(1);
                    FileStream fs = File.Create($@".\events\common\{EventID}.txt");
                    fs.Dispose();
                    File.AppendAllText($@".\events\common\{EventID}.txt", title + trigger + outcome);
                    FillList("common", EventID);
                }
                else
                {
                    PlaySound(2);
                    var box = MessageBoxManager
                .GetMessageBoxStandard(GetString("Err000"), GetString("Err015"),
                    ButtonEnum.Ok);
                    box.ShowAsync();
                    box = null;
                }
            }
        }
    }
    public bool CheckFullness()
    {
        if (EventID == null)
        {
            PlaySound(2);
            var box = MessageBoxManager
            .GetMessageBoxStandard(GetString("Err000"), GetString("Err001"),
                ButtonEnum.Ok);
            box.ShowAsync();
            box = null;
            return false;
        }
        if (Title == null)
        {
            PlaySound(2);
            var box = MessageBoxManager
            .GetMessageBoxStandard(GetString("Err000"), GetString("Err002"),
                ButtonEnum.Ok);
            box.ShowAsync();
            box = null;
            return false;
        }
        if (Description == null)
        {
            PlaySound(2);
            var box = MessageBoxManager
            .GetMessageBoxStandard(GetString("Err000"), GetString("Err003"),
                ButtonEnum.Ok);
            box.ShowAsync();
            box = null;
            return false;
        }
        if (ImageID == null)
        {
            PlaySound(2);
            var box = MessageBoxManager
            .GetMessageBoxStandard(GetString("Err000"), GetString("Err004"),
                ButtonEnum.Ok);
            box.ShowAsync();
            box = null;
            return false;
        }
        if (MissionImageID == null)
        {
            PlaySound(2);
            var box = MessageBoxManager
            .GetMessageBoxStandard(GetString("Err000"), GetString("Err005"),
                ButtonEnum.Ok);
            box.ShowAsync();
            box = null;
            return false;
        }
        if (Triggers.Count == 0)
        {
            PlaySound(2);
            var box = MessageBoxManager
            .GetMessageBoxStandard(GetString("Err000"), GetString("Err006"),
                ButtonEnum.Ok);
            box.ShowAsync();
            box = null;
            return false;
        }
        if (Outcomes.Count == 0)
        {
            PlaySound(2);
            var box = MessageBoxManager
            .GetMessageBoxStandard(GetString("Err000"), GetString("Err007"),
                ButtonEnum.Ok);
            box.ShowAsync();
            box = null;
            return false;
        }
        return true;
    }

    public string MakeTitle()
    {
        string title = "";

        title += "id=" + EventID + "\n";
        title += "title=" + Title + "\n";
        title += "desc=" + Description + "\n\n";
        title += "image=" + ImageID + ".png" + "\n\n";
        title += "show_in_missions=" + IsMissionShow.ToString().ToLower() + "\n";
        title += "mission_image=" + MissionImageID + "\n\n";
        title += "only_once=" + IsOnlyOnce.ToString().ToLower() + "\n";
        title += "possible_to_run=" + IsPossibleToRun.ToString().ToLower() + "\n";
        title += "popUp=" + IsPopUp.ToString().ToLower() + "\n\n";

        return title;
    }

    public string MakeTrigger()
    {
        string trigger = "";

        string[] triggerBeggining =
        {
            "trigger_and",
            "trigger_or",
            "trigger_and_not",
            "trigger_or_not"
        };
        string[] triggerEnd =
        {
            "trigger_and_end",
            "trigger_or_end",
            "trigger_and_not_end",
            "trigger_or_not_end"
        };
        string[] subTriggerLogic =
        {
            "next_and",
            "next_or",
            "next_and_not",
            "next_or_not"
        };

        foreach (var Trigger in Triggers)
        {
            if (Trigger.SubTriggers.Count != 0)
            {
                trigger += triggerBeggining[Trigger.Logic] + "\n";

                foreach (var SubTrigger in Trigger.SubTriggers)
                {
                    if (SubTrigger.TriggerVariant != "is_civ" && IsPossibleToRun == false)
                    {
                        var box = MessageBoxManager
                        .GetMessageBoxStandard(GetString("Aler000"), GetString("Aler001"),
                        ButtonEnum.Ok);
                        box.ShowAsync();
                        box = null;
                    }

                    if (SubTrigger.TriggerVariant == null)
                    {
                        PlaySound(2);
                        var box = MessageBoxManager
                        .GetMessageBoxStandard(GetString("Err000"), GetString("Err008"),
                        ButtonEnum.Ok);
                        box.ShowAsync();
                        box = null;
                        trigger += "\n\n";
                    }
                    else if (SubTrigger.TriggerParametr == null)
                    {
                        PlaySound(2);
                        var box = MessageBoxManager
                        .GetMessageBoxStandard(GetString("Err000"), GetString("Err009"),
                        ButtonEnum.Ok);
                        box.ShowAsync();
                        box = null;
                        trigger += "\n\n";
                    }
                    else
                    {
                        trigger += subTriggerLogic[SubTrigger.Logic] + "\n";
                        trigger += SubTrigger.TriggerVariant.Replace("\r", "") + "=" + SubTrigger.TriggerParametr + "\n";
                    }
                }

                trigger += triggerEnd[Trigger.Logic] + "\n\n";
            }
            else
            {
                PlaySound(2);
                var box = MessageBoxManager
            .GetMessageBoxStandard(GetString("Err000"), GetString("Err010"),
                ButtonEnum.Ok);
                box.ShowAsync();
                box = null;
                trigger += "\n\n";
            }
        }

        return trigger;
    }

    public string MakeOutcome()
    {
        string outcome = "";

        foreach (var Outcome in Outcomes)
        {
            if (Outcome.ButtonName == null)
            {
                PlaySound(2);
                var box = MessageBoxManager
                .GetMessageBoxStandard(GetString("Err000"), GetString("Err011"),
                ButtonEnum.Ok);
                box.ShowAsync();
                box = null;
                outcome += "\n\n";
            }
            else
            {
                if (Outcome.AIChance == null)
                {
                    PlaySound(2);
                    var box = MessageBoxManager
                    .GetMessageBoxStandard(GetString("Err000"), GetString("Err012"),
                    ButtonEnum.Ok);
                    box.ShowAsync();
                    box = null;
                    Outcome.AIChance = "100";
                }
                outcome += "option_btn" + "\n";
                outcome += "name=" + Outcome.ButtonName + "\n";
                outcome += "ai=" + Outcome.AIChance + "\n";

                foreach (var SubOutcome in Outcome.SubOutcomes)
                {
                    if (SubOutcome.OutcomeVariant == null)
                    {
                        PlaySound(2);
                        var box = MessageBoxManager
                        .GetMessageBoxStandard(GetString("Err000"), GetString("Err013"),
                        ButtonEnum.Ok);
                        box.ShowAsync();
                        box = null;
                        outcome += "\n\n";
                    }
                    else if (SubOutcome.OutcomeParametr == null)
                    {
                        PlaySound(2);
                        var box = MessageBoxManager
                        .GetMessageBoxStandard(GetString("Err000"), GetString("Err014"),
                        ButtonEnum.Ok);
                        box.ShowAsync();
                        box = null;
                        outcome += "\n\n";
                    }
                    else
                    {
                        outcome += SubOutcome.OutcomeVariant.Replace("\r", "") + "=" + SubOutcome.OutcomeParametr + "\n";
                    }
                }

                outcome += "option_end" + "\n\n";
            }
        }

        return outcome;
    }

    public static List<string> GetLanguages()
    {
        StreamReader languagesList = new StreamReader(@".\languages\languages.txt",
            Encoding.Default);

        string fullText = languagesList.ReadToEnd();

        string[] partsOfText = fullText.Split('\n');

        List<string> languages = new List<string>();

        foreach (string s in partsOfText)
        {
            languages.Add(s);
        }

        return languages;
    }

    public void FillList(string place, string name)
    {
        if (!File.Exists($@".\events\list_{place}.txt"))
        {
            FileStream fs = File.Create($@".\events\list_{place}.txt");
            fs.Dispose();
            File.AppendAllText($@".\events\list_{place}.txt", $"{name}.txt;");
        }
        else
        {
            File.AppendAllText($@".\events\list_{place}.txt", $"{name}.txt;");
        }
    }

    public void CreateTranslation()
    {
        PlaySound(0);
        string Lang = "Bundle";

        DirectoryInfo dirInfo = new DirectoryInfo(@".\translations");
        if (!dirInfo.Exists)
        {
            dirInfo.Create();
        }

        if (CheckFullnessTrans())
        {
            if (TranslateTitle == null)
            {
                TranslateTitle = Title;
            }
            if (TranslateDesc == null)
            {
                TranslateDesc = Description;
            }

            string content = $"{Title}={TranslateTitle.Replace("\r\n", ". ")}\n" +
                $"{Description}={TranslateDesc.Replace("\r\n", ". ")}\n\n";

            foreach (var but in Outcomes)
            {
                if(but.ButtonText == null)
                {
                    but.ButtonText = but.ButtonName;
                }
                content += $"{but.ButtonName}={but.ButtonText.Replace("\r\n", ". ")}\n";
            }

            content += "\n";

            try
            {
                if (TranslateLang != null)
                {
                    Lang += $"_{TranslateLang.ToLower()}";
                }

                if (!File.Exists($@".\translations\{Lang}.properties"))
                {
                    FileStream fs = File.Create($@".\translations\{Lang}.properties");
                    fs.Dispose();
                    File.AppendAllText($@".\translations\{Lang}.properties", content);
                }
                else
                {
                    File.AppendAllText($@".\translations\{Lang}.properties", content);
                }
                PlaySound(1);
                var box = MessageBoxManager
                    .GetMessageBoxStandard(GetString("Success"), $"{GetString("TrCr")} \n {dirInfo.FullName}",
                        ButtonEnum.Ok);
                box.ShowAsync();
                box = null;
            }
            catch
            {
                PlaySound(2);
                var box = MessageBoxManager
                    .GetMessageBoxStandard(GetString("Err000"), $"{GetString("Err000")}",
                        ButtonEnum.Ok);
                box.ShowAsync();
                box = null;
            }
        }
    }
    public bool CheckFullnessTrans()
    {
        if (Title == null)
        {
            PlaySound(2);
            var box = MessageBoxManager
            .GetMessageBoxStandard(GetString("Err000"), GetString("Err002"),
                ButtonEnum.Ok);
            box.ShowAsync();
            box = null;
            return false;
        }
        if (Description == null)
        {
            PlaySound(2);
            var box = MessageBoxManager
            .GetMessageBoxStandard(GetString("Err000"), GetString("Err003"),
                ButtonEnum.Ok);
            box.ShowAsync();
            box = null;
            return false;
        }
        if (Outcomes.Count == 0)
        {
            PlaySound(2);
            var box = MessageBoxManager
            .GetMessageBoxStandard(GetString("Err000"), GetString("Err007"),
                ButtonEnum.Ok);
            box.ShowAsync();
            box = null;
            return false;
        }
        return true;
    }

    public void ClearFields()
    {
        PlaySound(0);
        EventID = null;
        Title = null;
        Description = null;
        ImageID = null;
        MissionImageID = null;
    }

    public static void PlaySound(int index)
    {
        System.Media.SoundPlayer playerClick = new System.Media.SoundPlayer(@".\sounds\click.wav");
        System.Media.SoundPlayer playerSuccess = new System.Media.SoundPlayer(@".\sounds\success.wav");
        System.Media.SoundPlayer playerFail = new System.Media.SoundPlayer(@".\sounds\fail.wav");

        try
        {
            switch (index)
            {
                case 0:
                    playerClick.Play();
                    break;
                case 1:
                    playerSuccess.Play();
                    break;
                case 2:
                    playerFail.Play();
                    break;
                default:
                    playerClick.Play();
                    break;
            }
        }
        catch
        {

        }
    }
}
