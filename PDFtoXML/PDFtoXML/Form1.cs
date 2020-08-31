using System;
using System.Windows.Forms;
using DevExpress.Pdf;

namespace PDFtoXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Abrir Caixa de Dialogo
            // Abre direto no desktop...
            openFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFD.Title = "Abrir arquivo";
            openFD.Filter = "Arquivo PDF|*.pdf";
            openFD.FilterIndex = 1;
            openFD.ShowDialog();
            textEdit1.Text = openFD.FileName;

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {


            using (PdfDocumentProcessor processor = new PdfDocumentProcessor())
            {

                // Load a PDF document with AcroForm data. 
                processor.LoadDocument(textEdit1.Text);

                // Substitui pra XML o Destino com mesmo nome do arquivo.
                string FileXML = textEdit1.Text;
                FileXML = textEdit1.Text.Replace(".pdf", ".xml");

                // Export AcroForm data to XML format.
                processor.Export(FileXML, PdfFormDataFormat.Xml);
            }



        }

        private void openFD_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
