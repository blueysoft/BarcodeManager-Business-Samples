using System;
using System.Linq;
using System.Threading.Tasks;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace ProtocolActivation
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        async Task<ValueSet> LaunchAppForResults(string source)
        {
            var testAppUri = new Uri($"barcodemgr:reader?source={source}");
            var options = new LauncherOptions();
            options.TargetApplicationPackageFamilyName = ((RadioButton)(TargetAppRadioButtons.SelectedItem)).Tag.ToString();

            ValueSet keyValuePairs = null;
            LaunchUriResult result = await Windows.System.Launcher.LaunchUriForResultsAsync(testAppUri, options);
            if (result.Status == LaunchUriStatus.Success &&
                result.Result != null)
            {
                keyValuePairs = result.Result;
            }
            return keyValuePairs;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultFormatTextBox.Text = "";
            ResultDataTextBox.Text = "";
            var ret = await LaunchAppForResults(((Button)sender).Tag.ToString());
            if (ret != null)
            {
                ResultFormatTextBox.Text = ret.FirstOrDefault().Key ?? string.Empty;
                ResultDataTextBox.Text = ret.FirstOrDefault().Value?.ToString() ?? string.Empty;
            }
        }
    }
}
