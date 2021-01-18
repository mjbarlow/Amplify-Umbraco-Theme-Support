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
	/// <summary>Product</summary>
	[PublishedModel("product")]
	public partial class Product : PublishedContentModel, INavigationBase, IPageSettings, IXMlsiteMapSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const string ModelTypeAlias = "product";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Product, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Product(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("description")]
		public IHtmlString Description => this.Value<IHtmlString>("description");

		///<summary>
		/// Features: Add product features.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("featuresBlocks")]
		public Umbraco.Core.Models.Blocks.BlockListModel FeaturesBlocks => this.Value<Umbraco.Core.Models.Blocks.BlockListModel>("featuresBlocks");

		///<summary>
		/// Full Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("fullDescription")]
		public IHtmlString FullDescription => this.Value<IHtmlString>("fullDescription");

		///<summary>
		/// Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("image")]
		public IPublishedContent Image => this.Value<IPublishedContent>("image");

		///<summary>
		/// Additional Images
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("images")]
		public IEnumerable<IPublishedContent> Images => this.Value<IEnumerable<IPublishedContent>>("images");

		///<summary>
		/// Price
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("price")]
		public decimal Price => this.Value<decimal>("price");

		///<summary>
		/// Product Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("productName")]
		public string ProductName => this.Value<string>("productName");

		///<summary>
		/// SKU
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("sku")]
		public string Sku => this.Value<string>("sku");

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
