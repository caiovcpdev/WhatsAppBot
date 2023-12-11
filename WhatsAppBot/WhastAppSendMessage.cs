using EasyAutomationFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WhatsAppBot
{
    public class WhastAppSendMessage : Web
    {
        public void SendMessage(string messagem, string destinatario)
        {
            StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\caio\\AppData\\Local\\Google\\Chrome\\User Data");
            Navigate("https://web.whatsapp.com");
            WaitForLoad();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            var elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div[2]/div[2]/div/div", destinatario);
            elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);
            var elementMessage = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div[2]/div[1]", messagem);
            elementMessage.element.SendKeys(OpenQA.Selenium.Keys.Enter);
        }

        public void SendImage(string message, string pathImage, string destinatario)
        {
            StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\caio\\AppData\\Local\\Google\\Chrome\\User Data");
            Navigate("https://web.whatsapp.com");
            WaitForLoad();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            var elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div[2]/div[2]/div/div", destinatario);
            elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            //clicar no botao clip
            Click(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[1]/div/div/div/div/span");


            AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[1]/div/div/span/div/ul/div/div[2]/li/div/input", pathImage);
            Click(TypeElement.Xpath, "//*[@id=\"app\"]/div/div[2]/div[2]/div[2]/span/div/span/div/div/div[2]/div/div[2]/div[2]/div/div/span");
            //WaitForLoad();

        }

        public void SendEmoji(string message, List<string> emojis, string destinatario)
        {
            StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\caio\\AppData\\Local\\Google\\Chrome\\User Data");
            Navigate("https://web.whatsapp.com");
            WaitForLoad();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            var elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div[2]/div[2]/div/div", destinatario);
            elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            foreach (var emoji in emojis)
            {
                AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p", ":");
                var element = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p", emoji);
                element.element.SendKeys(OpenQA.Selenium.Keys.Tab);
            }

            var elementInput = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p", message);
            elementInput.element.SendKeys(OpenQA.Selenium.Keys.Enter);
        }
    }
}
