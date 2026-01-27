using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Models;

public partial class LibDbContext : DbContext
{
    public LibDbContext()
    {
    }

    public LibDbContext(DbContextOptions<LibDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Avtor> Avtors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookLoan> BookLoans { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Publishing> Publishings { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=lib_db;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Avtor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_avtors_id");

            entity.ToTable("avtors");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AvtorName).HasColumnName("avtor_name");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Isbn).HasName("pk_books_isbn");

            entity.ToTable("books");

            entity.Property(e => e.Isbn).HasColumnName("ISBN");
            entity.Property(e => e.Annotation).HasColumnName("annotation");
            entity.Property(e => e.Copies).HasColumnName("copies");
            entity.Property(e => e.CountBook).HasColumnName("count_book");
            entity.Property(e => e.IdAvtor).HasColumnName("id_avtor");
            entity.Property(e => e.IdGenre).HasColumnName("id_genre");
            entity.Property(e => e.IdPublishing).HasColumnName("id_publishing");
            entity.Property(e => e.NameBook).HasColumnName("name_book");
            entity.Property(e => e.Page).HasColumnName("page");
            entity.Property(e => e.PhotoUrl).HasColumnName("photo_url");
            entity.Property(e => e.YearIzd).HasColumnName("year_izd");

            entity.HasOne(d => d.Avtor).WithMany(p => p.Books)
                .HasForeignKey(d => d.IdAvtor)
                .HasConstraintName("fk_books_to_avtors");

            entity.HasOne(d => d.Genre).WithMany(p => p.Books)
                .HasForeignKey(d => d.IdGenre)
                .HasConstraintName("fk_books_to_genres");

            entity.HasOne(d => d.Publishing).WithMany(p => p.Books)
                .HasForeignKey(d => d.IdPublishing)
                .HasConstraintName("fk_books_to_publishing");
        });

        modelBuilder.Entity<BookLoan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_book_loans_id");

            entity.ToTable("book_loans");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateIssuance).HasColumnName("date_issuance");
            entity.Property(e => e.DatePlanReturn).HasColumnName("date_plan_return");
            entity.Property(e => e.DateReturn).HasColumnName("date_return");
            entity.Property(e => e.IdBook).HasColumnName("id_book");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.Book).WithMany(p => p.BookLoans)
                .HasForeignKey(d => d.IdBook)
                .HasConstraintName("fk_book_loans_to_books");

            entity.HasOne(d => d.Status).WithMany(p => p.BookLoans)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("fk_book_loans_to_statuses");

            entity.HasOne(d => d.User).WithMany(p => p.BookLoans)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("fk_book_loans_to_users");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_genres_id");

            entity.ToTable("genres");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GenreName).HasColumnName("genre_name");
        });

        modelBuilder.Entity<Publishing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_publishing_id");

            entity.ToTable("publishing");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PublishName).HasColumnName("publish_name");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_roles_id");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleName).HasColumnName("role_name");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_statuses_id");

            entity.ToTable("statuses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatusName).HasColumnName("status_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Bilet).HasName("pk_users_id");

            entity.ToTable("users");

            entity.HasIndex(e => e.Login, "uq_users_login").IsUnique();

            entity.Property(e => e.Bilet).HasColumnName("bilet");
            entity.Property(e => e.Fio).HasColumnName("fio");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.PasswordUser).HasColumnName("password_user");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_user_to_roles");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
