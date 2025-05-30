using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSpire.Application.Dto;
using TechSpire.Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TechSpire.infra.Helpers;
public class ProfileMapping
{
    public class ProfileMapping : Profile
    {
        public ProfileMapping()
        {

            CreateMap<SignupDtp, ApplicataionUser>()
                .ForMember(destination => destination.FirstName, options => options.MapFrom(
                    src => src.FirstName))
                .ForMember(destination => destination.LastName, options => options.MapFrom(
                    src => src.LastName))
                .ForMember(destination => destination.PhoneNumber, options => options.MapFrom(
                    src => src.PhoneNumber))
                 .ForMember(destination => destination.Email, options => options.MapFrom(
                     src => src.Email));

            CreateMap<ApplicataionUser, UserDto>()
                .ForMember(destination => destination.Email, options => options.MapFrom(
                    src => src.Email))
                .ForMember(destination => destination.Name, options => options.MapFrom(
                    src => src.UserName));
            CreateMap<loginDto, ApplicataionUser>(

           ).ForMember(des => des.Email, options => options.MapFrom(
               u => u.Email));
            CreateMap<Question, QuestionResponseDto>()
                .ForMember(destination => destination.Id, options => options.MapFrom(
                      src => src.Id))
                  .ForMember(destination => destination.QuestionText, options => options.MapFrom(
                      src => src.QuestionText))
                  .ForMember(destination => destination.Answer1, options => options.MapFrom(
                      src => src.Answer1))
                  .ForMember(destination => destination.Answer2, options => options.MapFrom(
                      src => src.Answer2))
                  .ForMember(destination => destination.Answer3, options => options.MapFrom(
                      src => src.Answer3))
                  .ForMember(destination => destination.Topic, options => options.MapFrom(
                      src => src.Topic));

            CreateMap<UsersProgress, UserProgressDto>()
             .ForMember(destination => destination.DailyBooks, options => options.MapFrom(
                 src => src.DailyBooks))
             .ForMember(destination => destination.DailyPosts, options => options.MapFrom(
                 src => src.DailyPosts))
             .ForMember(destination => destination.DailyArticles, options => options.MapFrom(
                 src => src.DailyArticles));


            CreateMap<UserBookInProgress, InProgressBookDto>()
             .ForMember(destination => destination.BookId, options => options.MapFrom(
                 src => src.BookId))
             .ForMember(destination => destination.CurrentPage, options => options.MapFrom(
                 src => src.CurrentPage));

        }

    }

}
