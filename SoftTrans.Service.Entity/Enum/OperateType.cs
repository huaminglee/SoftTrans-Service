using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftTrans.Service.Entity.Enum
{
    public enum OperateType
    {
        /// <summary>
        /// 新增
        /// </summary>
        ADD,
        /// <summary>
        /// 修改
        /// </summary>
        UPDATE,
        /// <summary>
        /// 删除
        /// </summary>
        REMOVE,
        /// <summary>
        /// 查看
        /// </summary>
        VIEW,
        /// <summary>
        /// 审批
        /// </summary>
        AUDIT,
        /// <summary>
        /// 反审批
        /// </summary>
        UNAUDIT,
        CHECK,
        UNCHECK,
        /// <summary>
        /// 复制
        /// </summary>
        COPY
    }
}
