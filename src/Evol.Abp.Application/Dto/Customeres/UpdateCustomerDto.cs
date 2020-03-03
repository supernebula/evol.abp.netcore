using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;


namespace Evol.Abp.Dto.Customeres
{
    public class UpdateCustomerDto : EntityDto<int>
    {
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
