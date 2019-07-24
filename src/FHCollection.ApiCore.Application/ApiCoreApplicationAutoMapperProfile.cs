using AutoMapper;

namespace FHCollection.ApiCore
{
    public class ApiCoreApplicationAutoMapperProfile : Profile
    {
        public ApiCoreApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            //在将书籍返回到表示层时,需要将Book实体转换为BookDto对象.
            CreateMap<Book, BookDto>();

            //创建或更新书籍的时候从用户界面获取图书信息
            //它定义了数据注释属性(如[Required])来定义属性的验证. DTO由ABP框架自动验证.
            CreateMap<CreateUpdateBookDto, Book>();

            //Mapper.AssertConfigurationIsValid();
        }
    }
}