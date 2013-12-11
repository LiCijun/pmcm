using System;
using System.Collections.Generic;
using System.Text;

namespace SetSN
{
    class Cdata
    {
        private string id, boxsn, type, day, psn, mssn, updatetime;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string BOXSN
        {
            get { return boxsn; }
            set { boxsn = value; }
        }

        public string TYPE
        {
            get { return type; }
            set { type = value; }
        }

        public string DAY
        {
            get { return day; }
            set { day = value; }
        }

        public string PSN
        {
            get { return psn; }
            set { psn = value; }
        }

        public string MSSN
        {
            get { return mssn; }
            set { mssn = value; }
        }

        public string UPDATETIME
        {
            get { return updatetime; }
            set { updatetime = value; }
        }
    }
}
