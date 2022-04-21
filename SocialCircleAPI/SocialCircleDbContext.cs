using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SocialCircleAPI.models;
using SocialCircleAPI.Models;

namespace SocialCircle.Data
{
    public partial class SocialCircleDbContext : DbContext
    {
        public SocialCircleDbContext()
        {
        }

        public SocialCircleDbContext(DbContextOptions<SocialCircleDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Post> Posts { get; set; } = null!;

        public virtual DbSet<Comment> Comments {get; set;} = null!;

        public virtual DbSet<Reply> Replies {get; set;} = null!;

        public virtual DbSet<Like> Likes {get; set;} = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:SocialCircleDb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");

                entity.Property(e => e.Text).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.Property(e => e.Text).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<Reply>(entity =>
            {
                entity.ToTable("Reply");

                entity.Property(e => e.Text).HasMaxLength(255);
            });
            
             modelBuilder.Entity<Like>(entity =>
            {
                entity.ToTable("Like");

                entity.Property(e => e.Id).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
