using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.ASPxEditors;

namespace GridRuntime {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Init(object sender, EventArgs e) {
            ASPxGridView grid = new ASPxGridView();
            grid.ID = "grid";
            grid.KeyFieldName = "ID";
            grid.DataSource = GetData();

            this.form1.Controls.Add(grid);

            grid.DataBind();
        }

        public DataTable GetData() {
            DataTable Table = new DataTable();
            Table.Columns.Add("ID", typeof(int));
            Table.Columns.Add("ItemName", typeof(string));
            Table.Rows.Add(1, "A");
            Table.Rows.Add(2, "B");
            return Table;
        }
    }
}
