/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 23/11/2024
 * Heure: 13:20
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BettingApp.data
{
    public class DataGridPrinter
    {
        private PrintDocument printDocument;
        private DataGridView dgv;
        private string title;
        
        // Paramètres d'impression
        private int currentPage;
        private int rowsPerPage;
        private int totalPages;
        private List<int> columnsWidth;
        private int pageHeight;
        private int pageWidth;
        private int leftMargin = 50;
        private int topMargin = 100; // Augmenté pour laisser de la place pour le titre
        private int rightMargin = 50;
        private int bottomMargin = 100;

        public DataGridPrinter(DataGridView dataGridView, string documentTitle = "Rapport")
        {
            this.dgv = dataGridView;
            this.title = documentTitle;
            
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
            printDocument.BeginPrint += new PrintEventHandler(BeginPrint);
            
            columnsWidth = new List<int>();
            CalculateColumnsWidth();
        }

        private void CalculateColumnsWidth()
        {
            columnsWidth.Clear();
            float totalWidth = 0;
            
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Visible)
                {
                    totalWidth += col.Width;
                    columnsWidth.Add(col.Width);
                }
            }

            float ratio = (printDocument.DefaultPageSettings.PrintableArea.Width - leftMargin - rightMargin) / totalWidth;
            for (int i = 0; i < columnsWidth.Count; i++)
            {
                columnsWidth[i] = (int)(columnsWidth[i] * ratio);
            }
        }

        private void BeginPrint(object sender, PrintEventArgs e)
        {
            currentPage = 1;
            pageHeight = (int)printDocument.DefaultPageSettings.PrintableArea.Height;
            pageWidth = (int)printDocument.DefaultPageSettings.PrintableArea.Width;
            
            int rowHeight = 35;
            rowsPerPage = (pageHeight - topMargin - bottomMargin) / rowHeight;
            totalPages = (int)Math.Ceiling(dgv.Rows.Count / (double)rowsPerPage);
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
           
            Font titleFont = new Font("Segoe UI", 16, FontStyle.Bold);
            Font dateFont = new Font("Segoe UI", 10);
            Font headerFont = new Font("Segoe UI", 9, FontStyle.Bold);
            Font cellFont = new Font("Segoe UI", 9);
            
            string date = DateTime.Now.ToString("dd MMMM yyyy");
            
           
            e.Graphics.DrawString(title, titleFont, Brushes.Black,
                new Rectangle(leftMargin, 30, pageWidth - leftMargin - rightMargin, 30),
                new StringFormat { Alignment = StringAlignment.Center });
                
            
            e.Graphics.DrawString(date, dateFont, Brushes.Gray,
                new Rectangle(leftMargin, 70, pageWidth - leftMargin - rightMargin, 20),
                new StringFormat { Alignment = StringAlignment.Near });

            int startRow = (currentPage - 1) * rowsPerPage;
            int currentY = topMargin;
            int rowHeight = 25;

           
            int currentX = leftMargin;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (dgv.Columns[i].Visible)
                {
                    Rectangle rect = new Rectangle(currentX, currentY, columnsWidth[i], rowHeight);
                    
                   
                    using (SolidBrush headerBrush = new SolidBrush(Color.FromArgb(240, 240, 240)))
                    {
                        e.Graphics.FillRectangle(headerBrush, rect);
                    }
                    
                    
                    using (Pen headerPen = new Pen(Color.FromArgb(200, 200, 200)))
                    {
                        e.Graphics.DrawRectangle(headerPen, rect);
                    }
                    
                    e.Graphics.DrawString(dgv.Columns[i].HeaderText, headerFont,
                        Brushes.Black, rect, new StringFormat {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        });
                    currentX += columnsWidth[i];
                }
            }
            currentY += rowHeight;

           
            for (int rowIndex = startRow; rowIndex < Math.Min(startRow + rowsPerPage, dgv.Rows.Count); rowIndex++)
            {
                if (dgv.Rows[rowIndex].Visible)
                {
                    currentX = leftMargin;
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        if (dgv.Columns[i].Visible)
                        {
                            Rectangle rect = new Rectangle(currentX, currentY, columnsWidth[i], rowHeight);
                            
                            
                            if (rowIndex % 2 == 0)
                            {
                                using (SolidBrush altBrush = new SolidBrush(Color.FromArgb(250, 250, 250)))
                                {
                                    e.Graphics.FillRectangle(altBrush, rect);
                                }
                            }
                            
                            
                            using (Pen cellPen = new Pen(Color.FromArgb(220, 220, 220)))
                            {
                                e.Graphics.DrawRectangle(cellPen, rect);
                            }
                            
                            string cellValue = dgv.Rows[rowIndex].Cells[i].Value.ToString() ?? "";
                            e.Graphics.DrawString(cellValue, cellFont, Brushes.Black, rect,
                                new StringFormat {
                                    Alignment = StringAlignment.Center,
                                    LineAlignment = StringAlignment.Center
                                });
                            
                            currentX += columnsWidth[i];
                        }
                    }
                    currentY += rowHeight;
                }
            }

           
            using (Font footerFont = new Font("Segoe UI", 8))
            using (SolidBrush footerBrush = new SolidBrush(Color.Gray))
            {
                string footer = "Page " + currentPage + " sur " + totalPages;
                e.Graphics.DrawString(footer, footerFont, footerBrush,
                    pageWidth / 2, pageHeight - bottomMargin / 2,
                    new StringFormat { Alignment = StringAlignment.Center });
            }

            currentPage++;
            e.HasMorePages = currentPage <= totalPages;
        }

        public void Print()
        {
            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        printDocument.Print();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur d'impression: " + ex.Message);
                    }
                }
            }
        }

        public void PrintPreview()
        {
            using (PrintPreviewDialog previewDialog = new PrintPreviewDialog())
            {
                previewDialog.Document = printDocument;
                previewDialog.WindowState = FormWindowState.Maximized;
                previewDialog.ShowDialog();
            }
        }
    }
}