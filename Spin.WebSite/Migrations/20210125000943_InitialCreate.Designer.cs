// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Spin.Connection.DAL.Provider.SQLServer.Common;

namespace Spin.WebSite.Migrations
{
    [DbContext(typeof(SQLServerGlobaContextCommon<int>))]
    [Migration("20210125000943_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Spin.Alias.Entity.AliasItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdAlias")
                        .UseIdentityColumn();

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Controller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<int?>("IdCustomer")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Module")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parameter")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCustomer");

                    b.ToTable("Spin_Alias");
                });

            modelBuilder.Entity("Spin.Base.Documentation.Entity.Translate.MemberTranslate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdMemberTranslate")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdRelation")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Base_MemberTranslate");
                });

            modelBuilder.Entity("Spin.Base.RedirectSite.Entity.Redirect", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdRedirect")
                        .UseIdentityColumn();

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("UrlBase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlRedirect")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Spin_Redirect");
                });

            modelBuilder.Entity("Spin.Diagnostics.Entity.Provider.ErrorDatabase.ErrorDatabase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdError")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCustomer")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Module")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Spin_Error");
                });

            modelBuilder.Entity("Spin.Modules.Entity.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdModule")
                        .UseIdentityColumn();

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Spin_Module");
                });

            modelBuilder.Entity("Spin.Modules.Entity.ModuleConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdModuleConfiguration")
                        .UseIdentityColumn();

                    b.Property<string>("GroupConfiguration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdCustomer")
                        .HasColumnType("int");

                    b.Property<int?>("IdModule")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdModule");

                    b.ToTable("Spin_ModuleConfiguration");
                });

            modelBuilder.Entity("Spin.Modules.Entity.Schedule.ScheduleTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdScheduleTask")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsExecuted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastDateExecute")
                        .HasColumnType("datetime2");

                    b.Property<string>("Module")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeSpanToExecuteTask")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeToExecuteTask")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Spin_ScheduleTask");
                });

            modelBuilder.Entity("Spin.Modules.Language.Entity.LanguageItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdLanguage")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdCustomer")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Spin_Language");
                });

            modelBuilder.Entity("Spin.Place.Entity.PlaceItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdPlace")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<int?>("IdParent")
                        .HasColumnType("int");

                    b.Property<decimal?>("Latitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("LevelTree")
                        .HasColumnType("int");

                    b.Property<decimal?>("Longitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeZone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypePlace")
                        .HasColumnType("int");

                    b.Property<string>("Viewport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("polygon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdParent");

                    b.ToTable("Place_Place");
                });

            modelBuilder.Entity("Spin.Place.Entity.PlaceTranslate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdPlaceTranslate")
                        .UseIdentityColumn();

                    b.Property<int>("IdRelation")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdRelation");

                    b.ToTable("Place_PlaceTranslate");
                });

            modelBuilder.Entity("Spin.Security.Entity.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCustomer")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Domain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<int?>("IdCustomerParent")
                        .HasColumnType("int");

                    b.Property<int?>("IdTheme")
                        .HasColumnType("int");

                    b.Property<bool>("InternalSite")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RedirectHTTPS")
                        .HasColumnType("bit");

                    b.Property<bool>("RedirectWWW")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdTheme");

                    b.ToTable("Security_Customer");
                });

            modelBuilder.Entity("Spin.Security.Entity.CustomerModule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCustomerModule")
                        .UseIdentityColumn();

                    b.Property<int>("IdCustomer")
                        .HasColumnType("int");

                    b.Property<int>("IdModule")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCustomer");

                    b.HasIndex("IdModule");

                    b.ToTable("Security_CustomerModule");
                });

            modelBuilder.Entity("Spin.Security.Entity.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdGroup")
                        .UseIdentityColumn();

                    b.Property<int>("IdCustomer")
                        .HasColumnType("int");

                    b.Property<int?>("IdGroupParent")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ShowConfigurationDashboard")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdCustomer");

                    b.ToTable("Security_Group");
                });

            modelBuilder.Entity("Spin.Security.Entity.GroupPermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdGroupPermission")
                        .UseIdentityColumn();

                    b.Property<string>("Controller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Edit")
                        .HasColumnType("bit");

                    b.Property<int>("IdGroup")
                        .HasColumnType("int");

                    b.Property<string>("Module")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Segment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Show")
                        .HasColumnType("bit");

                    b.Property<bool>("ShowConfiguration")
                        .HasColumnType("bit");

                    b.Property<bool?>("ShowHistory")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdGroup");

                    b.ToTable("Security_GroupPermission");
                });

            modelBuilder.Entity("Spin.Security.Entity.History.UserHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdUserHistory")
                        .UseIdentityColumn();

                    b.Property<string>("CodeUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdRelation")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OldData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TableName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeHistory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdRelation");

                    b.ToTable("Security_UserHistory");
                });

            modelBuilder.Entity("Spin.Security.Entity.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdSession")
                        .UseIdentityColumn();

                    b.Property<string>("DeviceToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastConnect")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("Token")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IdUser");

                    b.ToTable("Security_Session");
                });

            modelBuilder.Entity("Spin.Security.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdUser")
                        .UseIdentityColumn();

                    b.Property<bool>("ChangePassword")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAlternative")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCustomer")
                        .HasColumnType("int");

                    b.Property<int?>("IdGroup")
                        .HasColumnType("int");

                    b.Property<int?>("IdOwner")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdministrator")
                        .HasColumnType("bit");

                    b.Property<bool>("IsConnect")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastConnect")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathStructure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("Token")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCustomer");

                    b.HasIndex("IdGroup");

                    b.ToTable("Security_User");
                });

            modelBuilder.Entity("Spin.Themes.Entity.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdTheme")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Spin_Theme");
                });

            modelBuilder.Entity("Spin.WebSite.Spin.Module.Comics.Core.Entity.Comic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdComic")
                        .UseIdentityColumn();

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Comics_Comic");
                });

            modelBuilder.Entity("Spin.WebSite.Spin.Module.Comics.Core.Entity.Geolocation.ComicGeolocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdComicGeolocation")
                        .UseIdentityColumn();

                    b.Property<int>("IdPlace")
                        .HasColumnType("int");

                    b.Property<int>("IdRelation")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdPlace");

                    b.HasIndex("IdRelation");

                    b.ToTable("Comics_ComicGeolocation");
                });

            modelBuilder.Entity("Spin.WebSite.Spin.Module.MyModule.Core.Entity.AdditionalData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdAdditionalData")
                        .UseIdentityColumn();

                    b.Property<int>("IdData")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdData");

                    b.ToTable("MyModule_AdditionalData");
                });

            modelBuilder.Entity("Spin.WebSite.Spin.Module.MyModule.Core.Entity.CommentsData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCommentsData")
                        .UseIdentityColumn();

                    b.Property<int>("IdData")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdData");

                    b.ToTable("MyModule_CommentsData");
                });

            modelBuilder.Entity("Spin.WebSite.Spin.Module.MyModule.Core.Entity.Data", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdData")
                        .UseIdentityColumn();

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MyModule_Data");
                });

            modelBuilder.Entity("Spin.WebSite.Spin.Module.MyModule.Core.Entity.ImagesCommentsData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdImagesCommentsData")
                        .UseIdentityColumn();

                    b.Property<int>("IdCommentsData")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCommentsData");

                    b.ToTable("MyModule_ImagesCommentsData");
                });

            modelBuilder.Entity("Spin.Alias.Entity.AliasItem", b =>
                {
                    b.HasOne("Spin.Security.Entity.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("IdCustomer");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Spin.Modules.Entity.ModuleConfiguration", b =>
                {
                    b.HasOne("Spin.Modules.Entity.Module", "Module")
                        .WithMany("Configuration")
                        .HasForeignKey("IdModule");

                    b.Navigation("Module");
                });

            modelBuilder.Entity("Spin.Place.Entity.PlaceItem", b =>
                {
                    b.HasOne("Spin.Place.Entity.PlaceItem", "ParentPlace")
                        .WithMany()
                        .HasForeignKey("IdParent");

                    b.Navigation("ParentPlace");
                });

            modelBuilder.Entity("Spin.Place.Entity.PlaceTranslate", b =>
                {
                    b.HasOne("Spin.Place.Entity.PlaceItem", null)
                        .WithMany("SpinTranslates")
                        .HasForeignKey("IdRelation")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Spin.Security.Entity.Customer", b =>
                {
                    b.HasOne("Spin.Themes.Entity.Theme", "Theme")
                        .WithMany()
                        .HasForeignKey("IdTheme");

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("Spin.Security.Entity.CustomerModule", b =>
                {
                    b.HasOne("Spin.Security.Entity.Customer", "Customer")
                        .WithMany("CustomerModules")
                        .HasForeignKey("IdCustomer")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Spin.Modules.Entity.Module", "Module")
                        .WithMany()
                        .HasForeignKey("IdModule")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Module");
                });

            modelBuilder.Entity("Spin.Security.Entity.Group", b =>
                {
                    b.HasOne("Spin.Security.Entity.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("IdCustomer")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Spin.Security.Entity.GroupPermission", b =>
                {
                    b.HasOne("Spin.Security.Entity.Group", null)
                        .WithMany("GroupPermissions")
                        .HasForeignKey("IdGroup")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Spin.Security.Entity.History.UserHistory", b =>
                {
                    b.HasOne("Spin.Security.Entity.User", null)
                        .WithMany("SpinHistory")
                        .HasForeignKey("IdRelation")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Spin.Security.Entity.Session", b =>
                {
                    b.HasOne("Spin.Security.Entity.User", null)
                        .WithMany("Sessions")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Spin.Security.Entity.User", b =>
                {
                    b.HasOne("Spin.Security.Entity.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("IdCustomer")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Spin.Security.Entity.Group", "GroupUser")
                        .WithMany()
                        .HasForeignKey("IdGroup");

                    b.Navigation("Customer");

                    b.Navigation("GroupUser");
                });

            modelBuilder.Entity("Spin.WebSite.Spin.Module.Comics.Core.Entity.Geolocation.ComicGeolocation", b =>
                {
                    b.HasOne("Spin.Place.Entity.PlaceItem", "Place")
                        .WithMany()
                        .HasForeignKey("IdPlace")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Spin.WebSite.Spin.Module.Comics.Core.Entity.Comic", null)
                        .WithMany("SpinGeolocation")
                        .HasForeignKey("IdRelation")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Place");
                });

            modelBuilder.Entity("Spin.WebSite.Spin.Module.MyModule.Core.Entity.AdditionalData", b =>
                {
                    b.HasOne("Spin.WebSite.Spin.Module.MyModule.Core.Entity.Data", null)
                        .WithMany("Additional")
                        .HasForeignKey("IdData")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Spin.WebSite.Spin.Module.MyModule.Core.Entity.CommentsData", b =>
                {
                    b.HasOne("Spin.WebSite.Spin.Module.MyModule.Core.Entity.Data", null)
                        .WithMany("Commnets")
                        .HasForeignKey("IdData")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Spin.WebSite.Spin.Module.MyModule.Core.Entity.ImagesCommentsData", b =>
                {
                    b.HasOne("Spin.WebSite.Spin.Module.MyModule.Core.Entity.CommentsData", null)
                        .WithMany("Images")
                        .HasForeignKey("IdCommentsData")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Spin.Modules.Entity.Module", b =>
                {
                    b.Navigation("Configuration");
                });

            modelBuilder.Entity("Spin.Place.Entity.PlaceItem", b =>
                {
                    b.Navigation("SpinTranslates");
                });

            modelBuilder.Entity("Spin.Security.Entity.Customer", b =>
                {
                    b.Navigation("CustomerModules");
                });

            modelBuilder.Entity("Spin.Security.Entity.Group", b =>
                {
                    b.Navigation("GroupPermissions");
                });

            modelBuilder.Entity("Spin.Security.Entity.User", b =>
                {
                    b.Navigation("Sessions");

                    b.Navigation("SpinHistory");
                });

            modelBuilder.Entity("Spin.WebSite.Spin.Module.Comics.Core.Entity.Comic", b =>
                {
                    b.Navigation("SpinGeolocation");
                });

            modelBuilder.Entity("Spin.WebSite.Spin.Module.MyModule.Core.Entity.CommentsData", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("Spin.WebSite.Spin.Module.MyModule.Core.Entity.Data", b =>
                {
                    b.Navigation("Additional");

                    b.Navigation("Commnets");
                });
#pragma warning restore 612, 618
        }
    }
}
