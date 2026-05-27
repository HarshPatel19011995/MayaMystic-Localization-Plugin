namespace MayaMystic.Localization.Examples
{
	using UnityEngine;
	using TMPro;
	using MayaMystic.Localization.Core;
	using MayaMystic.Localization.Config;
	using MayaMystic.Localization.Models;
	using MayaMystic.Localization.Utilities;
	using MayaMystic.Localization.Screens.Login;
	using UnityEngine.InputSystem;

	/// <summary>
	/// Localization system runtime test example.
	/// </summary>
	public class LocalizationTest : MonoBehaviour
	{
		#region Inspector

		[Header("Languages")]

		[SerializeField]
		private MMLocalizationLanguageSO englishLanguage;

		[SerializeField]
		private MMLocalizationLanguageSO hebrewLanguage;

		[Header("UI")]

		[SerializeField]
		private TMP_Text titleText;

		#endregion

		#region Unity Callbacks

		/// <summary>
		/// Unity start callback.
		/// </summary>
		private void Start()
		{
			MMLocalization.Initialize(
				englishLanguage);

			MMLocalization.OnLanguageChanged +=
				OnLanguageChanged;

			OnLanguageChanged();

			Debug.Log(
				$"Current Language: " +
				$"{MMLocalization.CurrentLanguageType}");
		}
		/// <summary>
		/// Unity update callback.
		/// </summary>
		private void Update()
		{
			if (Keyboard.current.eKey.wasPressedThisFrame)
			{
				SwitchToEnglish();
			}

			if (Keyboard.current.hKey.wasPressedThisFrame)
			{
				SwitchToHebrew();
			}
		}
		/// <summary>
		/// Unity destroy callback.
		/// </summary>
		private void OnDestroy()
		{
			MMLocalization.OnLanguageChanged -=
				OnLanguageChanged;
		}

		#endregion

		#region Context Menu

		/// <summary>
		/// Switches localization to English.
		/// </summary>
		[ContextMenu("Switch To English")]
		private void SwitchToEnglish()
		{
			MMLocalization.SetLanguage(
				englishLanguage);
		}

		/// <summary>
		/// Switches localization to Hebrew.
		/// </summary>
		[ContextMenu("Switch To Hebrew")]
		private void SwitchToHebrew()
		{
			MMLocalization.SetLanguage(
				hebrewLanguage);
		}

		#endregion

		#region Localization

		/// <summary>
		/// Refreshes localized UI.
		/// </summary>
		private void OnLanguageChanged()
		{
			MMLocalizationLanguageSO language =
				MMLocalization.GetCurrentLanguage();

			if (language == null)
			{
				Debug.LogError(
					"Current language is NULL.");

				return;
			}

			MMLoginScreenLocalizationSO localization =
				language.loginScreen;

			if (localization == null)
			{
				Debug.LogError(
					"Login localization asset is NULL.");

				return;
			}

			bool isRTL =
				MMLocalizationUtility
					.DetectIsRightToLeft(
						language.languageType);
			Debug.Log(
				$"Language is RTL: " +
				$"{isRTL}");
			MMLocalizationUtility.ApplyTextSettings(
				titleText,
				localization.loginHeader,
				language.headerFont,
				isRTL,
				FontAlignmentOverride.None);

			Debug.Log(
				$"Localization Updated: " +
				$"{language.languageType}");
		}

		#endregion
	}
}