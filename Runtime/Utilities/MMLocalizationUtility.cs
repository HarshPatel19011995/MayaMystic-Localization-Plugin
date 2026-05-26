/**************************************************************************
 * 
 *  Project     : MayaMystic Localization Framework
 *  File        : MMLocalizationUtility.cs
 *  Author      : Harsh Patel
 *  Company     : MayaMystic
 *  Version     : 1.0.0
 * 
 *  Description :
 *  Utility helper class for applying localization
 *  settings to TextMeshPro UI components.
 *  
 *  Supports:
 *  - Localized text assignment
 *  - Dynamic font switching
 *  - RTL language handling
 *  - Text alignment overrides
 *  - Input field localization
 * 
 **************************************************************************/

using TMPro;
using UnityEngine;
using MayaMystic.Localization.Config;
using MayaMystic.Localization.Models;

namespace MayaMystic.Localization.Utilities
{
	/// <summary>
	/// Utility class responsible for applying
	/// localization settings to UI elements.
	/// </summary>
	public static class MMLocalizationUtility
	{
		#region Public Methods

		/// <summary>
		/// Applies localized settings to a TMP text component.
		/// </summary>
		/// <param name="target">
		/// Target TMP text component.
		/// </param>
		/// <param name="text">
		/// Localized text value.
		/// </param>
		/// <param name="font">
		/// Font asset to apply.
		/// </param>
		/// <param name="isRTL">
		/// Whether the language is right-to-left.
		/// </param>
		/// <param name="alignmentOverride">
		/// Alignment override mode.
		/// </param>
		public static void ApplyTextSettings(
			TMP_Text target,
			string text,
			TMP_FontAsset font,
			bool isRTL,
			FontAlignmentOverride alignmentOverride =
				FontAlignmentOverride.None)
		{
			if (target == null)
				return;

			target.text = text;

			if (font != null)
			{
				target.font = font;
			}

			ApplyAlignment(
				target,
				isRTL,
				alignmentOverride);
		}

		/// <summary>
		/// Applies localized settings to a TMP input field.
		/// </summary>
		/// <param name="inputField">
		/// Target TMP input field.
		/// </param>
		/// <param name="placeholderText">
		/// Localized placeholder text.
		/// </param>
		/// <param name="font">
		/// Font asset to apply.
		/// </param>
		/// <param name="isRTL">
		/// Whether the language is right-to-left.
		/// </param>
		/// <param name="alignmentOverride">
		/// Alignment override mode.
		/// </param>
		public static void ApplyInputFieldSettings(
			TMP_InputField inputField,
			string placeholderText,
			TMP_FontAsset font,
			bool isRTL,
			FontAlignmentOverride alignmentOverride =
				FontAlignmentOverride.None)
		{
			if (inputField == null)
				return;

			inputField.text = string.Empty;

			if (inputField.placeholder is TMP_Text placeholder)
			{
				placeholder.text = placeholderText;

				if (font != null)
				{
					placeholder.font = font;
				}

				ApplyAlignment(
					placeholder,
					isRTL,
					alignmentOverride);
			}

			if (inputField.textComponent != null)
			{
				if (font != null)
				{
					inputField.textComponent.font = font;
				}

				ApplyAlignment(
					inputField.textComponent,
					isRTL,
					alignmentOverride);
			}
		}

		/// <summary>
		/// Detects whether the specified language
		/// should use right-to-left text rendering.
		/// </summary>
		/// <param name="language">
		/// Target language type.
		/// </param>
		/// <returns>
		/// TRUE if the language is RTL; otherwise FALSE.
		/// </returns>
		public static bool DetectIsRightToLeft(
			LanguageType language)
		{
			return language ==
				LanguageType.Hebrew;
		}

		#endregion

		#region Private Methods

		/// <summary>
		/// Applies alignment and RTL settings
		/// to a TMP text component.
		/// </summary>
		/// <param name="target">
		/// Target TMP text component.
		/// </param>
		/// <param name="isRTL">
		/// Whether the language is right-to-left.
		/// </param>
		/// <param name="alignmentOverride">
		/// Alignment override mode.
		/// </param>
		private static void ApplyAlignment(
			TMP_Text target,
			bool isRTL,
			FontAlignmentOverride alignmentOverride)
		{
			if (target == null)
				return;

			TextAlignmentOptions alignment =
				TextAlignmentOptions.Center;

			if (isRTL)
			{
				target.isRightToLeftText = true;
			}
			else
			{
				target.isRightToLeftText = false;
			}

			switch (alignmentOverride)
			{
				case FontAlignmentOverride.Left:

					alignment = isRTL
						? TextAlignmentOptions.Right
						: TextAlignmentOptions.Left;

					break;

				case FontAlignmentOverride.Right:

					alignment = isRTL
						? TextAlignmentOptions.Left
						: TextAlignmentOptions.Right;

					break;

				case FontAlignmentOverride.Center:

					alignment =
						TextAlignmentOptions.Center;

					break;
			}

			target.alignment = alignment;
		}

		#endregion
	}
}