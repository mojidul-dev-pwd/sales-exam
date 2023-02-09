using AutoMapper;
using ExamSalesApp.Server.Models;
using ExamSalesApp.Shared;

namespace ExamSalesApp.Server.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Elements, ElementsDto>();
		}
	}
}
