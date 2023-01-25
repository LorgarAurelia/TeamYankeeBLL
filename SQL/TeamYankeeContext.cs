using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TeamYankeeBLL.SQL.Models;

namespace TeamYankeeBLL.SQL;

public partial class TeamYankeeContext : DbContext
{
    public TeamYankeeContext()
    {
    }

    public TeamYankeeContext(DbContextOptions<TeamYankeeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AircraftsSpecification> AircraftsSpecifications { get; set; }

    public virtual DbSet<FormationsAsset> FormationsAssets { get; set; }

    public virtual DbSet<FormationsComposition> FormationsCompositions { get; set; }

    public virtual DbSet<FormationsReference> FormationsReferences { get; set; }

    public virtual DbSet<HeavySpecification> HeavySpecifications { get; set; }

    public virtual DbSet<InfantrySpecification> InfantrySpecifications { get; set; }

    public virtual DbSet<Nation> Nations { get; set; }

    public virtual DbSet<RosterDescription> Rosters { get; set; }

    public virtual DbSet<RostersContent> RostersContents { get; set; }

    public virtual DbSet<RostersSupportUnit> RostersSupportUnits { get; set; }

    public virtual DbSet<SpecialRule> SpecialRules { get; set; }

    public virtual DbSet<UnitReferencesToSpecialRule> UnitReferencesToSpecialRules { get; set; }

    public virtual DbSet<UnitReferencesToWeapon> UnitReferencesToWeapons { get; set; }

    public virtual DbSet<UnitsComposition> UnitsCompositions { get; set; }

    public virtual DbSet<UnitsOptionsReference> UnitsOptionsReferences { get; set; }

    public virtual DbSet<UnitsReference> UnitsReferences { get; set; }

    public virtual DbSet<UnitsType> UnitsTypes { get; set; }

    public virtual DbSet<UsersFormation> UsersFormations { get; set; }

    public virtual DbSet<UsersUnit> UsersUnits { get; set; }

    public virtual DbSet<UsersUnitsOption> UsersUnitsOptions { get; set; }

    public virtual DbSet<VehicleSpecification> VehicleSpecifications { get; set; }

    public virtual DbSet<Weapon> Weapons { get; set; }

    public virtual DbSet<WeaponsToSpecialRule> WeaponsToSpecialRules { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=TeamYankee;Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AircraftsSpecification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aircraft__3214EC079843FCA9");

            entity.HasOne(d => d.Unit).WithMany(p => p.AircraftsSpecifications)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AircraftsSpecifications_UnitsReference");
        });

        modelBuilder.Entity<FormationsAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Formatio__3214EC07C3BE88E1");

            entity.HasOne(d => d.Formation).WithMany(p => p.FormationsAssets)
                .HasForeignKey(d => d.FormationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormationsAssets_UsersFormations");

            entity.HasOne(d => d.Unit).WithMany(p => p.FormationsAssets)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormationsAssets_UsersUnits");
        });

        modelBuilder.Entity<FormationsComposition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Formatio__3214EC07BA0E8774");

            entity.ToTable("FormationsComposition");

            entity.HasOne(d => d.AlternativeUnit).WithMany(p => p.FormationsCompositionAlternativeUnits)
                .HasForeignKey(d => d.AlternativeUnitId)
                .HasConstraintName("FK_FormationsComposition_UnitsReference_AlternativeUnits");

            entity.HasOne(d => d.Formation).WithMany(p => p.FormationsCompositions)
                .HasForeignKey(d => d.FormationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormationsComposition_FormationsReference");

            entity.HasOne(d => d.Unit).WithMany(p => p.FormationsCompositionUnits)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormationsComposition_UnitsReference");
        });

        modelBuilder.Entity<FormationsReference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Formatio__3214EC07712DF076");

            entity.ToTable("FormationsReference");

            entity.Property(e => e.Name).HasMaxLength(150);
        });

        modelBuilder.Entity<HeavySpecification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HeavySpe__3214EC07F84CC863");

            entity.Property(e => e.CrossCountryDash).HasMaxLength(10);
            entity.Property(e => e.RoadDash).HasMaxLength(10);
            entity.Property(e => e.Tactical).HasMaxLength(10);
            entity.Property(e => e.TerrainDash).HasMaxLength(10);

            entity.HasOne(d => d.Unit).WithMany(p => p.HeavySpecifications)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK_HeavySpecifications_UnitId");
        });

        modelBuilder.Entity<InfantrySpecification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Infantry__3214EC07763FAA02");

            entity.ToTable("InfantrySpecification");

            entity.Property(e => e.CrossCountryDash).HasMaxLength(10);
            entity.Property(e => e.RoadDash).HasMaxLength(10);
            entity.Property(e => e.Tactical).HasMaxLength(10);
            entity.Property(e => e.TerrainDash).HasMaxLength(10);

            entity.HasOne(d => d.Unit).WithMany(p => p.InfantrySpecifications)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InfantrySpecification_UnitsReference");
        });

        modelBuilder.Entity<Nation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Nations__3214EC073D232BDB");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<RosterDescription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Rosters__3214EC07ED6AA639");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Nation).WithMany(p => p.Rosters)
                .HasForeignKey(d => d.NationId)
                .HasConstraintName("FK_Rosters_Nations");
        });

        modelBuilder.Entity<RostersContent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RostersC__3214EC077913D32B");

            entity.ToTable("RostersContent");

            entity.HasOne(d => d.BlackBoxUnit).WithMany(p => p.RostersContents)
                .HasForeignKey(d => d.BlackBoxUnitId)
                .HasConstraintName("FK_RostersContent_UsersUnits");

            entity.HasOne(d => d.Formation).WithMany(p => p.RostersContents)
                .HasForeignKey(d => d.FormationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RostersContent_UsersFormations");

            entity.HasOne(d => d.Roster).WithMany(p => p.RostersContents)
                .HasForeignKey(d => d.RosterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RostersContent_Rosters");
        });

        modelBuilder.Entity<RostersSupportUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RostersS__3214EC07CE483AD4");

            entity.HasOne(d => d.SuppotUnit).WithMany(p => p.RostersSupportUnits)
                .HasForeignKey(d => d.SuppotUnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RostersSupportUnits_UsersUnits");
        });

        modelBuilder.Entity<SpecialRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SpecialR__3214EC0777070C24");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<UnitReferencesToSpecialRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UnitRefe__3214EC0792D06715");

            entity.HasOne(d => d.SpecialRule).WithMany(p => p.UnitReferencesToSpecialRules)
                .HasForeignKey(d => d.SpecialRuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnitReferencesToSpecialRules_SpecialRules");

            entity.HasOne(d => d.UnitReference).WithMany(p => p.UnitReferencesToSpecialRules)
                .HasForeignKey(d => d.UnitReferenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnitReferencesToSpecialRules_UnitsReference");
        });

        modelBuilder.Entity<UnitReferencesToWeapon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UnitRefe__3214EC07539C95DF");

            entity.HasOne(d => d.UnitReference).WithMany(p => p.UnitReferencesToWeapons)
                .HasForeignKey(d => d.UnitReferenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnitReferencesToWeapons_UnitsReference");

            entity.HasOne(d => d.Weapons).WithMany(p => p.UnitReferencesToWeapons)
                .HasForeignKey(d => d.WeaponsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnitReferencesToWeapons_Weapons");
        });

        modelBuilder.Entity<UnitsComposition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UnitsCom__3214EC0738C76856");

            entity.ToTable("UnitsComposition");

            entity.HasOne(d => d.Unit).WithMany(p => p.UnitsCompositions)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnitsComposition_UnitsReference");
        });

        modelBuilder.Entity<UnitsOptionsReference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UnitsOpt__3214EC07481AAB9C");

            entity.ToTable("UnitsOptionsReference");

            entity.Property(e => e.Option).HasMaxLength(300);

            entity.HasOne(d => d.Unit).WithMany(p => p.UnitsOptionsReferences)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnitsOptionsReference_UnitsReference");
        });

        modelBuilder.Entity<UnitsReference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UnitsRef__3214EC07687577B8");

            entity.ToTable("UnitsReference");

            entity.Property(e => e.Namne).HasMaxLength(50);

            entity.HasOne(d => d.Nation).WithMany(p => p.UnitsReferences)
                .HasForeignKey(d => d.NationId)
                .HasConstraintName("FK_UnitsReference_Nations");
        });

        modelBuilder.Entity<UnitsType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UnitsTyp__3214EC079E75EA65");

            entity.HasOne(d => d.Unit).WithMany(p => p.UnitsTypes)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK_UnitsTypes_UnitsReference");
        });

        modelBuilder.Entity<UsersFormation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UsersFor__3214EC07903928FD");

            entity.Property(e => e.Name).HasMaxLength(150);

            entity.HasOne(d => d.Reference).WithMany(p => p.UsersFormations)
                .HasForeignKey(d => d.ReferenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsersFormations_FormationsReference");
        });

        modelBuilder.Entity<UsersUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UsersUni__3214EC07767F6951");

            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Composition).WithMany(p => p.UsersUnits)
                .HasForeignKey(d => d.CompositionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsersUnits_UnitsComposition");

            entity.HasOne(d => d.Reference).WithMany(p => p.UsersUnits)
                .HasForeignKey(d => d.ReferenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsersUnits_UnitsReference");
        });

        modelBuilder.Entity<UsersUnitsOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UsersUni__3214EC07CAE44414");

            entity.HasOne(d => d.Reference).WithMany(p => p.UsersUnitsOptions)
                .HasForeignKey(d => d.ReferenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsersUnitsOptions_UnitsOptionsReference");

            entity.HasOne(d => d.Unit).WithMany(p => p.UsersUnitsOptions)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsersUnitsOptions_UsersUnits");
        });

        modelBuilder.Entity<VehicleSpecification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VehicleS__3214EC07CA53B82F");

            entity.ToTable("VehicleSpecification");

            entity.Property(e => e.CrossCountryDash).HasMaxLength(10);
            entity.Property(e => e.RoadDash).HasMaxLength(10);
            entity.Property(e => e.Tactical).HasMaxLength(10);
            entity.Property(e => e.TerrainDash).HasMaxLength(10);

            entity.HasOne(d => d.Unit).WithMany(p => p.VehicleSpecifications)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VehicleSpecification_UnitsReference");
        });

        modelBuilder.Entity<Weapon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Weapons__3214EC073BAB0977");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Range).HasMaxLength(100);

            entity.HasOne(d => d.SpecialRule).WithMany(p => p.Weapons)
                .HasForeignKey(d => d.SpecialRuleId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Weapons_SpecialRules");
        });

        modelBuilder.Entity<WeaponsToSpecialRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WeaponsT__3214EC0749BFC354");

            entity.HasOne(d => d.SpecialRule).WithMany(p => p.WeaponsToSpecialRules)
                .HasForeignKey(d => d.SpecialRuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WeaponsToSpecialRules_SpecialRules");

            entity.HasOne(d => d.Weapons).WithMany(p => p.WeaponsToSpecialRules)
                .HasForeignKey(d => d.WeaponsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WeaponsToSpecialRules_Weapons");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
