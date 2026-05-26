/**************************************************************************
 * 
 *  Project     : MayaMystic Localization Framework
 *  File        : MMLocalizationBootstrap.cs
 *  Author      : Harsh Patel
 *  Company     : MayaMystic
 *  Version     : 1.0.0
 * 
 *  Description :
 *  Bootstrap component responsible for initializing
 *  the MayaMystic Localization Framework during
 *  application startup.
 *  
 *  Automatically loads the default language asset
 *  and initializes the global localization system.
 * 
 **************************************************************************/

using UnityEngine;
using MayaMystic.Localization.Config;

namespace MayaMystic.Localization.Core
{
	/// <summary>
	/// Bootstrap component that initializes the
	/// localization system at application startup.
	/// </summary>
	public class MMLocalizationBootstrap :
		MonoBehaviour
	{
		#region Inspector Fields

		/// <summary>
		/// Default language configuration section.
		/// </summary>
		[Header("Default Language")]

		/// <summary>
		/// Default localization language asset
		/// used during initialization.
		/// </summary>
		[SerializeField]
		private MMLocalizationLanguageSO
			defaultLanguage;

		#endregion

		#region Unity Lifecycle

		/// <summary>
		/// Unity Awake callback.
		/// Initializes the localization system.
		/// </summary>
		private void Awake()
		{
			InitializeLocalization();
		}

		#endregion

		#region Private Methods

		/// <summary>
		/// Initializes the global localization system
		/// using the configured default language asset.
		/// </summary>
		private void InitializeLocalization()
		{
			if (defaultLanguage == null)
			{
				Debug.LogError(
					"Default localization language is NULL.");

				return;
			}

			MMLocalization.Initialize(
				defaultLanguage);

			Debug.Log(
				$"Localization initialized: " +
				$"{defaultLanguage.languageType}");
		}

		#endregion
	}
}