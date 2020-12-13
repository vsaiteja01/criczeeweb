using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace cricZee
{
    public partial class TejaContext : DbContext
    {
        public TejaContext()
        {
        }

        public TejaContext(DbContextOptions<TejaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Match> Matches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:vsaitejaserver.database.windows.net,1433;Initial Catalog=Teja;Persist Security Info=False;User ID=vsaiteja;Password=Teja@199189;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Match>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("date");

                entity.Property(e => e.DlApplied)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dl_applied");

                entity.Property(e => e.PlayerOfMatch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("player_of_match");

                entity.Property(e => e.Result)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("result");

                entity.Property(e => e.Season)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("season");

                entity.Property(e => e.Team1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("team1");

                entity.Property(e => e.Team1Picture)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Team2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("team2");

                entity.Property(e => e.Team2Picture)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TossDecision)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("toss_decision");

                entity.Property(e => e.TossWinner)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("toss_winner");

                entity.Property(e => e.Umpire1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("umpire1");

                entity.Property(e => e.Umpire2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("umpire2");

                entity.Property(e => e.Umpire3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("umpire3");

                entity.Property(e => e.Venue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("venue");

                entity.Property(e => e.WinByRuns)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("win_by_runs");

                entity.Property(e => e.WinByWickets)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("win_by_wickets");

                entity.Property(e => e.Winner)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("winner");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
