using RestWithASP_NET5.Model;
using RestWithASPNETUdemy.Hypermedia.Utils;
using System.Collections.Generic;

namespace RestWithASP_NET5.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindById(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long id);
        PagedSearchVO<BookVO> FindWithPagedSearch(string name, string sortDirection, int pageSize, int page);
    }
}
