using System.Collections.Generic;
using AutoMapper;
using Data.DataSources;
using Domain.Entities;
using WebAPI.DTO;

namespace WebAPI
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Client, ClientDataSource>();
            CreateMap<ClientDataSource, Client>();
            CreateMap<Client, ClientDTO>();
            CreateMap<ClientDTO, Client>();
            CreateMap<Order, OrderDataSource>();
            CreateMap<OrderDataSource, Order>();
            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();
            CreateMap<JoySell, JoySellDataSource>();
            CreateMap<JoySellDataSource,JoySell>();
            CreateMap<JoySell, JoySellDTO>();
            CreateMap<JoySellDTO, JoySell>();
            
            
        }
    }
}