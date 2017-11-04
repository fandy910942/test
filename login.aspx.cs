using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class login : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }

    }



    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if(tbusername.Text == "admin" & tbpsw.Text == "123456")
        {
            Response.Redirect("admin.aspx");
        }


        if (tbusername.Text == "")
        {
            Response.Write(@"<script>alert('用戶名不能為空！');</script>");
        }
        if (tbpsw.Text == "")
        {
            Response.Write(@"<script>alert('密碼不能為空！');</script>");
        }



        else if(tbusername.Text != null & tbpsw.Text != null)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=120.108.136.164;Initial Catalog=Upload;user id=sa;password=ckdiekinect1"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from register where userid=@userid and password=@password", conn);
                    SqlParameter tParam1 = new SqlParameter("@userid", SqlDbType.NChar);
                    tParam1.Value = this.tbusername.Text;
                    cmd.Parameters.Add(tParam1);

                    SqlParameter tParam2 = new SqlParameter("@password", SqlDbType.NVarChar);
                    tParam2.Value = this.tbpsw.Text;
                    cmd.Parameters.Add(tParam2);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            Session["userid"] = tbusername.Text;
                            Response.Redirect("Upload.aspx");
                        }
                        else
                        {
                            Response.Write(@"<script>alert('帳號或密碼錯誤！');</script>");
                        }
                    }
                }
            }
            catch (Exception)
            {
                Response.Write("錯誤");
            }


            //string userid = tbusername.Text;
            //string password = tbpsw.Text;
            //string sql = "select * from register where userid=@userid and password=@password";
            //string ConnStr;
            //ConnStr = "Data Source = USER-PC;Initial catalog =Upload;" +
            //"User id = sa; Password = apple0708";

            //SqlParameter[] parameters = { new SqlParameter("@userid", userid), new SqlParameter("@password", password) };

            //using (SqlConnection conn = new SqlConnection(ConnStr))
            //{
            //    conn.Open();
            //    using (SqlCommand cmd = conn.CreateCommand())
            //    {

            //            cmd.CommandText = sql;
            //            cmd.Parameters.AddRange(parameters);
            //            DataSet ds = new DataSet();
            //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //            adapter.Fill(ds);
            //            DataTable table = ds.Tables[0];


            //// 判斷資料庫帳號密碼------------------------

            //SqlConnection connection = new SqlConnection("Data Source=USER-PC;Initial catalog =Upload;" + "User id = sa; Password = apple0708");
            //connection.Open();

            //SqlCommand command = new SqlCommand("SELECT * FROM register WHERE userid = @userid and password = @password", connection);
            //command.Parameters.Add("@userid", System.Data.SqlDbType.NChar).Value = "userid";
            //command.Parameters.Add("@password", System.Data.SqlDbType.NChar).Value = "password";
            //SqlDataReader dr = command.ExecuteReader();



            //while (dr.Read())
            //{

            //    try
            //    {
            //        if (dr.HasRows)
            //        {
            //            Session["tbusername"] = dr["userid"].ToString();
            //            Session["tbpsw"] = dr["password"].ToString();
            //            cmd.Cancel();
            //            dr.Close();
            //            connection.Close();
            //            connection.Dispose();
            //            Response.Redirect("Upload.aspx");
            //        }
            //        else
            //        {
            //            tbusername.Text = "";
            //            tbpsw.Text = "";
            //            Session.Clear();
            //            Label1.Text = "帳號密碼錯誤！";
            //            cmd.Cancel();
            //            dr.Close();
            //            connection.Close();
            //            connection.Dispose();
            //            return;
            //        }


            //    }
            //    catch (Exception ex)
            //    {
            //        Response.Write("錯誤訊息：" + ex.ToString());
            //    }

            //}

            //--------------------------

            //if (table != null)
            //    Response.Redirect("Upload.aspx");
            ////Response.Write(@"<script>alert('登錄成功！');</script>");
            //else
            //    Response.Write(@"<script>alert('登錄失敗！');</script>");

            ////Response.Redirect("Upload.aspx");
        }
      }

   }

//    }
//}