/**************************************************************************
 * 
 *  Project     : MayaMystic Localization Framework
 *  File        : LanguageType.cs
 *  Author      : Harsh Patel
 *  Company     : MayaMystic
 *  Version     : 1.0.0
 * 
 *  Description :
 *  Defines all supported application languages
 *  used by the MayaMystic Localization Framework.
 *  
 *  This enum is used for:
 *  - Language selection
 *  - Localization asset mapping
 *  - Runtime language switching
 * 
 **************************************************************************/

namespace MayaMystic.Localization.Models
{
	/// <summary>
	/// Defines all supported application languages.
	/// </summary>
	public enum LanguageType
	{
		/// <summary>
		/// English language.
		/// </summary>
		English = 0,

		/// <summary>
		/// Hebrew language.
		/// </summary>
		Hebrew = 1
	}
}