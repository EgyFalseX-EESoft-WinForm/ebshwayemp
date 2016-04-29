
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Employee
{
    public static class DatabaseScripts
    {

        public static void FireScript()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.EmployeesConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                //vQry02
                if (CheckViewExists("vQry02"))
                {
                    cmd.CommandText = DropObject("vQry02");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry02;
                cmd.ExecuteNonQuery();
                //vQry03
                if (CheckViewExists("vQry03"))
                {
                    cmd.CommandText = DropObject("vQry03");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry03;
                cmd.ExecuteNonQuery();
                //vQry04
                if (CheckViewExists("vQry04"))
                {
                    cmd.CommandText = DropObject("vQry04");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry04;
                cmd.ExecuteNonQuery();
                //vtbl_maradiy
                if (CheckViewExists("vtbl_maradiy"))
                {
                    cmd.CommandText = DropObject("vtbl_maradiy");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vtbl_maradiy;
                cmd.ExecuteNonQuery();
                //vTBL_Emp
                if (CheckViewExists("vTBL_Emp"))
                {
                    cmd.CommandText = DropObject("vTBL_Emp");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vTBL_Emp;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Program.Logger.LogThis(FXFW.SqlDB.CheckExp(ex), "Fire Scripting", FXFW.Logger.OpType.success, null, ex, null);
            }
            con.Close();
        }

        public static bool CheckViewExists(string viewName)
        {
            bool exist = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.EmployeesConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandText = string.Format(@"IF EXISTS(select * FROM sys.views where name = '{0}')
                                            SELECT 1
                                            ELSE
                                            SELECT 0", viewName);
            try
            {
                con.Open();
                if (cmd.ExecuteScalar().ToString() == "1")
                    exist = true;
                else
                    exist = false;
            }
            catch (SqlException ex)
            {
                Program.Logger.LogThis(FXFW.SqlDB.CheckExp(ex), "Fire Scripting", FXFW.Logger.OpType.success, null, ex, null);
            }
            con.Close();
            return exist;
        }
        private static string DropObject(string objName)
        {
            return string.Format(@"DROP VIEW [dbo].[{0}]", objName);
        }

        public static string vQry02
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry02]
                AS
                WITH CTE1 AS
                (
                SELECT        TBLGehawork.GehaworkId, TBLGehawork.Gehawork, CDAlnoa.name_alnoa
                , CASE WHEN CDAlnoa.name_alnoa = 'ذكر' THEN COUNT(TBL_Emp.EmpID) ELSE 0 END AS MaleCount
                , CASE WHEN CDAlnoa.name_alnoa = 'انثي' THEN COUNT(TBL_Emp.EmpID) ELSE 0 END AS FemaleCount
                FROM            CDAlnoa INNER JOIN
                                         TBL_Emp ON CDAlnoa.code_alnoa = TBL_Emp.GENDER_ID RIGHT OUTER JOIN
                                         TBLGehawork ON TBL_Emp.GehaworkId = TBLGehawork.GehaworkId
                GROUP BY TBLGehawork.GehaworkId, TBLGehawork.Gehawork, CDAlnoa.name_alnoa
                )
                SELECT        GehaworkId, Gehawork, SUM(MaleCount) AS MaleCount, SUM(FemaleCount) AS FemaleCount
                FROM CTE1
                GROUP BY  GehaworkId, Gehawork";
            }
        }
        public static string vQry03
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry03]
                AS
                WITH CTE1 AS
(
SELECT        TBLGehawork.GehaworkId, TBLGehawork.Gehawork, CD_EmpJob.EmpJobId, CD_EmpJob.EmpJobName, TBL_Emp.EmpID
, YEAR(GETDATE()) - YEAR(TBL_Emp.BIRTH_DATE) AS Age
FROM            TBL_Emp INNER JOIN
                         CD_EmpJob ON TBL_Emp.EmpJobId = CD_EmpJob.EmpJobId INNER JOIN
                         TBLGehawork ON TBL_Emp.GehaworkId = TBLGehawork.GehaworkId
), CTE2 AS
(
SELECT        GehaworkId, Gehawork, EmpJobId, EmpJobName
, CASE WHEN Age BETWEEN 0 AND 20 OR Age IS NULL THEN EmpID END AS [0_20]
, CASE WHEN Age BETWEEN 20 AND 40 THEN EmpID END AS [20_40]
, CASE WHEN Age BETWEEN 40 AND 60 THEN EmpID END AS [40_60]
, CASE WHEN Age > 60 THEN EmpID END AS [>_60]
FROM            CTE1 
), CTE3 AS
(
SELECT GehaworkId, Gehawork, EmpJobId, EmpJobName, [0_20], [20_40], [40_60], [>_60]
FROM CTE2 GROUP BY GehaworkId, Gehawork, EmpJobId, EmpJobName, [0_20], [20_40], [40_60], [>_60]
)
SELECT GehaworkId, Gehawork, EmpJobId, EmpJobName, COUNT([0_20]) AS [0_20], COUNT([20_40]) AS [20_40], COUNT([40_60]) AS [40_60], COUNT([>_60]) AS [>_60]
FROM CTE3 GROUP BY GehaworkId, Gehawork, EmpJobId, EmpJobName";
            }
        }
        public static string vQry04
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry04]
                AS
                SELECT        TBLGehawork.GehaworkId, TBLGehawork.Gehawork, CD_EmpJob.EmpJobId, CD_EmpJob.EmpJobName, TBL_Emp.EmpID, TBL_Emp.EMPNAME
, TBL_Emp.BIRTH_DATE
,YEAR(GETDATE()) - YEAR(TBL_Emp.BIRTH_DATE) AS Age
, DateAdd(Year, 60, TBL_Emp.BIRTH_DATE) AS RetirementDate
FROM            TBL_Emp INNER JOIN
                         CD_EmpJob ON TBL_Emp.EmpJobId = CD_EmpJob.EmpJobId INNER JOIN
                         TBLGehawork ON TBL_Emp.GehaworkId = TBLGehawork.GehaworkId";
            }
        }
        public static string vtbl_maradiy
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vtbl_maradiy]
                AS
                SELECT        dbo.tbl_maradiy.mid, dbo.tbl_maradiy.EmpID, dbo.tbl_maradiy.teldatae, dbo.tbl_maradiy.datefrom, dbo.tbl_maradiy.dateto, dbo.tbl_maradiy.lagnatebea, dbo.tbl_maradiy.datelagna, dbo.tbl_maradiy.krar, 
                         dbo.tbl_maradiy.userin, dbo.tbl_maradiy.datein, dbo.Users.UserName, dbo.TBL_Emp.EMPNAME, dbo.CDGehaworktype.Gehaworktype
FROM            dbo.tbl_maradiy INNER JOIN
                         dbo.TBL_Emp ON dbo.tbl_maradiy.EmpID = dbo.TBL_Emp.EmpID INNER JOIN
                         dbo.Users ON dbo.tbl_maradiy.userin = dbo.Users.UserID INNER JOIN
                         dbo.CDGehaworktype ON dbo.TBL_Emp.GehaworkId = dbo.CDGehaworktype.GehaworktypeId";
            }
        }
        public static string vTBL_Emp
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vTBL_Emp]
                AS
                SELECT        dbo.TBL_Emp.EmpID, dbo.TBL_Emp.EMPNAME, dbo.TBL_Emp.GehaworkId, dbo.TBL_Emp.marhala_code, dbo.TBL_Emp.EmpNationalID, dbo.TBL_Emp.BIRTH_DATE, dbo.TBL_Emp.BIRTH_GOV, 
                         dbo.TBL_Emp.BIRTH_PLACE, dbo.TBL_Emp.GENDER_ID, dbo.TBL_Emp.EMP_FIRST_NAME, dbo.TBL_Emp.EMP_FATHER_NAME, dbo.TBL_Emp.EMP_FAM_NAME, dbo.TBL_Emp.EMP_FOURTH_NAME, 
                         dbo.TBL_Emp.nationaltyId, dbo.TBL_Emp.dyana_code, dbo.TBL_Emp.MaritalStatusId, dbo.TBL_Emp.SubjectId, dbo.TBL_Emp.DepartmentId, dbo.TBL_Emp.EmpJobId, dbo.TBL_Emp.JobkaderId, 
                         dbo.TBL_Emp.JOB_STATUS_ID, dbo.TBL_Emp.JobTypeId, dbo.TBL_Emp.Emp_Address, dbo.TBL_Emp.PHONE_NO, dbo.TBL_Emp.MOBILE_NO, dbo.TBL_Emp.Work_Start_Date, dbo.TBL_Emp.End_Work_Date, 
                         dbo.TBL_Emp.qualId, dbo.TBL_Emp.SpecializationId, dbo.TBL_Emp.QualifiedPlaceId, dbo.TBL_Emp.Moaahel_Date, dbo.TBL_Emp.tagned_id, dbo.TBL_Emp.tameen_no, dbo.TBL_Emp.tameen_date1, 
                         dbo.TBL_Emp.tameen_date2, dbo.TBL_Emp.betaka_tameen, dbo.TBL_Emp.noview, dbo.TBL_Emp.orderreport, dbo.TBL_Emp.userin, dbo.TBL_Emp.datein, dbo.TBL_Emp.JobDescriptionId, 
                         dbo.TBL_Emp.codemortabat, dbo.TBL_Emp.eschoolcode, dbo.Users.UserName, dbo.CDGehaworktype.Gehaworktype
FROM            dbo.TBL_Emp INNER JOIN
                         dbo.CDGehaworktype ON dbo.TBL_Emp.GehaworkId = dbo.CDGehaworktype.GehaworktypeId INNER JOIN
                         dbo.Users ON dbo.TBL_Emp.userin = dbo.Users.UserID";
            }
        }
    }
}
