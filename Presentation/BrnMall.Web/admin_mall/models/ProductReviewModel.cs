﻿using System;
using System.Data;

using BrnMall.Core;
using BrnMall.Services;
using BrnMall.Web.Framework;

namespace BrnMall.Web.MallAdmin.Models
{
    /// <summary>
    /// 商品评价列表模型类
    /// </summary>
    public class ProductReviewListModel
    {
        public PageModel PageModel { get; set; }
        public string SortColumn { get; set; }
        public string SortDirection { get; set; }
        public DataTable ProductReviewList { get; set; }
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public int Pid { get; set; }
        public string Message { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }

    /// <summary>
    /// 商品评价回复列表模型类
    /// </summary>
    public class ProductReviewReplyListModel
    {
        public DataTable ProductReviewReplyList { get; set; }
    }
}
