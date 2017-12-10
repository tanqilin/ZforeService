using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZforeFromwork.SqlService
{
    public interface IContextDatabase
    {
        void InitDatabase();

        void Insert(string sql);

        void Select(string sql);

        void Delete(string sql);

        void Find(string sql);
    }
}
