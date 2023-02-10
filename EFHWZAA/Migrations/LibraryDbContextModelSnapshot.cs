using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EFHWZAA.Migrations;

public class LibraryDbContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
        modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

        SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
        modelBuilder.Entity("AuthorBook", b =>
        {
            b.Property<int>("AuthorsId")
                .HasColumnType("int");

            b.Property<int>("BooksId")
                .HasColumnType("int");

            b.HasKey("AuthorsId", "BooksId");

            b.HasIndex("BooksId");

            b.ToTable("AuthorBook");
        });

        modelBuilder.Entity("EFHWZAA.Models.Author", b =>
        {
            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

            b.Property<DateTime>("CreatedDate")
                .HasColumnType("datetime2");

            b.Property<string>("FisrtName")
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            b.Property<string>("LastName")
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            b.Property<DateTime?>("ModifiedDate")
                .HasColumnType("datetime2");

            b.Property<int>("Status")
                .HasColumnType("int");

            b.HasKey("Id");

            b.ToTable("Authors");
        });

        modelBuilder.Entity("EFHWZAA.Models.Book", b =>
        {
            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

            b.Property<DateTime>("CreatedDate")
                .HasColumnType("datetime2");

            b.Property<DateTime?>("ModifiedDate")
                .HasColumnType("datetime2");

            b.Property<string>("Name")
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            b.Property<int>("PageCount")
                .HasColumnType("int");

            b.Property<int>("Status")
                .HasColumnType("int");

            b.Property<int?>("StudentId")
                .HasColumnType("int");

            b.Property<int>("ThemeId")
                .HasColumnType("int");

            b.HasKey("Id");

            b.HasIndex("StudentId");

            b.HasIndex("ThemeId");

            b.ToTable("Books");
        });

        modelBuilder.Entity("EFHWZAA.Models.Student", b =>
        {
            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

            b.Property<DateTime>("BirthDate")
                .HasColumnType("datetime2");

            b.Property<DateTime>("CreatedDate")
                .HasColumnType("datetime2");

            b.Property<string>("FirstName")
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            b.Property<int>("Gender")
                .HasColumnType("int");

            b.Property<string>("LastName")
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            b.Property<DateTime?>("ModifiedDate")
                .HasColumnType("datetime2");

            b.Property<string>("PhoneNumber")
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            b.Property<short>("SchoolNumber")
                .HasColumnType("smallint");

            b.Property<int>("Status")
                .HasColumnType("int");

            b.HasKey("Id");

            b.ToTable("Students");
        });

        modelBuilder.Entity("EFHWZAA.Models.Theme", b =>
        {
            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

            b.Property<DateTime>("CreatedDate")
                .HasColumnType("datetime2");

            b.Property<DateTime?>("ModifiedDate")
                .HasColumnType("datetime2");

            b.Property<string>("Name")
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            b.Property<int>("Status")
                .HasColumnType("int");

            b.HasKey("Id");

            b.ToTable("Themes");
        });

        modelBuilder.Entity("AuthorBook", b =>
        {
            b.HasOne("EFHWZAA.Models.Author", null)
                .WithMany()
                .HasForeignKey("AuthorsId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.HasOne("EFHWZAA.Models.Book", null)
                .WithMany()
                .HasForeignKey("BooksId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        });

        modelBuilder.Entity("EFHWZAA.Models.Book", b =>
        {
            b.HasOne("EFHWZAA.Models.Student", "Student")
                .WithMany("Books")
                .HasForeignKey("StudentId");

            b.HasOne("EFHWZAA.Models.Theme", "Theme")
                .WithMany("Books")
                .HasForeignKey("ThemeId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.Navigation("Student");

            b.Navigation("Theme");
        });

        modelBuilder.Entity("EFHWZAA.Models.Student", b =>
        {
            b.Navigation("Books");
        });

        modelBuilder.Entity("EFHWZAA.Models.Theme", b =>
        {
            b.Navigation("Books");
        });

    }
}
