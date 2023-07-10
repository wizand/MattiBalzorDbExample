using MattiDb.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattiDb
{
    public class MattiDbService
    {

        private string? _connectionString;
        private AppDbContext AppDbContextInstance 
        { 
            get
            {
                return new AppDbContext(_connectionString);
            }
        }

        public MattiDbService(string connectionString) 
        {
            _connectionString = connectionString;
        }


        public IEnumerable<Mittaustulos> GetAllMittaustulos()
        {

            using var ctx = AppDbContextInstance;
            var listOfMittaustulos = ctx.Mittaustulos.ToList();

            return listOfMittaustulos;

        }

        public int SaveMittaustulos(Mittaustulos mittaustulos) 
        {
            using var ctx = AppDbContextInstance;
            ctx.Mittaustulos.Add(mittaustulos);
            int i = ctx.SaveChanges();
            return i;
        }





    }
}
