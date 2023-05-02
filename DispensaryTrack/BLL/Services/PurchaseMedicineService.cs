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
    public class PurchaseMedicineService
    {
        public static List<PurchaseMedicineDTO> Get()
        {
            var data = DataAccessFactory.PurchaseMedicineData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PurchaseMedicine, PurchaseMedicineDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<PurchaseMedicineDTO>>(data);
            return mapped;
        }
        public static PurchaseMedicineDTO Get(int id)
        {
            var data = DataAccessFactory.PurchaseMedicineData().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PurchaseMedicine, PurchaseMedicineDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PurchaseMedicineDTO>(data);
            return mapped;
        }
        public static bool Create(PurchaseMedicineDTO purchasemedicine)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PurchaseMedicineDTO, PurchaseMedicine>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PurchaseMedicine>(purchasemedicine);
            return DataAccessFactory.PurchaseMedicineData().Insert(mapped);
        }
        public static bool Update(PurchaseMedicineDTO purchasemedicine)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PurchaseMedicineDTO, PurchaseMedicine>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PurchaseMedicine>(purchasemedicine);
            return DataAccessFactory.PurchaseMedicineData().Update(mapped);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.PurchaseMedicineData().Delete(id);
        }
    }
}
