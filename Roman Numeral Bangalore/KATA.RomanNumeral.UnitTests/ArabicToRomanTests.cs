using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KATA.RomanNumeral.Application.Interface;
using KATA.RomanNumeral.Application.Service;
using KATA.RomanNumeral.Domain.Interface;
using KATA.RomanNumeral.Domain.Service;

namespace KATA.RomanNumeral.UnitTests
{
	[TestClass]
	public class ArabicToRomanTests
	{
		IArabicToRomanApplicationService arabicToRomanApplicationService;

		[TestInitialize]
		public void TestInitializer()
		{
			IArabicToRomanDomainService arabicToRomanDomainService = new ArabicToRomanDomainService();
			arabicToRomanApplicationService = new ArabicToRomanApplicationService(arabicToRomanDomainService);
		}


		# region Scope Of Application
		[TestMethod]
		[ExpectedException(typeof(IndexOutOfRangeException))]
		public void test_value_greater_than_3000()
		{
			var input = 3001;
			var result = arabicToRomanApplicationService.GetRomanValueFrom(input);
		}

		[TestMethod]
		[ExpectedException(typeof(IndexOutOfRangeException))]
		public void test_value_less_than_1()
		{
			var input = 0;
			var result = arabicToRomanApplicationService.GetRomanValueFrom(input);
		}
		#endregion


		# region Roman Constant Tests
		[TestMethod]
		public void aa_one()
		{
			var input = 1;
			var expectedOutput = "I";
			var result = arabicToRomanApplicationService.GetRomanValueFrom(input);
			Assert.AreEqual(expectedOutput, result);
		}

		[TestMethod]
		public void ab_five()
		{
			var input = 5;
			var expectedOutput = "V";
			var result = arabicToRomanApplicationService.GetRomanValueFrom(input);
			Assert.AreEqual(expectedOutput, result);
		}

		[TestMethod]
		public void ac_ten()
		{
			var input = 10;
			var expectedOutput = "X";
			var result = arabicToRomanApplicationService.GetRomanValueFrom(input);
			Assert.AreEqual(expectedOutput, result);
		}

		[TestMethod]
		public void ad_fifty()
		{
			var input = 50;
			var expectedOutput = "L";
			var result = arabicToRomanApplicationService.GetRomanValueFrom(input);
			Assert.AreEqual(expectedOutput, result);
		}

		[TestMethod]
		public void ae_one_hundred()
		{
			var input = 100;
			var expectedOutput = "C";
			var result = arabicToRomanApplicationService.GetRomanValueFrom(input);
			Assert.AreEqual(expectedOutput, result);
		}

		[TestMethod]
		public void af_five_hundred()
		{
			var input = 500;
			var expectedOutput = "D";
			var result = arabicToRomanApplicationService.GetRomanValueFrom(input);
			Assert.AreEqual(expectedOutput, result);
		}

		[TestMethod]
		public void ag_one_thousand()
		{
			var input = 1000;
			var expectedOutput = "M";
			var result = arabicToRomanApplicationService.GetRomanValueFrom(input);
			Assert.AreEqual(expectedOutput, result);
		}

		#endregion



		#region RomanNonStandards
		[TestMethod]
		public void ba_two()
		{			
			var input = 2;
			var expectedOutput = "II";			
			var result = arabicToRomanApplicationService.GetRomanValueFrom(input);			
			Assert.AreEqual(expectedOutput, result);
		}

		[TestMethod]
		public void bb_three()
		{
			var input = 3;
			var expectedOutput = "III";
			var result = arabicToRomanApplicationService.GetRomanValueFrom(input);
			Assert.AreEqual(expectedOutput, result);
		}


		[TestMethod]
		public void bc_four()
		{			
			var input = 4;
			var expectedOutput = "IV";
			var result = arabicToRomanApplicationService.GetRomanValueFrom(input);			
			Assert.AreEqual(expectedOutput, result);
		}


		[TestMethod]
		public void bd_six()
		{
			var input = 6;
			var expectedOutput = "VI";
			var result = arabicToRomanApplicationService.GetRomanValueFrom(input);
			Assert.AreEqual(expectedOutput, result);
		}


		[TestMethod]
		public void be_seven()
		{
			var input = 7;
			var expectedOutput = "VII";
			var result = arabicToRomanApplicationService.GetRomanValueFrom(input);
			Assert.AreEqual(expectedOutput, result);
		}

		[TestMethod]
		public void bf_eight()
		{
			var input = 8;
			var expectedOutput = "VIII";
			var result = arabicToRomanApplicationService.GetRomanValueFrom(input);
			Assert.AreEqual(expectedOutput, result);
		}

		[TestMethod]
		public void bg_nine()
		{
			var input = 9;
			var expectedOutput = "IX";
			var result = arabicToRomanApplicationService.GetRomanValueFrom(input);
			Assert.AreEqual(expectedOutput, result);
		}

		#endregion
	}
}
