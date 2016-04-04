using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Engine
{
    public class AccessOleDbProvider
    {
        private String m_strDbFileName;
        private String m_strProviderString = "Microsoft.ACE.OLEDB.12.0";
        private OleDbConnection accessOleDbConnection = null;
        public String ProviderString { get; set; }
        public String TableName { get; set; }

        public AccessOleDbProvider()
        {
            m_strDbFileName = GlobalVariables.databasePath;
        }
        public AccessOleDbProvider(String fileName)
        {
            m_strDbFileName = fileName;
        }

        public void OpenConnection()
        {
            if ((accessOleDbConnection == null))
            {
                if ((m_strDbFileName != null) && m_strDbFileName.Trim().Length > 0)
                {
                    if (!System.IO.File.Exists(m_strDbFileName))
                    {
                        throw new Exception("ไม่พบฐานข้อมูลที่ระบุ กรุณาระบุไฟล์ฐานข้อมูลใหม่");
                    }

                    accessOleDbConnection = new OleDbConnection("Provider=" + m_strProviderString + ";" + "Data Source=" + m_strDbFileName + ";");
                    try
                    {
                        accessOleDbConnection.Open();
                    }
                    catch (OleDbException oledbExceptionErr)
                    {
                        throw new Exception("Access SQL", oledbExceptionErr);
                    }
                    catch (InvalidOperationException invalidOperationExceptionErr)
                    {
                        throw new Exception("Access SQL", invalidOperationExceptionErr);
                    }
                }
            }
        }

        public void CloseConnection()
        {
            if (IsConnectionOpen())
            {
                accessOleDbConnection.Close();
                accessOleDbConnection.Dispose();
                accessOleDbConnection = null;
            }
        }

        public bool IsConnectionOpen()
        {
            if ((accessOleDbConnection == null))
            {
                return false;
            }
            if (accessOleDbConnection.State != ConnectionState.Open)
            {
                return false;
            }
            return true;
        }

        public int ExecuteScalar(string sql)
        {
            int intRecordCount = 0;
            if (!IsConnectionOpen())
            {
                throw new Exception("Connection is Closed");
            }
            OleDbCommand command = default(OleDbCommand);

            command = new OleDbCommand(sql, accessOleDbConnection);
            try
            {
                intRecordCount = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (OleDbException oledbExceptionErr)
            {
                throw new Exception("Access SQL", oledbExceptionErr);
            }

            command.Dispose();
            command = null;
            return intRecordCount;
        }

        public DataView GetDataView(String sql)
        {
            DataView dv = null;
            DataTable tb = null;
            if (!IsConnectionOpen())
            {
                return null;
            }
            OleDbCommand command = default(OleDbCommand);
            command = new OleDbCommand(sql, accessOleDbConnection);
            command.CommandType = CommandType.Text;

            OleDbDataAdapter objDataAdapter = new OleDbDataAdapter();
            tb = new DataTable();
            objDataAdapter.SelectCommand = command;
            try
            {
                objDataAdapter.Fill(tb);
                dv = new DataView(tb);
            }
            catch (OleDbException oledbExceptionErr)
            {
                throw new Exception("Access SQL", oledbExceptionErr);
            }
            command.Dispose();
            command = null;
            objDataAdapter.Dispose();
            objDataAdapter = null;
            tb.Dispose();
            tb = null;
            return dv;
        }
    }
}
