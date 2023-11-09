using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CorpActCDSLCons
{
    public partial class CaCDSLCons : Form
    {
        public CaCDSLCons()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnView01_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=VCCIPL-TECH\\VENTURESQLEXP;Initial Catalog=VCCIPL;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from corpactCDSLHeader", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnView02_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=VCCIPL-TECH\\VENTURESQLEXP;Initial Catalog=VCCIPL;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from corpactCDSLDetail", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void btnView03_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=VCCIPL-TECH\\VENTURESQLEXP;Initial Catalog=VCCIPL;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from corpactCDSLDetailDist", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;

        }

        private void btnSave01_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=VCCIPL-TECH\\VENTURESQLEXP;Initial Catalog=VCCIPL;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into corpactCDSLHeader (Record_type,Total_Records,Tot_Curr_Qty,Tot_Freeze_Qty," +
                "Tot_Lockin_Qty,Tot_Detail_Rec02,Tot_Detail_Rec03,MasterUniqNo) " +
                "values (@Record_type,@Total_Records,@Tot_Curr_Qty,@Tot_Freeze_Qty," +
                "@Tot_Lockin_Qty,@Tot_Detail_Rec02,@Tot_Detail_Rec03,@MasterUniqNo)", con);

            cmd.Parameters.AddWithValue("@Record_type", txtRecType01.Text);
            cmd.Parameters.AddWithValue("@Total_Records", txtTotRecords.Text);
            cmd.Parameters.AddWithValue("@Tot_Curr_Qty", txtTotCurrQty.Text);
            cmd.Parameters.AddWithValue("@Tot_Freeze_Qty", txtFreezeQty.Text);
            cmd.Parameters.AddWithValue("@Tot_Lockin_Qty", txtLockinQty.Text);
            cmd.Parameters.AddWithValue("@Tot_Detail_Rec02", txtDtRec02.Text);
            cmd.Parameters.AddWithValue("@Tot_Detail_Rec03", txtDtRec03.Text);
            cmd.Parameters.AddWithValue("@MasterUniqNo", txtMunCDSL01.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has saved in corpactCDSLHeader database");

        }

        private void label16_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void label31_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            Focus();

        }

        private void label33_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void label34_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void label35_Click(object sender, EventArgs e)
        {
            Focus();

        }

        private void label47_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void label53_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void label54_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void label55_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void label56_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void label57_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void label58_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void label59_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void label60_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void label61_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void btn2Save02_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=VCCIPL-TECH\\VENTURESQLEXP;Initial Catalog=VCCIPL;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into corpactCDSLDetail (" +
                
                "Record_Type,Bo_id,RTA_IntRef_No,PISIN,PCurr_Qty,PFrozen_Qty,PLockin_Qty,PLockin_Reason_Cd," +
                "PLockin_Reason,PLockin_Exp_Date,PDRCR_Flag,Benefit_Isin,BCurr_Qty,BFrozen_Qty,BLockin_Qty,BLockin_Reason_Cd," +
                "BLockin_Reason,BLockin_Exp_Date,BDRCR_Flag, MasterUniqNo\r\n) " +
                "values(@Record_Type,@Bo_id,@RTA_IntRef_No,@PISIN,@PCurr_Qty,@PFrozen_Qty," +
                "@PLockin_Qty,@PLockin_Reason_Cd,@PLockin_Reason,@PLockin_Exp_Date,@PDRCR_Flag,@Benefit_Isin," +
                "@BCurr_Qty,@BFrozen_Qty,@BLockin_Qty,@BLockin_Reason_Cd,@BLockin_Reason,@BLockin_Exp_Date,@BDRCR_Flag, " +
                "@MasterUniqNo)", con);

            cmd.Parameters.AddWithValue("@Record_Type", txtRecType02.Text);
            cmd.Parameters.AddWithValue("@Bo_id", txtboid02.Text);
            cmd.Parameters.AddWithValue("@RTA_IntRef_No", txtIntrefno02.Text);
            cmd.Parameters.AddWithValue("@PISIN", txtPisin.Text);
            cmd.Parameters.AddWithValue("@PCurr_Qty", txtPCurqty.Text);
            cmd.Parameters.AddWithValue("@PFrozen_Qty", txtPFrozenqty.Text);
            cmd.Parameters.AddWithValue("@PLockin_Qty", txtPLockinqty02.Text);
            //            cmd.Parameters.AddWithValue("@PLockin_Qty", txtPLockinqty.Text);
            var plrcode = comboBox4.Text.Substring(0, 2);
            cmd.Parameters.AddWithValue("@PLockin_Reason_Cd", plrcode);
            cmd.Parameters.AddWithValue("@PLockin_Reason", txtPLockinReason.Text);
            cmd.Parameters.AddWithValue("@PLockin_Exp_Date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            var pdrcrflag = comboBox1.Text.Substring(0, 1);
            cmd.Parameters.AddWithValue("@PDRCR_Flag", pdrcrflag);
            cmd.Parameters.AddWithValue("@Benefit_Isin", txtBisin.Text);
            cmd.Parameters.AddWithValue("@BCurr_Qty", txtBCurqty.Text);
            cmd.Parameters.AddWithValue("@BFrozen_Qty", txtBFrozenqty.Text);
            cmd.Parameters.AddWithValue("@BLockin_Qty", txtBLockinqty.Text);
            var Blrcode = comboBox5.Text.Substring(0, 2);
            cmd.Parameters.AddWithValue("@BLockin_Reason_Cd", Blrcode);
            cmd.Parameters.AddWithValue("@BLockin_Reason", txtBLockinReason.Text);
            cmd.Parameters.AddWithValue("@BLockin_Exp_Date", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            var bdrcrflag = comboBox2.Text.Substring(0, 1);
            cmd.Parameters.AddWithValue("@BDRCR_Flag", bdrcrflag);
            cmd.Parameters.AddWithValue("@MasterUniqNo", txtMun02cd.Text);
            //
            // crqty * issuepricecr;
            //var totalamount = drqty * issueamountcr;
            //label8.Text = totalpaidupprice;
            //label21.Text = totalpaidupamount;
            //cmd.Parameters.AddWithValue("@Paidup_Price_Allotment_Allocation_Credit_ISIN", totalpaidupprice);
            //            cmd.Parameters.AddWithValue("@Paidup_Price_Allotment_Allocation_Credit_ISIN", txtIsspriceallcrisin.Text);

            //cmd.Parameters.AddWithValue("@Paidup_Amount_Allotment_Allocation_Credit_ISIN", totalpaidupamount);
            //            cmd.Parameters.AddWithValue("@Paidup_Amount_Allotment_Allocation_Credit_ISIN", txtPaidamtallcrisin.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has saved in corpactCDSLDetail database");
        }

        private void btnSave03_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=VCCIPL-TECH\\VENTURESQLEXP;Initial Catalog=VCCIPL;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into corpactCDSLDetailDist (" +
                "Record_Type,CA_Isin,From_DistNo_CDSL,To_DistNo_CDSL, Quantity,DRCR_Flag,MasterUniqNo) " +
                "values(@Record_Type,@CA_Isin,@From_DistNo_CDSL,@To_DistNo_CDSL, @Quantity,@DRCR_Flag,@MasterUniqNo)", con);
            
            cmd.Parameters.AddWithValue("@Record_Type", txtRecident03.Text);
            cmd.Parameters.AddWithValue("@CA_Isin", txtCAisin.Text);
            //var drcrind3 = comboBox2drcrindicator.Text.Substring(0, 1);
            cmd.Parameters.AddWithValue("@From_DistNo_CDSL", txtFromdistinctivenonsdl.Text);
            cmd.Parameters.AddWithValue("@To_DistNo_CDSL", txtTodistinctivenonsdl.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
            var drcrind = comboBox2drcrindicator.Text.Substring(0, 1); 
            cmd.Parameters.AddWithValue("@DRCR_Flag", drcrind);
            //var flagdnr = comboBox1flagdnrange.Text.Substring(0, 2);
            //var cacode3 = comboBox3.Text.Substring(0, 4);
            cmd.Parameters.AddWithValue("@MasterUniqNo", txtMun03cd.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has saved in corpactCDSLDetailDist database");

        }

        private void txtTotCurrQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=!char.IsNumber(e.KeyChar);
        }

        private void txtFreezeQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtLockinQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtDtRec02_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtDtRec03_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtMunCDSL01_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtPCurqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtPFrozenqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtPLockinqty02_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtBCurqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtBFrozenqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtBLockinqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtMun02cd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtFromdistinctivenonsdl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtTodistinctivenonsdl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtMun03cd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtTodistinctivenonsdl_TextChanged(object sender, EventArgs e)
        {
            //  cmd.Parameters.AddWithValue("@From_DistNo_CDSL", txtFromdistinctivenonsdl.Text);
            // cmd.Parameters.AddWithValue("@To_DistNo_CDSL", txtTodistinctivenonsdl.Text);

            //
            // cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
            if (txtFromdistinctivenonsdl.Text.Length > 0 && txtTodistinctivenonsdl.Text.Length > 0)
            {
                txtQuantity.Text = Convert.ToString(Convert.ToInt32(txtTodistinctivenonsdl.Text) - Convert.ToInt32(txtFromdistinctivenonsdl.Text) + 1);
            }

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
