﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using ModelLayer;

namespace BusinessLayer
{
    public class CommonBL
    {
        CommonDL db = new CommonDL();

        public List<Country> BindCountry()
        {
            return db.BindCountry();
        }
        public List<State> BindState(int CountryID)
        {
            return db.BindState(CountryID);
        }

        public List<Status> BindStatus()
        {
            return db.BindStatus();
        }

        public List<Agent> BindAgents()
        {
            return db.BindAgents();
        }

        public List<AgentDropdown> BindAgents2()
        {
            return db.BindAgents2();
        }
        public List<Status> BindStatus2()
        {
            return db.BindStatus2();
        }
        public List<City> BindCity(int stateID)
        {
            return db.BindCity(stateID);
        }

        public List<GetPercentages> BindPercentages()
        {
            return db.BindPercentages();
        }

        public List<Year> BindYear()
        {
            return db.BindYear();
        }

        public List<Month> BindMonth()
        {
            return db.BindMonth();
        }
    }
}
