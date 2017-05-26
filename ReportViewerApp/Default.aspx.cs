using Microsoft.Reporting.WebForms;
using System;
using System.Web.UI;

namespace ReportViewerApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnViewList_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccessLayer.DataController dataLayer = new DataAccessLayer.DataController();
                                                                                
                DataAccessLayer.PersonDataSet ds = null;

                ds = dataLayer.GetPersonList();

                ReportViewerDD.Visible = true;

                ReportViewerDD.LocalReport.DataSources.Clear();                

                ReportViewerDD.LocalReport.DataSources.Add( new ReportDataSource("DataSet1", ds.Tables[0]));

                ReportViewerDD.LocalReport.Refresh();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}