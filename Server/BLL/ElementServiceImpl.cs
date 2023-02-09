using ExamSalesApp.Server.DAL;
using ExamSalesApp.Shared;

namespace ExamSalesApp.Server.BLL
{
	public class ElementServiceImpl: IElementService
    {
        private readonly IElementRepo _elementRepo;
		public ElementServiceImpl(IElementRepo elementRepo)
		{
			this._elementRepo = elementRepo;
		}
		public bool Create(ElementsDto input)
		{
			//input.Type = "Doors";
			input.Height = 100;
			input.Width = 120;

			try
			{
				return _elementRepo.Create(input);
			}
			catch
			{
				return false;
			}
		}

		public bool Delete(int id)
		{
			try
			{
				return _elementRepo.Delete(id);
			}
			catch
			{
				return false;
			}
		}

		public ElementsDto Get(int id)
		{
			try
			{
				return _elementRepo.Get(id);
			}
			catch
			{
				return null;
			}
		}

		public List<ElementsDto> GetList()
		{
			try
			{
				return _elementRepo.GetList();
			}
			catch
			{
				return null;
			}
		}

		public bool Update(ElementsDto input)
		{
			try
			{
				return _elementRepo.Update(input);
			}
			catch
			{
				return false;
			}
		}
	}
}
