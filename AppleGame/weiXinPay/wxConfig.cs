﻿using AntDesigner.weiXinPay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WxPayAPI;

namespace AntDesigner.weiXinPay
{
    public class wxConfig
    {
  public string appId { get; set; } // 必填，公众号的唯一标识
  public string timestamp { get; set; }  // 必填，生成签名的时间戳
  public string nonceStr { get; set; }  // 必填，生成签名的随机串
  public string signature { get; set; } // 必填，签名，见附录1
        public wxConfig( string url)
        {
            string nonceStr_;
            string timestamp_;
            appId = WxPayConfig.APPID;
            signature = WxPayConfig.GetSignature(url, out nonceStr_, out timestamp_);
            nonceStr = nonceStr_;
            timestamp = timestamp_;
        }
    }
  
}
