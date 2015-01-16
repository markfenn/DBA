using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DowntownBoiseAssociation.Classes
{
    class SaveListViewToFile
    {
        public static Boolean SaveThisListViewToFile(ListView thisView, String Delimiter)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text|*.txt";
            saveFileDialog1.Title = "Save List View Data to File";
            saveFileDialog1.SupportMultiDottedExtensions = false;
            saveFileDialog1.AddExtension = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK && !String.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                try
                {
                    Export2Text(saveFileDialog1, thisView, Delimiter);

                    FileInfo fil = new FileInfo(saveFileDialog1.FileName);
                    if (fil.Exists == true)
                        MessageBox.Show("Process Completed", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    return false;
                }

                return true;
            }
            else
                return false;
        }

        public static Boolean SaveThisListViewToFile(ListView thisView)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel Spreadsheet|*.xls|Text|*.txt";
            saveFileDialog1.Title = "Save List View Data to File";
            saveFileDialog1.SupportMultiDottedExtensions = false;
            saveFileDialog1.AddExtension = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK && !String.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                try
                {
                    String theStrExt = (new FileInfo(saveFileDialog1.FileName)).Extension;
                    if (theStrExt.ToLower().Equals("xls") || theStrExt.ToLower().Equals(".xls"))
                        Export2Excel(saveFileDialog1, thisView, "\t");
                    else
                        Export2Text(saveFileDialog1, thisView, ",");

                    FileInfo fil = new FileInfo(saveFileDialog1.FileName);
                    if (fil.Exists == true)
                        MessageBox.Show("Process Completed", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    return false;
                }

                return true;
            }
            else
                return false;
        }

        private static void Export2Text(SaveFileDialog saveFileDialog1, ListView thisView, String seporator)
        {
            //lvwToBeSaved is nothing but the listview control name
            string[] st = new string[thisView.Columns.Count];
            System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.OpenFile());
            sw.AutoFlush = true;
            for (int col = 0; col < thisView.Columns.Count; col++)
            {
                if (col == 0)
                    sw.Write(thisView.Columns[col].Text.ToString());
                else
                    sw.Write(seporator + thisView.Columns[col].Text.ToString());
            }

            int rowIndex = 1;
            int row = 0;
            string st1 = "";
            for (row = 0; row < thisView.Items.Count; row++)
            {
                if (rowIndex <= thisView.Items.Count)
                    rowIndex++;
                st1 = "\r\n";
                for (int col = 0; col < thisView.Columns.Count; col++)
                {
                    if (col == 0)
                        st1 = st1 + "" + thisView.Items[row].SubItems[col].Text.ToString();
                    else
                        st1 = st1 + seporator + "" + thisView.Items[row].SubItems[col].Text.ToString();
                }
                sw.Write(st1);
            }
            sw.Close();
        }

        private static void Export2Excel(SaveFileDialog saveFileDialog1, ListView thisView, String seporator)
        {
            //lvwToBeSaved is nothing but the listview control name
            string[] st = new string[thisView.Columns.Count];
            System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.OpenFile());
            sw.AutoFlush = true;
            for (int col = 0; col < thisView.Columns.Count; col++)
            {
                if (col == 0)
                    sw.Write(thisView.Columns[col].Text.ToString());
                else
                    sw.Write(seporator + thisView.Columns[col].Text.ToString());
            }

            int rowIndex = 1;
            int row = 0;
            string st1 = "";
            for (row = 0; row < thisView.Items.Count; row++)
            {
                if (rowIndex <= thisView.Items.Count)
                    rowIndex++;
                st1 = "\r\n";
                for (int col = 0; col < thisView.Columns.Count; col++)
                {
                    if (col == 0)
                        st1 = st1 + "" + thisView.Items[row].SubItems[col].Text.ToString();
                    else
                        st1 = st1 + seporator + "" + thisView.Items[row].SubItems[col].Text.ToString();
                }
                sw.Write(st1);
            }
            sw.Close();
        }

    }
}
