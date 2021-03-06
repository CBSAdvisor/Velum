//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.0.4
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
	/// <summary>Dragalia Lost Adventurer Tier List</summary>
	[PublishedModel("dragaliaLostAdventurerTierList")]
	public partial class DragaliaLostAdventurerTierList : PublishedContentModel, IPageBasic
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "dragaliaLostAdventurerTierList";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<DragaliaLostAdventurerTierList, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public DragaliaLostAdventurerTierList(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Adventurers
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("adventurers")]
		public IPublishedContent Adventurers => this.Value<IPublishedContent>("adventurers");

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => PageBasic.GetPageTitle(this);
	}
}
