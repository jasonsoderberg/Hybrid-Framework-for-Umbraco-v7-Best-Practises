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
	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}


		/// <summary>Size</summary>
		[ImplementPropertyType("umbracoBytes")]
		public object Bytes
		{
			get { return this.GetPropertyValue("umbracoBytes"); }
		}

		/// <summary>Upload image</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet Cropper
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		/// <summary>Type</summary>
		[ImplementPropertyType("umbracoExtension")]
		public object Extension
		{
			get { return this.GetPropertyValue("umbracoExtension"); }
		}

		/// <summary>Height</summary>
		[ImplementPropertyType("umbracoHeight")]
		public object Height
		{
			get { return this.GetPropertyValue("umbracoHeight"); }
		}

		/// <summary>Width</summary>
		[ImplementPropertyType("umbracoWidth")]
		public object Width
		{
			get { return this.GetPropertyValue("umbracoWidth"); }
		}
	}
}
