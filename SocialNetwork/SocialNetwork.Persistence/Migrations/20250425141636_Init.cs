using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SocialNetwork.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Img = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<string>(type: "text", nullable: true),
                    Author = table.Column<string>(type: "text", nullable: true),
                    IntrestedCount = table.Column<int>(type: "integer", nullable: false),
                    GoingCount = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<int>(type: "integer", nullable: true),
                    Web = table.Column<int>(type: "integer", nullable: true),
                    Phone = table.Column<int>(type: "integer", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Notify",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SendMessage = table.Column<int>(type: "integer", nullable: true),
                    LikedPhoto = table.Column<int>(type: "integer", nullable: true),
                    SharedPhoto = table.Column<int>(type: "integer", nullable: true),
                    Followed = table.Column<int>(type: "integer", nullable: true),
                    Mentioned = table.Column<int>(type: "integer", nullable: true),
                    SendRequest = table.Column<int>(type: "integer", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notify", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    UserPageId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true),
                    LikeCount = table.Column<int>(type: "integer", nullable: false),
                    DislikeCount = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.UserPageId);
                });

            migrationBuilder.CreateTable(
                name: "Privacy",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FollowMe = table.Column<int>(type: "integer", nullable: true),
                    MessageMe = table.Column<int>(type: "integer", nullable: true),
                    Activities = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: true),
                    MyTags = table.Column<int>(type: "integer", nullable: true),
                    SearchEngine = table.Column<int>(type: "integer", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privacy", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "SocialLinks",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Facebook = table.Column<string>(type: "text", nullable: true),
                    Instagram = table.Column<string>(type: "text", nullable: true),
                    Twitter = table.Column<string>(type: "text", nullable: true),
                    Youtube = table.Column<string>(type: "text", nullable: true),
                    Github = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialLinks", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Img = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Bio = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    Relationship = table.Column<int>(type: "integer", nullable: false),
                    TwoFactorAuthentication = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Author", "CreatedBy", "CreatedDate", "Date", "GoingCount", "Id", "Img", "IntrestedCount", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "UK BRANDS", null, null, "WED JUL 10,2024 AT 10PM", 951, 0, "~/images/events/img-1.jpg", 742, "The Global Creative", null, null },
                    { 2, "Catiana", null, null, "Upcomming", 452, 0, "~/images/events/img-2.jpg", 153, "Wedding trend Ideas", null, null },
                    { 3, "Morleam", null, null, "Next week", 753, 0, "~/images/events/img-3.jpg", 651, "About Safety and Flight", null, null },
                    { 4, "UK BRANDS", null, null, "Tomorrow", 614, 0, "~/images/events/img-4.jpg", 824, "Perspective is everything", null, null },
                    { 5, "Global Hub", null, null, "FRI AUG 15,2024 AT 8PM", 567, 0, "~/images/events/img-1.jpg", 345, "Creative Minds Meetup", null, null },
                    { 6, "TechWorld", null, null, "Next month", 456, 0, "~/images/events/img-2.jpg", 234, "Tech Innovators Summit", null, null },
                    { 7, "ArtLovers", null, null, "SAT SEP 20,2024 AT 6PM", 678, 0, "~/images/events/img-3.jpg", 456, "Art Gallery Opening", null, null },
                    { 8, "MelodyMakers", null, null, "This weekend", 789, 0, "~/images/events/img-4.jpg", 567, "Music Festival Night", null, null },
                    { 9, "Entrepreneurs", null, null, "MON OCT 5,2024 AT 2PM", 890, 0, "~/images/events/img-1.jpg", 678, "Startup Pitch Day", null, null },
                    { 10, "LensCrafters", null, null, "Next Friday", 901, 0, "~/images/events/img-2.jpg", 789, "Photography Workshop", null, null },
                    { 11, "FoodFanatics", null, null, "TUE NOV 10,2024 AT 7PM", 101, 0, "~/images/events/img-3.jpg", 890, "Foodies Gathering", null, null },
                    { 12, "ReadersUnite", null, null, "Next Tuesday", 112, 0, "~/images/events/img-4.jpg", 901, "Book Club Meeting", null, null },
                    { 13, "FitLife", null, null, "THU DEC 15,2024 AT 5AM", 223, 0, "~/images/events/img-1.jpg", 101, "Fitness Bootcamp", null, null },
                    { 14, "ZenMasters", null, null, "Every Sunday", 334, 0, "~/images/events/img-2.jpg", 223, "Yoga and Meditation", null, null },
                    { 15, "CodeNinjas", null, null, "Next Saturday", 445, 0, "~/images/events/img-3.jpg", 334, "Coding Hackathon", null, null },
                    { 16, "GameOn", null, null, "Next Monday", 556, 0, "~/images/events/img-4.jpg", 445, "Gaming Tournament", null, null },
                    { 17, "Cinephiles", null, null, "FRI JAN 20,2025 AT 9PM", 667, 0, "~/images/events/img-1.jpg", 556, "Film Screening Night", null, null },
                    { 18, "DanceLovers", null, null, "Next Thursday", 778, 0, "~/images/events/img-2.jpg", 667, "Dance Workshop", null, null },
                    { 19, "StyleIcons", null, null, "SAT FEB 5,2025 AT 4PM", 889, 0, "~/images/events/img-3.jpg", 778, "Fashion Show Extravaganza", null, null },
                    { 20, "Connectors", null, null, "Next Wednesday", 990, 0, "~/images/events/img-4.jpg", 889, "Networking Mixer", null, null },
                    { 21, "ScienceGeeks", null, null, "MON MAR 10,2025 AT 11AM", 111, 0, "~/images/events/img-1.jpg", 990, "Science Fair", null, null },
                    { 22, "KindHearts", null, null, "Next Friday", 222, 0, "~/images/events/img-2.jpg", 111, "Charity Gala Dinner", null, null },
                    { 23, "PawsAndClaws", null, null, "TUE APR 15,2025 AT 3PM", 333, 0, "~/images/events/img-3.jpg", 222, "Pet Adoption Day", null, null },
                    { 24, "NatureExplorers", null, null, "Next Monday", 444, 0, "~/images/events/img-4.jpg", 333, "Outdoor Adventure", null, null },
                    { 25, "KitchenExperts", null, null, "THU MAY 20,2025 AT 2PM", 555, 0, "~/images/events/img-1.jpg", 444, "Cooking Masterclass", null, null },
                    { 26, "CraftyHands", null, null, "Next Sunday", 666, 0, "~/images/events/img-2.jpg", 555, "DIY Craft Workshop", null, null },
                    { 27, "Polyglots", null, null, "FRI JUN 25,2025 AT 7PM", 777, 0, "~/images/events/img-3.jpg", 666, "Language Exchange Meetup", null, null },
                    { 28, "GameNight", null, null, "Next Tuesday", 888, 0, "~/images/events/img-4.jpg", 777, "Board Games Night", null, null },
                    { 29, "VRWorld", null, null, "SAT JUL 30,2025 AT 10AM", 999, 0, "~/images/events/img-1.jpg", 888, "Virtual Reality Experience", null, null },
                    { 30, "LaughOutLoud", null, null, "Next Thursday", 1010, 0, "~/images/events/img-2.jpg", 999, "Comedy Night Live", null, null }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "UserId", "CreatedBy", "CreatedDate", "Email", "Id", "Phone", "UpdatedBy", "UpdatedDate", "Web" },
                values: new object[] { 1, null, null, 0, 0, 1, null, null, 1 });

            migrationBuilder.InsertData(
                table: "Notify",
                columns: new[] { "UserId", "CreatedBy", "CreatedDate", "Followed", "Id", "LikedPhoto", "Mentioned", "SendMessage", "SendRequest", "SharedPhoto", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, null, null, 0, 0, 1, 1, 0, 1, 1, null, null });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "UserPageId", "Content", "CreatedBy", "CreatedDate", "DislikeCount", "Id", "LikeCount", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Контент1", null, null, 1, 0, 1, null, null },
                    { 2, "Контент2", null, null, 2, 0, 2, null, null },
                    { 3, "Контент3", null, null, 3, 0, 3, null, null }
                });

            migrationBuilder.InsertData(
                table: "Privacy",
                columns: new[] { "UserId", "Activities", "CreatedBy", "CreatedDate", "FollowMe", "Id", "MessageMe", "MyTags", "SearchEngine", "Status", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 1, null, null, 0, 0, 0, 2, 1, 0, null, null });

            migrationBuilder.InsertData(
                table: "SocialLinks",
                columns: new[] { "UserId", "CreatedBy", "CreatedDate", "Facebook", "Github", "Id", "Instagram", "Twitter", "UpdatedBy", "UpdatedDate", "Youtube" },
                values: new object[] { 1, null, null, "facebook", "github", 0, "instagram", "twitter", null, null, "youtube" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Bio", "CreatedBy", "CreatedDate", "Email", "Gender", "Id", "Img", "Name", "Password", "Relationship", "TwoFactorAuthentication", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "Хочу клубничку", null, null, "deniskapipiska@loh.ru", 1, 0, "~/images/avatars/avatar-7.jpg", "Денис", "lublumujikov", 1, 0, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Notify");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Privacy");

            migrationBuilder.DropTable(
                name: "SocialLinks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
