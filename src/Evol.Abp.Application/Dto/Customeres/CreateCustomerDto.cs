using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Evol.Abp.Dto.Customeres
{
    public class CreateCustomerDto
    {

        /// <summary>
        /// 登录名
        /// </summary>
        [Required]
        [StringLength(10,MinimumLength = 5)]
        public string LoginName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [StringLength(10, MinimumLength = 2)]
        public string Name { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }


    }
}
