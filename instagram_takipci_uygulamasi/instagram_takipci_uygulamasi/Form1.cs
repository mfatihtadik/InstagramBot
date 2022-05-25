using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace instagram_takipci_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.instagram.com");
            
            Thread.Sleep(2000);

            IWebElement kuladi = driver.FindElement(By.Name("username"));
            IWebElement sifre = driver.FindElement(By.Name("password"));
            IWebElement girButon = driver.FindElement(By.CssSelector(".sqdOP.L3NKy.y3zKF"));
            

            kuladi.SendKeys(txtKadi.Text);
            sifre.SendKeys(txtSifre.Text);

            girButon.Click();
            
            Thread.Sleep(3000);

            driver.Navigate().GoToUrl("https://www.instagram.com/"+txtKadi.Text);
            Thread.Sleep(2500);

            IWebElement followersLink = driver.FindElement(By.CssSelector("#react-root > section > main > div > header > section > ul > li:nth-child(2) > a"));
            followersLink.Click();
            Thread.Sleep(3000);

            //ScrollDown Başlangıç
            //isgrP

            string jscommand = "" +
                "sayfa=document.querySelector('.isgrP');" +
                "sayfa.scrollTo(0,sayfa.scrollHeight);" +
                "var sayfaSonu = sayfa.scrollHeight;" +
                "return sayfaSonu;";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            var sayfaSonu = Convert.ToInt32(js.ExecuteScript(jscommand));

            while (true)
            {
                var son = sayfaSonu;
                Thread.Sleep(1000);
                sayfaSonu = Convert.ToInt32(js.ExecuteScript(jscommand));
                if (son == sayfaSonu)
                    break;
            }



            //ScrollDown Sonu




            //Takipçi Listeleme Başlangıcı


            int sayac = 1;

            IReadOnlyCollection<IWebElement> followers = driver.FindElements(By.CssSelector(".FPmhX.notranslate._0imsa"));

            foreach (IWebElement follower in followers)
            {

                lbxTakipciler.Items.Add(follower.Text);
                //Console.WriteLine(sayac + " ==> " + follower.Text);
                sayac++;

            }


            //Takipçi Listeleme Sonu
            Thread.Sleep(5000);

            driver.Navigate().GoToUrl("https://www.instagram.com/" + txtKadi.Text);

            IWebElement followLink = driver.FindElement(By.CssSelector("#react-root > section > main > div > header > section > ul > li:nth-child(3) > a"));
            followLink.Click();
            Thread.Sleep(3000);

            //ScrollDown Başlangıç
            

            
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            var sayfaSonu2 = Convert.ToInt32(js.ExecuteScript(jscommand));

            while (true)
            {
                var son2 = sayfaSonu2;
                Thread.Sleep(1000);
                sayfaSonu2 = Convert.ToInt32(js.ExecuteScript(jscommand));
                if (son2 == sayfaSonu2)
                    break;
            }

            //ScrollDown Sonu



            //Takip Edilen Listeleme Başlangıcı


            int sayac2 = 1;

            IReadOnlyCollection<IWebElement> followed = driver.FindElements(By.CssSelector(".FPmhX.notranslate._0imsa"));

            foreach (IWebElement follower in followed)
            {
                              
                        lbxTakipEdilen.Items.Add(follower.Text);
                        //Console.WriteLine(sayac + " ==> " + follower.Text);
                        sayac2++;
                

            }


            //Takip Edilen Listeleme Sonu
            Thread.Sleep(2000);

            driver.Navigate().GoToUrl("https://www.instagram.com/" + txtKadi.Text);


            label8.Text = lbxTakipciler.Items.Count.ToString();
            label9.Text = lbxTakipEdilen.Items.Count.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //(Listbox 1.-2.)İki Grupta aynı olanları listelettik. (Karşılıklı takip ettiklerimiz...)
            lbxTakiplestiklerin.DataSource = lbxTakipciler.Items.OfType<string>().ToArray().Intersect(lbxTakipEdilen.Items.OfType<string>().ToArray()).Union(lbxTakipEdilen.Items.OfType<string>().ToArray().Intersect(lbxTakipciler.Items.OfType<string>().ToArray())).ToArray();

            Thread.Sleep(1500);

            //(Listbox 2.-3.)İki Grupta farklı olanları listelettik. (Takip ettiklerim != Karşılıklı takip edilen = Takip)
            lbxTakipEtmeyenler.DataSource = lbxTakipEdilen.Items.OfType<string>().ToArray().Except(lbxTakiplestiklerin.Items.OfType<string>().ToArray()).Union(lbxTakiplestiklerin.Items.OfType<string>().ToArray().Except(lbxTakipEdilen.Items.OfType<string>().ToArray())).ToArray();

            Thread.Sleep(1500);

            
            label10.Text = lbxTakiplestiklerin.Items.Count.ToString();
            label11.Text = lbxTakipEtmeyenler.Items.Count.ToString();

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
