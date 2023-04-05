<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128538832/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E321)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Grid View for ASP.NET Web Forms - How to create the control at runtime
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/128538832/)**
<!-- run online end -->

This example shows how to create and configure the ASPxGridView control dynamically at runtime.

Follow the steps below to create the control in code.

1. Call the control type constructor.
1. Specify the control's `ID` property.
1. Attach event handlers.
1. Specify the control's properties.
1. Insert the control into the control hierarchy.
1. Bind the control to data.

```cs
protected void Page_Init(object sender, EventArgs e) {
    ASPxGridView grid = new ASPxGridView();
    grid.ID = "grid";
    grid.KeyFieldName = "ID";
    grid.DataSource = GetData();
    this.form1.Controls.Add(grid);
    grid.DataBind();
}
```

## Files to Review

[Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))

## More Examples

* [How to create and configure a HyperLink column at runtime](https://www.devexpress.com/Support/Center/p/E308)
* [How to create a DataItemTemplate for a column at Runtime](https://github.com/DevExpress-Examples/aspxgridview-dataitemtemplate-runtime)
* [How to create a master-detail grid at runtime](https://github.com/DevExpress-Examples/how-to-create-a-master-detail-grid-at-runtime-e1141)
* [How to dynamically switch the Grid's data source and recreate columns at runtime](https://github.com/DevExpress-Examples/aspxgridview-switch-grid-data-source-and-recreate-columns-at-runtime)
* [How to create columns and bind the control to different data sources at runtime](https://github.com/DevExpress-Examples/aspxgridview-create-columns-and-bind-grid-at-runtime)
* [How to bind the GridViewDataComboBoxColumn edit form editor at runtime](https://github.com/DevExpress-Examples/aspxgridview-bind-comboboxcolumn-edit-form-editor-at-runtime)
* [How to bind the control created in design mode to different data sources at runtime](https://github.com/DevExpress-Examples/aspxgridview-switch-data-sources-at-runtime)
* [How to bind a grid created at runtime to different data sources](https://github.com/DevExpress-Examples/aspxgridview-created-at-runtime-switch-data-sources)
* [How to edit a DataTable stored in ViewState at runtime](https://github.com/DevExpress-Examples/how-to-edit-data-in-a-datatable-using-aspxgridview-at-runtime-when-data-is-stored-in-viewsta-e2945)
* [How to edit data in a DataTable at runtime when data is stored in Session](https://github.com/DevExpress-Examples/aspxgridview-how-to-edit-data-in-a-datatable-at-runtime-when-data-is-stored-in-session-t191009)
* [How to load UserControl within EditFormTemplate at runtime](https://github.com/DevExpress-Examples/aspxgridview-how-to-load-usercontrol-within-editformtemplate-at-runtime-e3735)
* [How to switch date formats for the GridViewDataDateColumn at runtime](https://github.com/DevExpress-Examples/how-to-switch-date-formats-for-the-gridviewdatadatecolumn-at-runtime-e2530)
