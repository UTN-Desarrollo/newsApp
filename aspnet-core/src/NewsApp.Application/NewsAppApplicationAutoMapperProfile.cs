﻿using AutoMapper;
using NewsApp.Themes;
using NewsApp.News;
using NewsApp.User;
using Volo.Abp.Identity;


namespace NewsApp;

public class NewsAppApplicationAutoMapperProfile : Profile
{
    public NewsAppApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Theme, ThemeDto>();
        CreateMap<NewsDto, ArticleDto>().ReverseMap();
        CreateMap<IdentityUser, UserDto>();
    }
}
