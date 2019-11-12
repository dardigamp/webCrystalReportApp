using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCrystalReport
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Page.IsPostBack)
            //{
                BDUTPEntities1 mde = new BDUTPEntities1();
                CrystalReportAlumno crp = new CrystalReportAlumno();
                crp.SetDataSource(mde.Alumnoes.Select(a => new {
                    Codigo = a.Codigo,
                    Apellidos = a.Apellidos,
                    Nombres = a.Nombres,
                    Documento = a.Documento,
                    Telefono = a.Telefono
                }));
                this.CrystalReportViewerAlumno.ReportSource = crp;
                this.CrystalReportViewerAlumno.DataBind();

            //}
        }
    }
}