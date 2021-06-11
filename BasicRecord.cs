using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
//using System.Data.Odbc;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;

namespace C_Sharp_Practices
{
    public partial class BasicRecord : Form
    {
        public BasicRecord()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //try
            //{
                System.Data.OleDb.OleDbConnection cn;
                System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
                string ct = null;
                cn=new OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0;Data Source='C:\\Users\\USER\\Documents\\Visual Studio 2008\\Projects\\Practice\\C_Sharp_Practices\\bin\\Debug\\BasicRecord.xlsx';Extended Properties=Excel 12.0 Xml; HDR=YES");
                cn.Open();
                cmd.Connection = cn;
                ct = "Update ['Sheet1$'] set Name = 'new name' where Sex=m";
                cmd.CommandText = ct;
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Saved");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

            ////try
            ////{
            //    OleDbConnection myConnection;
            //    OleDbCommand myCommand = new OleDbCommand();
            //    string sql = null;
            //    //myConnection=new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\basicRecord.xls; Extended Properties=Excel 8.0;");
            //    //myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" +Application.StartupPath+ " basicRecord.xlsx'; Extended Properties=Excel 12.0 Xml; HDR=YES");
            //    //C:\\Users\\USER\\Documents\\Visual Studio 2008\\Projects\\Practice\\C_Sharp_Practices\\bin\\Debug\\
            //    myConnection=new OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source='C:\\Users\\USER\\Documents\\Visual Studio 2008\\Projects\\C_Sharp_Practices\\bin\\Debug\\BasicRecord.accdb'");
            //if (myConnection.State == ConnectionState.Closed)
            //    {
            //        myConnection.Open();
            //    }
            //    myCommand.Connection = myConnection;
            //    //OdbcCommand cmd = new OdbcCommand;
            //    //OdbcConnection cnn;
            //    //cnn = new OdbcConnection("Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};dbq=C:\Users\USER\Documents\Visual Studio 2008\Projects\Practice\C_Sharp_Practices\bin\Debug\basicRecord.xlsx;defaultdir=C:\Users\USER\Documents\Visual Studio 2008\Projects\Practice\C_Sharp_Practices\bin\Debug;driverid=1046;fil=excel 12.0;filedsn=C:\Users\USER\Documents\Visual Studio 2008\Projects\Practice\C_Sharp_Practices\bin\Debug\basicRecord.xlsx.dsn;maxbuffersize=2048;maxscanrows=8;pagetimeout=5;readonly=1;safetransactions=0;threads=3;uid=admin;usercommitsync=Yes");
            //    //cmd.Connection=cnn;    
            //    //sql="Insert into [Sheet1$] (Name,Sex,Phone Number,Location,State,LGA)Values ('"+txtName.Text+","+cboSex.Text+","+txtPN.Text+","+txtLocation.Text+","+cboState.Text+","+cboLGA.Text+"')";
            //    sql="Insert into tblData (Name,Sex,Phone Number,Location,State,LGA)Values ('"+txtName.Text+","+cboSex.Text+","+txtPN.Text+","+txtLocation.Text+","+cboState.Text+","+cboLGA.Text+"')";
            //    myCommand.ExecuteNonQuery();
            //    myConnection.Close();
            //    MessageBox.Show("Recorded Successfully", "Basic Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ////}
            ////catch (Exception ex)
            ////{
            ////    MessageBox.Show(ex.ToString());
            ////}
        }
    }
}
