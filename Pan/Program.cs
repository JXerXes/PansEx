using Pan;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
var drive = new ChromeDriver();
drive.Url = https://rozetka.com.ua/skovorody/c4626754/
drive.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


var tempBase = new PansDataBase();

tempBase.ConnectionCreate();
