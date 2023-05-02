using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TokenRepo : Repo, IRepo<Token, string, bool>
    {
        public bool Delete(string tkey)
        {
            var token = Get(tkey);
            db.Tokens.Remove(token);
            return db.SaveChanges() > 0;
        }

        public List<Token> Get()
        {
            return db.Tokens.ToList();
        }

        public Token Get(string tkey)
        {
            return db.Tokens.Find(tkey);
        }

        public bool Insert(Token obj)
        {
            db.Tokens.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Token obj)
        {
            var exToken = Get(obj.TKey);
            db.Entry(exToken).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
