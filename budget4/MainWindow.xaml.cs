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

namespace budget4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Record> records = new List<Record>();
        List<Record> TodayRecords = new List<Record>();
        List<string> types = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            records = Converter.MyDeserialize<List<Record>>();
            types = Converter.MyDeserialize2<List<string>>();
            DatePick.Text = DateTime.Now.ToString();
        }

        private void DG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TodayRecords.Clear();
            foreach (Record rr in records)
            {
                if (rr.Date.Date == Convert.ToDateTime(DatePick.SelectedDate).Date)
                {
                    TodayRecords.Add(rr);
                }
            }
            DG.ItemsSource = TodayRecords;
           
            int summa = 0;
            foreach (Record item in records) 
            {
                if (item.IsIncome)
                {
                    summa += item.Money;
                }

                else
                {
                    item.Money *= -1;
                    summa += item.Money;
                }
            }
            total.Text = "Итого: " + summa;
            RecordName.Text = "";
            summma.Text = "";
            TypesList.SelectedItem = null;
            TypesList.Items.Clear();
            foreach (string item in types)
            {
                TypesList.Items.Add(item);
            }
            Converter.MySerialize0(records);
            Converter.MySerialize1(types);
        }

        private void AddNewType(object sender, RoutedEventArgs e)
        {
            AddTypes type = new AddTypes();
            type.ShowDialog();
            if ((bool)type.DialogResult)
            {
                types.Add(type.Types.Text);
                TypesList.Items.Add(type.Types.Text);
            }
            TodayRecords.Clear();
            foreach (Record rr in records)
            {
                if (rr.Date.Date == Convert.ToDateTime(DatePick.SelectedDate).Date)
                {
                    TodayRecords.Add(rr);
                }
            }
            DG.ItemsSource = TodayRecords;

            int summa = 0;
            foreach (Record item in records)
            {
                if (item.IsIncome)
                {
                    summa += item.Money;
                }

                else
                {
                    item.Money *= -1;
                    summa += item.Money;
                }
            }
            total.Text = "Итого: " + summa;
            RecordName.Text = "";
            summma.Text = "";
            TypesList.SelectedItem = null;
            TypesList.Items.Clear();
            foreach (string item in types)
            {
                TypesList.Items.Add(item);
            }
            Converter.MySerialize0(records);
            Converter.MySerialize1(types);
        }

        private void AddRecord(object sender, RoutedEventArgs e)
        {
            records.Add(new Record(RecordName.Text, TypesList.Text, Convert.ToInt32(summma.Text), Convert.ToDateTime(DatePick.SelectedDate)));
            TodayRecords.Clear();
            foreach (Record rr in records)
            {
                if (rr.Date.Date == Convert.ToDateTime(DatePick.SelectedDate).Date)
                {
                    TodayRecords.Add(rr);
                }
            }
            DG.ItemsSource = TodayRecords;

            int summa = 0;
            foreach (Record item in records)
            {
                if (item.IsIncome)
                {
                    summa += item.Money;
                }

                else
                {
                    item.Money *= -1;
                    summa += item.Money;
                }
            }
            total.Text = "Итого: " + summa;
            RecordName.Text = "";
            summma.Text = "";
            TypesList.SelectedItem = null;
            TypesList.Items.Clear();
            foreach (string item in types)
            {
                TypesList.Items.Add(item);
            }
            Converter.MySerialize0(records);
            Converter.MySerialize1(types);
        }

        private void ChangeSelectedRecord(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItems.Count != 0)
            {
                records[records.IndexOf(TodayRecords[DG.SelectedIndex])].Name = RecordName.Text;
                records[records.IndexOf(TodayRecords[DG.SelectedIndex])].Type = TypesList.Text;
                TodayRecords.Clear();
                foreach (Record rr in records)
                {
                    if (rr.Date.Date == Convert.ToDateTime(DatePick.SelectedDate).Date)
                    {
                        TodayRecords.Add(rr);
                    }
                }
                DG.ItemsSource = TodayRecords;

                int summa = 0;
                foreach (Record item in records)
                {
                    if (item.IsIncome)
                    {
                        summa += item.Money;
                    }

                    else
                    {
                        item.Money *= -1;
                        summa += item.Money;
                    }
                }
                total.Text = "Итого: " + summa;
                RecordName.Text = "";
                summma.Text = "";
                TypesList.SelectedItem = null;
                TypesList.Items.Clear();
                foreach (string item in types)
                {
                    TypesList.Items.Add(item);
                }
                Converter.MySerialize0(records);
                Converter.MySerialize1(types);
            }

        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItems.Count != 0)
            {
                records.RemoveAt(records.IndexOf(TodayRecords[DG.SelectedIndex]));
                TodayRecords.Clear();
                foreach (Record rr in records)
                {
                    if (rr.Date.Date == Convert.ToDateTime(DatePick.SelectedDate).Date)
                    {
                        TodayRecords.Add(rr);
                    }
                }
                DG.ItemsSource = TodayRecords;

                int summa = 0;
                foreach (Record item in records)
                {
                    if (item.IsIncome)
                    {
                        summa += item.Money;
                    }

                    else
                    {
                        item.Money *= -1;
                        summa += item.Money;
                    }
                }
                total.Text = "Итого: " + summa;
                RecordName.Text = "";
                summma.Text = "";
                TypesList.SelectedItem = null;
                TypesList.Items.Clear();
                foreach (string item in types)
                {
                    TypesList.Items.Add(item);
                }
                Converter.MySerialize0(records);
                Converter.MySerialize1(types);
            }
            else
            {
                MessageBox.Show("Выберите запись, которую хотите удалить");
            }

        }
    }
}
