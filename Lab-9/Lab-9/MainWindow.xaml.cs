using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;

namespace Lab_9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmbFontFamily.ItemsSource = new List<string>() { "Segoe UI", "Times New Roman", "Arial", "Calibri"};
            cmbFontSize.ItemsSource = new List<int>() { 8, 10, 12, 14, 16, 18, 20 };
            cmbFontSize.Text = "12";
        }

        private void MenuItemNew_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newWindow = new MainWindow();
            newWindow.Show();
        }
        private void MenuItemOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files(*.txt)|*.txt|RichText Files (*.rtf)|*.rtf";

            if (openFileDialog.ShowDialog() == true)
            {
                TextRange doc = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
                using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    if (System.IO.Path.GetExtension(openFileDialog.FileName).ToLower() == ".txt")
                        doc.Load(fileStream, DataFormats.Text);
                    else if (System.IO.Path.GetExtension(openFileDialog.FileName).ToLower() == ".rtf")
                        doc.Load(fileStream, DataFormats.Rtf);
                    else
                        doc.Load(fileStream, DataFormats.Xaml);
                    this.Title = "Notepad | " + openFileDialog.FileName.ToString();
                }
            }
        }
        private void MenuItemSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files(*.txt)|*.txt|RichText Files (*.rtf)|*.rtf";

            if (saveFileDialog.ShowDialog() == true)
            {
                TextRange doc = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
                using (FileStream fs = File.Create(saveFileDialog.FileName))
                {
                    if (System.IO.Path.GetExtension(saveFileDialog.FileName).ToLower() == ".txt")
                        doc.Save(fs, DataFormats.Text);
                    else if (System.IO.Path.GetExtension(saveFileDialog.FileName).ToLower() == ".rtf")
                        doc.Save(fs, DataFormats.Rtf);
                    else
                        doc.Save(fs, DataFormats.Xaml);
                }
            }
        }
        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void MenuItemCopy_Click(object sender, RoutedEventArgs e)
        {
            rtbEditor.Copy();
        }
        private void MenuItemPaste_Click(object sender, RoutedEventArgs e)
        {
            rtbEditor.Paste();
        }

        private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            rtbEditor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem);
        }
        private void cmbFontSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            rtbEditor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbFontSize.Text);
        }

        private void rtbEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            object temp;

            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontWeightProperty);
            btnBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));

            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontStyleProperty);
            btnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));
            
            temp = rtbEditor.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            btnUnderline.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));
            
            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            cmbFontFamily.SelectedItem = temp;

            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontSizeProperty);
            cmbFontSize.Text = temp.ToString();

            
            tbNumSimbols.Text = tbNumSimbols.Text = "Line: " + rtbEditor_ComputeCurrentLineNumber().ToString();
        }

        private int rtbEditor_ComputeCurrentLineNumber()
        {
            int someBigNumber = int.MaxValue;
            int lineMoved, currentLineNumber;
            rtbEditor.Selection.Start.GetLineStartPosition(-someBigNumber, out lineMoved);
            currentLineNumber = -lineMoved + 1;
            return currentLineNumber;
        }
    }
}
