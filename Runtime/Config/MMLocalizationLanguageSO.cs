/**************************************************************************
 * 
 *  Project     : MayaMystic Localization Framework
 *  File        : MMLocalizationLanguageSO.cs
 *  Author      : Harsh Patel
 *  Company     : MayaMystic
 *  Version     : 1.0.0
 * 
 *  Description :
 *  ScriptableObject that stores all localization-related data
 *  for a specific language in the MayaMystic Localization Framework.
 *  
 *  Includes:
 *  - Language identification
 *  - Font references
 *  - Screen-specific localization assets
 *  
 **************************************************************************/

using TMPro;
using UnityEngine;
using MayaMystic.Localization.Models;
using MayaMystic.Localization.Screens.Login;

namespace MayaMystic.Localization.Config
{
	/// <summary>
	/// ScriptableObject that stores localized assets and
	/// configuration data for a specific language.
	/// </summary>
	[CreateAssetMenu(
		fileName = "MM_LocalizationLanguage",
		menuName = "MayaMystic/Localization/Language")]
	public class MMLocalizationLanguageSO :
		ScriptableObject
	{
		#region Language

		/// <summary>
		/// Language configuration section.
		/// </summary>
		[Header("Language")]

		/// <summary>
		/// Defines the language type represented by this asset.
		/// </summary>
		public LanguageType languageType;

		#endregion

		#region Fonts

		/// <summary>
		/// Font configuration section.
		/// </summary>
		[Header("Fonts")]

		/// <summary>
		/// Font used for headers and titles.
		/// </summary>
		public TMP_FontAsset headerFont;

		/// <summary>
		/// Font used for subheaders and secondary titles.
		/// </summary>
		public TMP_FontAsset subHeaderFont;

		/// <summary>
		/// Default font used for regular text content.
		/// </summary>
		public TMP_FontAsset regularFont;

		#endregion

		#region Screens

		/// <summary>
		/// Screen localization asset references section.
		/// </summary>
		[Header("Screens")]

		/// <summary>
		/// Localization data for the login screen.
		/// </summary>
		public MMLoginScreenLocalizationSO loginScreen;

		#endregion
	}
}