using LB.WinFunction.Args;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace LB.WinFunction
{
    public class ExecuteSQL
    {
        public static event CallSPHandle CallSPEvent;
        
        /// <summary>
        /// 调用存储过程或中间层
        /// </summary>
        /// <param name="iSPType">存储过程号</param>
        /// <param name="dtInput">参数数据</param>
        /// <param name="dsReturn">返回的查询数据</param>
        /// <param name="dtOut">返回的参数值</param>
        public static void CallSP(int iSPType,DataTable dtInput,out DataSet dsReturn,out DataTable dtOut)
        {
            if (string.IsNullOrEmpty(dtInput.TableName))
            {
                dtInput.TableName = "SPIN";
            }
            LBWebService.LBWebService webservice = new LBWebService.LBWebService();
            string strErrorMsg;
            bool bolIsError;

            List<Dictionary<object, object>> lstDictValue = new List<Dictionary<object, object>>();
            Dictionary<object, object> dictDataType = new Dictionary<object, object>();
            foreach (DataRow dr in dtInput.Rows)
            {
                Dictionary<object, object> dict = new Dictionary<object, object>();
                foreach (DataColumn dc in dtInput.Columns)
                {
                    dict.Add(dc.ColumnName, dr[dc.ColumnName]);
                    if (!dictDataType.ContainsKey(dc.ColumnName))
                    {
                        dictDataType.Add(dc.ColumnName, dc.DataType.ToString());
                    }
                }
                lstDictValue.Add(dict);
            }

            byte[] bSerialValue = SerializeObject(lstDictValue);
            byte[] bSerialDataType = SerializeObject(dictDataType);
            
            dsReturn = webservice.RunProcedure(iSPType, LoginInfo.LoginName, bSerialValue,bSerialDataType, out dtOut, out strErrorMsg, out bolIsError);
            if (bolIsError)
            {
                throw new Exception(strErrorMsg);
            }
            if (CallSPEvent != null)
            {
                CallSPArgs args = new Args.CallSPArgs(iSPType, dtInput);
                CallSPEvent(args);
            }
        }

        public static byte[] SerializeObject(object pObj)
        {
            if (pObj == null)
                return null;
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(memoryStream, pObj);
            memoryStream.Position = 0;
            byte[] read = new byte[memoryStream.Length];
            memoryStream.Read(read, 0, read.Length);
            memoryStream.Close();
            return read;
        }

        public static object DeserializeObject(byte[] pBytes)
        {
            object newOjb = null;
            if (pBytes == null)
            {
                return newOjb;
            }


            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(pBytes);
            memoryStream.Position = 0;
            BinaryFormatter formatter = new BinaryFormatter();
            newOjb = formatter.Deserialize(memoryStream);
            memoryStream.Close();


            return newOjb;
        }

        /// <summary>
        /// 调用存储过程或中间层
        /// </summary>
        /// <param name="iSPType">存储过程号</param>
        /// <param name="parmCollection">参数数据</param>
        /// <param name="dsReturn">返回的查询数据</param>
        /// <param name="dictReturn">返回的参数值</param>
        public static void CallSP(int iSPType, LBDbParameterCollection parmCollection,out DataSet dsReturn,out Dictionary<string,object> dictReturn)
        {
            dictReturn = new Dictionary<string, object>();
            DataTable dtSPIN = new DataTable("SPIN");
            foreach(LBParameter parm in parmCollection)
            {
                if (!dtSPIN.Columns.Contains(parm.ParameterName))
                {
                    dtSPIN.Columns.Add(parm.ParameterName, LBDbType.GetSqlDbType( parm.LBDBType));
                }
            }

            DataRow drNew = dtSPIN.NewRow();
            foreach (LBParameter parm in parmCollection)
            {
                if(parm.Direction!= ParameterDirection.Output)
                {
                    drNew[parm.ParameterName] = parm.Value;
                }
            }
            dtSPIN.Rows.Add(drNew);

            LBWebService.LBWebService webservice = new LBWebService.LBWebService();
            string strErrorMsg;
            bool bolIsError;
            DataTable dtOut;

            CallSP(iSPType, dtSPIN, out dsReturn, out dtOut);

            if (dtOut != null && dtOut.Rows.Count > 0)
            {
                foreach(DataColumn dc in dtOut.Columns)
                {
                    if (!dictReturn.ContainsKey(dc.ColumnName))
                    {
                        dictReturn.Add(dc.ColumnName, dtOut.Rows[0][dc.ColumnName]);
                    }
                }
            }
        }

        /// <summary>
        /// 查询视图
        /// </summary>
        /// <param name="iViewType">视图号</param>
        /// <param name="strFieldNames">查询字段</param>
        /// <param name="strWhere">查询条件</param>
        /// <param name="strOrderBy">排序</param>
        /// <returns></returns>
        public static DataTable CallView(int iViewType,string strFieldNames,string strWhere ,string strOrderBy)
        {
            DataTable dtResult = null;
            LBWebService.LBWebService webservice = new LBWebService.LBWebService();
            string strErrorMsg;
            bool bolIsError;
            dtResult = webservice.RunView(iViewType, LoginInfo.LoginName, strFieldNames, strWhere,strOrderBy, out strErrorMsg, out bolIsError);
            if (bolIsError)
            {
                throw new Exception(strErrorMsg);
            }
            return dtResult;
        }

        /// <summary>
        /// 无条件查询视图
        /// </summary>
        /// <param name="iViewType">视图号</param>
        /// <returns></returns>
        public static DataTable CallView(int iViewType)
        {
            return CallView(iViewType, "", "", "");
        }
        /// <summary>
        /// 直接执行SQL
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        public static DataTable CallDirectSQL(string strSQL)
        {
            DataTable dtResult = null;
            LBWebService.LBWebService webservice = new LBWebService.LBWebService();
            string strErrorMsg;
            bool bolIsError;
            dtResult = webservice.RunDirectSQL(LoginInfo.LoginName, strSQL, out strErrorMsg, out bolIsError);
            if (bolIsError)
            {
                throw new Exception(strErrorMsg);
            }
            return dtResult;
        }

        /// <summary>
        /// 测试连接状态
        /// </summary>
        /// <returns></returns>
        public static bool TestConnectStatus()
        {
            LBWebService.LBWebService webservice = new LBWebService.LBWebService();
            return webservice.ConnectServer();
        }
    }
}
