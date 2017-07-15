using TejeratBankReporting.Core;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TejeratBankReporting.Web
{


    public class ApplicationUser : IdentityUser<int, AppUserLogin, AppUserRole,
     AppUserClaim>
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(
            UserManager<ApplicationUser, int> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }  
        public string Name { get; set; }
        public byte Gender { get; set; }
        public string CellPhoneNumber { get; set; }
        public byte Status { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }

    }

    //public class Address 
    //{
    //    public Address() { }
    //    public  int Id { get; set; }
    //    public virtual ApplicationUser User { get; set; }
    //    public virtual int NewUserId { get; set; }
    //    public virtual byte Status { get; set; }
    //    public virtual System.DateTime CreateDate { get; set; }
    //    public virtual System.DateTime LastUpdateDate { get; set; }
    //}

    public class AppUserRole : IdentityUserRole<int> {
        public int Id { get; set; }
        public  int CreatorId { get; set; }
        public  byte Status { get; set; }
        public  System.DateTime CreateDate { get; set; }
        public  System.DateTime LastUpdateDate { get; set; }
    }
    public class AppUserClaim : IdentityUserClaim<int> { }
    public class AppUserLogin : IdentityUserLogin<int> { }

    public class AppRole : IdentityRole<int, AppUserRole>
    {
        public AppRole() { }
        public AppRole(string name) { Name = name; }
        public string Description { get; set; }
     
        public  int CreatorId { get; set; }
        public  byte Status { get; set; }
        public  System.DateTime CreateDate { get; set; }
        public  System.DateTime LastUpdateDate { get; set; }
    }

    public class AppUserStore : UserStore<ApplicationUser, AppRole, int,
        AppUserLogin, AppUserRole, AppUserClaim>
    {
        public AppUserStore(ApplicationDbContext context)
            : base(context)
        {
        }
    }

    public class AppRoleStore : RoleStore<AppRole, int, AppUserRole>
    {
        public AppRoleStore(ApplicationDbContext context)
            : base(context)
        {
        }
    }





    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, AppRole,
                                       int, AppUserLogin, AppUserRole, AppUserClaim>
    {
        public ApplicationDbContext() : base("TejeratBankReporting")
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>()
                  .HasKey<int>(s => s.Id)
            .Property(p => p.Id)
            .HasColumnType("int")
            .IsRequired();

            modelBuilder.Entity<AppUserRole>()
            .HasKey(s => s.Id)
             .Property(p => p.UserId)
             .HasColumnType("int")
             .IsRequired();
            modelBuilder.Entity<AppUserClaim>()
                   .HasKey<int>(s => s.Id)
             .Property(p => p.Id)
             .HasColumnType("int")
             .IsRequired();
            modelBuilder.Entity<AppUserLogin>()
                   .HasKey<int>(s => s.UserId)
             .Property(p => p.UserId)
             .HasColumnType("int")

             .IsRequired();
            modelBuilder.Entity<AppRole>()
            .HasKey<int>(s => s.Id)
            .Property(p => p.Id)
            .HasColumnType("int")
            .IsRequired();

            modelBuilder.Entity<ApplicationUser>()
                .ToTable("AppUser");

            modelBuilder.Entity<AppRole>()
                .ToTable("AppRole");

            modelBuilder.Entity<AppUserRole>()
                .ToTable("AppUserInRole");

            modelBuilder.Entity<AppUserClaim>()
                .ToTable("AppUserClaim");

            modelBuilder.Entity<AppUserLogin>()
                .ToTable("AppUserLogin");
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<MyUser>()
        //        .Property(p => p.Id)
        //        .HasColumnType("int")
        //        .IsRequired();

        //    modelBuilder.Entity<MyRole>()
        //        .Property(p => p.Id)
        //        .HasColumnType("int")
        //        .IsRequired();

        //    modelBuilder.Entity<MyUserRole>()
        //        .Property(p => p.RoleId)
        //        .HasColumnType("int")
        //        .IsRequired();

        //    modelBuilder.Entity<MyUserRole>()
        //        .Property(p => p.UserId)
        //        .HasColumnType("int")
        //        .IsRequired();

        //    modelBuilder.Entity<MyUserClaim>()
        //        .Property(p => p.Id)
        //        .HasColumnType("int")
        //        .IsRequired();

        //    modelBuilder.Entity<MyUserClaim>()
        //        .Property(p => p.UserId)
        //        .HasColumnType("int")
        //        .IsRequired();

        //    modelBuilder.Entity<MyUserLogin>()
        //        .Property(p => p.UserId)
        //        .HasColumnType("int")
        //        .IsRequired();

        //    modelBuilder.Entity<MyUser>()
        //        .ToTable("Users");

        //    modelBuilder.Entity<MyRole>()
        //        .ToTable("Roles");

        //    modelBuilder.Entity<MyUserRole>()
        //        .ToTable("UserRoles");

        //    modelBuilder.Entity<MyUserClaim>()
        //        .ToTable("UserClaims");

        //    modelBuilder.Entity<MyUserLogin>()
        //        .ToTable("UserLogins");

        //}
    }
}