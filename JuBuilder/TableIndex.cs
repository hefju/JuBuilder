﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JuBuilder
{
    /// <summary>
    /// 数据库表索引
    /// </summary>
    public class TableIndex
    {
        /// <summary>
        /// 索引名称
        /// </summary>
        public string IndexName { get; set; }
        /// <summary>
        /// 索引类型
        /// </summary>
        public string IndexType { get; set; }
        /// <summary>
        /// 是否为主键
        /// </summary>
        public bool IsPrimaryKey { get; set; }

        /// <summary>
        /// 是否唯一索引
        /// </summary>
        public bool IsUnique { get; set; }
        /// <summary>
        /// 是否唯一约束
        /// </summary>
        public bool IsUniqueConstraint { get; set; }
        /// <summary>
        /// 索引列
        /// </summary>
        public string IndexColumns { get; set; }

        /// <summary>
        /// 覆盖索引列
        /// </summary>
        public string IndexIncludeColumns { get; set; }
    }
}
