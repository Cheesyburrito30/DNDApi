﻿// <auto-generated />
using DNDApi.Models.Character;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DNDApi.Migrations
{
    [DbContext(typeof(CharacterContext))]
    partial class CharacterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DNDApi.Models.Character.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alignment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ArmorClass")
                        .HasColumnType("int");

                    b.Property<string>("HitDice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HitPoints")
                        .HasColumnType("int");

                    b.Property<bool>("Hover")
                        .HasColumnType("bit");

                    b.Property<string>("Languages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("DNDApi.Models.Character.Character", b =>
                {
                    b.OwnsOne("DNDApi.Models.Ability", "Abilities", b1 =>
                        {
                            b1.Property<int>("CharacterId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Charisma")
                                .HasColumnType("int");

                            b1.Property<int>("Constitution")
                                .HasColumnType("int");

                            b1.Property<int>("Dexterity")
                                .HasColumnType("int");

                            b1.Property<int>("Intelligence")
                                .HasColumnType("int");

                            b1.Property<int>("Strength")
                                .HasColumnType("int");

                            b1.Property<int>("Wisdom")
                                .HasColumnType("int");

                            b1.HasKey("CharacterId");

                            b1.ToTable("Characters");

                            b1.WithOwner()
                                .HasForeignKey("CharacterId");
                        });

                    b.OwnsOne("DNDApi.Models.Ability", "Saves", b1 =>
                        {
                            b1.Property<int>("CharacterId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Charisma")
                                .HasColumnType("int");

                            b1.Property<int>("Constitution")
                                .HasColumnType("int");

                            b1.Property<int>("Dexterity")
                                .HasColumnType("int");

                            b1.Property<int>("Intelligence")
                                .HasColumnType("int");

                            b1.Property<int>("Strength")
                                .HasColumnType("int");

                            b1.Property<int>("Wisdom")
                                .HasColumnType("int");

                            b1.HasKey("CharacterId");

                            b1.ToTable("Characters");

                            b1.WithOwner()
                                .HasForeignKey("CharacterId");
                        });

                    b.OwnsMany("DNDApi.Models.Actions.Action", "Actions", b1 =>
                        {
                            b1.Property<int>("CharacterId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Desc")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Name")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Type")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("CharacterId", "Id");

                            b1.ToTable("Action");

                            b1.WithOwner()
                                .HasForeignKey("CharacterId");

                            b1.OwnsOne("DNDApi.Models.Actions.Attack", "Attack", b2 =>
                                {
                                    b2.Property<int>("ActionCharacterId")
                                        .HasColumnType("int");

                                    b2.Property<int>("ActionId")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int")
                                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                                    b2.Property<int>("Bonus")
                                        .HasColumnType("int");

                                    b2.HasKey("ActionCharacterId", "ActionId");

                                    b2.ToTable("Action");

                                    b2.WithOwner()
                                        .HasForeignKey("ActionCharacterId", "ActionId");

                                    b2.OwnsMany("DNDApi.Models.Actions.AttackDamage", "Damage", b3 =>
                                        {
                                            b3.Property<int>("AttackActionCharacterId")
                                                .HasColumnType("int");

                                            b3.Property<int>("AttackActionId")
                                                .HasColumnType("int");

                                            b3.Property<int>("Id")
                                                .ValueGeneratedOnAdd()
                                                .HasColumnType("int")
                                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                                            b3.Property<int>("DamageBonus")
                                                .HasColumnType("int");

                                            b3.Property<string>("DamageDice")
                                                .HasColumnType("nvarchar(max)");

                                            b3.Property<string>("DamageType")
                                                .HasColumnType("nvarchar(max)");

                                            b3.HasKey("AttackActionCharacterId", "AttackActionId", "Id");

                                            b3.ToTable("AttackDamage");

                                            b3.WithOwner()
                                                .HasForeignKey("AttackActionCharacterId", "AttackActionId");
                                        });
                                });
                        });

                    b.OwnsOne("DNDApi.Models.Character.Skill", "Skills", b1 =>
                        {
                            b1.Property<int>("CharacterId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Acrobatics")
                                .HasColumnType("int");

                            b1.Property<int>("AnimalHandling")
                                .HasColumnType("int");

                            b1.Property<int>("Arcana")
                                .HasColumnType("int");

                            b1.Property<int>("Athletics")
                                .HasColumnType("int");

                            b1.Property<int>("Deception")
                                .HasColumnType("int");

                            b1.Property<int>("History")
                                .HasColumnType("int");

                            b1.Property<int>("Insight")
                                .HasColumnType("int");

                            b1.Property<int>("Intimidation")
                                .HasColumnType("int");

                            b1.Property<int>("Investigation")
                                .HasColumnType("int");

                            b1.Property<int>("Medicine")
                                .HasColumnType("int");

                            b1.Property<int>("Nature")
                                .HasColumnType("int");

                            b1.Property<int>("Perception")
                                .HasColumnType("int");

                            b1.Property<int>("Performance")
                                .HasColumnType("int");

                            b1.Property<int>("Persuasion")
                                .HasColumnType("int");

                            b1.Property<int>("Religion")
                                .HasColumnType("int");

                            b1.Property<int>("SleightOfHand")
                                .HasColumnType("int");

                            b1.Property<int>("Stealth")
                                .HasColumnType("int");

                            b1.Property<int>("Survival")
                                .HasColumnType("int");

                            b1.HasKey("CharacterId");

                            b1.ToTable("Characters");

                            b1.WithOwner()
                                .HasForeignKey("CharacterId");
                        });

                    b.OwnsOne("DNDApi.Models.Character.Speed", "Speed", b1 =>
                        {
                            b1.Property<int>("CharacterId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Burrow")
                                .HasColumnType("int");

                            b1.Property<int>("Climb")
                                .HasColumnType("int");

                            b1.Property<int>("Fly")
                                .HasColumnType("int");

                            b1.Property<int>("Swim")
                                .HasColumnType("int");

                            b1.Property<int>("Walk")
                                .HasColumnType("int");

                            b1.HasKey("CharacterId");

                            b1.ToTable("Characters");

                            b1.WithOwner()
                                .HasForeignKey("CharacterId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
