using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace Estimator
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }
        public  DataTable tbl = new DataTable();
        private void btnBack_Click(object sender, EventArgs e)
        {
            estimate es = new estimate();
            es.ShowDialog();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (dataG.Rows.Count > 0)
            {
                save.Filter = "pdf(*.pdf)|*.pdf;";
                save.FileName = "Result.pdf";
                bool fileError = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Unable to Write to Disk", "Error", MessageBoxButtons.OK);
                        }
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        PdfWriter write = new PdfWriter(save.FileName);
                        PdfDocument pdf = new PdfDocument(write);
                        Document doc = new Document(pdf);
                        Table tb = new Table(3, true);
                        doc.Close();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
    }
}
