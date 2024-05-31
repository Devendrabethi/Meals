using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

public class Login
{

    static public void Main()
    {

        //Launch
        IWebDriver  driver=   new ChromeDriver();
        driver.Navigate().GoToUrl("https://nhmealsportal2.azurewebsites.net/");
        driver.Manage().Window.Maximize();
        Thread.Sleep(1000);


        //Login

        driver.FindElement(By.XPath("//input[@id = 'loginUserName']")).SendKeys("SabAtta");
        driver.FindElement(By.XPath("//input[@id = 'loginPassword']")).SendKeys("Tb4j7M8Fa");
        driver.FindElement(By.XPath("//button[@id = 'loginbtn']")).Click();
        Thread.Sleep(3000);


        //Member Search

        driver.FindElement(By.XPath("//input[@id='floatingInputInsuranceMemberId']")).SendKeys("Hum567654");
        driver.FindElement(By.XPath("//button[text()='Search']")).Click();
        Thread.Sleep(2000);

        //Action mouse hover

        IWebElement mname = driver.FindElement(By.XPath("(//div[contains(@class,'show-tooltip')])[1]"));
        IWebElement Hplan = driver.FindElement(By.XPath("(//div[contains(@class,'show-tooltip')])[2]"));
        IWebElement Address = driver.FindElement(By.XPath("(//div[contains(@class,'show-tooltip')])[3]"));

        Actions a = new Actions(driver);
        a.MoveToElement(mname).Perform();
        a.MoveToElement(Hplan).Perform();
        a.MoveToElement(Address).Perform();


        //Search Result

        driver.FindElement(By.XPath("//tr[@class='cursor-pointer']")).Click();

        // Create Order

        driver.FindElement(By.XPath("//a[@id='btnCreateOrder']")).Click();
        Thread.Sleep(2000);

        // Selecting PD

        driver.FindElement(By.XPath("//input[@id='MEALS_PD14B2MD1SH4DISYR']")).Click();

        //Discharge Date
        driver.FindElement(By.XPath("//div[@id='crossIconDischargeDate']/input")).Click();

        //disappear discharge date
        driver.FindElement(By.XPath("//div[@id='benefitSelectionRightsection']//ancestor::div[contains(@class,'col-lg-3')]")).Click();

        //Discharge Date
        driver.FindElement(By.XPath("//div[@id='crossIconDischargeDate']/input")).Click();
        Thread.Sleep(500);
        //Previous month
        
        try
        {
            driver.FindElement(By.XPath("//span[contains(text(),'Prev')]")).Click();
        }
        catch
        {
        
        }

        //Next month
        driver.FindElement(By.XPath("//span[contains(text(),'Next')]")).Click();

        //Date selecting
        driver.FindElement(By.XPath("//td[contains(@class,'ui-datepicker-today')]/preceding-sibling::td[1]")).Click();

        //continue

        driver.FindElement(By.XPath("//button[@id='btnBenefitSelection']")).Click();

        //Meal Preference

        driver.FindElement(By.XPath("//button[@id='btnDropdownLabelForDietary']")).Click();
        Thread.Sleep(1000);
        driver.FindElement(By.XPath("//label[contains(text(),'General Wellness')]")).Click();

        Thread.Sleep(500);

        //Exclusion
        driver.FindElement(By.XPath("//button[@id='btnDropdownLabelForExclusions']")).Click();
        driver.FindElement(By.XPath("//button[@id='btnDropdownLabelForExclusions']/following-sibling::ul/li//input[@id='Chicken']")).Click();
        driver.FindElement(By.XPath("//button[@id='btnDropdownLabelForExclusions']/following-sibling::ul/li//input[@id='Beef']")).Click();
        driver.FindElement(By.XPath("//button[@id='btnDropdownLabelForExclusions']/following-sibling::ul/li//input[@id='Turkey']")).Click();

        //MoveToElement
        IWebElement  mushroom = driver.FindElement(By.XPath("//button[@id='btnDropdownLabelForExclusions']/following-sibling::ul/li//input[@id='Mushroom']"));
        IWebElement Gluten = driver.FindElement(By.XPath("//button[@id='btnDropdownLabelForExclusions']/following-sibling::ul/li//input[@id='Gluten']"));

        //Action
       
        a.MoveToElement(mushroom);
        a.MoveToElement(Gluten);
        Thread.Sleep(2000);
        mushroom.Click();
        Gluten.Click();

        //Image expand

        driver.FindElement(By.XPath("(//span[contains(@class,'popup-icon')])[1]")).Click();
        Thread.Sleep(500);
        driver.FindElement(By.XPath("//img[@id='maxMealPreferenceImg']/parent::div/preceding-sibling::div/button")).Click();
        Thread.Sleep(500);

        //Food Allergies

        driver.FindElement(By.XPath("//button[@id='btnDropdownLabelForAllergic']")).Click();
        driver.FindElement(By.XPath("//input[@id='Egg']")).Click();
        driver.FindElement(By.XPath("//input[@id='Shellfish']")).Click();
        driver.FindElement(By.XPath("//input[@id='Wheat']")).Click();


        IWebElement soy = driver.FindElement(By.XPath("//input[@id='Soy']"));
        IWebElement Sesame = driver.FindElement(By.XPath("//input[@id='Sesame']"));
        IWebElement TNuts = driver.FindElement(By.XPath("//input[@id='Tree Nuts']"));
        IWebElement Milk = driver.FindElement(By.XPath("//input[@id='Milk']"));
        IWebElement Peanuts = driver.FindElement(By.XPath("//input[@id='Peanuts']"));
        IWebElement Fish = driver.FindElement(By.XPath("//input[@id='Fish']"));

        a.MoveToElement(soy);
        a.MoveToElement(Sesame);
        a.MoveToElement(TNuts);
        a.MoveToElement(Fish);
        a.MoveToElement(Peanuts);
        a.MoveToElement(Milk);

        //Benefit Selection edit

        driver.FindElement(By.XPath("//div[@id='benefitSelectionRightsection']")).Click();

        //Back to benefit selection

        driver.FindElement(By.XPath("(//button[contains(text(),'Back')])[1]")).Click();

        //Continu to Meal Preference

        driver.FindElement(By.XPath("//button[@id='btnBenefitSelection']")).Click();
        Thread.Sleep(2000);

        //Selecting Dietary

        driver.FindElement(By.XPath("//button[@id='btnDropdownLabelForDietary']")).Click();
        driver.FindElement(By.XPath("(//button[@id='btnDropdownLabelForDietary']/following-sibling::ul/li)[1]")).Click();
        Thread.Sleep(1000);

        //Continue to Delivery Info
        driver.FindElement(By.XPath("//button[@id='btnMealPreference']")).Click();

        //Delivery Info Page
        //changeing the repositary
        //changeing the repositary
        //changeing the repositary
        //changeing the repositary



        driver.FindElement(By.XPath("//div[@id='dv5690411']/div/div/span[2]")).Click();
        Thread.Sleep(1000);

        //Ground 1 day to delivery

        driver.FindElement(By.XPath("//input[@id='txtZipcode']")).SendKeys("32815");
        driver.FindElement(By.XPath("//button[@id='btnstayingApartmentNo']")).Click();
        driver.FindElement(By.XPath("//button[@id='btnHasGateCodeNo']")).Click();
        driver.FindElement(By.XPath("//button[@id='btnValidateAddress']")).Click();
        Thread.Sleep(2000);
        driver.FindElement(By.XPath("(//button[contains(text(),'Use Entered Address')])[2]")).Click();
        Thread.Sleep(2000);

        //Delivery Alert

        driver.FindElement(By.XPath("(//h5[contains(text(),'Address is not verified')]/parent::div/preceding-sibling::div/button)[1]")).Click();
        driver.FindElement(By.XPath("(//button[contains(text(),'Use Entered Address')])[2]")).Click();
        Thread.Sleep(1000);
        driver.FindElement(By.XPath("//input[@id='chkUseEnteredAddress']")).Click();
        driver.FindElement(By.XPath("//button[@id='btnContinue']")).Click();
        Thread.Sleep(2000);

        //Delivery Date

        driver.FindElement(By.XPath("//input[@id='txtdtDeliveryDate']")).Click();
        driver.FindElement(By.XPath("//a[contains(@class,'ui-state-active')]")).Click();

        //Place Order
        driver.FindElement(By.XPath("//button[@id='btnPlaceOrder']")).Click();
        Thread.Sleep(5000);

        //Cancellation Order.

        driver.FindElement(By.XPath("//div[@class='order-wrapper']/div[1]")).Click();
        driver.FindElement(By.XPath("//button[@id='cancelorderbtn']")).Click();
        Thread.Sleep(500);
        driver.FindElement(By.XPath("//button[@id='btnOrderCancelReason']")).Click();
        driver.FindElement(By.XPath("//li[@id='Inpatientdischargedateispostponed']")).Click();
        Thread.Sleep(500);
        driver.FindElement(By.XPath("//button[@id='btncancelorder']")).Click();




    }
}