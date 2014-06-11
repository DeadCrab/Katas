using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KATA.RomanNumeral.Application.Interface
{
	public interface IArabicToRomanApplicationService
	{
		string GetRomanValueFrom(int input);
	}
}
