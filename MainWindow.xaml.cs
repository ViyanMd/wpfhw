using System.Windows;
using System.Windows.Controls;

namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal leftNumber = 0;
        decimal rightNumber = 0;
        string currentOperation = String.Empty;
        bool inputStatus = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt_numClicked(object sender, RoutedEventArgs e)
        {
            Button selectedBtn = (Button)sender;

            if (!String.IsNullOrEmpty(currentOperation) && inputStatus)
            {
                label_result.Text = String.Empty;
                inputStatus = false;
            }

            label_operations.Text += selectedBtn.Content.ToString();

            label_result.Text += selectedBtn.Content.ToString();
        }
        private void bt_operationClicked(object sender, RoutedEventArgs e)
        {
            Button selectedBtn = (Button)sender;

            var operation = selectedBtn.Content.ToString();

            label_operations.Text += operation;

            if (String.IsNullOrEmpty(currentOperation))
            {
                leftNumber = Decimal.Parse(label_result.Text);
            }
            else
            {
                rightNumber = Decimal.Parse(label_result.Text);

                switch (currentOperation)
                {
                    case "+":
                        leftNumber += rightNumber;
                        break;
                    case "-":
                        leftNumber -= rightNumber;
                        break;
                    case "/":
                        leftNumber /= rightNumber;
                        break;
                    case "*":
                        leftNumber *= rightNumber;
                        break;
                    case "=":
                        label_result.Text = leftNumber.ToString("F2");
                        break;
                    default:
                        break;
                }

                label_result.Text = leftNumber.ToString("F2");
                label_operations.Text = leftNumber.ToString("F2") + (operation == "=" ? ' ' : operation);
            }

            currentOperation = operation;
            inputStatus = true;
        }

        private void bt_clearClicked(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            var typeClear = button.Content.ToString();

            switch(typeClear)
            {
                case "CE":
                    label_result.Text = String.Empty;
                    break;
                case "C":
                    label_result.Text = String.Empty;
                    label_operations.Text = String.Empty;
                    currentOperation = String.Empty;
                    break;
                case "<":
                    label_result.Text = label_result.Text.Substring(0, label_result.Text.Length - 1);
                    break;
                default:
                    break;
            }
        }
    }
}
