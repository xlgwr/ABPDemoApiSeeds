using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace FHCollection.ApiCore
{
    /// <summary>
    /// 测试样例
    /// </summary>
    public class Book : Entity<int>
    {
        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}
