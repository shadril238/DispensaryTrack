using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class OrderDetailService
    {
        public static List<OrderDetailDTO> Get()
        {
            var data = DataAccessFactory.OrderDetailData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetail, OrderDetailDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<OrderDetailDTO>>(data);
            return mapped;
        }
        public static OrderDetailDTO Get(int id)
        {
            var data = DataAccessFactory.OrderDetailData().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetail, OrderDetailDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<OrderDetailDTO>(data);
            return mapped;
        }
        public static bool Create(OrderDetailDTO orderdetail)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetailDTO, OrderDetail>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<OrderDetail>(orderdetail);
            return DataAccessFactory.OrderDetailData().Insert(mapped);
        }
        public static bool Update(OrderDetailDTO orderdetail)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetailDTO, OrderDetail>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<OrderDetail>(orderdetail);
            return DataAccessFactory.OrderDetailData().Update(mapped);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.OrderDetailData().Delete(id);
        }
    }
}
