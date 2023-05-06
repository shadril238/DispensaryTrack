//shadril238
using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService
    {
        public static TokenDTO Authenticate(string email, string password)
        {
            var res = DataAccessFactory.AuthData().Authenticate(email, password);

            if (res)
            {
                var token = new Token();
                token.EmpMail = email;
                token.CreatedAt= DateTime.Now;
                token.TKey= Guid.NewGuid().ToString();
                var ret = DataAccessFactory.TokenData().Insert(token);
                if (ret != null)
                {
                    var cfg = new MapperConfiguration(c => {
                        c.CreateMap<Token, TokenDTO>();
                    });
                    var mapper = new Mapper(cfg);
                    return mapper.Map<TokenDTO>(ret);
                }
            }
            return null;
        }
        public static bool IsTokenValid(string tkey)
        {
            var extk = DataAccessFactory.TokenData().Get(tkey);
            return extk != null && extk.DeletedAt == null;
        }
        public static bool Logout(string tkey)
        {
            var extk = DataAccessFactory.TokenData().Get(tkey);
            if (extk != null)
            {
                extk.DeletedAt = DateTime.Now;
                if (DataAccessFactory.TokenData().Update(extk) != null)
                {
                    return true;
                }
            }
            return false;
        }
        //admin access
        public static bool IsAdmin(string tkey)
        {
            var extk = DataAccessFactory.TokenData().Get(tkey);
            if (IsTokenValid(tkey) && extk.Employee.EmpType.Equals("Admin"))
            {
                return true;
            }
            return false;
        }
        //manager access
        public static bool IsManager(string tkey)
        {
            var extk = DataAccessFactory.TokenData().Get(tkey);
            if (IsTokenValid(tkey) && extk.Employee.EmpType.Equals("Manager"))
            {
                return true;
            }
            return false;
        }
        //salesman access
        public static bool IsSalesman(string tkey)
        {
            var extk = DataAccessFactory.TokenData().Get(tkey);
            if (IsTokenValid(tkey) && extk.Employee.EmpType.Equals("Salesman"))
            {
                return true;
            }
            return false;
        }
    }
}
