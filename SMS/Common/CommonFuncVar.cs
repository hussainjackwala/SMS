using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.IO;
namespace SMS.Common
{
 class CommonFuncVar
    {
        public static string LoginName = "";

        public static bool IsValidateDS(DataSet ds)
        {
            bool isValdtds = false;
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        isValdtds = true;
                    }
                    
                }
            }
            return isValdtds;
        }



        //public static Exception Log(this Exception ex)
        //{
        //    File.AppendAllText("CaughtExceptions" + DateTime.Now.ToString("yyyy-MM-dd") + ".log", DateTime.Now.ToString("HH:mm:ss") + ": " + ex.Message + "\n" + ex.ToString() + "\n");
        //    return ex;
        //}

        //public static Exception Display(this Exception ex, string msg = null, MessageBoxIcon img = MessageBoxIcon.Error)
        //{
        //    MessageBox.Show(msg ?? ex.Message, "", MessageBoxButtons.OK, img);
        //    return ex;
        //}

    }
}
