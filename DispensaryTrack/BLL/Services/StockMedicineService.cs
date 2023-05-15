//shadril238
using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StockMedicineService
    {
        public static List<StockMedicineDTO> Get()
        {
            var data = DataAccessFactory.StockMedicineData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<StockMedicine, StockMedicineDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<StockMedicineDTO>>(data);
            return mapped;
        }
        public static StockMedicineDTO Get(int id)
        {
            var data = DataAccessFactory.StockMedicineData().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<StockMedicine, StockMedicineDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<StockMedicineDTO>(data);
            return mapped;
        }
        public static bool Create(StockMedicineDTO stockmedicine)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<StockMedicineDTO, StockMedicine>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<StockMedicine>(stockmedicine);
            return DataAccessFactory.StockMedicineData().Insert(mapped);
        }
        public static bool Update(StockMedicineDTO stockmedicine)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<StockMedicineDTO, StockMedicine>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<StockMedicine>(stockmedicine);
            return DataAccessFactory.StockMedicineData().Update(mapped);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.StockMedicineData().Delete(id);
        }
    }
}
