using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace FHCollection.ApiCore.Books
{
    /// <summary>
    /// 
    /// ABP可以自动按照惯例将你的应用程序服务配置为MVC API控制器.
    /// 
    /// BookAppService继承了AsyncCrudAppService<...>.AsyncCrudAppService<...>实现了上面定义的CRUD方法.
    /// BookAppService注入IRepository <Book,Guid>,这是Book实体的默认仓储.ABP自动为每个聚合根(或实体) 创建默认仓储.请参阅仓储文档
    /// BookAppService使用IObjectMapper将Book对象转换为BookDto对象, 将CreateUpdateBookDto对象转换为Book对象.
    /// 启动模板使用AutoMapper库作为对象映射提供程序.你之前定义了映射, 因此它将按预期工作
    /// </summary>
    public class BookAppService :
        AsyncCrudAppService<Book, BookDto, int, PagedAndSortedResultRequestDto,
                            CreateUpdateBookDto, CreateUpdateBookDto>,
        IBookAppService
    {
        public BookAppService(IRepository<Book, int> repository)
            : base(repository)
        {

        }
    }
}
