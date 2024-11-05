using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GamataAPI.Context
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {

        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=database-1.cnucag0kenpd.us-east-1.rds.amazonaws.com;userid=admin;password=!A)d%WF,9qHP4wd;database=GamataAPI;persistsecurityinfo=True;convert zero datetime=True;SSL Mode=None;", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.14-mariadb"));

            }
        }
        #region DataTables

        public DbSet<Country> Countries { get; set; }
        public DbSet<Country_Detail> Country_Details { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product_Instruction> Product_Instructions { get; set; }
        public DbSet<Activity> Activities { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Supplier_Item> Supplier_Items { get; set; }

        public DbSet<Harvest_Calendar> Harvest_Calendars { get; set; }
        public DbSet<Farming_Location> Farming_Locations { get; set; }
        public DbSet<Farming_Product> Farming_Products { get; set; }

        public DbSet<Plan> Plans { get; set; }
        public DbSet<Plan_Detail> Plan_Details { get; set; }
        public DbSet<Advisory> Advisories { get; set; }

        public DbSet<Sell> Sell { get; set; }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Post_Comment> Comments { get; set; }
        public DbSet<Post_Like> Likes { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Library_has_Group> Library_Groups { get; set; }

        public DbSet<Library_has_Post> Library_Posts { get; set; }

        public DbSet<WishList> WishLists { get; set; }

        public DbSet<Subscribe> Subscribes { get; set; }

        public DbSet<Sell_Rate> Sell_Rates { get; set; }

        public DbSet<Inquiry> Inquiries { get; set; }
        public DbSet<Inquiry_has_Message> Inquiry_has_Messages { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<Crop_Record_Book> Crop_Record_Books { get; set; }
        public DbSet<CRB_Location_Detail> CRB_Location_Details { get; set; }
        public DbSet<CRB_has_Planting_Material> CRB_has_Planting_Materials { get; set; }
        public DbSet<CRB_has_Seed_Report> CRB_has_Seed_Reports { get; set; }
        public DbSet<CRB_has_Material_Purchase> CRB_has_Material_Purchases { get; set; }
        public DbSet<CRB_has_Fertilizer_Detail> CRB_has_Fertilizer_Details { get; set; }
        public DbSet<CRB_has_Chemical_Detail> CRB_has_Chemical_Details { get; set; }

        public DbSet<CRB_has_Combined_Pest_Control_Detail> CRB_has_Combined_Pest_Control_Details { get; set; }
        public DbSet<CRB_has_Additional_Fertilizer_Detail> CRB_has_Additional_Fertilizer_Details { get; set; }
        public DbSet<CRB_Diseases_Control_Method> CRB_Diseases_Control_Methods { get; set; }
        public DbSet<CRB_Irrigation_Detail> CRB_Irrigation_Details { get; set; }
        public DbSet<CRB_Irrigation_Report> CRB_Irrigation_Reports { get; set; }
        public DbSet<CRB_Employee_Training_Report> CRB_Employee_Training_Reports { get; set; }
        public DbSet<CRB_Harvest_Activity_Detail> CRB_Harvest_Activity_Details { get; set; }
        public DbSet<CRB_Wast_Harvest_Record> CRB_Wast_Harvest_Records { get; set; }

        public DbSet<Listing> Listings { get; set; }
        public DbSet<AppToken> AppTokens { get; set; }
        public DbSet<Temp_Shopping_Cart> Temp_Shopping_Carts { get; set; }
        public DbSet<Order_Header> Order_Headers { get; set; }
        public DbSet<Order_Detail> Order_Details { get; set; }

        #endregion


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //modelBuilder.Entity<IdentityUser>().ToTable("MyUsers").Property(p => p.Id).HasColumnName("UserId");
            builder.Entity<AppUser>().ToTable("t_user").Property(p => p.Id).HasColumnName("RnUserID");


            builder.Entity<IdentityUserRole<string>>().ToTable("Tbl_User_Role");
            builder.Entity<IdentityUserLogin<string>>().ToTable("Tbl_User_Login");
            builder.Entity<IdentityUserClaim<string>>().ToTable("Tbl_User_Claims");
            builder.Entity<IdentityRole>().ToTable("Tbl_Role");
            builder.Entity<IdentityUserToken<string>>().ToTable("Tbl_User_Token");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("Tbl_Role_Claims");

            builder.Entity<Advisory>()
            .HasKey(a => new { a.FK_Product_Code, a.FK_Activity_Code });

            builder.Entity<Advisory>()
                                .HasIndex(e => e.Start_Duration)
                                .IsUnique(false);
            builder.Entity<Advisory>()
                               .HasIndex(e => e.FK_Product_Code)
                               .IsUnique(false);

            builder.Entity<Country_Detail>()
           .HasKey(cd => new { cd.Code, cd.Parent });

            builder.Entity<Farming_Product>()
          .HasKey(cd => new { cd.FK_UserID, cd.FK_Product_Code });

            builder.Entity<Product_Instruction>()
         .HasKey(cd => new { cd.FK_Product_Code, cd.FK_Activity_Code });

            builder.Entity<WishList>()
         .HasKey(cd => new { cd.FK_Sell_Code, cd.FK_UserID });

            builder.Entity<AppToken>()
                .HasOne(t => t.User)
                .WithMany(u => u.AppTokens)
                .HasForeignKey(t => t.FK_UserID);

            builder.Entity<Country_Detail>()
            .HasKey(cd => new { cd.Code, cd.Type, cd.Parent });

            builder.Entity<Farming_Location>()
                .HasOne(fl => fl.Country_Detail)
                .WithMany(cd => cd.Farming_Locations)
                .HasForeignKey(fl => new { fl.FK_Country_Code, fl.FK_Country_Type, fl.FK_Country_Parent });

        }

    }

}
