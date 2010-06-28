using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.layout {
	/// <summary>
	///     /**
	///     <p>Inherits the anchoring of {@link Ext.layout.AnchorLayout} and adds the ability for x/y positioning using the
	///     standard x and y component config options.</p>
	///     */
	///     Ext.layout.AbsoluteLayout = Ext.extend(Ext.layout.AnchorLayout, {
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\layout\AbsoluteLayout.js</jssource>
	public class AbsoluteLayout : Ext.layout.AnchorLayout {

		/// <summary>Auto-generated default constructor</summary>
		/// <returns></returns>
		public extern AbsoluteLayout();

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static AbsoluteLayout prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.layout.AnchorLayout superclass { get; set; }

		/// <summary>
		///     An optional extra CSS class that will be added to the container (defaults to 'x-abs-layout-item').  This can be useful for
		///     adding customized styles to the container or any of its children using standard CSS rules.
		/// </summary>
		public extern string extraCls { get; set; }




	}

	[JsAnonymous]
	public class AbsoluteLayoutConfig : System.DotWeb.JsDynamic {
		/// <summary>  An optional extra CSS class that will be added to the container (defaults to 'x-abs-layout-item').  This can be useful for adding customized styles to the container or any of its children using standard CSS rules.</summary>
		public extern string extraCls { get; set; }

		/// <summary>  True to hide each contained item on render (defaults to false).</summary>
		public extern bool renderHidden { get; set; }

	}
}
