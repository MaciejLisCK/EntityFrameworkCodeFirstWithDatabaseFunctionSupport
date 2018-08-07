namespace EntityFrameworkWithDatabaseFunctions
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using CodeFirstStoreFunctions;

    public partial class TestModel : DbContext
    {
        public TestModel()
            : base("name=TestModel1")
        {
        }

        public virtual DbSet<Foo> Foos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add(new FunctionsConvention("dbo", this.GetType()));
        }

        // "CodeFirstDatabaseSchema" is a convention mandatory schema name i.e. leave it a it is in your project)
        [DbFunction("CodeFirstDatabaseSchema", "ConcatenateText")]
        public static string ConcatenateText(string first, string second)
        {
            // no need to provide an implementation
            throw new NotSupportedException();
        }

    }
}
