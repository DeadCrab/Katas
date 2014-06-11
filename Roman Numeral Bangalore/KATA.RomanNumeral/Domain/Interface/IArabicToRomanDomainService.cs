using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KATA.RomanNumeral.Domain.Interface
{
	public interface IArabicToRomanDomainService
	{
		string GetRomanValue(int input);
	}
}
