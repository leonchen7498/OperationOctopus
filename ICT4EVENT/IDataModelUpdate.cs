using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4EVENT
{
    interface IDataModelUpdate
    {
        bool Create();
        bool Read();
        bool Update();
        bool Destroy();

    }
}
