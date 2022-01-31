using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPortal.Migrations
{
    public partial class SubForumOwnerId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "3922f6f9-6613-4b53-a74e-852a9d82d9a3", "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "3922f6f9-6613-4b53-a74e-852a9d82d9a3", "725c5431-6bf5-42bb-a968-060403ad2e0b" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "cf3d3d49-5b35-4fba-a077-a11de76bf1e3", "725c5431-6bf5-42bb-a968-060403ad2e0b" });

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "cb8eef8f-0d4d-46b2-94a8-588e0ad6851c");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "cbabcda8-9697-4cbf-a630-df0370dd6450");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "0d64271b-64af-42b5-b1e7-8237f3c67421");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "704cc157-92fe-4314-a59c-974e100131c4");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "a0bb40c7-f95e-4545-805e-bf279bbdc7b7");

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "64509879-7b93-48a0-884a-afdb26c53a18", "7c72e7f2-5e55-4b28-9883-9d67158aba72" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "64509879-7b93-48a0-884a-afdb26c53a18", "9ac533d5-60b0-4793-81ef-1d827fa36e4e" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "9beaff8b-1c8e-43ac-944f-e23283176e4c", "7c72e7f2-5e55-4b28-9883-9d67158aba72" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "9beaff8b-1c8e-43ac-944f-e23283176e4c", "d78b1bbf-770a-4b6f-acdf-f3c3f7d24cfe" });

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "0a0cecc1-7d3d-44d7-9abf-eee43ace7cb9");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "27993cee-c5ab-4f6c-886d-e7bb68d23d6e");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "47c90354-0922-4fcf-951f-ee2641e7f2db");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "6729f8fb-c5a4-4438-9ec3-61758365d71a");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "9a6b7444-86f6-4bcb-86e1-afebe6e51003");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "cd0f31c0-2168-45d5-ac21-db26721e50c5");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "e85fc14c-5502-48f9-8cd4-109180cc1432");

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "53a802aa-6e59-4f1d-9d79-24a7a0a01c05", "549a4035-5392-4b84-b082-b44dd65a9180" });

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "c8579023-b05c-40f0-97d5-5c462dd87d2c", "acb9ae7b-bf09-4da1-92e0-f164ae6da7db" });

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "c8579023-b05c-40f0-97d5-5c462dd87d2c", "b2859d13-433c-45ab-a12a-b89c60fcdf80" });

            migrationBuilder.DeleteData(
                table: "UserConversations",
                keyColumns: new[] { "UserId", "ConversationId" },
                keyValues: new object[] { "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91", "a530f177-5f06-4572-bb1a-991bbade2fd8" });

            migrationBuilder.DeleteData(
                table: "UserConversations",
                keyColumns: new[] { "UserId", "ConversationId" },
                keyValues: new object[] { "725c5431-6bf5-42bb-a968-060403ad2e0b", "a530f177-5f06-4572-bb1a-991bbade2fd8" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91", "53a802aa-6e59-4f1d-9d79-24a7a0a01c05" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91", "c8579023-b05c-40f0-97d5-5c462dd87d2c" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "725c5431-6bf5-42bb-a968-060403ad2e0b", "53a802aa-6e59-4f1d-9d79-24a7a0a01c05" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "725c5431-6bf5-42bb-a968-060403ad2e0b", "c8579023-b05c-40f0-97d5-5c462dd87d2c" });

            migrationBuilder.DeleteData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: "a530f177-5f06-4572-bb1a-991bbade2fd8");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "53a802aa-6e59-4f1d-9d79-24a7a0a01c05");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "c8579023-b05c-40f0-97d5-5c462dd87d2c");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "64509879-7b93-48a0-884a-afdb26c53a18");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "9beaff8b-1c8e-43ac-944f-e23283176e4c");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "7c72e7f2-5e55-4b28-9883-9d67158aba72");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "9ac533d5-60b0-4793-81ef-1d827fa36e4e");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "d78b1bbf-770a-4b6f-acdf-f3c3f7d24cfe");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "78949cce-3c1f-4a37-8c9c-aa422be6b49a");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "cea6a9c3-7a24-4b87-bb77-943787cbd25c");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "f84b9af1-0d3f-479c-8c68-de766d57d4d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "725c5431-6bf5-42bb-a968-060403ad2e0b");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3922f6f9-6613-4b53-a74e-852a9d82d9a3");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cf3d3d49-5b35-4fba-a077-a11de76bf1e3");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "549a4035-5392-4b84-b082-b44dd65a9180");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "acb9ae7b-bf09-4da1-92e0-f164ae6da7db");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "b2859d13-433c-45ab-a12a-b89c60fcdf80");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: "9b3b754b-25df-4338-ba5a-e9cf7da3d101");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: "c300c635-dbc3-48ba-8958-01eab50d29ee");

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "SubForums",
                nullable: false);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageURL", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b540e779-3ff6-424a-9375-8e9817ceaaa0", 0, "cbb95c21-9a16-4d1c-906f-de07520eb975", "seeduser@gmail.com", false, "https://i.pravatar.cc/100?img=2", false, null, "SEEDUSER@GMAIL.COM", "SEEDUSER", "AQAAAAEAACcQAAAAEOtUkrHF4X2adYzZQyvDylIaVDopLOnMP42pCN7N3+O34c+wBaMpU5jOGnud1w9KpQ==", null, false, "7458390e-a077-4608-a9ae-90441e12f1e2", false, "SeedUser" },
                    { "3b608417-03da-4732-8663-58daa6c8cdd2", 0, "a079ec94-b5a0-41d8-8ec1-de227d33b7fb", "seeduser2@gmail.com", false, "https://i.pravatar.cc/100?img=4", false, null, "SEEDUSER2@GMAIL.COM", "SEEDUSER2", "AQAAAAEAACcQAAAAEG4/oAjEVSb/2iGWNmlxFdI5F8BUEImJu5//7U6X26Vdib6Rhdo56jN2IBSwMuyJ3g==", null, false, "c16b1d6a-cd71-454f-a286-950ca48cc751", false, "SeedUser2" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "07504bde-3aed-4f50-a5cb-2bbbf26f96f1", "Gaming" },
                    { "75bf782a-8b12-4d1d-b202-9885db6f0bb0", "Health & Safety" }
                });

            migrationBuilder.InsertData(
                table: "Conversations",
                columns: new[] { "Id", "Subject" },
                values: new object[] { "60901eff-c237-45ce-9e3a-ffc3d1034a87", "A cool conversation between seeded users" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "a88553b7-594c-4f29-987c-25f960b8939c", "Programming" },
                    { "e47efd52-80c7-49db-ae21-46e466cd9eb4", "Gaming" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "87911303-4163-4bc8-baf7-8e8b7bc37b9e", "First Post" },
                    { "7909d965-9aea-4551-ae07-8e933e94de47", "Informative" },
                    { "cfb2e951-4e31-46f9-afbe-0586a7407e43", "Casual" }
                });

            migrationBuilder.InsertData(
                table: "CategorySubscribers",
                columns: new[] { "CategoryId", "UserId" },
                values: new object[,]
                {
                    { "75bf782a-8b12-4d1d-b202-9885db6f0bb0", "3b608417-03da-4732-8663-58daa6c8cdd2" },
                    { "75bf782a-8b12-4d1d-b202-9885db6f0bb0", "b540e779-3ff6-424a-9375-8e9817ceaaa0" },
                    { "07504bde-3aed-4f50-a5cb-2bbbf26f96f1", "b540e779-3ff6-424a-9375-8e9817ceaaa0" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Content", "StartDate", "Subject", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { "92be5442-7a84-4d96-8ff0-b8dd80dd2b6e", "We will be meeting in the town centre on the specified date.", new DateTime(2022, 1, 30, 11, 6, 7, 184, DateTimeKind.Local).AddTicks(4075), "Meeting in town centre", new DateTime(2022, 1, 27, 11, 6, 7, 182, DateTimeKind.Local).AddTicks(1133), "b540e779-3ff6-424a-9375-8e9817ceaaa0" },
                    { "7094b713-a852-4718-828b-cd001aeb64b4", "We will begin a riot on Walmart on the second street", new DateTime(2022, 2, 6, 11, 6, 7, 184, DateTimeKind.Local).AddTicks(4527), "Riot at Walmart", new DateTime(2022, 1, 27, 11, 6, 7, 184, DateTimeKind.Local).AddTicks(4508), "3b608417-03da-4732-8663-58daa6c8cdd2" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name", "OwnerId" },
                values: new object[,]
                {
                    { "f1a6fa7a-4e85-47fc-84dc-f7cc96346df5", "Programmers", "3b608417-03da-4732-8663-58daa6c8cdd2" },
                    { "48503736-b8cb-4ac9-be1c-9c18331639df", "General", "b540e779-3ff6-424a-9375-8e9817ceaaa0" },
                    { "17a3e6b3-8e60-40ac-ae33-d9b9d3b23f59", "Gamers", "b540e779-3ff6-424a-9375-8e9817ceaaa0" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "ConversationId", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "d25dcc5b-5017-4b63-b359-1682f7033ac4", "Hello my dear friend, how are you doing?", "60901eff-c237-45ce-9e3a-ffc3d1034a87", new DateTime(2022, 1, 27, 11, 6, 7, 184, DateTimeKind.Local).AddTicks(9536), "b540e779-3ff6-424a-9375-8e9817ceaaa0" },
                    { "703c28ba-ee0a-435c-b617-b5dbd5f3af76", "Hi! I'm doing great, thanks for asking!!", "60901eff-c237-45ce-9e3a-ffc3d1034a87", new DateTime(2022, 1, 27, 14, 6, 7, 184, DateTimeKind.Local).AddTicks(9904), "3b608417-03da-4732-8663-58daa6c8cdd2" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Content", "Subject", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { "d23227c4-b4d7-47c0-91b2-72837a86e7d3", "07504bde-3aed-4f50-a5cb-2bbbf26f96f1", "Thank you so much for reading my first post, it means a lot to me!", "This is my first post (:", new DateTime(2022, 1, 27, 11, 6, 7, 185, DateTimeKind.Local).AddTicks(1885), "b540e779-3ff6-424a-9375-8e9817ceaaa0" },
                    { "d05d1689-fd5e-4d3e-8efd-a774e0017481", "75bf782a-8b12-4d1d-b202-9885db6f0bb0", "Hey so I made my first post today, and this it! It's not much but it's something.", "So I made my first post today..", new DateTime(2022, 1, 29, 0, 6, 7, 185, DateTimeKind.Local).AddTicks(2264), "3b608417-03da-4732-8663-58daa6c8cdd2" }
                });

            migrationBuilder.InsertData(
                table: "SubForums",
                columns: new[] { "Id", "Description", "ForumId", "Name", "OwnerId" },
                values: new object[,]
                {
                    { "1417e5fd-40fc-4c1d-a457-8297e6501a4a", "SubForum about the game League of Legends", "e47efd52-80c7-49db-ae21-46e466cd9eb4", "League of Legends", "b540e779-3ff6-424a-9375-8e9817ceaaa0" },
                    { "d0936709-f91a-436d-b66b-4bfa1e5fd239", "All programming related to the C# language and it's frameworks", "a88553b7-594c-4f29-987c-25f960b8939c", "C#", "b540e779-3ff6-424a-9375-8e9817ceaaa0" },
                    { "211096a2-29f1-40ee-9e03-a8e5255ceb55", "Everything about Minecraft", "e47efd52-80c7-49db-ae21-46e466cd9eb4", "Minecraft", "b540e779-3ff6-424a-9375-8e9817ceaaa0" }
                });

            migrationBuilder.InsertData(
                table: "UserConversations",
                columns: new[] { "UserId", "ConversationId" },
                values: new object[,]
                {
                    { "b540e779-3ff6-424a-9375-8e9817ceaaa0", "60901eff-c237-45ce-9e3a-ffc3d1034a87" },
                    { "3b608417-03da-4732-8663-58daa6c8cdd2", "60901eff-c237-45ce-9e3a-ffc3d1034a87" }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { "d23227c4-b4d7-47c0-91b2-72837a86e7d3", "87911303-4163-4bc8-baf7-8e8b7bc37b9e" },
                    { "d23227c4-b4d7-47c0-91b2-72837a86e7d3", "7909d965-9aea-4551-ae07-8e933e94de47" },
                    { "d05d1689-fd5e-4d3e-8efd-a774e0017481", "87911303-4163-4bc8-baf7-8e8b7bc37b9e" },
                    { "d05d1689-fd5e-4d3e-8efd-a774e0017481", "cfb2e951-4e31-46f9-afbe-0586a7407e43" }
                });

            migrationBuilder.InsertData(
                table: "SubForumGroups",
                columns: new[] { "GroupId", "SubForumId" },
                values: new object[,]
                {
                    { "f1a6fa7a-4e85-47fc-84dc-f7cc96346df5", "d0936709-f91a-436d-b66b-4bfa1e5fd239" },
                    { "17a3e6b3-8e60-40ac-ae33-d9b9d3b23f59", "1417e5fd-40fc-4c1d-a457-8297e6501a4a" },
                    { "17a3e6b3-8e60-40ac-ae33-d9b9d3b23f59", "211096a2-29f1-40ee-9e03-a8e5255ceb55" }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "SubForumId", "Subject", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "f0d585d7-a95e-44dc-b495-d2d4cc8faa67", "d0936709-f91a-436d-b66b-4bfa1e5fd239", "How do I print text?", new DateTime(2022, 1, 27, 11, 6, 7, 186, DateTimeKind.Local).AddTicks(804), "b540e779-3ff6-424a-9375-8e9817ceaaa0" },
                    { "2ad3c1d4-a154-49dc-a2c7-8f09365afa30", "1417e5fd-40fc-4c1d-a457-8297e6501a4a", "Why League is the most toxic game", new DateTime(2022, 1, 28, 11, 6, 7, 186, DateTimeKind.Local).AddTicks(1163), "3b608417-03da-4732-8663-58daa6c8cdd2" },
                    { "07e0295c-6d84-4d24-a9b9-8099dc24b300", "211096a2-29f1-40ee-9e03-a8e5255ceb55", "Where to find diamonds?", new DateTime(2022, 1, 27, 17, 6, 7, 186, DateTimeKind.Local).AddTicks(1189), "3b608417-03da-4732-8663-58daa6c8cdd2" }
                });

            migrationBuilder.InsertData(
                table: "UserGroups",
                columns: new[] { "UserId", "GroupId" },
                values: new object[,]
                {
                    { "b540e779-3ff6-424a-9375-8e9817ceaaa0", "17a3e6b3-8e60-40ac-ae33-d9b9d3b23f59" },
                    { "3b608417-03da-4732-8663-58daa6c8cdd2", "17a3e6b3-8e60-40ac-ae33-d9b9d3b23f59" },
                    { "b540e779-3ff6-424a-9375-8e9817ceaaa0", "f1a6fa7a-4e85-47fc-84dc-f7cc96346df5" },
                    { "3b608417-03da-4732-8663-58daa6c8cdd2", "f1a6fa7a-4e85-47fc-84dc-f7cc96346df5" }
                });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "Id", "Content", "ThreadId", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "9062bc29-b7b3-4dad-9c6a-31665b4230da", "I've been trying really long to figure how to print text but I just get errors plz help", "f0d585d7-a95e-44dc-b495-d2d4cc8faa67", new DateTime(2022, 1, 27, 11, 6, 7, 186, DateTimeKind.Local).AddTicks(3066), "b540e779-3ff6-424a-9375-8e9817ceaaa0" },
                    { "33cd0dab-8017-44d0-bde6-0f7724850c24", "Use google.", "f0d585d7-a95e-44dc-b495-d2d4cc8faa67", new DateTime(2022, 1, 27, 16, 6, 7, 186, DateTimeKind.Local).AddTicks(3464), "3b608417-03da-4732-8663-58daa6c8cdd2" },
                    { "a84d9a19-1842-44ef-b20a-a454d0c60938", "This is the most toxic game ever, everybody is just flaming. I QUIT!!!", "2ad3c1d4-a154-49dc-a2c7-8f09365afa30", new DateTime(2022, 1, 27, 11, 6, 7, 186, DateTimeKind.Local).AddTicks(3486), "3b608417-03da-4732-8663-58daa6c8cdd2" },
                    { "f644f65a-ebda-4a26-aefe-ee797801f623", "lol noob", "2ad3c1d4-a154-49dc-a2c7-8f09365afa30", new DateTime(2022, 1, 27, 15, 6, 7, 186, DateTimeKind.Local).AddTicks(3493), "b540e779-3ff6-424a-9375-8e9817ceaaa0" },
                    { "52b67e0f-7c2d-4a93-a4d1-d723a3f81229", "COME 1V1 ME", "2ad3c1d4-a154-49dc-a2c7-8f09365afa30", new DateTime(2022, 1, 27, 17, 6, 7, 186, DateTimeKind.Local).AddTicks(3499), "3b608417-03da-4732-8663-58daa6c8cdd2" },
                    { "f5e7d33e-2508-4129-b6ec-0524e569e46c", "I can't find diamonds anywhere, it's really hard :(", "07e0295c-6d84-4d24-a9b9-8099dc24b300", new DateTime(2022, 1, 27, 11, 6, 7, 186, DateTimeKind.Local).AddTicks(3509), "3b608417-03da-4732-8663-58daa6c8cdd2" },
                    { "06c5ddc4-3baa-4859-be98-cbac1a0a0e6e", "I thinks it's below y-level 12 try that! ((:", "07e0295c-6d84-4d24-a9b9-8099dc24b300", new DateTime(2022, 1, 27, 13, 6, 7, 186, DateTimeKind.Local).AddTicks(3516), "3b608417-03da-4732-8663-58daa6c8cdd2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "07504bde-3aed-4f50-a5cb-2bbbf26f96f1", "b540e779-3ff6-424a-9375-8e9817ceaaa0" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "75bf782a-8b12-4d1d-b202-9885db6f0bb0", "3b608417-03da-4732-8663-58daa6c8cdd2" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "75bf782a-8b12-4d1d-b202-9885db6f0bb0", "b540e779-3ff6-424a-9375-8e9817ceaaa0" });

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "7094b713-a852-4718-828b-cd001aeb64b4");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "92be5442-7a84-4d96-8ff0-b8dd80dd2b6e");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "48503736-b8cb-4ac9-be1c-9c18331639df");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "703c28ba-ee0a-435c-b617-b5dbd5f3af76");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "d25dcc5b-5017-4b63-b359-1682f7033ac4");

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "d05d1689-fd5e-4d3e-8efd-a774e0017481", "87911303-4163-4bc8-baf7-8e8b7bc37b9e" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "d05d1689-fd5e-4d3e-8efd-a774e0017481", "cfb2e951-4e31-46f9-afbe-0586a7407e43" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "d23227c4-b4d7-47c0-91b2-72837a86e7d3", "7909d965-9aea-4551-ae07-8e933e94de47" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "d23227c4-b4d7-47c0-91b2-72837a86e7d3", "87911303-4163-4bc8-baf7-8e8b7bc37b9e" });

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "06c5ddc4-3baa-4859-be98-cbac1a0a0e6e");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "33cd0dab-8017-44d0-bde6-0f7724850c24");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "52b67e0f-7c2d-4a93-a4d1-d723a3f81229");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "9062bc29-b7b3-4dad-9c6a-31665b4230da");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "a84d9a19-1842-44ef-b20a-a454d0c60938");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "f5e7d33e-2508-4129-b6ec-0524e569e46c");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "f644f65a-ebda-4a26-aefe-ee797801f623");

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "17a3e6b3-8e60-40ac-ae33-d9b9d3b23f59", "1417e5fd-40fc-4c1d-a457-8297e6501a4a" });

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "17a3e6b3-8e60-40ac-ae33-d9b9d3b23f59", "211096a2-29f1-40ee-9e03-a8e5255ceb55" });

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "f1a6fa7a-4e85-47fc-84dc-f7cc96346df5", "d0936709-f91a-436d-b66b-4bfa1e5fd239" });

            migrationBuilder.DeleteData(
                table: "UserConversations",
                keyColumns: new[] { "UserId", "ConversationId" },
                keyValues: new object[] { "3b608417-03da-4732-8663-58daa6c8cdd2", "60901eff-c237-45ce-9e3a-ffc3d1034a87" });

            migrationBuilder.DeleteData(
                table: "UserConversations",
                keyColumns: new[] { "UserId", "ConversationId" },
                keyValues: new object[] { "b540e779-3ff6-424a-9375-8e9817ceaaa0", "60901eff-c237-45ce-9e3a-ffc3d1034a87" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "3b608417-03da-4732-8663-58daa6c8cdd2", "17a3e6b3-8e60-40ac-ae33-d9b9d3b23f59" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "3b608417-03da-4732-8663-58daa6c8cdd2", "f1a6fa7a-4e85-47fc-84dc-f7cc96346df5" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "b540e779-3ff6-424a-9375-8e9817ceaaa0", "17a3e6b3-8e60-40ac-ae33-d9b9d3b23f59" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "b540e779-3ff6-424a-9375-8e9817ceaaa0", "f1a6fa7a-4e85-47fc-84dc-f7cc96346df5" });

            migrationBuilder.DeleteData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: "60901eff-c237-45ce-9e3a-ffc3d1034a87");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "17a3e6b3-8e60-40ac-ae33-d9b9d3b23f59");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "f1a6fa7a-4e85-47fc-84dc-f7cc96346df5");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "d05d1689-fd5e-4d3e-8efd-a774e0017481");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "d23227c4-b4d7-47c0-91b2-72837a86e7d3");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "7909d965-9aea-4551-ae07-8e933e94de47");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "87911303-4163-4bc8-baf7-8e8b7bc37b9e");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "cfb2e951-4e31-46f9-afbe-0586a7407e43");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "07e0295c-6d84-4d24-a9b9-8099dc24b300");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "2ad3c1d4-a154-49dc-a2c7-8f09365afa30");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "f0d585d7-a95e-44dc-b495-d2d4cc8faa67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b608417-03da-4732-8663-58daa6c8cdd2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b540e779-3ff6-424a-9375-8e9817ceaaa0");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "07504bde-3aed-4f50-a5cb-2bbbf26f96f1");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "75bf782a-8b12-4d1d-b202-9885db6f0bb0");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "1417e5fd-40fc-4c1d-a457-8297e6501a4a");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "211096a2-29f1-40ee-9e03-a8e5255ceb55");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "d0936709-f91a-436d-b66b-4bfa1e5fd239");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: "a88553b7-594c-4f29-987c-25f960b8939c");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: "e47efd52-80c7-49db-ae21-46e466cd9eb4");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "SubForums");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageURL", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "725c5431-6bf5-42bb-a968-060403ad2e0b", 0, "495b10ab-1a66-40ab-84e1-585473f1ecff", "seeduser@gmail.com", false, "https://i.pravatar.cc/100?img=2", false, null, "SEEDUSER@GMAIL.COM", "SEEDUSER", "AQAAAAEAACcQAAAAEJx4NMU1U0Yidyo3fta787ySojva/MbPbPBViFZMIniNczDbmmT1WfxSCeu2mKRWGg==", null, false, "ad353b61-378e-41d2-8040-c8dda1b1c6a4", false, "SeedUser" },
                    { "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91", 0, "2f517e54-0791-40c3-bd22-03103d8773b1", "seeduser2@gmail.com", false, "https://i.pravatar.cc/100?img=4", false, null, "SEEDUSER2@GMAIL.COM", "SEEDUSER2", "AQAAAAEAACcQAAAAEEUBK29vwdj/ZFt3KeSzhBAJzDgEOJpZ+S7ByXQ5OUcvSx28ng7117kOlYsLEv78fw==", null, false, "131cd0ee-7ccc-4327-9b95-8754dffbc55d", false, "SeedUser2" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "cf3d3d49-5b35-4fba-a077-a11de76bf1e3", "Gaming" },
                    { "3922f6f9-6613-4b53-a74e-852a9d82d9a3", "Health & Safety" }
                });

            migrationBuilder.InsertData(
                table: "Conversations",
                columns: new[] { "Id", "Subject" },
                values: new object[] { "a530f177-5f06-4572-bb1a-991bbade2fd8", "A cool conversation between seeded users" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "c300c635-dbc3-48ba-8958-01eab50d29ee", "Programming" },
                    { "9b3b754b-25df-4338-ba5a-e9cf7da3d101", "Gaming" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "7c72e7f2-5e55-4b28-9883-9d67158aba72", "First Post" },
                    { "9ac533d5-60b0-4793-81ef-1d827fa36e4e", "Informative" },
                    { "d78b1bbf-770a-4b6f-acdf-f3c3f7d24cfe", "Casual" }
                });

            migrationBuilder.InsertData(
                table: "CategorySubscribers",
                columns: new[] { "CategoryId", "UserId" },
                values: new object[,]
                {
                    { "3922f6f9-6613-4b53-a74e-852a9d82d9a3", "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91" },
                    { "3922f6f9-6613-4b53-a74e-852a9d82d9a3", "725c5431-6bf5-42bb-a968-060403ad2e0b" },
                    { "cf3d3d49-5b35-4fba-a077-a11de76bf1e3", "725c5431-6bf5-42bb-a968-060403ad2e0b" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Content", "StartDate", "Subject", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { "cbabcda8-9697-4cbf-a630-df0370dd6450", "We will be meeting in the town centre on the specified date.", new DateTime(2022, 1, 27, 11, 55, 35, 769, DateTimeKind.Local).AddTicks(1692), "Meeting in town centre", new DateTime(2022, 1, 24, 11, 55, 35, 767, DateTimeKind.Local).AddTicks(1342), "725c5431-6bf5-42bb-a968-060403ad2e0b" },
                    { "cb8eef8f-0d4d-46b2-94a8-588e0ad6851c", "We will begin a riot on Walmart on the second street", new DateTime(2022, 2, 3, 11, 55, 35, 769, DateTimeKind.Local).AddTicks(2147), "Riot at Walmart", new DateTime(2022, 1, 24, 11, 55, 35, 769, DateTimeKind.Local).AddTicks(2128), "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name", "OwnerId" },
                values: new object[,]
                {
                    { "53a802aa-6e59-4f1d-9d79-24a7a0a01c05", "Programmers", "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91" },
                    { "0d64271b-64af-42b5-b1e7-8237f3c67421", "General", "725c5431-6bf5-42bb-a968-060403ad2e0b" },
                    { "c8579023-b05c-40f0-97d5-5c462dd87d2c", "Gamers", "725c5431-6bf5-42bb-a968-060403ad2e0b" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "ConversationId", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "a0bb40c7-f95e-4545-805e-bf279bbdc7b7", "Hello my dear friend, how are you doing?", "a530f177-5f06-4572-bb1a-991bbade2fd8", new DateTime(2022, 1, 24, 11, 55, 35, 769, DateTimeKind.Local).AddTicks(6857), "725c5431-6bf5-42bb-a968-060403ad2e0b" },
                    { "704cc157-92fe-4314-a59c-974e100131c4", "Hi! I'm doing great, thanks for asking!!", "a530f177-5f06-4572-bb1a-991bbade2fd8", new DateTime(2022, 1, 24, 14, 55, 35, 769, DateTimeKind.Local).AddTicks(7240), "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Content", "Subject", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { "64509879-7b93-48a0-884a-afdb26c53a18", "cf3d3d49-5b35-4fba-a077-a11de76bf1e3", "Thank you so much for reading my first post, it means a lot to me!", "This is my first post (:", new DateTime(2022, 1, 24, 11, 55, 35, 769, DateTimeKind.Local).AddTicks(9271), "725c5431-6bf5-42bb-a968-060403ad2e0b" },
                    { "9beaff8b-1c8e-43ac-944f-e23283176e4c", "3922f6f9-6613-4b53-a74e-852a9d82d9a3", "Hey so I made my first post today, and this it! It's not much but it's something.", "So I made my first post today..", new DateTime(2022, 1, 26, 0, 55, 35, 769, DateTimeKind.Local).AddTicks(9641), "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91" }
                });

            migrationBuilder.InsertData(
                table: "SubForums",
                columns: new[] { "Id", "Description", "ForumId", "Name" },
                values: new object[,]
                {
                    { "acb9ae7b-bf09-4da1-92e0-f164ae6da7db", "SubForum about the game League of Legends", "9b3b754b-25df-4338-ba5a-e9cf7da3d101", "League of Legends" },
                    { "549a4035-5392-4b84-b082-b44dd65a9180", "All programming related to the C# language and it's frameworks", "c300c635-dbc3-48ba-8958-01eab50d29ee", "C#" },
                    { "b2859d13-433c-45ab-a12a-b89c60fcdf80", "Everything about Minecraft", "9b3b754b-25df-4338-ba5a-e9cf7da3d101", "Minecraft" }
                });

            migrationBuilder.InsertData(
                table: "UserConversations",
                columns: new[] { "UserId", "ConversationId" },
                values: new object[,]
                {
                    { "725c5431-6bf5-42bb-a968-060403ad2e0b", "a530f177-5f06-4572-bb1a-991bbade2fd8" },
                    { "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91", "a530f177-5f06-4572-bb1a-991bbade2fd8" }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { "64509879-7b93-48a0-884a-afdb26c53a18", "7c72e7f2-5e55-4b28-9883-9d67158aba72" },
                    { "64509879-7b93-48a0-884a-afdb26c53a18", "9ac533d5-60b0-4793-81ef-1d827fa36e4e" },
                    { "9beaff8b-1c8e-43ac-944f-e23283176e4c", "7c72e7f2-5e55-4b28-9883-9d67158aba72" },
                    { "9beaff8b-1c8e-43ac-944f-e23283176e4c", "d78b1bbf-770a-4b6f-acdf-f3c3f7d24cfe" }
                });

            migrationBuilder.InsertData(
                table: "SubForumGroups",
                columns: new[] { "GroupId", "SubForumId" },
                values: new object[,]
                {
                    { "53a802aa-6e59-4f1d-9d79-24a7a0a01c05", "549a4035-5392-4b84-b082-b44dd65a9180" },
                    { "c8579023-b05c-40f0-97d5-5c462dd87d2c", "acb9ae7b-bf09-4da1-92e0-f164ae6da7db" },
                    { "c8579023-b05c-40f0-97d5-5c462dd87d2c", "b2859d13-433c-45ab-a12a-b89c60fcdf80" }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "SubForumId", "Subject", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "78949cce-3c1f-4a37-8c9c-aa422be6b49a", "549a4035-5392-4b84-b082-b44dd65a9180", "How do I print text?", new DateTime(2022, 1, 24, 11, 55, 35, 770, DateTimeKind.Local).AddTicks(7848), "725c5431-6bf5-42bb-a968-060403ad2e0b" },
                    { "cea6a9c3-7a24-4b87-bb77-943787cbd25c", "acb9ae7b-bf09-4da1-92e0-f164ae6da7db", "Why League is the most toxic game", new DateTime(2022, 1, 25, 11, 55, 35, 770, DateTimeKind.Local).AddTicks(8202), "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91" },
                    { "f84b9af1-0d3f-479c-8c68-de766d57d4d6", "b2859d13-433c-45ab-a12a-b89c60fcdf80", "Where to find diamonds?", new DateTime(2022, 1, 24, 17, 55, 35, 770, DateTimeKind.Local).AddTicks(8222), "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91" }
                });

            migrationBuilder.InsertData(
                table: "UserGroups",
                columns: new[] { "UserId", "GroupId" },
                values: new object[,]
                {
                    { "725c5431-6bf5-42bb-a968-060403ad2e0b", "c8579023-b05c-40f0-97d5-5c462dd87d2c" },
                    { "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91", "c8579023-b05c-40f0-97d5-5c462dd87d2c" },
                    { "725c5431-6bf5-42bb-a968-060403ad2e0b", "53a802aa-6e59-4f1d-9d79-24a7a0a01c05" },
                    { "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91", "53a802aa-6e59-4f1d-9d79-24a7a0a01c05" }
                });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "Id", "Content", "ThreadId", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "9a6b7444-86f6-4bcb-86e1-afebe6e51003", "I've been trying really long to figure how to print text but I just get errors plz help", "78949cce-3c1f-4a37-8c9c-aa422be6b49a", new DateTime(2022, 1, 24, 11, 55, 35, 771, DateTimeKind.Local).AddTicks(133), "725c5431-6bf5-42bb-a968-060403ad2e0b" },
                    { "47c90354-0922-4fcf-951f-ee2641e7f2db", "Use google.", "78949cce-3c1f-4a37-8c9c-aa422be6b49a", new DateTime(2022, 1, 24, 16, 55, 35, 771, DateTimeKind.Local).AddTicks(505), "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91" },
                    { "27993cee-c5ab-4f6c-886d-e7bb68d23d6e", "This is the most toxic game ever, everybody is just flaming. I QUIT!!!", "cea6a9c3-7a24-4b87-bb77-943787cbd25c", new DateTime(2022, 1, 24, 11, 55, 35, 771, DateTimeKind.Local).AddTicks(527), "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91" },
                    { "e85fc14c-5502-48f9-8cd4-109180cc1432", "lol noob", "cea6a9c3-7a24-4b87-bb77-943787cbd25c", new DateTime(2022, 1, 24, 15, 55, 35, 771, DateTimeKind.Local).AddTicks(534), "725c5431-6bf5-42bb-a968-060403ad2e0b" },
                    { "0a0cecc1-7d3d-44d7-9abf-eee43ace7cb9", "COME 1V1 ME", "cea6a9c3-7a24-4b87-bb77-943787cbd25c", new DateTime(2022, 1, 24, 17, 55, 35, 771, DateTimeKind.Local).AddTicks(540), "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91" },
                    { "cd0f31c0-2168-45d5-ac21-db26721e50c5", "I can't find diamonds anywhere, it's really hard :(", "f84b9af1-0d3f-479c-8c68-de766d57d4d6", new DateTime(2022, 1, 24, 11, 55, 35, 771, DateTimeKind.Local).AddTicks(554), "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91" },
                    { "6729f8fb-c5a4-4438-9ec3-61758365d71a", "I thinks it's below y-level 12 try that! ((:", "f84b9af1-0d3f-479c-8c68-de766d57d4d6", new DateTime(2022, 1, 24, 13, 55, 35, 771, DateTimeKind.Local).AddTicks(560), "4ecaf5ab-ad8b-467e-acf2-8343d4a02b91" }
                });
        }
    }
}
