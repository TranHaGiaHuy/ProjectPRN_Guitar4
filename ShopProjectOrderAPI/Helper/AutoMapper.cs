using AutoMapper;
using BussinessObject.Models;
using BussinessObject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShopProjectOrderAPI.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryResponse>().ReverseMap();
            CreateMap<Order, OrderResponse>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailResponse>().ReverseMap();
            CreateMap<Product, ProductResponse>().ReverseMap();
            CreateMap<Cart, CartResponse>().ReverseMap();
            CreateMap<Account, AccountResponse>().ReverseMap();
            CreateMap<User, UserResponse>().ReverseMap();
        }
    }
}
