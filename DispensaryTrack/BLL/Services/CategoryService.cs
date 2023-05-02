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
    public class CategoryService
    {
        public static List<CategoryDTO> Get()
        {
            var data = DataAccessFactory.CategoryData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Category, CategoryDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<CategoryDTO>>(data);
            return mapped;
        }
        public static CategoryDTO Get(int id)
        {
            var data = DataAccessFactory.CategoryData().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Category, CategoryDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CategoryDTO>(data);
            return mapped;
        }
        public static bool Create(CategoryDTO category)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CategoryDTO, Category>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Category>(category);
            return DataAccessFactory.CategoryData().Insert(mapped);
        }
        public static bool Update(CategoryDTO category)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CategoryDTO, Category>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Category>(category);
            return DataAccessFactory.CategoryData().Update(mapped);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.CategoryData().Delete(id);
        }
    }
}
