using AutoMapper;
using ExamSalesApp.Server.Data;
using ExamSalesApp.Server.Models;
using ExamSalesApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace ExamSalesApp.Server.DAL
{
	public class ElementRepoImpl : IElementRepo
	{
		readonly ExamSalesContext _dbContext = new();
		private readonly IMapper _mapper;
		public ElementRepoImpl(ExamSalesContext dbContext, IMapper mapper)
		{
			this._dbContext = dbContext;
			this._mapper = mapper;
		}

		public bool Create(ElementsDto input)
		{
			try
			{
				var newItem = _mapper.Map<ElementsDto, Elements>(input);
				var item = _dbContext.Elements.Add(newItem);
				_dbContext.SaveChanges();
				return true;
			}
			catch
			{
				throw;
			}
		}

		public bool Delete(int id)
		{
			try
			{
				Elements? element = _dbContext.Elements.Find(id);
				if (element != null)
				{
					_dbContext.Elements.Remove(element);
					_dbContext.SaveChanges();
					return true;
				}
				else
				{
					throw new ArgumentNullException();
				}
			}
			catch
			{
				throw;
			}
		}

		public ElementsDto Get(int id)
		{
			try
			{
				Elements? element = _dbContext.Elements.Find(id);
				if (element != null)
				{
					var newItem = _mapper.Map<Elements, ElementsDto>(element);
					return newItem;
				}
				else
				{
					throw new ArgumentNullException();
				}
			}
			catch
			{
				throw;
			}
		}

		public List<ElementsDto> GetList()
		{
			try
			{
				var list = _dbContext.Elements.ToList();
				return _mapper.Map<List<Elements>, List<ElementsDto>>(list);
			}
			catch
			{
				throw;
			}
		}

		public bool Update(ElementsDto input)
		{
			try
			{
				var newItem = _mapper.Map<ElementsDto, Elements>(input);
				_dbContext.Entry(newItem).State = EntityState.Modified;
				_dbContext.SaveChanges();
				return true;
			}
			catch
			{
				throw;
			}
		}
	}
}
