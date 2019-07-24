using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AutoMapper;
using Volo.Abp.Domain.Entities.Auditing;

namespace FHCollection.ApiCore
{
    /// <summary>
    /// 这个DTO类被用于在创建或更新书籍的时候从用户界面获取图书信息.
    /// 它定义了数据注释属性(如[Required])来定义属性的验证. DTO由ABP框架自动验证.
    /// </summary>
    public class CreateUpdateBookDto : AuditedEntityDto<Guid>
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public BookType Type { get; set; } = BookType.Undefined;

        [Required]
        public DateTime PublishDate { get; set; }

        [Required]
        public float Price { get; set; }
    }
}
