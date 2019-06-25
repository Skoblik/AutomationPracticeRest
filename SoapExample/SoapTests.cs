using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SoapExample
{
	[TestFixture]
    public class SoapTests
    {
	    [Test]
	    public void TestCalculator()
	    {
			var service = new Calculator.CalculatorSoapClient();

			var addOperation = service.Add(120, 130);

			Assert.AreEqual(250, addOperation, "Add operation is wrong");

	    }

	    [Test]
	    public void TestDataAccess()
	    {
		    var service = new DataAccess.NumberConversionSoapTypeClient();

		    var dollars = service.NumberToDollars(1000000);
		    var words = service.NumberToWords(123000);

			Assert.AreEqual("one million dollars", dollars, "Wrong response in NumberToDollars method");
			Assert.AreEqual("one hundred and twenty three thousand", words, "Wrong response in NumberToWords method");

	    }

		[Test]
	    public void Test()
	    {
		    var service = new CountryInfo.CountryInfoServiceSoapTypeClient();

		    var continents = service.ListOfContinentsByName();

		    foreach (var continent in continents)
		    {
			    Console.WriteLine(continent.sCode + " " + continent.sName);
		    }

		    var  languagesNames = service.ListOfLanguagesByName();

		    foreach (var language in languagesNames)
		    {
			    Console.WriteLine(language.sName.Length);
		    }
			Assert.That(languagesNames.Length == 50, "Wrong language names number");
	    }
    }
}
