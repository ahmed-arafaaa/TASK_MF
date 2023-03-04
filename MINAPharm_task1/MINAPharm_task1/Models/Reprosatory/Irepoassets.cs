using MINAPharm_task1.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MINAPharm_task1.Models.Reprosatory
{
    public interface Irepoassets <T>
    {
        List<T> getallassets();
        T search(int id);


        void creat(T assett);
        void update(T assett);

        void delete(int id);







    }
}
