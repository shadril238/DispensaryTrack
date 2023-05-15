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
    public class MedicineService
    {
        public static List<MedicineDTO> Get()
        {
            var data = DataAccessFactory.MedicineData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Medicine, MedicineDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<MedicineDTO>>(data);
            return mapped;
        }
        public static MedicineDTO Get(int id)
        {
            var data = DataAccessFactory.MedicineData().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Medicine, MedicineDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<MedicineDTO>(data);
            return mapped;
        }
        public static bool Create(MedicineDTO medicine)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<MedicineDTO, Medicine>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Medicine>(medicine);
            return DataAccessFactory.MedicineData().Insert(mapped);
        }
        public static bool Update(MedicineDTO medicine)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<MedicineDTO, Medicine>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Medicine>(medicine);
            return DataAccessFactory.MedicineData().Update(mapped);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.MedicineData().Delete(id);
        }

        //Expired Medicine Alert
        public static List<MedicineDTO> ExpireMedicineAlert()
        {
            var medicine = DataAccessFactory.MedicineData().Get();
            var data = medicine
                .Where(m => m.ExpireDate.AddDays(-5) >= DateTime.Now && m.Status.Equals("Active")).ToList();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Medicine, MedicineDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<MedicineDTO>>(data);
            return mapped;
        }
        //Stock Alert
        public static List<MedicineDTO> StockMedicineAlert()
        {
            var medicine = DataAccessFactory.MedicineData().Get();
            var data = medicine
                .Where(m => m.TotalStock < 100).ToList();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Medicine, MedicineDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<MedicineDTO>>(data);
            return mapped;
        }
    }
}
