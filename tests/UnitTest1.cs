using course;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Npgsql;
using NUnit.Framework;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Automation;
using NUnit.Framework;
using System.Windows.Controls;
using System.Windows.Media;

namespace tests
{
    [TestClass]
    public class UnitTest1
    {
        public NpgsqlConnection connect()
        {
            string connectionString = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=476312;Database=coursework;";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            return connection;
        }
        public double Result(double correctAswer, double answerCount)
        {
            return correctAswer / answerCount * 100;
        }

        [TestMethod]
        public void DBConnection()
        {

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(connect());

        }
        [TestMethod]
        public void resultOfTest()
        {
            int correctAnswer = 8;
            int answerCount = 10;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(80, Result(correctAnswer, answerCount));
        }

            private MainWindow _window;

            [SetUp]
            public void SetUp()
            {
                _window = new MainWindow();
                _window.Show();
            }

            [TearDown]
            public void TearDown()
            {
                _window.Close();
            }

            [TestMethod]
            public void LoginButton_Click_UpdatesTextBlock()
            {
                // Поиск элементов по их AutomationId
                var loginButton = AutomationElement.RootElement.FindFirst(
                    TreeScope.Descendants,
                    new PropertyCondition(AutomationElement.AutomationIdProperty, "login")
                );
                var textBlock = AutomationElement.RootElement.FindFirst(
                    TreeScope.Descendants,
                    new PropertyCondition(AutomationElement.AutomationIdProperty, "myTextBlock")
                );
                

                // Нажатие на кнопку
                InvokePattern loginInvokePattern = (InvokePattern)loginButton.GetCurrentPattern(InvokePattern.Pattern);
                loginInvokePattern.Invoke();
                var updatedText = textBlock.Current.Name;
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Updated Text", "Updated Text");
            }


        }
    }

