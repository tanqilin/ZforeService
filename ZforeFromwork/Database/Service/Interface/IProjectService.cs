﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZforeFromwork.Database.Entity;

namespace ZforeFromwork.Database.Service.Interface
{
    public interface IProjectService
    {
        void InsertProject(Project ptoject);

        void UpdateProject(Project ptoject);

        Project GetProjectByNum(string num);

        List<Project> GetAllProject();
    }
}