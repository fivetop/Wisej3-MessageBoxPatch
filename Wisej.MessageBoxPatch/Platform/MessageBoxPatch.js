
debugger;

qx.Mixin.define("wisej.web.MessageBoxPatch", {
	members: {

		_onAppear: function (e) {

			this.base(arguments, e);

			// always maximize.
			this.maximize();

		//// or limit the size
		//var parent = this.getLayoutParent();
		//var bounds = parent.getBounds();
		//var maxWidth = Math.min(this.getMaxWidth(), bounds.width);
		//var maxHeight = Math.min(this.getMaxHeight(), bounds.height);
		//this.setMaxWidth(maxWidth);
		//this.setMaxHeight(maxHeight);
		}
	}
});

qx.Class.patch(wisej.web.MessageBox, wisej.web.MessageBoxPatch);
