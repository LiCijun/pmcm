using System;
using System.Collections.Generic;
using System.Text;

namespace SetSN
{
    class Cuser
    {
        private string id, user, password, entertime, exittime;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string USER
        {
            get { return user; }
            set { user = value; }
        }

        public string PASSWORD
        {
            get { return password; }
            set { password = value; }
        }

        public string ENTERTIME
        {
            get { return entertime; }
            set { entertime = value; }
        }

        public string EXITTIME
        {
            get { return exittime; }
            set { exittime = value; }
        }
    }
}
