using System.Net;
using System;
using System.Linq;
using System.Threading;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Xml.Linq;
using OpenQA.Selenium.Remote;
using System.IO.Enumeration;
using System.Runtime.InteropServices;


namespace PhotoGrabber
{
    internal static class Searcher
    {

        private static ChromeDriver driver;
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new Form1());
        }

        public static int searchMedia(string url, string folderName)
        {
            //OpenQA.Selenium.NoSuchWindowException
            int iter = 0;
            string destination = "C:\\imgDown\\" + folderName + "\\";
            try
            {
                Thread.Sleep(1000); // Wait for chromedriver to load
                var chromeDriverService = ChromeDriverService.CreateDefaultService();
                chromeDriverService.HideCommandPromptWindow = true;
                ChromeOptions options = new ChromeOptions();
                string adBlockDirectory = Directory.GetCurrentDirectory() + "\\uBlock-Origin.crx"; // Prevent ad images from being downloaded
                options.AddExtensions(adBlockDirectory);
                driver = new ChromeDriver(chromeDriverService, options = options);
              
                driver.Navigate().GoToUrl(url);
             
                Thread.Sleep(1000); // Give URL time to load
                var Images = driver.FindElements(By.ClassName("post__image")); // Search for class

                Console.WriteLine("Number of Images to Be Downloaded: " + Images.Count());




                // For every i in Images.Count, re assgign images, then click on Images with class type
                for (int i = 0; i < Images.Count(); i++)
                {

                    Images = driver.FindElements(By.ClassName("post__image")); // For every
                    Images[i].Click();
                    Console.WriteLine("starting");
                    Thread.Sleep(1000); // Give each click time to load
                    var imageToSave = driver.FindElements(By.TagName("img")); // Now we look for the img tag and the source
                    Directory.CreateDirectory("C:\\imgDown\\" + folderName); // Create a new directory for the search\

                    // Iterate for every image count
                    for (int j = 0; j < imageToSave.Count(); j++)
                    {

                        var imageURL = imageToSave[j].GetAttribute("src"); // Get the image URL source

                        Random rnd = new Random(); // Generates a random number to create filename
                        int num = rnd.Next();
                        
                        Console.WriteLine(j + " | Viewing: " + imageURL + " | saving as :" + folderName + num + ".jpeg"); // Testing only, outputs currently viewing 
                        WebClient downloadCurImage = new WebClient();

                        // Generates a random number to create filename

                        downloadCurImage.DownloadFile(imageURL, destination + folderName + num + ".jpeg");


                    }
                    iter++;
                    
                    Console.WriteLine(iter);
                    Thread.Sleep(250);

                    driver.Navigate().Back(); // Navigate backwards to click on the image next to previous one.

                }


            }
            catch (OpenQA.Selenium.NoSuchWindowException e)
            {
                // Empty, quiet stop
            }
            catch(System.ObjectDisposedException e) 
            {
                //Empty, quiet stop
            }

            return iter;
        }

        public static void quitDriver()
        {
            driver.Quit();
        }
    }
}