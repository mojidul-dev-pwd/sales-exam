using ExamSalesApp.Shared;

namespace ExamSalesApp.Server.DAL
{
	public interface IElementRepo
	{
		ElementsDto Get(int id);
		bool Create(ElementsDto input);
		bool Update(ElementsDto input);
		bool Delete(int id);
		List<ElementsDto> GetList();
	}
}
