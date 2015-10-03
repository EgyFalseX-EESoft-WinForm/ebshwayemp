
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
    }
}
