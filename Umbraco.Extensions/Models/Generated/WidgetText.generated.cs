//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Zbu.ModelsBuilder v2.0.0.26
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
using Zbu.ModelsBuilder;
using Zbu.ModelsBuilder.Umbraco;

namespace Umbraco.Extensions.Models.Generated
{
	/// <summary>Widget text</summary>
	[PublishedContentModel("WidgetText")]
	public partial class WidgetText : Data
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "WidgetText";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public WidgetText(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<WidgetText, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}


		/// <summary>Text</summary>
		[ImplementPropertyType("text")]
		public IHtmlString Text
		{
			get { return this.GetPropertyValue<IHtmlString>("text"); }
		}

		/// <summary>Title</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}
	}
}
