﻿using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace QuanLyNhanSu
{
    class ConnectDatabase
    {
        string strConnect = @"Data Source=DESKTOP-81VHF3A\SQLEXPRESS;Initial Catalog=TTN_QLNHANSU_01;Integrated Security=True";
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        SqlDataReader sqlDataReader;
        DataSet dataSet = new DataSet();

        void KetNoi()
        {
            sqlConnection = new SqlConnection(strConnect);
            sqlConnection.Open();
        }

        void NgatKetNoi()
        {
            sqlConnection.Close();
        }

        public void ThucThiKetNoi(string strsql)
        {
            KetNoi();
            sqlCommand = new SqlCommand(strsql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            NgatKetNoi();
        }
        //public void loadDataGridView(DataGridView dg, string strselect)
        //{
            
        //    sqlDataAdapter = new SqlDataAdapter(strselect, strConnect);
        //    dataSet.Clear();
        //    sqlDataAdapter.Fill(dataSet, "query");
        //    dg.DataSource = dataSet.Tables[0];
        //}

        public void loadDataGridView(DataGridView dg, string strselect)
        {
            DataTable table = new DataTable();
            sqlDataAdapter = new SqlDataAdapter(strselect, strConnect);
            table.Clear();
            sqlDataAdapter.Fill(table);
            dg.DataSource = table;
        }

        public void loadComboBox(ComboBox cb, string strselect)
        {
            KetNoi();
            sqlCommand = new SqlCommand(strselect, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cb.Items.Add(sqlDataReader[0].ToString());
            }
            NgatKetNoi();
        }
        public void loadComboBox_Show(ComboBox cb, string strselect)
        {
            KetNoi();
            sqlCommand = new SqlCommand(strselect, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cb.Text = (sqlDataReader[0].ToString());
            }
            NgatKetNoi();
        }
        public void loadTextBox(TextBox tb, string strselect)
        {
            KetNoi();
            sqlCommand = new SqlCommand(strselect, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                tb.Text = sqlDataReader[0].ToString();
            }
            NgatKetNoi();
        }

        

        public bool Check(string temp, string strsql)
        {

            KetNoi();
            bool check = false;
            sqlCommand = new SqlCommand(strsql, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                if (sqlDataReader[0].ToString().Trim() == temp)
                    check = true;
            }
            NgatKetNoi();
            return check;
        }


    }
}
