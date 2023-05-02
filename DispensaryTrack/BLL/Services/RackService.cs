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
    public class RackService
    {
        public static List<RackDTO> Get()
        {
            var data = DataAccessFactory.RackData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Rack, RackDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<RackDTO>>(data);
            return mapped;
        }
        public static RackDTO Get(int id)
        {
            var data = DataAccessFactory.RackData().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Rack, RackDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<RackDTO>(data);
            return mapped;
        }
        public static bool Create(RackDTO rack)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<RackDTO, Rack>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Rack>(rack);
            return DataAccessFactory.RackData().Insert(mapped);
        }
        public static bool Update(RackDTO rack)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<RackDTO, Rack>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Rack>(rack);
            return DataAccessFactory.RackData().Update(mapped);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.RackData().Delete(id);
        }
    }
}
