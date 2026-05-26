/**************************************************************************
 * 
 *  Project     : MayaMystic Localization Framework
 *  File        : MMLoginScreenLocalizationSO.cs
 *  Author      : Harsh Patel
 *  Company     : MayaMystic
 *  Version     : 1.0.0
 * 
 *  Description :
 *  ScriptableObject that stores all localized text
 *  content for the Login Screen UI.
 *  
 *  Used by the MayaMystic Localization Framework
 *  to provide runtime language support for
 *  login-related interface elements.
 * 
 **************************************************************************/

using UnityEngine;

namespace MayaMystic.Localization.Screens.Login
{
	/// <summary>
	/// ScriptableObject containing localized
	/// text content for the login screen.
	/// </summary>
	[CreateAssetMenu(
		fileName = "MM_LoginScreen_Localization",
		menuName = "MayaMystic/Localization/Screens/Login")]
	public class MMLoginScreenLocalizationSO :
		ScriptableObject
	{
		#region Login

		/// <summary>
		/// Login screen localization section.
		/// </summary>
		[Header("Login")]

		/// <summary>
		/// Localized project or application name.
		/// </summary>
		[TextArea]
		public string projectName;

		/// <summary>
		/// Localized main login header text.
		/// </summary>
		[TextArea]
		public string loginHeader;

		/// <summary>
		/// Localized login subheader or description text.
		/// </summary>
		[TextArea]
		public string loginSubHeader;

		/// <summary>
		/// Localized username input label.
		/// </summary>
		[TextArea]
		public string usernameLabel;

		/// <summary>
		/// Localized password input label.
		/// </summary>
		[TextArea]
		public string passwordLabel;

		/// <summary>
		/// Localized login button label.
		/// </summary>
		[TextArea]
		public string loginButtonLabel;

		/// <summary>
		/// Localized forgot password link label.
		/// </summary>
		[TextArea]
		public string forgotPasswordLinkLabel;

		/// <summary>
		/// Localized remember me toggle label.
		/// </summary>
		[TextArea]
		public string rememberMeLabel;

		#endregion
	}
}