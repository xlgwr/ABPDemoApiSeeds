using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace FHCollection.ApiCore
{
    /// <summary>
    /// DTO类被用来在 表示层 和 应用层 传递数据.查看DTO文档查看更多信息.
    /// 为了在页面上展示书籍信息,BookDto被用来将书籍数据传递到表示层.
    /// </summary>
    public class BookDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}
