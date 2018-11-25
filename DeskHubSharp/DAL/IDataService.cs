using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT225FinalAppication
{
    public interface IDataService
    {
        List<User> ReadAll();
        void WriteAll(List<User> characters);
    }
}
