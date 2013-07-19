using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Reflection;

namespace TurVek
{
    public enum SorguTipi
    {
        text, procedure
    }
    public class TurVek
    {
        SqlConnection con;
        public TurVek(string ConnectionString)
        {
            con = new SqlConnection(ConnectionString);

        }
        //connection acip kapatan kodları yazdık
        #region Connection
        void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        #endregion

        //select * from asda where id=@id ( @adi,@asd)
        //makalegetir
        //command olusuturup parametre get ve set ettik
        //string query için regex procedure için view kullandık
        #region Command
        SqlCommand CreateCommand(string sorgu, CommandType tip)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = tip ;
            cmd.CommandText = sorgu;

            return cmd;
        }
        string[] GetParametersFromQuery(string sorgu)
        {
            MatchCollection col = Regex.Matches(sorgu, @"@\w+");
            string[] parametreler = new string[col.Count];
            for (int i = 0; i < parametreler.Length; i++)
            {
                parametreler[i] = col[i].Value;
            }
            return parametreler;
        }
        string[] GetParametersFromProcedure(string spname)
        {
            string query = "select PARAMETER_NAME from INFORMATION_SCHEMA.PARAMETERS where SPECIFIC_NAME=@name";
            SqlDataReader dr = ExecuteReader(CommandType.Text, query, spname);
            List<string> parametreler = new List<string>();
            while (dr.Read())
            {
                parametreler.Add(dr["PARAMETER_NAME"].ToString());
            }
            dr.Close();
            return parametreler.ToArray();
        }
        void SetParameters(SqlCommand cmd, object[] values)
        {
            string[] parametreler;
            if (cmd.CommandType == CommandType.Text)
            {
                parametreler = GetParametersFromQuery(cmd.CommandText);
            }
            else
            {
                parametreler = GetParametersFromProcedure(cmd.CommandText);
            }
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == null)
                {
                    cmd.Parameters.AddWithValue(parametreler[i], DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue(parametreler[i], values[i]);
                }

            }
        }

        #endregion

        #region Execute Metotları
        public int ExecuteNonQuery(CommandType tip, string sorgu, params object[] degerler)
        {
            SqlCommand cmd = CreateCommand(sorgu, tip);
            SetParameters(cmd, degerler);
            OpenConnection();
            int sonuc = cmd.ExecuteNonQuery();
            CloseConnection();
            return sonuc;
        }
        public int ExecuteNonQuery(CommandType tip, string sorgu)
        {
            SqlCommand cmd = CreateCommand(sorgu, tip);
            OpenConnection();
            int sonuc = cmd.ExecuteNonQuery();
            CloseConnection();
            return sonuc;
        }

        public object ExecuteScalar(CommandType tip, string sorgu, params object[] degerler)
        {
            SqlCommand cmd = CreateCommand(sorgu, tip);
            SetParameters(cmd, degerler);
            OpenConnection();
            object sonuc = cmd.ExecuteScalar();
            CloseConnection();
            return sonuc;
        }
        public object ExecuteScalar(CommandType tip, string sorgu)
        {
            SqlCommand cmd = CreateCommand(sorgu, tip);
            OpenConnection();
            object sonuc = cmd.ExecuteScalar();
            CloseConnection();
            return sonuc;
        }

        public SqlDataReader ExecuteReader(CommandType tip, string sorgu, params object[] degerler)
        {
            SqlCommand cmd = CreateCommand(sorgu, tip);
            SetParameters(cmd, degerler);
            OpenConnection();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
        public SqlDataReader ExecuteReader(CommandType tip, string sorgu)
        {
            SqlCommand cmd = CreateCommand(sorgu, tip);
            OpenConnection();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }

        public List<T> ExecuteReader<T>(CommandType tip, string sorgu)
        {
            SqlCommand cmd = CreateCommand(sorgu, tip);
            OpenConnection();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return DataTableToEntityList<T>(DataReadertoDataTable(dr, typeof(T)));
        }
        public List<T> ExecuteReader<T>(CommandType tip, string sorgu, params object[] degerler)
        {
            SqlCommand cmd = CreateCommand(sorgu, tip);
            SetParameters(cmd, degerler);
            OpenConnection();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return DataTableToEntityList<T>(DataReadertoDataTable(dr, typeof(T)));
        }

        //public DataTable GetDataTable(CommandType tip, string sorgu, params object[] degerler)
        //{
        //    SqlCommand cmd = CreateCommand(sorgu, tip);
        //    SetParameters(cmd, degerler);
        //    OpenConnection();
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    for (int i = 0; i < dr.FieldCount; i++)
        //    {
        //        dt.Columns.Add(dr.GetName(i), dr.GetFieldType(i));
        //    }
        //    while (dr.Read())
        //    {
        //        DataRow drow = dt.NewRow();
        //        for (int i = 0; i < dr.FieldCount; i++)
        //        {
        //            drow[i] = dr[i];
        //        }
        //        dt.Rows.Add(drow);
        //    }
        //    dr.Close();
        //    CloseConnection();
        //    return dt;


        //}

        public DataTable GetDT(CommandType tip, DataTable dt, string sorgu, params object[] degerler)
        {
            SqlCommand cmd = CreateCommand(sorgu, tip);
            SetParameters(cmd, degerler);
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(dt);
            return (dt);
        }

        public DataTable GetDataTable(CommandType tip, string sorgu, params object[] degerler)
        {
            SqlCommand cmd = CreateCommand(sorgu, tip);
            SetParameters(cmd, degerler);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt=new DataTable();
            DataColumn col1 = new DataColumn();
            col1.ColumnName = "SNo";
            col1.AutoIncrement = true;
            col1.AutoIncrementSeed = 1;
            col1.AutoIncrementStep = 1;
            dt.Columns.Add(col1);
            //foreach (IDataParameter data in da.GetFillParameters())
            //{
            //    dt.Columns.Add(data.ParameterName,DbTypetoType(data.DbType));
            //}
            da.Fill(dt);
            return dt;
        }
        #endregion
        public DataTable DataTableOlustur(Type Entity)
        {
            DataTable dt = new DataTable();

            foreach (PropertyInfo info in Entity.GetProperties())
            {
                dt.Columns.Add(new DataColumn(info.Name, info.PropertyType));
            }
            return dt;
        }


        public DataTable DataReadertoDataTable(SqlDataReader dr, Type Entity)
        {
            DataTable dt = DataTableOlustur(Entity);
            dt.Load(dr);
            return dt;
        }

        //List<T> ListeVer<T>(SqlDataReader dr)
        //{
        //    DataTable dt = DataTableOlustur(typeof(T));
        //    dt.Load(dr);
        //    List<T> liste = new List<T>();
        //    object obj;
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        obj = row;
        //        liste.Add((T)obj);
        //    }
        //    List<T> listOfEntityObjects = liste.Cast<T>().ToList();
        //    return listOfEntityObjects;
        //}

        private  List<T> DataTableToEntityList<T>(DataTable dtSource)
        {
            string propName = string.Empty;
            List<T> entityList = new List<T>();

            foreach (DataRow dr in dtSource.Rows)
            {
                // Create Instance of the Type T
                T entity = System.Activator.CreateInstance<T>();

                // Get all properties of the Type T
                System.Reflection.PropertyInfo[]
                entityProperties = typeof(T).GetProperties();

                // Loop through the properties defined in the 
                // entityList entity object and mapped the value
                foreach (System.Reflection.PropertyInfo item in
                        entityProperties)
                {
                    propName = string.Empty;
                    if (propName.Equals(string.Empty))
                        propName = item.Name;

                    if (dtSource.Columns.Contains(propName))
                    {
                        // Assign value to the property
                        try
                        {
                            item.SetValue(entity,dr[propName].GetType().Name.Equals(typeof(DBNull).Name)? null : dr[propName],null);
                        }
                        catch
                        {
                        }
                    }
                }
                entityList.Add(entity);
            }
            return entityList;
        }

        protected Type DbTypetoType(DbType dbType)
        {
            Type toReturn = typeof(DBNull);
            switch (dbType)
            {
                case DbType.String:
                    toReturn = typeof(string);
                    break;

                case DbType.UInt64:
                    toReturn = typeof(UInt64);
                    break;

                case DbType.Int64:
                    toReturn = typeof(Int64);
                    break;

                case DbType.Int32:
                    toReturn = typeof(Int32);
                    break;

                case DbType.UInt32:
                    toReturn = typeof(UInt32);
                    break;

                case DbType.Single:
                    toReturn = typeof(float);
                    break;

                case DbType.Date:
                    toReturn = typeof(DateTime);
                    break;

                case DbType.DateTime:
                    toReturn = typeof(DateTime);
                    break;

                case DbType.Time:
                    toReturn = typeof(DateTime);
                    break;

                case DbType.StringFixedLength:
                    toReturn = typeof(string);
                    break;

                case DbType.UInt16:
                    toReturn = typeof(UInt16);
                    break;

                case DbType.Int16:
                    toReturn = typeof(Int16);
                    break;

                case DbType.SByte:
                    toReturn = typeof(byte);
                    break;

                case DbType.Object:
                    toReturn = typeof(object);
                    break;

                case DbType.AnsiString:
                    toReturn = typeof(string);
                    break;

                case DbType.AnsiStringFixedLength:
                    toReturn = typeof(string);
                    break;

                case DbType.VarNumeric:
                    toReturn = typeof(decimal);
                    break;

                case DbType.Currency:
                    toReturn = typeof(double);
                    break;

                case DbType.Binary:
                    toReturn = typeof(byte[]);
                    break;

                case DbType.Decimal:
                    toReturn = typeof(decimal);
                    break;

                case DbType.Double:
                    toReturn = typeof(Double);
                    break;

                case DbType.Guid:
                    toReturn = typeof(Guid);
                    break;

                case DbType.Boolean:
                    toReturn = typeof(bool);
                    break;
            }

            return toReturn;
        }
    }
}
