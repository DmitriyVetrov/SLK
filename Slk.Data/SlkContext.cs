namespace Slk.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SlkContext : DbContext
    {
        public SlkContext() : base("name=SlkContext")
        {
            Database.SetInitializer<SlkContext>(null);
        }

        public virtual DbSet<inf_article> inf_article { get; set; }
        public virtual DbSet<inf_article_picture> inf_article_picture { get; set; }
        public virtual DbSet<inf_article_tag> inf_article_tag { get; set; }
        public virtual DbSet<inf_category> inf_category { get; set; }
        public virtual DbSet<inf_comment> inf_comment { get; set; }
        public virtual DbSet<inf_tag> inf_tag { get; set; }
        public virtual DbSet<inf_user> inf_user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<inf_article>()
                .Property(e => e.bg_image)
                .IsUnicode(false);

            modelBuilder.Entity<inf_article>()
                .HasMany(e => e.inf_article_picture)
                .WithRequired(e => e.inf_article)
                .HasForeignKey(e => e.article_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<inf_article>()
                .HasMany(e => e.inf_comment)
                .WithRequired(e => e.inf_article)
                .HasForeignKey(e => e.article_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<inf_article_picture>()
                .Property(e => e.picture)
                .IsUnicode(false);

            modelBuilder.Entity<inf_category>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<inf_category>()
                .Property(e => e.subtitle)
                .IsUnicode(false);

            modelBuilder.Entity<inf_category>()
                .HasMany(e => e.inf_article)
                .WithRequired(e => e.inf_category)
                .HasForeignKey(e => e.category_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<inf_comment>()
                .Property(e => e.body)
                .IsUnicode(false);

            modelBuilder.Entity<inf_user>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<inf_user>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<inf_user>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<inf_user>()
                .Property(e => e.pass)
                .IsUnicode(false);

            modelBuilder.Entity<inf_user>()
                .Property(e => e.avatar)
                .IsUnicode(false);

            modelBuilder.Entity<inf_user>()
                .HasMany(e => e.inf_article)
                .WithRequired(e => e.inf_user)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<inf_user>()
                .HasMany(e => e.inf_comment)
                .WithRequired(e => e.inf_user)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);
        }
    }
}
