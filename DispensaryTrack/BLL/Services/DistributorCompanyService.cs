//shadril238
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
    public class DistributorCompanyService
    {
        public static List<DistributorCompanyDTO> Get()
        {
            var data = DataAccessFactory.DistributorCompanyData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DistributorCompany, DistributorCompanyDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<DistributorCompanyDTO>>(data);
            return mapped;
        }
        public static DistributorCompanyDTO Get(int id)
        {
            var data = DataAccessFactory.DistributorCompanyData().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DistributorCompany, DistributorCompanyDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DistributorCompanyDTO>(data);
            return mapped;
        }
        public static bool Create(DistributorCompanyDTO distributorCompany)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DistributorCompanyDTO, DistributorCompany>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DistributorCompany>(distributorCompany);
            return DataAccessFactory.DistributorCompanyData().Insert(mapped);
        }
        public static bool Update(DistributorCompanyDTO distributorCompany)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DistributorCompanyDTO, DistributorCompany>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DistributorCompany>(distributorCompany);
            return DataAccessFactory.DistributorCompanyData().Update(mapped);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.DistributorCompanyData().Delete(id);
        }
    }
}
