/**************************************************************************
 * 
 *  Project     : MayaMystic Localization Framework
 *  File        : MMLocalization.cs
 *  Author      : Harsh Patel
 *  Company     : MayaMystic
 *  Version     : 1.0.0
 * 
 *  Description :
 *  Global localization management system for the
 *  MayaMystic Localization Framework.
 *  
 *  Responsible for:
 *  - Localization initialization
 *  - Runtime language switching
 *  - Localized screen data access
 *  - Language change event broadcasting
 * 
 **************************************************************************/

using System;
using UnityEngine;
using MayaMystic.Localization.Config;
using MayaMystic.Localization.Models;
using MayaMystic.Localization.Screens.Login;

namespace MayaMystic.Localization.Core
{
	/// <summary>
	/// Global localization system responsible for
	/// language initialization, runtime language switching,
	/// and localized screen data retrieval.
	/// </summary>
	public static class MMLocalization
	{
		#region Events

		/// <summary>
		/// Event triggered whenever the active language changes.
		/// Used by UI systems to refresh localized content.
		/// </summary>
		public static event Action OnLanguageChanged;

		#endregion

		#region Private Members

		/// <summary>
		/// Currently active localization language asset.
		/// </summary>
		private static MMLocalizationLanguageSO currentLanguage;

		#endregion

		#region Properties

		/// <summary>
		/// Gets the currently selected language type.
		/// Returns English if localization is not initialized.
		/// </summary>
		public static LanguageType CurrentLanguageType =>
			currentLanguage != null
				? currentLanguage.languageType
				: LanguageType.English;

		#endregion

		#region Initialization

		/// <summary>
		/// Initializes the localization system
		/// with the provided default language asset.
		/// </summary>
		/// <param name="languageAsset">
		/// Default localization language asset.
		/// </param>
		public static void Initialize(
			MMLocalizationLanguageSO languageAsset)
		{
			if (languageAsset == null)
			{
				Debug.LogError(
					"MMLocalization initialization failed. " +
					"Language asset is NULL.");

				return;
			}

			currentLanguage = languageAsset;

			Debug.Log(
				$"Localization Initialized: " +
				$"{currentLanguage.languageType}");
		}

		#endregion

		#region Public Methods

		/// <summary>
		/// Changes the currently active language.
		/// Triggers the language changed event
		/// to refresh all localized UI elements.
		/// </summary>
		/// <param name="languageAsset">
		/// Target localization language asset.
		/// </param>
		public static void SetLanguage(
			MMLocalizationLanguageSO languageAsset)
		{
			if (languageAsset == null)
			{
				Debug.LogError(
					"Cannot set language. " +
					"Language asset is NULL.");

				return;
			}

			currentLanguage = languageAsset;

			Debug.Log(
				$"Language Changed: " +
				$"{currentLanguage.languageType}");

			OnLanguageChanged?.Invoke();
		}

		/// <summary>
		/// Returns the currently active
		/// localization language asset.
		/// </summary>
		/// <returns>
		/// Active localization language asset.
		/// </returns>
		public static MMLocalizationLanguageSO
			GetCurrentLanguage()
		{
			return currentLanguage;
		}

		#endregion

		#region Screen Localization

		/// <summary>
		/// Returns localized data for the login screen.
		/// </summary>
		/// <returns>
		/// Login screen localization asset.
		/// Returns NULL if localization is not initialized.
		/// </returns>
		public static MMLoginScreenLocalizationSO
			GetLoginScreen()
		{
			if (currentLanguage == null)
			{
				Debug.LogError(
					"Localization system not initialized.");

				return null;
			}

			return currentLanguage.loginScreen;
		}

		#endregion
	}
}