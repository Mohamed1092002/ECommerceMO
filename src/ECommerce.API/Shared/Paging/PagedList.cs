namespace ECommerce.API.Shared.Paging
{
    public class PagedList<T>:List<T>
    {
        public MetaData MetaData { get; set; }
        public PagedList(List<T> items,int count,int pageNumber,int pageSize) 
        {
            MetaData = new MetaData()
            {
                PageSize = pageSize,
                TotalCount = count,
                CurrentPage = pageNumber,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize),
            };
            AddRange(items);
        }
        public static PagedList<T> ToPagedList(List<T> list,int pageNum,int pageSize,int count)
        {
            var pageItems=list.Skip((pageNum-1)*pageSize).Take(pageSize).ToList();
            return new PagedList<T>(pageItems, count, pageNum, pageSize);
        }
    }
}
