using KATA.RomanNumeral.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KATA.RomanNumeral.Domain.Interface;

namespace KATA.RomanNumeral.Application.Service
{
	public class ArabicToRomanApplicationService : IArabicToRomanApplicationService
	{
		private IArabicToRomanDomainService arabicToRomanDomainService;
		public ArabicToRomanApplicationService(IArabicToRomanDomainService arabicToRomanDomainService)
		{
			this.arabicToRomanDomainService = arabicToRomanDomainService;
		}
		public string GetRomanValueFrom(int input)
		{
			return this.arabicToRomanDomainService.GetRomanValue(input);
		}
	}
}
