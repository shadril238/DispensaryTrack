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
            var stocks = DataAccessFactory.StockMedicineData().Get();
            var medicines = DataAccessFactory.MedicineData().Get();
            var racks = DataAccessFactory.RackData().Get();
            var distributors=DataAccessFactory.DistributorCompanyData().Get();
            //joining stocks with medicines and racks
            var data = from stock in stocks
                       join medicine in medicines on stock.MedicineId equals medicine.Id
                       join rack in racks on stock.RackId equals rack.Id
                       join disributor in distributors on stock.DistributorId equals disributor.Id
                       where medicine.Status.Equals("Active") && stock.Status.Equals("Active")
                       select new StockMedicineDTO
                       {
                           Id= stock.Id,
                           MedicineName = medicine.Name,
                           MedicineGenericName= medicine.GenericName,
                           RackName= rack.Name,
                           BuyPrice= stock.BuyPrice,
                           SalePrice = stock.SalePrice,
                           TotalStock= stock.TotalStock,
                           ExpireDate= stock.ExpireDate,
                           Status= stock.Status,
                           //PurchaseId= stock.PurchaseId,
                           RackId= rack.Id,
                           DistributorId= stock.DistributorId,
                           MedicineId= medicine.Id,

                       };
            return data.ToList();
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
