using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PDFJoin
{
    /*
     * PdfSharp Lisence
     * Creator of PDFsharp is empira Software GmbH
     * Kirchstrase 19 53840 Troisdorf Germany
     * http://www.empira.de
     * PDFsharp (R) is a registered trademark of empira Software GmbH
     * Released under the MIT license
     * http://www.pdfsharp.net/PDFsharp_License.ashx?AspxAutoDetectCookieSupport=1
     */
    class MyPdf
    {
        internal static bool PdfJoin(string savePath, string[] files)
        {
            try
            {
                using (var doc = new PdfDocument())
                {
                    foreach (string file in files)
                    {
                        if (!File.Exists(file)) 
                        {
                            MessageBox.Show(file + "\nが存在しません。");
                            return false;
                        }
                        using (var inputDocument = PdfReader.Open(file, PdfDocumentOpenMode.Import))
                        {
                            foreach (var page in inputDocument.Pages)
                            {
                                doc.AddPage(page);
                            }
                        }
                    }
                    doc.Save(savePath);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return false;
        }
    }
}
