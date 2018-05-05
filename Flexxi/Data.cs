using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows;
using System.Windows.Forms;
using System.Reflection;
using Flexxi.Properties;

namespace Flexxi
{
    class Data
    {
        

        private static Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public static Dictionary<string, string> languages = new Dictionary<string, string>();
        public static String language = Properties.Settings.Default.Language == "" ? 
            CultureInfo.InstalledUICulture.TwoLetterISOLanguageName : Properties.Settings.Default.Language;
        public static bool askedForTranslation = false;
        public static bool permitionTranslate = false;
        public static bool firstLoadedLanguage = false;
        public static bool writeNecessary = false;
        public static bool changingLanguage = false;

        public static void initLanguages()
        {
            addLanguage("en", "English");
            addLanguage("de", "Deutsch");
            addLanguage("es", "Español");
        }

        public static void load()
        {
            read(language);

            translatedAskForTranslation = translate(askForTranslation);
            translatedAddTranslation = translate(addTranslation);
            translatedTranslate = translate(translateWord);
        }

        private static void addLanguage(String key, String value)
        {
            if (!languages.ContainsKey(key))
            {
                languages.Add(key, value);
            }
        }

        public static void saveLanguage()
        {
            write(language);
        }

        private static void add(String en, String other)
        {
            if(!dictionary.ContainsKey(en))
            {
                dictionary.Add(en, other);
            }
        }

        private static string getFileName(String language)
        {
            return language + ".txt";
        }

        private static void write(String language)
        {
            File.WriteAllText(getFileName(language), (new JavaScriptSerializer().Serialize(dictionary)).Replace("\",\"","\","+Environment.NewLine+"\""));
        }

        private static void read(String language)
        {
            string result = "";
            if(language == "de") result = Resources.de;
            if (language == "es") result = Resources.es;

            dictionary.Clear();
            if (result != "")
            {
                dictionary = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(result);
            }
            if (File.Exists(getFileName(language)))
            {
                Dictionary<string, string> dictionary_file = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(File.ReadAllText(getFileName(language)));

                foreach(KeyValuePair<string, string> kv in dictionary_file)
                {
                    if(dictionary.ContainsKey(kv.Key) && kv.Value != "")
                    {
                        dictionary.Remove(kv.Key);
                    }
                    dictionary.Add(kv.Key, kv.Value);
                }
            }
        }
        public static String translate(String text)
        {
            return translate(text, "");
        }

        private static String askForTranslation = "For the selected language are some words not translated. Do you want to add this translations?";
        private static String addTranslation = "Add translations";
        private static String translateWord = "Translate";
        private static String translatedAskForTranslation;
        private static String translatedAddTranslation;
        private static String translatedTranslate;

        public static String translate(String text, String name)
        {
            if (language == "en") return text;
            if (text == "") return text;
            if (dictionary.ContainsKey(text))
            {
                return dictionary[text];
            }
            else
            {
                if (!askedForTranslation)
                {
                    /*
                    System.Windows.MessageBoxResult result = System.Windows.MessageBox.Show(
                        dictionary.ContainsKey(askForTranslation) ? dictionary[askForTranslation] : askForTranslation,
                        dictionary.ContainsKey(addTranslation) ? dictionary[addTranslation] : addTranslation, MessageBoxButton.YesNo);

                    permitionTranslate = result == MessageBoxResult.Yes ? true : false;
                    askedForTranslation = true;
                    */
                }
                if (permitionTranslate)
                {
                    String translationText = "";
                    String textOutput = text + (name != "" ? " (" + name + ")" : "");
                    Clipboard.SetText(text);
                    DialogResult result = InputBox(
                        dictionary.ContainsKey(translateWord) ? dictionary[translateWord] : translateWord,
                        textOutput, ref translationText);
                    if (result == DialogResult.Cancel)
                    {
                        permitionTranslate = false;
                        Data.saveLanguage();
                        return text;
                    }
                    if (translationText == "")
                    {
                        return text;
                    }
                    else
                    { 
                        add(text, translationText);
                        writeNecessary = true;
                        return translationText;
                    }
                }
                else
                {
                    return text;
                }
            }
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
    }
}
