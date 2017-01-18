using System;

namespace dev_wsaa_cliente_aspnet_cs
{
    public partial class index : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            ClienteLoginCms.process();
        }
    }
}