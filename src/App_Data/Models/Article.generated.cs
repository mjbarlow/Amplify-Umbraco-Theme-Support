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
	/// <summary>Article</summary>
	[PublishedModel("article")]
	public partial class Article : PublishedContentModel, IArticleImage, IAuthorBase, IHeaderTitleComposition, INavigationBase, IPageBlockList, ISideNavigationComposition, IXMlsiteMapSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const string ModelTypeAlias = "article";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Article, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Article(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Categories
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("categories")]
		public IEnumerable<string> Categories => this.Value<IEnumerable<string>>("categories");

		///<summary>
		/// Display Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("displayDate")]
		public DateTime DisplayDate => this.Value<DateTime>("displayDate");

		///<summary>
		/// Image: Select a main image.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("image")]
		public IPublishedContent Image => ArticleImage.GetImage(this);

		///<summary>
		/// Image Ratio: Select the image ratio.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("imageRatio")]
		public string ImageRatio => ArticleImage.GetImageRatio(this);

		///<summary>
		/// Author: Set the author text.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("author")]
		public string Author => AuthorBase.GetAuthor(this);

		///<summary>
		/// Select Author: Optionally pick one or multiple authors.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("selectedAuthor")]
		public IPublishedContent SelectedAuthor => AuthorBase.GetSelectedAuthor(this);

		///<summary>
		/// Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("subtitle")]
		public IHtmlString Subtitle => HeaderTitleComposition.GetSubtitle(this);

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("title")]
		public string Title => HeaderTitleComposition.GetTitle(this);

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
		/// Content Blocks
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("contentBlocks")]
		public Umbraco.Core.Models.Blocks.BlockListModel ContentBlocks => PageBlockList.GetContentBlocks(this);

		///<summary>
		/// Hide Side Navs: By default both side navigation's are shown, toggle this to hide them.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("hideSideNavs")]
		public bool HideSideNavs => SideNavigationComposition.GetHideSideNavs(this);

		///<summary>
		/// Hide From XML Sitemap
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("hideFromXMLSitemap")]
		public bool HideFromXmlsitemap => XMlsiteMapSettings.GetHideFromXmlsitemap(this);
	}
}
