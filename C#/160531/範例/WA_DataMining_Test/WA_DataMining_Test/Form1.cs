using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AnalysisServices.AdomdClient;


namespace WA_DataMining_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AdomdConnection conn = new AdomdConnection("Data Source=localhost;Catalog=MyDataMining1");
            AdomdCommand cmd = new AdomdCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT [類神經].[GOOD BAD], " +
                                "PredictProbability([類神經].[GOOD BAD],1) " +
                                "From [類神經] " +
                                "NATURAL PREDICTION JOIN " +
                                "(SELECT 44 AS [AGE], " +
                                "'大學' AS [EDUCATION], " +
                                "'1' AS [GENDER], " +
                                "'40~80萬' AS [INCOME], " +
                                "'1' AS [MARRIAGE], " +
                                "10 AS [MAX ACTIVE CARD VINTAGE], " +
                                "1 AS [QUERY 3M CNT]) AS t";
            conn.Open();
            AdomdDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string a = dr.GetValue(0).ToString();
            string b = dr.GetValue(1).ToString();
            conn.Close();

            textBox1.Text = a + "\r\n" + b;

        }
    }
}
