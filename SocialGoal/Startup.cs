﻿using System;
using System.Collections.Generic;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialGoal.Startup))]
namespace SocialGoal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Iterate(10);
            ConfigureAuth(app);
        }
        
        private void Iterate(int count)
        {
            var list = new List<string>();
    
            list.Add("This is the first string to add.");

            for (int i = 1; i <= count; i++)
            {
                list.Add(string.Format("String item {0}/{1} has id {2}", i, count, Guid.NewGuid()));
            }
    
            list.Add("This is the last string to add.");
        }
    }
}
