using DapperExtensions.Mapper;
using Evol.Abp.Component.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evol.Abp
{
    public class CustomerMapper : ClassMapper<Customer>
    {
        public CustomerMapper()
        {
            Table("customer");
            //Map(x => x.Id).Column("id");
            //Map(x => x.LoginName).Column("login_name");
            //Map(x => x.Password).Column("password");
            //Map(x => x.Name).Column("name");
            //Map(x => x.Email).Column("email");
            //Map(x => x.Balance).Column("balance");
            //Map(x => x.Point).Column("point");
            //Map(x => x.CreateTime).Column("create_time");
            AutoMap();
        }
    }
}
