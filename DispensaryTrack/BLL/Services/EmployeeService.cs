//shadril238
using AutoMapper;
using BLL.DTOs;
using DAL;
using DispensaryTrack.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmployeeService
    {
        public static List<EmployeeDTO> Get()
        {
            var data = DataAccessFactory.EmployeeData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<EmployeeDTO>>(data);
            return mapped;
        }
        public static EmployeeDTO Get(int id)
        {
            var data = DataAccessFactory.EmployeeData().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<EmployeeDTO>(data);
            return mapped;
        }
        public static bool Create(EmployeeDTO employee)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<EmployeeDTO, Employee>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Employee>(employee);
            return DataAccessFactory.EmployeeData().Insert(mapped);
        }
        public static bool Update(EmployeeDTO employee)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<EmployeeDTO, Employee>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Employee>(employee);
            return DataAccessFactory.EmployeeData().Update(mapped);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.EmployeeData().Delete(id);
        }
        
    }
}
