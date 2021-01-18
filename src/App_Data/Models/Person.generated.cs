//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.1.6
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Person</summary>
	[PublishedModel("person")]
	public partial class Person : PublishedContentModel, INavigationBase, IPageSettings, IXMlsiteMapSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const string ModelTypeAlias = "person";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Person, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Person(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Bio
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("bio")]
		public IHtmlString Bio => this.Value<IHtmlString>("bio");

		///<summary>
		/// Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("email")]
		public string Email => this.Value<string>("email");

		///<summary>
		/// Facebook username
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("facebookUsername")]
		public string FacebookUsername => this.Value<string>("facebookUsername");

		///<summary>
		/// Full Bio: Set the full bio for this person.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("fullBio")]
		public IHtmlString FullBio => this.Value<IHtmlString>("fullBio");

		///<summary>
		/// Instagram Username
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("instagramUsername")]
		public string InstagramUsername => this.Value<string>("instagramUsername");

		///<summary>
		/// LinkedIn username
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("linkedInUsername")]
		public string LinkedInUsername => this.Value<string>("linkedInUsername");

		///<summary>
		/// Location
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("location")]
		public string Location => this.Value<string>("location");

		///<summary>
		/// Photo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("photo")]
		public IPublishedContent Photo => this.Value<IPublishedContent>("photo");

		///<summary>
		/// Position
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("position")]
		public string Position => this.Value<string>("position");

		///<summary>
		/// Twitter username
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("twitterUsername")]
		public string TwitterUsername => this.Value<string>("twitterUsername");

		///<summary>
		/// Hide Footer: Hide the footer.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("hideFooter")]
		public bool HideFooter => NavigationBase.GetHideFooter(this);

		///<summary>
		/// Hide Main Nav: Hide the main navigation.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("hideMainNav")]
		public bool HideMainNav => NavigationBase.GetHideMainNav(this);

		///<summary>
		/// Description: A brief description of the content on your page. This text is shown below the title in a google search result and also used for Social Sharing Cards. The ideal length is between 130 and 155 characters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("seoMetaDescription")]
		public string SeoMetaDescription => NavigationBase.GetSeoMetaDescription(this);

		///<summary>
		/// Background Color: Set the background color.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("contentBgColor")]
		public Amplify.Web.Custom.Models.AmplifyColor ContentBgColor => PageSettings.GetContentBgColor(this);

		///<summary>
		/// Background Gradient: Add a background gradient.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("contentBgGradient")]
		public Amplify.Web.Custom.Models.AmplifyGradient ContentBgGradient => PageSettings.GetContentBgGradient(this);

		///<summary>
		/// Background Texture: Add a transparent texture to overlay your background.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("contentBgTexture")]
		public IPublishedContent ContentBgTexture => PageSettings.GetContentBgTexture(this);

		///<summary>
		/// Text Color: Choose your text color,
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("contentTextColor")]
		public Amplify.Web.Custom.Models.AmplifyColor ContentTextColor => PageSettings.GetContentTextColor(this);

		///<summary>
		/// Hide From XML Sitemap
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("hideFromXMLSitemap")]
		public bool HideFromXmlsitemap => XMlsiteMapSettings.GetHideFromXmlsitemap(this);
	}
}
