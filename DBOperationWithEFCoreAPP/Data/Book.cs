using Microsoft.AspNetCore.Mvc.Razor;

namespace DBOperationWithEFCoreAPP.Data
{
	public class Book
	{
        public int Id { get; set; }
        public string ? Title { get; set; }
        public string ? Description { get; set; }
        public int NoOfPages { get; set; }
        public bool isActive { get; set; }
        public DateTime CreateOn { get; set; }

        public int LanguageId { get; set; }
        public Language ? Language { get; set; }
    }
}
