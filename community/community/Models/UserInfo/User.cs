using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace community.Models.UserInfo
{
    public class User
    {
        /// <summary>
        /// 用户ID/唯一标识
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd{ get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public string Age { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        public string IdCard { get; set; }
        /// <summary>
        /// 星座
        /// </summary>
        public string Constellation { get; set; }
        /// <summary>
        /// 生肖
        /// </summary>
        public string AnimalSigns { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime BrithDay { get; set; }
        /// <summary>
        /// 联系方式
        /// </summary>
        public string Contact { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 注册日期
        /// </summary>
        public DateTime RegDate { get; set; }
    }
}