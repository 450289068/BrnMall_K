﻿using System;
using System.Data;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using BrnMall.Core;
using BrnMall.Services;
using BrnMall.Web.Framework;

namespace BrnMall.Web.StoreAdmin.Models
{
    /// <summary>
    /// 商品咨询列表模型类
    /// </summary>
    public class ProductConsultListModel
    {
        /// <summary>
        /// 分页对象
        /// </summary>
        public PageModel PageModel { get; set; }
        /// <summary>
        /// 排序列
        /// </summary>
        public string SortColumn { get; set; }
        /// <summary>
        /// 排序方向
        /// </summary>
        public string SortDirection { get; set; }
        /// <summary>
        /// 商品咨询列表
        /// </summary>
        public DataTable ProductConsultList { get; set; }
        /// <summary>
        /// 账号名
        /// </summary>
        public string AccountName { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        public int Pid { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 商品咨询类型id
        /// </summary>
        public int ConsultTypeId { get; set; }
        /// <summary>
        /// 咨询信息
        /// </summary>
        public string ConsultMessage { get; set; }
        /// <summary>
        /// 咨询开始时间
        /// </summary>
        public string ConsultStartTime { get; set; }
        /// <summary>
        /// 咨询结束时间
        /// </summary>
        public string ConsultEndTime { get; set; }
    }

    /// <summary>
    /// 回复商品咨询模型类
    /// </summary>
    [Bind(Exclude = "ProductConsultInfo")]
    public class ReplyProductConsultModel
    {
        public ProductConsultInfo ProductConsultInfo { get; set; }

        [Required(ErrorMessage = "回复内容不能为空")]
        [StringLength(100, ErrorMessage = "最多只能输入100个字")]
        public string ReplyMessage { get; set; }
    }
}
