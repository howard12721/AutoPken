using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;
using System.Threading.Tasks;

namespace auto_pken
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        int delay = 0;
        int miss = 0;

        private void startButtonClicked(object sender, EventArgs e)
        {
            Task.Run(() => 
            {
                int delay = this.delay;
                int miss = this.miss;

                Random random = new Random();

                try
                {
                    //最大化して起動
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--start-maximized");
                    IWebDriver driver = new ChromeDriver(options);

                    //検定画面を開く
                    driver.Navigate().GoToUrl("https://manabi-gakushu.benesse.ne.jp/gakushu/typing/nihongonyuryoku.html?_gl=1*1xu4lpp*_ga*NzkyNTEwNTMxLjE2NTAwMjI1NTU.*_ga_1YYYR3J6VM*MTY1MDc3Nzc4OC4zLjAuMTY1MDc3Nzc4OC42MA..");

                    //スタートボタンを押す
                    driver.FindElement(By.XPath("//*[@id=\"goSettingButton\"]")).Click();

                    //時間を一分に設定
                    IWebElement slider = driver.FindElement(By.XPath("//*[@id=\"timeLimitButton\"]"));
                    Actions action = new Actions(driver);
                    action.DragAndDropToOffset(slider, -500, 0);
                    action.Perform();

                    //タイピングスタートボタンを押す
                    driver.FindElement(By.XPath("//*[@class=\"typingButton\"]")).Click();

                    //スペースキーを押す
                    new Actions(driver).KeyDown(OpenQA.Selenium.Keys.Space).KeyUp(OpenQA.Selenium.Keys.Space).Perform();

                    while (true)
                    {
                        IWebElement element = driver.FindElement(By.XPath("//*[@id=\"remaining\"]"));
                        if (element == null) continue;
                        if (element.Text == null) continue;
                        if (element.Text.Length == 0) continue;
                        if (miss == 0 && delay == 0)
                        {
                            new Actions(driver).SendKeys(element.Text).Perform();
                        }
                        else
                        {
                            foreach (char c in element.Text)
                            {
                                while (random.Next(100) < miss)
                                {
                                    int key = random.Next(65, 90);
                                    if (key == c) {
                                        key++;
                                    }
                                    new Actions(driver).SendKeys(((char)key).ToString()).Perform();
                                    Thread.Sleep(delay);
                                }
                                new Actions(driver).SendKeys(c.ToString()).Perform();
                                Thread.Sleep(delay);
                            }
                        }
                    }
                }
                catch
                {
                    return;
                }
            });

        }

        private void mainFormLoad(object sender, EventArgs e)
        {

        }

        private void delayBox_TextChanged(object sender, EventArgs e)
        {
            string text = ((TextBox)sender).Text;
            if (text.Length != 0)
            {
                delay = int.Parse(text);
            }
        }

        private void missBox_TextChanged(object sender, EventArgs e)
        {
            string text = ((TextBox)sender).Text;
            if (text.Length != 0)
            {
                miss = int.Parse(text);
            }
        }

        private void delayBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void missBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
