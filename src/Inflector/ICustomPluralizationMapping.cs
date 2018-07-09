using System;
namespace Inflector
{
	public interface ICustomPluralizationMapping
	{
		void AddWord(string singular, string plural);
	}
}
