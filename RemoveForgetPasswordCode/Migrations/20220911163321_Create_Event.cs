using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RemoveForgetPasswordCode.Migrations
{
    public partial class Create_Event : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             string createEvent = @"CREATE EVENT Remove_Password_Code
                                        on SCHEDULE EVERY 1 SECOND
                                        DO
                                        DELETE FROM forgetpasswordcodes WHERE TIMESTAMPDIFF(minute,CreatedAt,UTC_TIMESTAMP()) >= ExpiredTime
                                        ";

            migrationBuilder.Sql(createEvent);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
