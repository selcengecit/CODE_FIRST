using CodeFirst_Student_Class;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_Student_Class
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;
    

    public class StudentClass : DbContext
    {
        // Your context has been configured to use a 'StudentClass' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeFirst_Student_Class.StudentClass' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'StudentClass' 
        // connection string in the application configuration file.
        public StudentClass()
            : base("name=StudentClass")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Class_> Classes { get; set; } //Dbset satýrlarý facade 
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
    [Table("Student")]// database kýsmýnda tablo adý Student demektir. Eger bunu hic yazmasaydýk tablo ismi Students olacaktý.
   public class Student
    {
        [Key,DisplayName("Kimlik Numarasý")] //Kimlik Numarasý primaryKeydir. Eðer bunu yazmasaydýk sonu ID ile biteni primaryKey olarak görür.
        public long TcKimlikID { get; set; }
        [StringLength(80)]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Ad Soyad Boþ Olamaz")] //hata mesajý tanýmladýk
        public string AdSoyad { get; set; }
        public int Yas { get; set; }
        public int SýnýfID { get; set; }
         public  virtual Class_ class_ { get;set;}

    }
    [Table("Class_")]
    public class Class_
{
    public Class_()
    {
        this.Students = new HashSet<Student>();
    }
    [Key]
    public int ClassId { get; set; }
    [StringLength(50)]
    public string Description { get; set; }
    public virtual ICollection<Student> Students { get; set; }
}

}