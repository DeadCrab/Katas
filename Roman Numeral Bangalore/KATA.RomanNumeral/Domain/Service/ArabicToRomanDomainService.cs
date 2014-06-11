using KATA.RomanNumeral.Domain.Enum;
using KATA.RomanNumeral.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace KATA.RomanNumeral.Domain.Service
{
	public class ArabicToRomanDomainService : IArabicToRomanDomainService
	{

		public string GetRomanValue(int input)
		{
			string result = string.Empty;
			
			if (input > 3000 || input < 1)
			{
				throw new IndexOutOfRangeException();
			}

			if (input <= 3 && input > 1)
			{
				for (int i = 1; i <= input; i++)
				{
					result += GetRomanConstant(1);
				}

				return result;
			}


			if(input == 4)
			{
				return String.Format(CultureInfo.InvariantCulture, "{0}{1}",((RomanConstant)1).ToString(), ((RomanConstant)5).ToString());			
			}

			if(input > 5 && input < 9)
			{
				return String.Format(CultureInfo.InvariantCulture, "{0}{1}", ((RomanConstant)5).ToString(), GetRomanValue(input - 5));			
			}

			if(input == 9)
			{
				return String.Format(CultureInfo.InvariantCulture, "{0}{1}", ((RomanConstant)1).ToString(), ((RomanConstant)10).ToString());			
			}

			return GetRomanConstant(input);
		}

		private string GetRomanConstant(int input)
		{
			return ((RomanConstant)input).ToString();
		}

	}
}
