#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using RustyNail.ProductsData;

namespace RustyNail.ProductsData	
{
	public partial class Vendor
	{
		private int _id;
		public virtual int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		
		private string _vendorName;
		public virtual string VendorName
		{
			get
			{
				return this._vendorName;
			}
			set
			{
				this._vendorName = value;
			}
		}
		
		private IList<Product> _products = new List<Product>();
		public virtual IList<Product> Products
		{
			get
			{
				return this._products;
			}
		}
		
	}
}
#pragma warning restore 1591
