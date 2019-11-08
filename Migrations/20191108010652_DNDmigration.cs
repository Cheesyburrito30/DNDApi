using Microsoft.EntityFrameworkCore.Migrations;

namespace DNDApi.Migrations
{
    public partial class DNDmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Slug = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Alignment = table.Column<string>(nullable: true),
                    ArmorClass = table.Column<int>(nullable: false),
                    HitPoints = table.Column<int>(nullable: false),
                    HitDice = table.Column<string>(nullable: true),
                    Speed_Walk = table.Column<int>(nullable: true),
                    Speed_Climb = table.Column<int>(nullable: true),
                    Speed_Burrow = table.Column<int>(nullable: true),
                    Speed_Fly = table.Column<int>(nullable: true),
                    Speed_Swim = table.Column<int>(nullable: true),
                    Hover = table.Column<bool>(nullable: false),
                    Abilities_Strength = table.Column<int>(nullable: true),
                    Abilities_Dexterity = table.Column<int>(nullable: true),
                    Abilities_Constitution = table.Column<int>(nullable: true),
                    Abilities_Intelligence = table.Column<int>(nullable: true),
                    Abilities_Wisdom = table.Column<int>(nullable: true),
                    Abilities_Charisma = table.Column<int>(nullable: true),
                    Saves_Strength = table.Column<int>(nullable: true),
                    Saves_Dexterity = table.Column<int>(nullable: true),
                    Saves_Constitution = table.Column<int>(nullable: true),
                    Saves_Intelligence = table.Column<int>(nullable: true),
                    Saves_Wisdom = table.Column<int>(nullable: true),
                    Saves_Charisma = table.Column<int>(nullable: true),
                    Skills_Acrobatics = table.Column<int>(nullable: true),
                    Skills_AnimalHandling = table.Column<int>(nullable: true),
                    Skills_Arcana = table.Column<int>(nullable: true),
                    Skills_Athletics = table.Column<int>(nullable: true),
                    Skills_Deception = table.Column<int>(nullable: true),
                    Skills_History = table.Column<int>(nullable: true),
                    Skills_Insight = table.Column<int>(nullable: true),
                    Skills_Intimidation = table.Column<int>(nullable: true),
                    Skills_Investigation = table.Column<int>(nullable: true),
                    Skills_Medicine = table.Column<int>(nullable: true),
                    Skills_Nature = table.Column<int>(nullable: true),
                    Skills_Perception = table.Column<int>(nullable: true),
                    Skills_Performance = table.Column<int>(nullable: true),
                    Skills_Persuasion = table.Column<int>(nullable: true),
                    Skills_Religion = table.Column<int>(nullable: true),
                    Skills_SleightOfHand = table.Column<int>(nullable: true),
                    Skills_Stealth = table.Column<int>(nullable: true),
                    Skills_Survival = table.Column<int>(nullable: true),
                    Senses = table.Column<string>(nullable: true),
                    Languages = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Action",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Attack_Bonus = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Action", x => new { x.CharacterId, x.Id });
                    table.ForeignKey(
                        name: "FK_Action_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttackDamage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttackActionCharacterId = table.Column<int>(nullable: false),
                    AttackActionId = table.Column<int>(nullable: false),
                    DamageType = table.Column<string>(nullable: true),
                    DamageDice = table.Column<string>(nullable: true),
                    DamageBonus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttackDamage", x => new { x.AttackActionCharacterId, x.AttackActionId, x.Id });
                    table.ForeignKey(
                        name: "FK_AttackDamage_Action_AttackActionCharacterId_AttackActionId",
                        columns: x => new { x.AttackActionCharacterId, x.AttackActionId },
                        principalTable: "Action",
                        principalColumns: new[] { "CharacterId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttackDamage");

            migrationBuilder.DropTable(
                name: "Action");

            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
