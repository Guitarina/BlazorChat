using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorChat.DAL.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ConversationType",
                table: "Chats",
                newName: "ChatType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ChatType",
                table: "Chats",
                newName: "ConversationType");
        }
    }
}
