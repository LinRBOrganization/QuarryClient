using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LB.Common
{
    public enum enBillStatus
    {
        /// <summary>
        /// 添加
        /// </summary>
        Add,
        /// <summary>
        /// 编辑
        /// </summary>
        Edit,
        /// <summary>
        /// 审核
        /// </summary>
        Approve,
        /// <summary>
        /// 作废
        /// </summary>
        Cancel
    }

    public enum enBaseInfoType
    {
        None,
        Item,
        Customer,
        Car
    }

    public enum enWeightType
    {
        /// <summary>
        /// 入场磅
        /// </summary>
        WeightIn=0,
        /// <summary>
        /// 出场磅
        /// </summary>
        WeightOut=1
    }
}
