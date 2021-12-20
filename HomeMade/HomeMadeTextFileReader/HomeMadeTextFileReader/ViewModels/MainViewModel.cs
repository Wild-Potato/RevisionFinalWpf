using HomeMadeTextFileReader.Commands;
using Ookii.Dialogs.Wpf;
using System;
using System.IO;

namespace HomeMadeTextFileReader.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        public DelegateCommand<string> OpenFileDialogCommand { get; set; }
        public DelegateCommand<string> SaveFileDialogCommand { get; set; }
        public DelegateCommand<string> HelloButtonCommand { get; set; }
        public DelegateCommand<string> ChangeLanguageCommand { get; set; }
        public DelegateCommand<string> RestartCommand { get; set; }

        private VistaOpenFileDialog openFileDialog;
        private VistaSaveFileDialog saveFileDialog;

        private string openFilename;

        public string OpenFilename
        {
            get { return openFilename; }
            set
            {
                openFilename = value;
                OnPropertyChanged();
            }
        }

        private string saveFilename;

        public string SaveFilename
        {
            get { return saveFilename; }
            set
            {
                saveFilename = value;
                OnPropertyChanged();
            }
        }

        private string textToButton;

        public string TextToButton
        {
            get { return textToButton; }
            set
            {
                textToButton = value;
                OnPropertyChanged();
            }
        }
        private void initCommands()
        {
            HelloButtonCommand = new DelegateCommand<string>(HiButton);
        }
        private void HiButton(string obj) 
        {
            TextToButton = "How are you doing mate";
        


        }

        public MainViewModel()
        {
            ChangeLanguageCommand = new DelegateCommand<string>(ChangeLanguage);
            saveFileDialog = new VistaSaveFileDialog();
            /// Permet de filtrer les fichies de base
            saveFileDialog.Filter = "Text file|*.txt|Comma-separated values (CSV)|*.csv|All files|*.*";
            /// Extension par défaut si l'utilisateur omet de l'inscrire
            saveFileDialog.DefaultExt = "txt";

            openFileDialog = new VistaOpenFileDialog();
            openFileDialog.Filter = "Text file|*.txt|Comma-separated values (CSV)|*.csv|All files|*.*";

            OpenFileDialogCommand = new DelegateCommand<string>(SelectFile);
            SaveFileDialogCommand = new DelegateCommand<string>(ChooseFileToSave);
            initCommands();

        }
        private void ChangeLanguage(string param)
        {
            Properties.Settings.Default.Language = param;
            Properties.Settings.Default.Save();

            RestartCommand?.Execute("");
        }

        private void SelectFile(string obj)
        {
            if (openFileDialog.ShowDialog() == true)
            {
                OpenFilename = openFileDialog.FileName;
                showFileContent();
            }
        }

        private void ChooseFileToSave(string obj)
        {

            if (saveFileDialog.ShowDialog() == true)
            {
                SaveFilename = saveFileDialog.FileName;
                saveToFile();
            }
        }

        /// <summary>
        /// Seulement pour des fins de démonstration
        /// </summary>
        private void saveToFile()
        {
            using (var tw = new StreamWriter(SaveFilename, false))
            {
                tw.WriteLine(OpenFilename);
                tw.WriteLine(SaveFilename);
                tw.Close();
            }
        }

        private void showFileContent()
        {
            //using (var sr = new StreamReader(OpenFilename))
            //{
            //    TextToButton = "-- FileContent --" + Environment.NewLine;
            //    TextToButton += sr.ReadToEnd();

            //}
        }
    }
}
