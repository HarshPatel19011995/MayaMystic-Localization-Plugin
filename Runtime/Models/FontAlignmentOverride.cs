/**************************************************************************
 * 
 *  Project     : MayaMystic Localization Framework
 *  File        : FontAlignmentOverride.cs
 *  Author      : Harsh Patel
 *  Company     : MayaMystic
 *  Version     : 1.0.0
 * 
 *  Description :
 *  Defines text alignment override modes used by the
 *  MayaMystic Localization Framework.
 *  
 *  Allows localized UI elements to dynamically
 *  override text alignment settings based on
 *  language or layout requirements.
 * 
 **************************************************************************/

namespace MayaMystic.Localization.Models
{
	/// <summary>
	/// Defines alignment override modes for localized text.
	/// Used to dynamically adjust UI text alignment
	/// depending on the selected language.
	/// </summary>
	public enum FontAlignmentOverride
	{
		/// <summary>
		/// No alignment override is applied.
		/// Uses the default alignment configured
		/// on the target UI component.
		/// </summary>
		None = 0,

		/// <summary>
		/// Aligns text to the left side.
		/// </summary>
		Left = 1,

		/// <summary>
		/// Aligns text to the right side.
		/// </summary>
		Right = 2,

		/// <summary>
		/// Centers the text horizontally.
		/// </summary>
		Center = 3
	}
}