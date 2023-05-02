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
    public class BillService
    {
        public static List<BillDTO> Get()
        {
            var data = DataAccessFactory.BillData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Bill, BillDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<BillDTO>>(data);
            return mapped;
        }
        public static BillDTO Get(int id)
        {
            var data = DataAccessFactory.BillData().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Bill, BillDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<BillDTO>(data);
            return mapped;
        }
        public static bool Create(BillDTO bill)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<BillDTO, Bill>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Bill>(bill);
            return DataAccessFactory.BillData().Insert(mapped);
        }
        public static bool Update(BillDTO bill)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<BillDTO, Bill>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Bill>(bill);
            return DataAccessFactory.BillData().Update(mapped);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.BillData().Delete(id);
        }
    }
}
