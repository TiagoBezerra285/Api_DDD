using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //usado para Criar as Migrações
            var connectionString = "Server=localhost;Port=3306;Database=ddbApi_DDD;Uid=root;Pwd123456";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext> ();
            optionsBuilder.UseMySql(connectionString);
            return new MyContext(optionsBuilder.Options);

         
        }
    }
}
