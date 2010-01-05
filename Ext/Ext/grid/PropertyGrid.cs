using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.grid {
	/// <summary>
	///     /**
	///     A specialized grid implementation intended to mimic the traditional property grid as typically seen in
	///     development IDEs.  Each row in the grid represents a property of some object, and the data is stored
	///     as a set of name/value pairs in {@link Ext.grid.PropertyRecord}s.  Example usage:
	///     <pre><code>
	///     var grid = new Ext.grid.PropertyGrid({
	///     title: 'Properties Grid',
	///     autoHeight: true,
	///     width: 300,
	///     renderTo: 'grid-ct',
	///     source: {
	///     "(name)": "My Object",
	///     "Created": new Date(Date.parse('10/15/2006')),
	///     "Available": false,
	///     "Version": .01,
	///     "Description": "A test object"
	///     }
	///     });
	///     </pre></code>
	/// </summary>
	/// <jssource>F:\src\git\DotWeb\proxy\ExtJsParser\ext-2.2\source\widgets\grid\PropertyGrid.js</jssource>
	public class PropertyGrid : Ext.grid.EditorGridPanel {

		/// <summary></summary>
		/// <returns></returns>
		public extern PropertyGrid();
		/// <summary></summary>
		/// <param name="config">The grid config object</param>
		/// <returns></returns>
		public extern PropertyGrid(object config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern PropertyGrid(Ext.Element config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern PropertyGrid(string config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static PropertyGrid prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.grid.EditorGridPanel superclass { get; set; }

		/// <summary>A data object to use as the data source of the grid (see {@link #setSource} for details).</summary>
		public extern object source { get; set; }

		/// <summary>
		///     An object containing name/value pairs of custom editor type definitions that allowthe grid to support additional types of editable fields.  By default, the grid supports strongly-typed editing
		///     of strings, dates, numbers and booleans using built-in form editors, but any custom type can be supported and
		///     associated with a custom input control by specifying a custom editor.  The name of the editor
		///     type should correspond with the name of the property that will use the editor.  Example usage:
		///     <pre><code>
		///     var grid = new Ext.grid.PropertyGrid({
		///     ...
		///     customEditors: {
		///     'Start Time': new Ext.grid.GridEditor(new Ext.form.TimeField({selectOnFocus:true}))
		///     },
		///     source: {
		///     'Start Time': '10:00 AM'
		///     }
		///     });
		///     </code></pre>
		/// </summary>
		public extern object customEditors { get; set; }


		/// <summary>
		///     Sets the source data object containing the property data.  The data object can contain one or more name/value
		///     pairs representing all of the properties of an object to display in the grid, and this data will automatically
		///     be loaded into the grid's {@link #store}.  The values should be supplied in the proper data type if needed,
		///     otherwise string type will be assumed.  If the grid already contains data, this method will replace any
		///     existing data.  See also the {@link #source} config value.  Example usage:
		///     <pre><code>
		///     grid.setSource({
		///     "(name)": "My Object",
		///     "Created": new Date(Date.parse('10/15/2006')),  // date type
		///     "Available": false,  // boolean type
		///     "Version": .01,      // decimal type
		///     "Description": "A test object"
		///     });
		///     </code></pre>
		/// </summary>
		/// <returns></returns>
		public extern virtual void setSource();

		/// <summary>
		///     Sets the source data object containing the property data.  The data object can contain one or more name/value
		///     pairs representing all of the properties of an object to display in the grid, and this data will automatically
		///     be loaded into the grid's {@link #store}.  The values should be supplied in the proper data type if needed,
		///     otherwise string type will be assumed.  If the grid already contains data, this method will replace any
		///     existing data.  See also the {@link #source} config value.  Example usage:
		///     <pre><code>
		///     grid.setSource({
		///     "(name)": "My Object",
		///     "Created": new Date(Date.parse('10/15/2006')),  // date type
		///     "Available": false,  // boolean type
		///     "Version": .01,      // decimal type
		///     "Description": "A test object"
		///     });
		///     </code></pre>
		/// </summary>
		/// <param name="source">The data object</param>
		/// <returns></returns>
		public extern virtual void setSource(object source);

		/// <summary>
		///     Gets the source data object containing the property data.  See {@link #setSource} for details regarding the
		///     format of the data object.
		/// </summary>
		/// <returns>Object</returns>
		public extern virtual void getSource();



	}

	[JsAnonymous]
	public class PropertyGridConfig : System.DotWeb.JsDynamic {
		/// <summary> A data object to use as the data source of the grid (see {@link #setSource} for details).</summary>
		public object source { get { return (object)this["source"]; } set { this["source"] = value; } }

		/// <summary> An object containing name/value pairs of custom editor type definitions that allow the grid to support additional types of editable fields.  By default, the grid supports strongly-typed editing of strings, dates, numbers and booleans using built-in form editors, but any custom type can be supported and associated with a custom input control by specifying a custom editor.  The name of the editor type should correspond with the name of the property that will use the editor.  Example usage: <pre><code> var grid = new Ext.grid.PropertyGrid({ ... customEditors: { 'Start Time': new Ext.grid.GridEditor(new Ext.form.TimeField({selectOnFocus:true})) }, source: { 'Start Time': '10:00 AM' } }); </code></pre></summary>
		public object customEditors { get { return (object)this["customEditors"]; } set { this["customEditors"] = value; } }

		/// <summary>  The number of clicks on a cell required to display the cell's editor (defaults to 2)</summary>
		public double clicksToEdit { get { return (double)this["clicksToEdit"]; } set { this["clicksToEdit"] = value; } }

		/// <summary>  True to automatically HTML encode and decode values pre and post edit (defaults to false)</summary>
		public bool autoEncode { get { return (bool)this["autoEncode"]; } set { this["autoEncode"] = value; } }

		/// <summary> Any subclass of AbstractSelectionModel that will provide the selection model for the grid (defaults to {@link Ext.grid.CellSelectionModel} if not specified).</summary>
		public object selModel { get { return (object)this["selModel"]; } set { this["selModel"] = value; } }

		/// <summary> The {@link Ext.data.Store} the grid should use as its data source (required).</summary>
		public Ext.data.Store store { get { return (Ext.data.Store)this["store"]; } set { this["store"] = value; } }

		/// <summary> Shorthand for {@link #colModel}.</summary>
		public object cm { get { return (object)this["cm"]; } set { this["cm"] = value; } }

		/// <summary> The {@link Ext.grid.ColumnModel} to use when rendering the grid (required).</summary>
		public object colModel { get { return (object)this["colModel"]; } set { this["colModel"] = value; } }

		/// <summary> Shorthand for {@link #selModel}.</summary>
		public object sm { get { return (object)this["sm"]; } set { this["sm"] = value; } }

		/// <summary> An array of columns to auto create a ColumnModel</summary>
		public System.Array columns { get { return (System.Array)this["columns"]; } set { this["columns"] = value; } }

		/// <summary> Sets the maximum height of the grid - ignored if autoHeight is not on.</summary>
		public double maxHeight { get { return (double)this["maxHeight"]; } set { this["maxHeight"] = value; } }

		/// <summary> True to disable selections in the grid (defaults to false). - ignored if a SelectionModel is specified</summary>
		public bool disableSelection { get { return (bool)this["disableSelection"]; } set { this["disableSelection"] = value; } }

		/// <summary> False to turn off column reordering via drag drop (defaults to true).</summary>
		public bool enableColumnMove { get { return (bool)this["enableColumnMove"]; } set { this["enableColumnMove"] = value; } }

		/// <summary> False to turn off column resizing for the whole grid (defaults to true).</summary>
		public bool enableColumnResize { get { return (bool)this["enableColumnResize"]; } set { this["enableColumnResize"] = value; } }

		/// <summary> A config object that will be applied to the grid's UI view.  Any of the config options available for {@link Ext.grid.GridView} can be specified here.</summary>
		public object viewConfig { get { return (object)this["viewConfig"]; } set { this["viewConfig"] = value; } }

		/// <summary> True to hide the grid's header (defaults to false).</summary>
		public bool hideHeaders { get { return (bool)this["hideHeaders"]; } set { this["hideHeaders"] = value; } }

		/// <summary> The minimum width a column can be resized to. Defaults to 25.</summary>
		public double minColumnWidth { get { return (double)this["minColumnWidth"]; } set { this["minColumnWidth"] = value; } }

		/// <summary> True to highlight rows when the mouse is over. Default is true.</summary>
		public bool trackMouseOver { get { return (bool)this["trackMouseOver"]; } set { this["trackMouseOver"] = value; } }

		/// <summary> True to enable dragging of the selected rows of the GridPanel.</p> <p>Setting this to <b><tt>true</tt></b> causes this GridPanel's {@link #getView GridView} to create an instance of {@link Ext.grid.GridDragZone}. This is available <b>(only after the Grid has been rendered)</b> as the GridView's {@link Ext.grid.GridView#dragZone dragZone} property.</p> <p>A cooperating {@link Ext.dd.DropZone DropZone} must be created who's implementations of {@link Ext.dd.DropZone#onNodeEnter onNodeEnter}, {@link Ext.dd.DropZone#onNodeOver onNodeOver}, {@link Ext.dd.DropZone#onNodeOut onNodeOut} and {@link Ext.dd.DropZone#onNodeDrop onNodeDrop}</p> are able to process the {@link Ext.grid.GridDragZone#getDragData data} which is provided.</summary>
		public bool enableDragDrop { get { return (bool)this["enableDragDrop"]; } set { this["enableDragDrop"] = value; } }

		/// <summary> True to enable hiding of columns with the header context menu.</summary>
		public bool enableColumnHide { get { return (bool)this["enableColumnHide"]; } set { this["enableColumnHide"] = value; } }

		/// <summary> True to enable the drop down button for menu in the headers.</summary>
		public bool enableHdMenu { get { return (bool)this["enableHdMenu"]; } set { this["enableHdMenu"] = value; } }

		/// <summary> True to stripe the rows. Default is false.</summary>
		public bool stripeRows { get { return (bool)this["stripeRows"]; } set { this["stripeRows"] = value; } }

		/// <summary> The id of a column in this grid that should expand to fill unused space. This id can not be 0.</summary>
		public string autoExpandColumn { get { return (string)this["autoExpandColumn"]; } set { this["autoExpandColumn"] = value; } }

		/// <summary> The minimum width the autoExpandColumn can have (if enabled). defaults to 50.</summary>
		public double autoExpandMin { get { return (double)this["autoExpandMin"]; } set { this["autoExpandMin"] = value; } }

		/// <summary> The maximum width the autoExpandColumn can have (if enabled). Defaults to 1000.</summary>
		public double autoExpandMax { get { return (double)this["autoExpandMax"]; } set { this["autoExpandMax"] = value; } }

		/// <summary> The {@link Ext.grid.GridView} used by the grid. This can be set before a call to render().</summary>
		public object view { get { return (object)this["view"]; } set { this["view"] = value; } }

		/// <summary> An {@link Ext.LoadMask} config or true to mask the grid while loading (defaults to false).</summary>
		public object loadMask { get { return (object)this["loadMask"]; } set { this["loadMask"] = value; } }

		/// <summary> True to enable deferred row rendering. Default is true.</summary>
		public bool deferRowRender { get { return (bool)this["deferRowRender"]; } set { this["deferRowRender"] = value; } }

		/// <summary>  The id of the node, a DOM node or an existing Element corresponding to a DIV that is already present in the document that specifies some panel-specific structural markup.  When applyTo is used, constituent parts of the panel can be specified by CSS class name within the main element, and the panel will automatically create those components from that markup. Any required components not specified in the markup will be autogenerated if necessary. The following class names are supported (baseCls will be replaced by {@link #baseCls}): <ul><li>baseCls + '-header'</li> <li>baseCls + '-header-text'</li> <li>baseCls + '-bwrap'</li> <li>baseCls + '-tbar'</li> <li>baseCls + '-body'</li> <li>baseCls + '-bbar'</li> <li>baseCls + '-footer'</li></ul> Using this config, a call to render() is not required.  If applyTo is specified, any value passed for {@link #renderTo} will be ignored and the target element's parent node will automatically be used as the panel's container.</summary>
		public object applyTo { get { return (object)this["applyTo"]; } set { this["applyTo"] = value; } }

		/// <summary>{Object/Array}  The top toolbar of the panel. This can be a {@link Ext.Toolbar} object, a toolbar config, or an array of buttons/button configs to be added to the toolbar.  Note that this is not available as a property after render. To access the top toolbar after render, use {@link #getTopToolbar}.</summary>
		public object tbar { get { return (object)this["tbar"]; } set { this["tbar"] = value; } }

		/// <summary>{Object/Array}  The bottom toolbar of the panel. This can be a {@link Ext.Toolbar} object, a toolbar config, or an array of buttons/button configs to be added to the toolbar.  Note that this is not available as a property after render. To access the bottom toolbar after render, use {@link #getBottomToolbar}.</summary>
		public object bbar { get { return (object)this["bbar"]; } set { this["bbar"] = value; } }

		/// <summary>  True to create the header element explicitly, false to skip creating it.  By default, when header is not specified, if a {@link #title} is set the header will be created automatically, otherwise it will not.  If a title is set but header is explicitly set to false, the header will not be rendered.</summary>
		public bool header { get { return (bool)this["header"]; } set { this["header"] = value; } }

		/// <summary>  True to create the footer element explicitly, false to skip creating it.  By default, when footer is not specified, if one or more buttons have been added to the panel the footer will be created automatically, otherwise it will not.</summary>
		public bool footer { get { return (bool)this["footer"]; } set { this["footer"] = value; } }

		/// <summary>  The title text to display in the panel header (defaults to '').  When a title is specified the header element will automatically be created and displayed unless {@link #header} is explicitly set to false.  If you don't want to specify a title at config time, but you may want one later, you must either specify a non-empty title (a blank space ' ' will do) or header:true so that the container element will get created.</summary>
		public string title { get { return (string)this["title"]; } set { this["title"] = value; } }

		/// <summary>  An array of {@link Ext.Button}s or {@link Ext.Button} configs used to add buttons to the footer of this panel.</summary>
		public System.Array buttons { get { return (System.Array)this["buttons"]; } set { this["buttons"] = value; } }

		/// <summary>{Object/String/Function}  A valid url spec according to the Updater {@link Ext.Updater#update} method. If autoLoad is not null, the panel will attempt to load its contents immediately upon render.<p> The URL will become the default URL for this panel's {@link #body} element, so it may be {@link Ext.Element#refresh refresh}ed at any time.</p></summary>
		public object autoLoad { get { return (object)this["autoLoad"]; } set { this["autoLoad"] = value; } }

		/// <summary>  True to render the panel with custom rounded borders, false to render with plain 1px square borders (defaults to false).</summary>
		public bool frame { get { return (bool)this["frame"]; } set { this["frame"] = value; } }

		/// <summary>  True to display the borders of the panel's body element, false to hide them (defaults to true).  By default, the border is a 2px wide inset border, but this can be further altered by setting {@link #bodyBorder} to false.</summary>
		public bool border { get { return (bool)this["border"]; } set { this["border"] = value; } }

		/// <summary>  True to display an interior border on the body element of the panel, false to hide it (defaults to true). This only applies when {@link #border} == true.  If border == true and bodyBorder == false, the border will display as a 1px wide inset border, giving the entire body element an inset appearance.</summary>
		public bool bodyBorder { get { return (bool)this["bodyBorder"]; } set { this["bodyBorder"] = value; } }

		/// <summary>{String/Object/Function}  Custom CSS styles to be applied to the body element in the format expected by {@link Ext.Element#applyStyles} (defaults to null).</summary>
		public object bodyStyle { get { return (object)this["bodyStyle"]; } set { this["bodyStyle"] = value; } }

		/// <summary>  A CSS class that will provide a background image to be used as the header icon (defaults to '').  An example custom icon class would be something like: .my-icon { background: url(../images/my-icon.gif) 0 6px no-repeat !important;}</summary>
		public string iconCls { get { return (string)this["iconCls"]; } set { this["iconCls"] = value; } }

		/// <summary>  True to make the panel collapsible and have the expand/collapse toggle button automatically rendered into the header tool button area, false to keep the panel statically sized with no button (defaults to false).</summary>
		public bool collapsible { get { return (bool)this["collapsible"]; } set { this["collapsible"] = value; } }

		/// <summary>  An array of tool button configs to be added to the header tool area. When rendered, each tool is stored as an {@link Ext.Element Element} referenced by a public property called <tt><b></b>tools.<i>&lt;tool-type&gt;</i></tt> <p>Each tool config may contain the following properties: <div class="mdetail-params"><ul> <li><b>id</b> : String<div class="sub-desc"><b>Required.</b> The type of tool to create. Values may be<ul> <li><tt>toggle</tt> (Created by default when {@link #collapsible} is <tt>true</tt>)</li> <li><tt>close</tt></li> <li><tt>minimize</tt></li> <li><tt>maximize</tt></li> <li><tt>restore</tt></li> <li><tt>gear</tt></li> <li><tt>pin</tt></li> <li><tt>unpin</tt></li> <li><tt>right</tt></li> <li><tt>left</tt></li> <li><tt>up</tt></li> <li><tt>down</tt></li> <li><tt>refresh</tt></li> <li><tt>minus</tt></li> <li><tt>plus</tt></li> <li><tt>help</tt></li> <li><tt>search</tt></li> <li><tt>save</tt></li> <li><tt>print</tt></li> </ul></div></li> <li><b>handler</b> : Function<div class="sub-desc"><b>Required.</b> The function to call when clicked. Arguments passed are:<ul> <li><b>event</b> : Ext.EventObject<div class="sub-desc">The click event.</div></li> <li><b>toolEl</b> : Ext.Element<div class="sub-desc">The tool Element.</div></li> <li><b>Panel</b> : Ext.Panel<div class="sub-desc">The host Panel</div></li> </ul></div></li> <li><b>scope</b> : Object<div class="sub-desc">The scope in which to call the handler.</div></li> <li><b>qtip</b> : String/Object<div class="sub-desc">A tip string, or a config argument to {@link Ext.QuickTip#register}</div></li> <li><b>hidden</b> : Boolean<div class="sub-desc">True to initially render hidden.</div></li> <li><b>on</b> : Object<div class="sub-desc">A listener config object specifiying event listeners in the format of an argument to {@link #addListener}</div></li> </ul></div> Example usage: <pre><code> tools:[{ id:'refresh', qtip: 'Refresh form Data', // hidden:true, handler: function(event, toolEl, panel){ // refresh logic } }] </code></pre> Note that apart from the toggle tool which is provided when a panel is collapsible, these tools only provide the visual button. Any required functionality must be provided by adding handlers that implement the necessary behavior.</summary>
		public System.Array tools { get { return (System.Array)this["tools"]; } set { this["tools"] = value; } }

		/// <summary>  True to hide the expand/collapse toggle button when {@link #collapsible} = true, false to display it (defaults to false).</summary>
		public bool hideCollapseTool { get { return (bool)this["hideCollapseTool"]; } set { this["hideCollapseTool"] = value; } }

		/// <summary>  True to allow expanding and collapsing the panel (when {@link #collapsible} = true) by clicking anywhere in the header bar, false to allow it only by clicking to tool button (defaults to false).</summary>
		public bool titleCollapse { get { return (bool)this["titleCollapse"]; } set { this["titleCollapse"] = value; } }

		/// <summary>  True to use overflow:'auto' on the panel's body element and show scroll bars automatically when necessary, false to clip any overflowing content (defaults to false).</summary>
		public bool autoScroll { get { return (bool)this["autoScroll"]; } set { this["autoScroll"] = value; } }

		/// <summary>  True to float the panel (absolute position it with automatic shimming and shadow), false to display it inline where it is rendered (defaults to false).  Note that by default, setting floating to true will cause the panel to display at negative offsets so that it is hidden -- because the panel is absolute positioned, the position must be set explicitly after render (e.g., myPanel.setPosition(100,100);).  Also, when floating a panel you should always assign a fixed width, otherwise it will be auto width and will expand to fill to the right edge of the viewport.</summary>
		public bool floating { get { return (bool)this["floating"]; } set { this["floating"] = value; } }

		/// <summary>{Boolean/String}  True (or a valid Ext.Shadow {@link Ext.Shadow#mode} value) to display a shadow behind the panel, false to display no shadow (defaults to 'sides').  Note that this option only applies when floating = true.</summary>
		public object shadow { get { return (object)this["shadow"]; } set { this["shadow"] = value; } }

		/// <summary>  The number of pixels to offset the shadow if displayed (defaults to 4). Note that this option only applies when floating = true.</summary>
		public double shadowOffset { get { return (double)this["shadowOffset"]; } set { this["shadowOffset"] = value; } }

		/// <summary>  False to disable the iframe shim in browsers which need one (defaults to true).  Note that this option only applies when floating = true.</summary>
		public bool shim { get { return (bool)this["shim"]; } set { this["shim"] = value; } }

		/// <summary>{String/Object}  An HTML fragment, or a {@link Ext.DomHelper DomHelper} specification to use as the panel's body content (defaults to '').</summary>
		public object html { get { return (object)this["html"]; } set { this["html"] = value; } }

		/// <summary>  The id of an existing HTML node to use as the panel's body content (defaults to '').</summary>
		public string contentEl { get { return (string)this["contentEl"]; } set { this["contentEl"] = value; } }

		/// <summary>{Object/Array}  A KeyMap config object (in the format expected by {@link Ext.KeyMap#addBinding} used to assign custom key handling to this panel (defaults to null).</summary>
		public object keys { get { return (object)this["keys"]; } set { this["keys"] = value; } }

		/// <summary>  <p>True to enable dragging of this Panel (defaults to false).</p> <p>For custom drag/drop implementations, an Ext.Panel.DD config could also be passed in this config instead of true. Ext.Panel.DD is an internal, undocumented class which moves a proxy Element around in place of the Panel's element, but provides no other behaviour during dragging or on drop. It is a subclass of {@link Ext.dd.DragSource}, so behaviour may be added by implementing the interface methods of {@link Ext.dd.DragDrop} eg: <pre><code> new Ext.Panel({ title: 'Drag me', x: 100, y: 100, renderTo: Ext.getBody(), floating: true, frame: true, width: 400, height: 200, draggable: { //      Config option of Ext.Panel.DD class. //      It's a floating Panel, so do not show a placeholder proxy in the original position. insertProxy: false, //      Called for each mousemove event while dragging the DD object. onDrag : function(e){ //          Record the x,y position of the drag proxy so that we can //          position the Panel at end of drag. var pel = this.proxy.getEl(); this.x = pel.getLeft(true); this.y = pel.getTop(true); //          Keep the Shadow aligned if there is one. var s = this.panel.getEl().shadow; if (s) { s.realign(this.x, this.y, pel.getWidth(), pel.getHeight()); } }, //      Called on the mouseup event. endDrag : function(e){ this.panel.setPosition(this.x, this.y); } } }).show(); </code></pre></summary>
		public bool draggable { get { return (bool)this["draggable"]; } set { this["draggable"] = value; } }

		/// <summary>  Adds a tooltip when mousing over the tab of a Ext.Panel which is an item of a Ext.TabPanel. Ext.QuickTips.init() must be called in order for the tips to render.</summary>
		public string tabTip { get { return (string)this["tabTip"]; } set { this["tabTip"] = value; } }

		/// <summary>  Render this panel disabled (default is false). An important note when using the disabled config on panels is that IE will often fail to initialize the disabled mask element correectly if the panel's layout has not yet completed by the time the Panel is disabled during the render process. If you experience this issue, you may need to instead use the {@link afterlayout} event to initialize the disabled state: <pre><code> new Ext.Panel({ ... listeners: { 'afterlayout': { fn: function(p){ p.disable(); }, single: true // important, as many layouts can occur } } }); </code></pre></summary>
		public bool disabled { get { return (bool)this["disabled"]; } set { this["disabled"] = value; } }

		/// <summary>  The base CSS class to apply to this panel's element (defaults to 'x-panel').</summary>
		public string baseCls { get { return (string)this["baseCls"]; } set { this["baseCls"] = value; } }

		/// <summary>  A CSS class to add to the panel's element after it has been collapsed (defaults to 'x-panel-collapsed').</summary>
		public string collapsedCls { get { return (string)this["collapsedCls"]; } set { this["collapsedCls"] = value; } }

		/// <summary>  True to mask the panel when it is disabled, false to not mask it (defaults to true).  Either way, the panel will always tell its contained elements to disable themselves when it is disabled, but masking the panel can provide an additional visual cue that the panel is disabled.</summary>
		public bool maskDisabled { get { return (bool)this["maskDisabled"]; } set { this["maskDisabled"] = value; } }

		/// <summary>  True to animate the transition when the panel is collapsed, false to skip the animation (defaults to true if the {@link Ext.Fx} class is available, otherwise false).</summary>
		public bool animCollapse { get { return (bool)this["animCollapse"]; } set { this["animCollapse"] = value; } }

		/// <summary>  True to display the panel title in the header, false to hide it (defaults to true).</summary>
		public bool headerAsText { get { return (bool)this["headerAsText"]; } set { this["headerAsText"] = value; } }

		/// <summary>  The alignment of any buttons added to this panel.  Valid values are 'right,' 'left' and 'center' (defaults to 'right').</summary>
		public string buttonAlign { get { return (string)this["buttonAlign"]; } set { this["buttonAlign"] = value; } }

		/// <summary>  True to render the panel collapsed, false to render it expanded (defaults to false).</summary>
		public bool collapsed { get { return (bool)this["collapsed"]; } set { this["collapsed"] = value; } }

		/// <summary>  True to make sure the collapse/expand toggle button always renders first (to the left of) any other tools in the panel's title bar, false to render it last (defaults to true).</summary>
		public bool collapseFirst { get { return (bool)this["collapseFirst"]; } set { this["collapseFirst"] = value; } }

		/// <summary>  Minimum width in pixels of all buttons in this panel (defaults to 75)</summary>
		public double minButtonWidth { get { return (double)this["minButtonWidth"]; } set { this["minButtonWidth"] = value; } }

		/// <summary>  A comma-delimited list of panel elements to initialize when the panel is rendered.  Normally, this list will be generated automatically based on the items added to the panel at config time, but sometimes it might be useful to make sure a structural element is rendered even if not specified at config time (for example, you may want to add a button or toolbar dynamically after the panel has been rendered).  Adding those elements to this list will allocate the required placeholders in the panel when it is rendered.  Valid values are<ul> <li><b>header</b></li> <li><b>tbar</b> (top bar)</li> <li><b>body</b> (required)</li> <li><b>bbar</b> (bottom bar)</li> <li><b>footer</b><li> </ul> Defaults to 'body'.</summary>
		public string elements { get { return (string)this["elements"]; } set { this["elements"] = value; } }

		/// <summary> The default type of container represented by this object as registered in Ext.ComponentMgr (defaults to 'panel').</summary>
		public string defaultType { get { return (string)this["defaultType"]; } set { this["defaultType"] = value; } }

		/// <summary>  The layout type to be used in this container.  If not specified, a default {@link Ext.layout.ContainerLayout} will be created and used.  Valid values are: absolute, accordion, anchor, border, card, column, fit, form and table. Specific config values for the chosen layout type can be specified using {@link #layoutConfig}.</summary>
		public string layout { get { return (string)this["layout"]; } set { this["layout"] = value; } }

		/// <summary>  This is a config object containing properties specific to the chosen layout (to be used in conjunction with the {@link #layout} config value).  For complete details regarding the valid config options for each layout type, see the layout class corresponding to the type specified:<ul class="mdetail-params"> <li>{@link Ext.layout.Absolute}</li> <li>{@link Ext.layout.Accordion}</li> <li>{@link Ext.layout.AnchorLayout}</li> <li>{@link Ext.layout.BorderLayout}</li> <li>{@link Ext.layout.CardLayout}</li> <li>{@link Ext.layout.ColumnLayout}</li> <li>{@link Ext.layout.FitLayout}</li> <li>{@link Ext.layout.FormLayout}</li> <li>{@link Ext.layout.TableLayout}</li></ul></summary>
		public object layoutConfig { get { return (object)this["layoutConfig"]; } set { this["layoutConfig"] = value; } }

		/// <summary>{Boolean/Number}  When set to true (100 milliseconds) or a number of milliseconds, the layout assigned for this container will buffer the frequency it calculates and does a re-layout of components. This is useful for heavy containers or containers with a large quantity of sub-components for which frequent layout calls would be expensive.</summary>
		public object bufferResize { get { return (object)this["bufferResize"]; } set { this["bufferResize"] = value; } }

		/// <summary>{String/Number}  A string component id or the numeric index of the component that should be initially activated within the container's layout on render.  For example, activeItem: 'item-1' or activeItem: 0 (index 0 = the first item in the container's collection).  activeItem only applies to layout styles that can display items one at a time (like {@link Ext.layout.Accordion}, {@link Ext.layout.CardLayout} and {@link Ext.layout.FitLayout}).  Related to {@link Ext.layout.ContainerLayout#activeItem}.</summary>
		public object activeItem { get { return (object)this["activeItem"]; } set { this["activeItem"] = value; } }

		/// <summary>  A single item, or an array of child Components to be added to this container. Each item can be any type of object based on {@link Ext.Component}.<br><br> Component config objects may also be specified in order to avoid the overhead of constructing a real Component object if lazy rendering might mean that the added Component will not be rendered immediately. To take advantage of this "lazy instantiation", set the {@link Ext.Component#xtype} config property to the registered type of the Component wanted.<br><br> For a list of all available xtypes, see {@link Ext.Component}. If a single item is being passed, it should be passed directly as an object reference (e.g., items: {...}).  Multiple items should be passed as an array of objects (e.g., items: [{...}, {...}]).</summary>
		public object items { get { return (object)this["items"]; } set { this["items"] = value; } }

		/// <summary>  A config object that will be applied to all components added to this container either via the {@link #items} config or via the {@link #add} or {@link #insert} methods.  The defaults config can contain any number of name/value property pairs to be added to each item, and should be valid for the types of items being added to the container.  For example, to automatically apply padding to the body of each of a set of contained {@link Ext.Panel} items, you could pass: defaults: {bodyStyle:'padding:15px'}.</summary>
		public object defaults { get { return (object)this["defaults"]; } set { this["defaults"] = value; } }

		/// <summary>  The local x (left) coordinate for this component if contained within a positioning container.</summary>
		public double x { get { return (double)this["x"]; } set { this["x"] = value; } }

		/// <summary>  The local y (top) coordinate for this component if contained within a positioning container.</summary>
		public double y { get { return (double)this["y"]; } set { this["y"] = value; } }

		/// <summary>  The page level x coordinate for this component if contained within a positioning container.</summary>
		public double pageX { get { return (double)this["pageX"]; } set { this["pageX"] = value; } }

		/// <summary>  The page level y coordinate for this component if contained within a positioning container.</summary>
		public double pageY { get { return (double)this["pageY"]; } set { this["pageY"] = value; } }

		/// <summary>  The height of this component in pixels (defaults to auto).</summary>
		public double height { get { return (double)this["height"]; } set { this["height"] = value; } }

		/// <summary>  The width of this component in pixels (defaults to auto).</summary>
		public double width { get { return (double)this["width"]; } set { this["width"] = value; } }

		/// <summary>  True to use height:'auto', false to use fixed height. Note: although many components inherit this config option, not all will function as expected with a height of 'auto'. (defaults to false).</summary>
		public bool autoHeight { get { return (bool)this["autoHeight"]; } set { this["autoHeight"] = value; } }

		/// <summary>  True to use width:'auto', false to use fixed width. Note: although many components inherit this config option, not all will function as expected with a width of 'auto'. (defaults to false).</summary>
		public bool autoWidth { get { return (bool)this["autoWidth"]; } set { this["autoWidth"] = value; } }

		/// <summary> 
		///     The registered xtype to create. This config option is not used when passing a config object into a constructor. This config option is used only when lazy instantiation is being used, and a child item of a Container is being specified not as a fully instantiated Component, but as a Component config object. The xtype will be looked up at render time up to determine what type of child Component to create.
		///     The predefined xtypes are listed at the top of this document.
		///     If you subclass Components to create your own Components, you may register them using Ext.ComponentMgr.registerType in order to be able to take advantage of lazy instantiation and rendering.
		/// </summary>
		public string xtype { get { return (string)this["xtype"]; } set { this["xtype"] = value; } }

		/// <summary>  The unique id of this component (defaults to an auto-assigned id).</summary>
		public string id { get { return (string)this["id"]; } set { this["id"] = value; } }

		/// <summary>{String/Object}  A tag name or DomHelper spec to create an element with. This is intended to create shorthand utility components inline via JSON. It should not be used for higher level components which already create their own elements. Example usage: <pre><code> {xtype:'box', autoEl: 'div', cls:'my-class'} {xtype:'box', autoEl: {tag:'blockquote', html:'autoEl is cool!'}} // with DomHelper </code></pre></summary>
		public object autoEl { get { return (object)this["autoEl"]; } set { this["autoEl"] = value; } }

		/// <summary>  An optional extra CSS class that will be added to this component's Element (defaults to '').  This can be useful for adding customized styles to the component or any of its children using standard CSS rules.</summary>
		public string cls { get { return (string)this["cls"]; } set { this["cls"] = value; } }

		/// <summary>  An optional extra CSS class that will be added to this component's Element when the mouse moves over the Element, and removed when the mouse moves out. (defaults to '').  This can be useful for adding customized "active" or "hover" styles to the component or any of its children using standard CSS rules.</summary>
		public string overCls { get { return (string)this["overCls"]; } set { this["overCls"] = value; } }

		/// <summary>  A custom style specification to be applied to this component's Element.  Should be a valid argument to {@link Ext.Element#applyStyles}.</summary>
		public string style { get { return (string)this["style"]; } set { this["style"] = value; } }

		/// <summary>  An optional extra CSS class that will be added to this component's container (defaults to '').  This can be useful for adding customized styles to the container or any of its children using standard CSS rules.</summary>
		public string ctCls { get { return (string)this["ctCls"]; } set { this["ctCls"] = value; } }

		/// <summary>  Render this component hidden (default is false).</summary>
		public bool hidden { get { return (bool)this["hidden"]; } set { this["hidden"] = value; } }

		/// <summary>{Object/Array}  An object or array of objects that will provide custom functionality for this component.  The only requirement for a valid plugin is that it contain an init method that accepts a reference of type Ext.Component. When a component is created, if any plugins are available, the component will call the init method on each plugin, passing a reference to itself.  Each plugin can then call methods or respond to events on the component as needed to provide its functionality.</summary>
		public object plugins { get { return (object)this["plugins"]; } set { this["plugins"] = value; } }

		/// <summary>  The id of the node, a DOM node or an existing Element that will be the container to render this component into. Using this config, a call to render() is not required.</summary>
		public object renderTo { get { return (object)this["renderTo"]; } set { this["renderTo"] = value; } }

		/// <summary>  A flag which causes the Component to attempt to restore the state of internal properties from a saved state on startup.<p> For state saving to work, the state manager's provider must have been set to an implementation of {@link Ext.state.Provider} which overrides the {@link Ext.state.Provider#set set} and {@link Ext.state.Provider#get get} methods to save and recall name/value pairs. A built-in implementation, {@link Ext.state.CookieProvider} is available.</p> <p>To set the state provider for the current page:</p> <pre><code> Ext.state.Manager.setProvider(new Ext.state.CookieProvider()); </code></pre> <p>Components attempt to save state when one of the events listed in the {@link #stateEvents} configuration fires.</p> <p>You can perform extra processing on state save and restore by attaching handlers to the {@link #beforestaterestore}, {@link staterestore}, {@link beforestatesave} and {@link statesave} events</p></summary>
		public bool stateful { get { return (bool)this["stateful"]; } set { this["stateful"] = value; } }

		/// <summary>  The unique id for this component to use for state management purposes (defaults to the component id). <p>See {@link #stateful} for an explanation of saving and restoring Component state.</p></summary>
		public string stateId { get { return (string)this["stateId"]; } set { this["stateId"] = value; } }

		/// <summary>  CSS class added to the component when it is disabled (defaults to "x-item-disabled").</summary>
		public string disabledClass { get { return (string)this["disabledClass"]; } set { this["disabledClass"] = value; } }

		/// <summary>  Whether the component can move the Dom node when rendering (defaults to true).</summary>
		public bool allowDomMove { get { return (bool)this["allowDomMove"]; } set { this["allowDomMove"] = value; } }

		/// <summary>  True if the component should check for hidden classes (e.g. 'x-hidden' or 'x-hide-display') and remove them on render (defaults to false).</summary>
		public bool autoShow { get { return (bool)this["autoShow"]; } set { this["autoShow"] = value; } }

		/// <summary>  How this component should hidden. Supported values are "visibility" (css visibility), "offsets" (negative offset position) and "display" (css display) - defaults to "display".</summary>
		public string hideMode { get { return (string)this["hideMode"]; } set { this["hideMode"] = value; } }

		/// <summary>  True to hide and show the component's container when hide/show is called on the component, false to hide and show the component itself (defaults to false).  For example, this can be used as a shortcut for a hide button on a window by setting hide:true on the button when adding it to its parent container.</summary>
		public bool hideParent { get { return (bool)this["hideParent"]; } set { this["hideParent"] = value; } }

		/// <summary> A config object containing one or more event handlers to be added to this object during initialization.  This should be a valid listeners config object as specified in the {@link #addListener} example for attaching multiple handlers at once.</summary>
		public object listeners { get { return (object)this["listeners"]; } set { this["listeners"] = value; } }

	}

    public class PropertyGridEvents {
        /// <summary>
        ///     Fires before a property value changes.  Handlers can return false to cancel the property change
        ///     (this will internally call {@link Ext.data.Record#reject} on the property's record).
        ///     as the {@link #source} config property).
        /// 
        /// <pre><code>
        /// USAGE: ({Object} source, {String} recordId, {Mixed} value, {Mixed} oldValue)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>source</b></term><description>The source data object for the grid (corresponds to the same object passed in</description></item>
        /// <item><term><b>recordId</b></term><description>The record's id in the data store</description></item>
        /// <item><term><b>value</b></term><description>The current edited property value</description></item>
        /// <item><term><b>oldValue</b></term><description>The original property value prior to editing</description></item>
        /// </list>
        /// </summary>
        public static string beforepropertychange { get { return "beforepropertychange"; } }
        /// <summary>
        ///     Fires after a property value has changed.
        ///     as the {@link #source} config property).
        /// 
        /// <pre><code>
        /// USAGE: ({Object} source, {String} recordId, {Mixed} value, {Mixed} oldValue)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>source</b></term><description>The source data object for the grid (corresponds to the same object passed in</description></item>
        /// <item><term><b>recordId</b></term><description>The record's id in the data store</description></item>
        /// <item><term><b>value</b></term><description>The current edited property value</description></item>
        /// <item><term><b>oldValue</b></term><description>The original property value prior to editing</description></item>
        /// </list>
        /// </summary>
        public static string propertychange { get { return "propertychange"; } }
    }

    public delegate void PropertyGridBeforepropertychangeDelegate(object source, string recordId, object value, object oldValue);
    public delegate void PropertyGridPropertychangeDelegate(object source, string recordId, object value, object oldValue);
}
