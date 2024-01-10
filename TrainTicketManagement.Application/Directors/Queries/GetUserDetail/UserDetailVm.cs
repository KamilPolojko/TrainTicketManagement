using AutoMapper;
using TrainTicketManagement.Application.Common.Mappings;
using TrainTicketManagement.Domain.Entities;

namespace TrainTicketManagement.Application.Directors.Queries.GetUserDetail;

public class UserDetailVm : IMapFrom<User>
{
    public string PersonName { get; set; }
    
    public string Email { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<User, UserDetailVm>()
            .ForMember(d => 
                d.PersonName, map => 
                map.MapFrom(src => src.PersonName.ToString()))
            .ForMember(d=>
                d.Email, map => 
                map.MapFrom(src => src.Email.ToString()));
        
    }
    
    //WARUNKOWE MAPOWANIE DLA SPECJALNYCH PRZYPAKDÓW KIEDY NIE WIEMY CZY MAPPER SIE NIE WYKRZACZY PRZEZ NULL
    
    // private class LastUserNameResolver : IValueResolver<User, object, string>
    // {
    //     public string Resolve(User source, object destination, string destMember, ResolutionContext context)
    //     {
    //         if (source.PersonName.FirstName is not null && source.PersonName.FirstName.Any())
    //         {
    //             var lastFirstName = source.PersonName.FirstName;
    //             return lastFirstName;
    //         }
    //
    //         return string.Empty;
    //     }
    // }
}