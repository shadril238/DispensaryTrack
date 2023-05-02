//shadril238
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
    internal class TokenRepo : Repo, IRepo<Token, string, Token>
    {
        public Token Delete(string tkey)
        {
            var token = Get(tkey);
            db.Tokens.Remove(token);
            if(db.SaveChanges() > 0)
            {
                return token;
            }
            return null;
        }

        public List<Token> Get()
        {
            return db.Tokens.ToList();
        }

        public Token Get(string tkey)
        {
            return db.Tokens.FirstOrDefault(t => t.TKey.Equals(tkey));
        }

        public Token Insert(Token obj)
        {
            db.Tokens.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public Token Update(Token obj)
        {
            var exToken = Get(obj.TKey);
            db.Entry(exToken).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
