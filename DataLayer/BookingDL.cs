﻿using AutoMapper;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BookingDL
    {
        salesDBEntities dbEntity = new salesDBEntities();
        public List<Projects> BindProjects()
        {
            this.dbEntity.Configuration.ProxyCreationEnabled = false;

            List<Projects> lstProjects = new List<Projects>();
            try
            {
                //lstCountry = dbEntity.tblProjects.ToList();
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<tblProject, Projects>();
                });
                IMapper mapper = config.CreateMapper();
                lstProjects = mapper.Map<List<tblProject>, List<Projects>>(dbEntity.tblProjects.Where(a => a.BookingStatus == "O").ToList()).ToList();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return lstProjects;
        }

        public List<Towers> BindTowers(int projectID)
        {
            this.dbEntity.Configuration.ProxyCreationEnabled = false;

            List<Towers> lstTowers = new List<Towers>();
            try
            {
                //lstCountry = dbEntity.tblProjects.ToList();
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<tblTower, Towers>();
                });
                IMapper mapper = config.CreateMapper();
                lstTowers = mapper.Map<List<tblTower>, List<Towers>>(dbEntity.tblTowers.Where(a => a.ProjectID == projectID).ToList()).ToList();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return lstTowers;
        }

        public List<Flats> BindFlats(int towerID)
        {
            this.dbEntity.Configuration.ProxyCreationEnabled = false;

            List<Flats> lstFlats = new List<Flats>();
            try
            {
                //lstCountry = dbEntity.tblProjects.ToList();
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<tblFlat, Flats>();
                });
                IMapper mapper = config.CreateMapper();
                lstFlats = mapper.Map<List<tblFlat>, List<Flats>>(dbEntity.tblFlats.Where(a => a.TowerID == towerID).ToList()).ToList();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return lstFlats;
        }

        public List<AgentProjectLevel> BindProjectAgents(int projectID)
        {
            this.dbEntity.Configuration.ProxyCreationEnabled = false;

            List<AgentProjectLevel> lstAgents = new List<AgentProjectLevel>();
            try
            {

                



                //lstCountry = dbEntity.tblProjects.ToList();
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<sp_GetAgentsByProjectID_Result, AgentProjectLevel>();
                });
                IMapper mapper = config.CreateMapper();
                lstAgents = mapper.Map<List<sp_GetAgentsByProjectID_Result>, List<AgentProjectLevel>>(dbEntity.sp_GetAgentsByProjectID(projectID).ToList()).ToList();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return lstAgents;
        }

        public List<FlatDetails> BindFlatDetails(int flatID,int ProjectID)
        {
            this.dbEntity.Configuration.ProxyCreationEnabled = false;

            List<FlatDetails> lstFlatDetails = new List<FlatDetails>();
            try
            {

                //lstCountry = dbEntity.tblProjects.ToList();
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<sp_GetFlatDetails_Result, FlatDetails>();
                });
                IMapper mapper = config.CreateMapper();
                lstFlatDetails = mapper.Map<List<sp_GetFlatDetails_Result>, List<FlatDetails>>(dbEntity.sp_GetFlatDetails(flatID, ProjectID).ToList()).ToList();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return lstFlatDetails;
        }
    }
}
