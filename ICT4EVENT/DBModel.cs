using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4EVENT
{
    abstract class DBModel
    {
        private DBManager dbManager;

        public DBModel(DBManager dbManager)
        {
            this.dbManager = dbManager;
        }
    }

    class EventModel : DBModel, IDataModelUpdate
    {
        public EventModel(DBManager dbManager) :base (dbManager)
        {
            
        }

        public bool Create()
        {
            throw new NotImplementedException();
        }

        public bool Read()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }

        public bool Destroy()
        {
            throw new NotImplementedException();
        }
    }
}
