using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPortal.Migrations
{
    public partial class AddedAdminAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "c4e83028-14b3-48f7-8aaf-12401d74014e", "01a32623-8082-4788-a4a7-9b73a730d5bb" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "cf3836b5-4520-4a3a-9851-13f132f53c78", "01a32623-8082-4788-a4a7-9b73a730d5bb" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "cf3836b5-4520-4a3a-9851-13f132f53c78", "236be921-b65f-46fe-b230-8ee29b693a92" });

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "bf589935-33c0-449d-8cf2-f61318fe1666");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "f1fbb65f-1036-4a59-b5e5-33534bc2cd2d");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "cef34078-3f72-49b1-b091-1557f4b8e7a3");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "45347ab9-d2fd-41ff-bc36-c363d951983f");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "65a9f376-7ca4-4901-8954-9fbc2e57be7f");

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "80ff963c-aab2-4d59-ac28-b85b2a9df37f", "64a0ff13-4e7a-444c-90e3-1a98b8d46909" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "80ff963c-aab2-4d59-ac28-b85b2a9df37f", "a829d159-438b-45bd-89dd-5668a5b8f8d6" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "e16cd3ac-e293-4711-a69b-98121ef867e1", "056765f1-0603-4c62-83b5-b757bfceeee8" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "e16cd3ac-e293-4711-a69b-98121ef867e1", "a829d159-438b-45bd-89dd-5668a5b8f8d6" });

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "5cf80d8f-19ca-480c-9a09-eef25205ff1a");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "6b8f4642-2048-4bde-9df6-a0efe0176223");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "6f81f5f3-0052-4d7c-a15b-dcc3fd73e6f2");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "73f79481-0491-4d8b-8765-f89def1c801c");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "9fab24d2-f273-4e00-8481-e8575d5fe127");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "b0a3fe22-517b-4186-89de-0030c502fa31");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "fd47352f-1725-4d40-9f8d-1e9a6c3e2847");

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "b2694a4d-9fef-48d5-a6b1-f1e9f4ba8a75", "9c2ab6ef-f0ec-467a-93d6-431506bf477b" });

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "eba6eb00-34ac-48e2-9e63-054dcfddb1fa", "3b7d4676-8cd4-4503-8663-ff6a9425fb78" });

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "eba6eb00-34ac-48e2-9e63-054dcfddb1fa", "8d4e0fe5-bcde-47ab-bb5e-a795776c94ce" });

            migrationBuilder.DeleteData(
                table: "UserConversations",
                keyColumns: new[] { "UserId", "ConversationId" },
                keyValues: new object[] { "01a32623-8082-4788-a4a7-9b73a730d5bb", "29ffa4c2-9bb4-4b8c-98ea-30099a7c1d89" });

            migrationBuilder.DeleteData(
                table: "UserConversations",
                keyColumns: new[] { "UserId", "ConversationId" },
                keyValues: new object[] { "236be921-b65f-46fe-b230-8ee29b693a92", "29ffa4c2-9bb4-4b8c-98ea-30099a7c1d89" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "01a32623-8082-4788-a4a7-9b73a730d5bb", "b2694a4d-9fef-48d5-a6b1-f1e9f4ba8a75" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "01a32623-8082-4788-a4a7-9b73a730d5bb", "eba6eb00-34ac-48e2-9e63-054dcfddb1fa" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "236be921-b65f-46fe-b230-8ee29b693a92", "b2694a4d-9fef-48d5-a6b1-f1e9f4ba8a75" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "236be921-b65f-46fe-b230-8ee29b693a92", "eba6eb00-34ac-48e2-9e63-054dcfddb1fa" });

            migrationBuilder.DeleteData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: "29ffa4c2-9bb4-4b8c-98ea-30099a7c1d89");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "b2694a4d-9fef-48d5-a6b1-f1e9f4ba8a75");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "eba6eb00-34ac-48e2-9e63-054dcfddb1fa");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "80ff963c-aab2-4d59-ac28-b85b2a9df37f");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "e16cd3ac-e293-4711-a69b-98121ef867e1");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "056765f1-0603-4c62-83b5-b757bfceeee8");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "64a0ff13-4e7a-444c-90e3-1a98b8d46909");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "a829d159-438b-45bd-89dd-5668a5b8f8d6");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "325afe2b-5f2a-4823-ba46-c4a3b3d53a8a");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "54cca2d8-5bfc-4fa5-b73f-37c03a4c3ecc");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "ba838924-f7c9-49f2-9bd9-b97e4b6b6bbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01a32623-8082-4788-a4a7-9b73a730d5bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "236be921-b65f-46fe-b230-8ee29b693a92");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "c4e83028-14b3-48f7-8aaf-12401d74014e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "cf3836b5-4520-4a3a-9851-13f132f53c78");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "3b7d4676-8cd4-4503-8663-ff6a9425fb78");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "8d4e0fe5-bcde-47ab-bb5e-a795776c94ce");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "9c2ab6ef-f0ec-467a-93d6-431506bf477b");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: "ab35ae61-d958-4f58-b4c1-319973c4b30d");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: "f190b974-fed7-4fa2-8e9c-4d25263ee14f");

            migrationBuilder.AlterColumn<string>(
                name: "QuoteId",
                table: "Replies",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c8ec449b-90b2-4f4e-8bcd-54f5f89c8ffa", "52f0cb42-646d-4b38-8fc3-415791315cca", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageURL", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "098503ec-109a-4d37-b9e7-4d8f3c84159d", 0, "976b70cc-94e2-42d5-ba3c-5d58bb7cb7a4", "admin@admin.com", false, null, false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEHuvykjwTdBLI9nuuqLEwoMXYqSYTieJh+mkcvaChkna4mzjNr25gfKrMhCr/76zug==", null, false, "0bef2660-2b44-4143-ab6a-789cac7f9d67", false, "Admin" },
                    { "19ed66aa-0fb1-42bd-a442-4985bb001d77", 0, "8a5aa7ab-3e49-4656-a291-b9bf0a2b7cf1", "seeduser@gmail.com", false, "https://i.pravatar.cc/100?img=2", false, null, "SEEDUSER@GMAIL.COM", "SEEDUSER", "AQAAAAEAACcQAAAAECzEhOz7sZwNkS/21fQ0p9KGheIxHhXwn9FeweU9+H8ve73gRGbWmAVLM6q0F4idsg==", null, false, "5b3aea39-955a-4ecf-ab2d-c8b9b6362c81", false, "SeedUser" },
                    { "f5d89a9e-c88d-4821-a036-0ec05b565b8f", 0, "041f0512-3d26-40da-9ccb-7a07e805bfcb", "seeduser2@gmail.com", false, "https://i.pravatar.cc/100?img=4", false, null, "SEEDUSER2@GMAIL.COM", "SEEDUSER2", "AQAAAAEAACcQAAAAEC1UVYD5frmOs3mumuT4giHB5mRmfpws1o7Xda2lgbdS/67T8ks3BjvYc5muweOUuw==", null, false, "e1840632-a542-4bc8-b5ce-3019cb0c975e", false, "SeedUser2" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "566ee0dd-bcf1-4f8b-b75c-df0b910d1e21", "Gaming" },
                    { "16de1972-b89c-46dd-9651-74a9afeba990", "Health & Safety" }
                });

            migrationBuilder.InsertData(
                table: "Conversations",
                columns: new[] { "Id", "Subject" },
                values: new object[] { "ae2eab92-c2e2-4adb-bbd0-bb3ac4bb4c3a", "A cool conversation between seeded users" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "fb5a714e-3d96-433a-8e30-7f7e24ac9974", "Programming" },
                    { "ee192e32-4f8b-4788-a892-338aa14095c3", "Gaming" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "fae1bc3f-eae9-4291-8249-ca7f5ae02f44", "First Post" },
                    { "8a442e4c-ba34-4ac3-9d5d-166310128dec", "Informative" },
                    { "78fe6256-ebce-4165-8eb9-1b50b55f4fb6", "Casual" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "098503ec-109a-4d37-b9e7-4d8f3c84159d", "c8ec449b-90b2-4f4e-8bcd-54f5f89c8ffa" });

            migrationBuilder.InsertData(
                table: "CategorySubscribers",
                columns: new[] { "CategoryId", "UserId" },
                values: new object[,]
                {
                    { "16de1972-b89c-46dd-9651-74a9afeba990", "19ed66aa-0fb1-42bd-a442-4985bb001d77" },
                    { "566ee0dd-bcf1-4f8b-b75c-df0b910d1e21", "19ed66aa-0fb1-42bd-a442-4985bb001d77" },
                    { "16de1972-b89c-46dd-9651-74a9afeba990", "f5d89a9e-c88d-4821-a036-0ec05b565b8f" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Content", "StartDate", "Subject", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { "cfed2bdf-1e5b-436b-842e-d37888eeb6be", "We will begin a riot on Walmart on the second street", new DateTime(2022, 2, 11, 18, 31, 36, 163, DateTimeKind.Local).AddTicks(2019), "Riot at Walmart", new DateTime(2022, 2, 1, 18, 31, 36, 163, DateTimeKind.Local).AddTicks(2000), "f5d89a9e-c88d-4821-a036-0ec05b565b8f" },
                    { "983503e8-4b8f-47f2-a8a2-04b380eda2e0", "We will be meeting in the town centre on the specified date.", new DateTime(2022, 2, 4, 18, 31, 36, 163, DateTimeKind.Local).AddTicks(1524), "Meeting in town centre", new DateTime(2022, 2, 1, 18, 31, 36, 160, DateTimeKind.Local).AddTicks(8803), "19ed66aa-0fb1-42bd-a442-4985bb001d77" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name", "OwnerId" },
                values: new object[,]
                {
                    { "6869c3f4-af50-400e-9c5f-d04c6bc0a307", "Programmers", "f5d89a9e-c88d-4821-a036-0ec05b565b8f" },
                    { "1ac41ae7-00ec-49d6-92e9-177893a3f5e9", "General", "19ed66aa-0fb1-42bd-a442-4985bb001d77" },
                    { "4acf3fd3-872c-493f-a8fa-d38330d2428a", "Gamers", "19ed66aa-0fb1-42bd-a442-4985bb001d77" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "ConversationId", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "5ee9cb21-1b34-448f-9d12-4e4a0c2d5176", "Hello my dear friend, how are you doing?", "ae2eab92-c2e2-4adb-bbd0-bb3ac4bb4c3a", new DateTime(2022, 2, 1, 18, 31, 36, 163, DateTimeKind.Local).AddTicks(7286), "19ed66aa-0fb1-42bd-a442-4985bb001d77" },
                    { "a39ddb77-e54c-4ea2-9188-ce7333317713", "Hi! I'm doing great, thanks for asking!!", "ae2eab92-c2e2-4adb-bbd0-bb3ac4bb4c3a", new DateTime(2022, 2, 1, 21, 31, 36, 163, DateTimeKind.Local).AddTicks(7664), "f5d89a9e-c88d-4821-a036-0ec05b565b8f" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Content", "Subject", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { "325109a0-6c70-4397-91b6-52c10af1ab53", "566ee0dd-bcf1-4f8b-b75c-df0b910d1e21", "Thank you so much for reading my first post, it means a lot to me!", "This is my first post (:", new DateTime(2022, 2, 1, 18, 31, 36, 163, DateTimeKind.Local).AddTicks(9637), "19ed66aa-0fb1-42bd-a442-4985bb001d77" },
                    { "d9217d90-0303-4d5f-bf77-dc2140b28c91", "16de1972-b89c-46dd-9651-74a9afeba990", "Hey so I made my first post today, and this it! It's not much but it's something.", "So I made my first post today..", new DateTime(2022, 2, 1, 18, 31, 36, 164, DateTimeKind.Local).AddTicks(21), "f5d89a9e-c88d-4821-a036-0ec05b565b8f" }
                });

            migrationBuilder.InsertData(
                table: "SubForums",
                columns: new[] { "Id", "Description", "ForumId", "Name", "OwnerId" },
                values: new object[,]
                {
                    { "96a75232-8a1e-4529-b8ef-d35c42c9d14d", "Everything about Minecraft", "ee192e32-4f8b-4788-a892-338aa14095c3", "Minecraft", "19ed66aa-0fb1-42bd-a442-4985bb001d77" },
                    { "9ab7b6ec-cfec-435b-ba62-7704d2f29e89", "All programming related to the C# language and it's frameworks", "fb5a714e-3d96-433a-8e30-7f7e24ac9974", "C#", "19ed66aa-0fb1-42bd-a442-4985bb001d77" },
                    { "b0b983ed-f54e-48c8-9036-eb3662de2eee", "SubForum about the game League of Legends", "ee192e32-4f8b-4788-a892-338aa14095c3", "League of Legends", "19ed66aa-0fb1-42bd-a442-4985bb001d77" }
                });

            migrationBuilder.InsertData(
                table: "UserConversations",
                columns: new[] { "UserId", "ConversationId" },
                values: new object[,]
                {
                    { "19ed66aa-0fb1-42bd-a442-4985bb001d77", "ae2eab92-c2e2-4adb-bbd0-bb3ac4bb4c3a" },
                    { "f5d89a9e-c88d-4821-a036-0ec05b565b8f", "ae2eab92-c2e2-4adb-bbd0-bb3ac4bb4c3a" }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { "325109a0-6c70-4397-91b6-52c10af1ab53", "fae1bc3f-eae9-4291-8249-ca7f5ae02f44" },
                    { "325109a0-6c70-4397-91b6-52c10af1ab53", "8a442e4c-ba34-4ac3-9d5d-166310128dec" },
                    { "d9217d90-0303-4d5f-bf77-dc2140b28c91", "fae1bc3f-eae9-4291-8249-ca7f5ae02f44" },
                    { "d9217d90-0303-4d5f-bf77-dc2140b28c91", "78fe6256-ebce-4165-8eb9-1b50b55f4fb6" }
                });

            migrationBuilder.InsertData(
                table: "SubForumGroups",
                columns: new[] { "GroupId", "SubForumId" },
                values: new object[,]
                {
                    { "6869c3f4-af50-400e-9c5f-d04c6bc0a307", "9ab7b6ec-cfec-435b-ba62-7704d2f29e89" },
                    { "4acf3fd3-872c-493f-a8fa-d38330d2428a", "b0b983ed-f54e-48c8-9036-eb3662de2eee" },
                    { "4acf3fd3-872c-493f-a8fa-d38330d2428a", "96a75232-8a1e-4529-b8ef-d35c42c9d14d" }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "SubForumId", "Subject", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "7f3da049-b83c-4565-9de4-5dd2a5d9400a", "9ab7b6ec-cfec-435b-ba62-7704d2f29e89", "How do I print text?", new DateTime(2022, 2, 1, 18, 31, 36, 164, DateTimeKind.Local).AddTicks(8684), "19ed66aa-0fb1-42bd-a442-4985bb001d77" },
                    { "504763e7-2d27-42d0-b6c3-16625cb3acc6", "b0b983ed-f54e-48c8-9036-eb3662de2eee", "Why League is the most toxic game", new DateTime(2022, 2, 2, 18, 31, 36, 164, DateTimeKind.Local).AddTicks(9054), "f5d89a9e-c88d-4821-a036-0ec05b565b8f" },
                    { "205d8072-38fa-4c6d-acee-2f0ad1799bb2", "96a75232-8a1e-4529-b8ef-d35c42c9d14d", "Where to find diamonds?", new DateTime(2022, 2, 2, 0, 31, 36, 164, DateTimeKind.Local).AddTicks(9077), "f5d89a9e-c88d-4821-a036-0ec05b565b8f" }
                });

            migrationBuilder.InsertData(
                table: "UserGroups",
                columns: new[] { "UserId", "GroupId" },
                values: new object[,]
                {
                    { "19ed66aa-0fb1-42bd-a442-4985bb001d77", "4acf3fd3-872c-493f-a8fa-d38330d2428a" },
                    { "f5d89a9e-c88d-4821-a036-0ec05b565b8f", "4acf3fd3-872c-493f-a8fa-d38330d2428a" },
                    { "19ed66aa-0fb1-42bd-a442-4985bb001d77", "6869c3f4-af50-400e-9c5f-d04c6bc0a307" },
                    { "f5d89a9e-c88d-4821-a036-0ec05b565b8f", "6869c3f4-af50-400e-9c5f-d04c6bc0a307" }
                });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "Id", "Content", "QuoteId", "ThreadId", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "3188d726-7a40-4f83-970b-7fc0553d023c", "I've been trying really long to figure how to print text but I just get errors plz help", null, "7f3da049-b83c-4565-9de4-5dd2a5d9400a", new DateTime(2022, 2, 1, 18, 31, 36, 165, DateTimeKind.Local).AddTicks(1031), "19ed66aa-0fb1-42bd-a442-4985bb001d77" },
                    { "fd7841a8-bfc8-4d44-a439-50c0f9cb5009", "Use google.", null, "7f3da049-b83c-4565-9de4-5dd2a5d9400a", new DateTime(2022, 2, 1, 23, 31, 36, 165, DateTimeKind.Local).AddTicks(1405), "f5d89a9e-c88d-4821-a036-0ec05b565b8f" },
                    { "6add5138-345c-45cc-aad5-03767b6365cc", "This is the most toxic game ever, everybody is just flaming. I QUIT!!!", null, "504763e7-2d27-42d0-b6c3-16625cb3acc6", new DateTime(2022, 2, 1, 18, 31, 36, 165, DateTimeKind.Local).AddTicks(1427), "f5d89a9e-c88d-4821-a036-0ec05b565b8f" },
                    { "c393453f-a2d4-40d9-b2d3-e27651be4760", "lol noob", null, "504763e7-2d27-42d0-b6c3-16625cb3acc6", new DateTime(2022, 2, 1, 22, 31, 36, 165, DateTimeKind.Local).AddTicks(1434), "19ed66aa-0fb1-42bd-a442-4985bb001d77" },
                    { "289bf0f7-33b1-4eb0-9fc0-bd2a0765a1b1", "COME 1V1 ME", null, "504763e7-2d27-42d0-b6c3-16625cb3acc6", new DateTime(2022, 2, 2, 0, 31, 36, 165, DateTimeKind.Local).AddTicks(1441), "f5d89a9e-c88d-4821-a036-0ec05b565b8f" },
                    { "cce6bb46-50cf-4730-ba90-43ba601160fa", "I can't find diamonds anywhere, it's really hard :(", null, "205d8072-38fa-4c6d-acee-2f0ad1799bb2", new DateTime(2022, 2, 1, 18, 31, 36, 165, DateTimeKind.Local).AddTicks(1455), "f5d89a9e-c88d-4821-a036-0ec05b565b8f" },
                    { "ae46805c-2837-49eb-8a7c-ab8ddf305575", "I thinks it's below y-level 12 try that! ((:", null, "205d8072-38fa-4c6d-acee-2f0ad1799bb2", new DateTime(2022, 2, 1, 20, 31, 36, 165, DateTimeKind.Local).AddTicks(1462), "f5d89a9e-c88d-4821-a036-0ec05b565b8f" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Replies_QuoteId",
                table: "Replies",
                column: "QuoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_Replies_QuoteId",
                table: "Replies",
                column: "QuoteId",
                principalTable: "Replies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Replies_Replies_QuoteId",
                table: "Replies");

            migrationBuilder.DropIndex(
                name: "IX_Replies_QuoteId",
                table: "Replies");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "098503ec-109a-4d37-b9e7-4d8f3c84159d", "c8ec449b-90b2-4f4e-8bcd-54f5f89c8ffa" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "16de1972-b89c-46dd-9651-74a9afeba990", "19ed66aa-0fb1-42bd-a442-4985bb001d77" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "16de1972-b89c-46dd-9651-74a9afeba990", "f5d89a9e-c88d-4821-a036-0ec05b565b8f" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "566ee0dd-bcf1-4f8b-b75c-df0b910d1e21", "19ed66aa-0fb1-42bd-a442-4985bb001d77" });

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "983503e8-4b8f-47f2-a8a2-04b380eda2e0");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "cfed2bdf-1e5b-436b-842e-d37888eeb6be");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "1ac41ae7-00ec-49d6-92e9-177893a3f5e9");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "5ee9cb21-1b34-448f-9d12-4e4a0c2d5176");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "a39ddb77-e54c-4ea2-9188-ce7333317713");

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "325109a0-6c70-4397-91b6-52c10af1ab53", "8a442e4c-ba34-4ac3-9d5d-166310128dec" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "325109a0-6c70-4397-91b6-52c10af1ab53", "fae1bc3f-eae9-4291-8249-ca7f5ae02f44" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "d9217d90-0303-4d5f-bf77-dc2140b28c91", "78fe6256-ebce-4165-8eb9-1b50b55f4fb6" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "d9217d90-0303-4d5f-bf77-dc2140b28c91", "fae1bc3f-eae9-4291-8249-ca7f5ae02f44" });

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "289bf0f7-33b1-4eb0-9fc0-bd2a0765a1b1");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "3188d726-7a40-4f83-970b-7fc0553d023c");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "6add5138-345c-45cc-aad5-03767b6365cc");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "ae46805c-2837-49eb-8a7c-ab8ddf305575");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "c393453f-a2d4-40d9-b2d3-e27651be4760");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "cce6bb46-50cf-4730-ba90-43ba601160fa");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "fd7841a8-bfc8-4d44-a439-50c0f9cb5009");

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "4acf3fd3-872c-493f-a8fa-d38330d2428a", "96a75232-8a1e-4529-b8ef-d35c42c9d14d" });

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "4acf3fd3-872c-493f-a8fa-d38330d2428a", "b0b983ed-f54e-48c8-9036-eb3662de2eee" });

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "6869c3f4-af50-400e-9c5f-d04c6bc0a307", "9ab7b6ec-cfec-435b-ba62-7704d2f29e89" });

            migrationBuilder.DeleteData(
                table: "UserConversations",
                keyColumns: new[] { "UserId", "ConversationId" },
                keyValues: new object[] { "19ed66aa-0fb1-42bd-a442-4985bb001d77", "ae2eab92-c2e2-4adb-bbd0-bb3ac4bb4c3a" });

            migrationBuilder.DeleteData(
                table: "UserConversations",
                keyColumns: new[] { "UserId", "ConversationId" },
                keyValues: new object[] { "f5d89a9e-c88d-4821-a036-0ec05b565b8f", "ae2eab92-c2e2-4adb-bbd0-bb3ac4bb4c3a" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "19ed66aa-0fb1-42bd-a442-4985bb001d77", "4acf3fd3-872c-493f-a8fa-d38330d2428a" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "19ed66aa-0fb1-42bd-a442-4985bb001d77", "6869c3f4-af50-400e-9c5f-d04c6bc0a307" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "f5d89a9e-c88d-4821-a036-0ec05b565b8f", "4acf3fd3-872c-493f-a8fa-d38330d2428a" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "f5d89a9e-c88d-4821-a036-0ec05b565b8f", "6869c3f4-af50-400e-9c5f-d04c6bc0a307" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8ec449b-90b2-4f4e-8bcd-54f5f89c8ffa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "098503ec-109a-4d37-b9e7-4d8f3c84159d");

            migrationBuilder.DeleteData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: "ae2eab92-c2e2-4adb-bbd0-bb3ac4bb4c3a");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "4acf3fd3-872c-493f-a8fa-d38330d2428a");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "6869c3f4-af50-400e-9c5f-d04c6bc0a307");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "325109a0-6c70-4397-91b6-52c10af1ab53");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "d9217d90-0303-4d5f-bf77-dc2140b28c91");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "78fe6256-ebce-4165-8eb9-1b50b55f4fb6");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "8a442e4c-ba34-4ac3-9d5d-166310128dec");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "fae1bc3f-eae9-4291-8249-ca7f5ae02f44");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "205d8072-38fa-4c6d-acee-2f0ad1799bb2");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "504763e7-2d27-42d0-b6c3-16625cb3acc6");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "7f3da049-b83c-4565-9de4-5dd2a5d9400a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19ed66aa-0fb1-42bd-a442-4985bb001d77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5d89a9e-c88d-4821-a036-0ec05b565b8f");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "16de1972-b89c-46dd-9651-74a9afeba990");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "566ee0dd-bcf1-4f8b-b75c-df0b910d1e21");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "96a75232-8a1e-4529-b8ef-d35c42c9d14d");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "9ab7b6ec-cfec-435b-ba62-7704d2f29e89");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "b0b983ed-f54e-48c8-9036-eb3662de2eee");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: "ee192e32-4f8b-4788-a892-338aa14095c3");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: "fb5a714e-3d96-433a-8e30-7f7e24ac9974");

            migrationBuilder.AlterColumn<string>(
                name: "QuoteId",
                table: "Replies",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageURL", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "01a32623-8082-4788-a4a7-9b73a730d5bb", 0, "9861ba36-ae02-4e88-82ad-477bfa91e2be", "seeduser@gmail.com", false, "https://i.pravatar.cc/100?img=2", false, null, "SEEDUSER@GMAIL.COM", "SEEDUSER", "AQAAAAEAACcQAAAAELfUx0LfM4y03OGuRARNQRLznODXV8z3CXITvRUnQwQFxhUygceLfpgRiPEhiMhkNg==", null, false, "e3dd9edc-4183-42dd-a136-bf55b88a4f72", false, "SeedUser" },
                    { "236be921-b65f-46fe-b230-8ee29b693a92", 0, "2419ddf3-3be0-4925-8566-3239497b197a", "seeduser2@gmail.com", false, "https://i.pravatar.cc/100?img=4", false, null, "SEEDUSER2@GMAIL.COM", "SEEDUSER2", "AQAAAAEAACcQAAAAEM2LFhRLrASeYf1TXhpoNcNUfbA6roB6eLr80g4t7dcsRIMalVPkpVbfEMYpFfc4Pw==", null, false, "01e3ae59-605d-49db-9454-9ed78da73397", false, "SeedUser2" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "c4e83028-14b3-48f7-8aaf-12401d74014e", "Gaming" },
                    { "cf3836b5-4520-4a3a-9851-13f132f53c78", "Health & Safety" }
                });

            migrationBuilder.InsertData(
                table: "Conversations",
                columns: new[] { "Id", "Subject" },
                values: new object[] { "29ffa4c2-9bb4-4b8c-98ea-30099a7c1d89", "A cool conversation between seeded users" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "f190b974-fed7-4fa2-8e9c-4d25263ee14f", "Programming" },
                    { "ab35ae61-d958-4f58-b4c1-319973c4b30d", "Gaming" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "a829d159-438b-45bd-89dd-5668a5b8f8d6", "First Post" },
                    { "056765f1-0603-4c62-83b5-b757bfceeee8", "Informative" },
                    { "64a0ff13-4e7a-444c-90e3-1a98b8d46909", "Casual" }
                });

            migrationBuilder.InsertData(
                table: "CategorySubscribers",
                columns: new[] { "CategoryId", "UserId" },
                values: new object[,]
                {
                    { "cf3836b5-4520-4a3a-9851-13f132f53c78", "236be921-b65f-46fe-b230-8ee29b693a92" },
                    { "cf3836b5-4520-4a3a-9851-13f132f53c78", "01a32623-8082-4788-a4a7-9b73a730d5bb" },
                    { "c4e83028-14b3-48f7-8aaf-12401d74014e", "01a32623-8082-4788-a4a7-9b73a730d5bb" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Content", "StartDate", "Subject", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { "f1fbb65f-1036-4a59-b5e5-33534bc2cd2d", "We will be meeting in the town centre on the specified date.", new DateTime(2022, 2, 4, 8, 58, 47, 16, DateTimeKind.Local).AddTicks(4093), "Meeting in town centre", new DateTime(2022, 2, 1, 8, 58, 47, 14, DateTimeKind.Local).AddTicks(2588), "01a32623-8082-4788-a4a7-9b73a730d5bb" },
                    { "bf589935-33c0-449d-8cf2-f61318fe1666", "We will begin a riot on Walmart on the second street", new DateTime(2022, 2, 11, 8, 58, 47, 16, DateTimeKind.Local).AddTicks(4572), "Riot at Walmart", new DateTime(2022, 2, 1, 8, 58, 47, 16, DateTimeKind.Local).AddTicks(4553), "236be921-b65f-46fe-b230-8ee29b693a92" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name", "OwnerId" },
                values: new object[,]
                {
                    { "b2694a4d-9fef-48d5-a6b1-f1e9f4ba8a75", "Programmers", "236be921-b65f-46fe-b230-8ee29b693a92" },
                    { "cef34078-3f72-49b1-b091-1557f4b8e7a3", "General", "01a32623-8082-4788-a4a7-9b73a730d5bb" },
                    { "eba6eb00-34ac-48e2-9e63-054dcfddb1fa", "Gamers", "01a32623-8082-4788-a4a7-9b73a730d5bb" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "ConversationId", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "65a9f376-7ca4-4901-8954-9fbc2e57be7f", "Hello my dear friend, how are you doing?", "29ffa4c2-9bb4-4b8c-98ea-30099a7c1d89", new DateTime(2022, 2, 1, 8, 58, 47, 16, DateTimeKind.Local).AddTicks(9499), "01a32623-8082-4788-a4a7-9b73a730d5bb" },
                    { "45347ab9-d2fd-41ff-bc36-c363d951983f", "Hi! I'm doing great, thanks for asking!!", "29ffa4c2-9bb4-4b8c-98ea-30099a7c1d89", new DateTime(2022, 2, 1, 11, 58, 47, 16, DateTimeKind.Local).AddTicks(9872), "236be921-b65f-46fe-b230-8ee29b693a92" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Content", "Subject", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { "e16cd3ac-e293-4711-a69b-98121ef867e1", "c4e83028-14b3-48f7-8aaf-12401d74014e", "Thank you so much for reading my first post, it means a lot to me!", "This is my first post (:", new DateTime(2022, 2, 1, 8, 58, 47, 17, DateTimeKind.Local).AddTicks(1811), "01a32623-8082-4788-a4a7-9b73a730d5bb" },
                    { "80ff963c-aab2-4d59-ac28-b85b2a9df37f", "cf3836b5-4520-4a3a-9851-13f132f53c78", "Hey so I made my first post today, and this it! It's not much but it's something.", "So I made my first post today..", new DateTime(2022, 2, 2, 21, 58, 47, 17, DateTimeKind.Local).AddTicks(2189), "236be921-b65f-46fe-b230-8ee29b693a92" }
                });

            migrationBuilder.InsertData(
                table: "SubForums",
                columns: new[] { "Id", "Description", "ForumId", "Name", "OwnerId" },
                values: new object[,]
                {
                    { "3b7d4676-8cd4-4503-8663-ff6a9425fb78", "SubForum about the game League of Legends", "ab35ae61-d958-4f58-b4c1-319973c4b30d", "League of Legends", "01a32623-8082-4788-a4a7-9b73a730d5bb" },
                    { "9c2ab6ef-f0ec-467a-93d6-431506bf477b", "All programming related to the C# language and it's frameworks", "f190b974-fed7-4fa2-8e9c-4d25263ee14f", "C#", "01a32623-8082-4788-a4a7-9b73a730d5bb" },
                    { "8d4e0fe5-bcde-47ab-bb5e-a795776c94ce", "Everything about Minecraft", "ab35ae61-d958-4f58-b4c1-319973c4b30d", "Minecraft", "01a32623-8082-4788-a4a7-9b73a730d5bb" }
                });

            migrationBuilder.InsertData(
                table: "UserConversations",
                columns: new[] { "UserId", "ConversationId" },
                values: new object[,]
                {
                    { "01a32623-8082-4788-a4a7-9b73a730d5bb", "29ffa4c2-9bb4-4b8c-98ea-30099a7c1d89" },
                    { "236be921-b65f-46fe-b230-8ee29b693a92", "29ffa4c2-9bb4-4b8c-98ea-30099a7c1d89" }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { "e16cd3ac-e293-4711-a69b-98121ef867e1", "a829d159-438b-45bd-89dd-5668a5b8f8d6" },
                    { "e16cd3ac-e293-4711-a69b-98121ef867e1", "056765f1-0603-4c62-83b5-b757bfceeee8" },
                    { "80ff963c-aab2-4d59-ac28-b85b2a9df37f", "a829d159-438b-45bd-89dd-5668a5b8f8d6" },
                    { "80ff963c-aab2-4d59-ac28-b85b2a9df37f", "64a0ff13-4e7a-444c-90e3-1a98b8d46909" }
                });

            migrationBuilder.InsertData(
                table: "SubForumGroups",
                columns: new[] { "GroupId", "SubForumId" },
                values: new object[,]
                {
                    { "b2694a4d-9fef-48d5-a6b1-f1e9f4ba8a75", "9c2ab6ef-f0ec-467a-93d6-431506bf477b" },
                    { "eba6eb00-34ac-48e2-9e63-054dcfddb1fa", "3b7d4676-8cd4-4503-8663-ff6a9425fb78" },
                    { "eba6eb00-34ac-48e2-9e63-054dcfddb1fa", "8d4e0fe5-bcde-47ab-bb5e-a795776c94ce" }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "SubForumId", "Subject", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "325afe2b-5f2a-4823-ba46-c4a3b3d53a8a", "9c2ab6ef-f0ec-467a-93d6-431506bf477b", "How do I print text?", new DateTime(2022, 2, 1, 8, 58, 47, 18, DateTimeKind.Local).AddTicks(710), "01a32623-8082-4788-a4a7-9b73a730d5bb" },
                    { "54cca2d8-5bfc-4fa5-b73f-37c03a4c3ecc", "3b7d4676-8cd4-4503-8663-ff6a9425fb78", "Why League is the most toxic game", new DateTime(2022, 2, 2, 8, 58, 47, 18, DateTimeKind.Local).AddTicks(1069), "236be921-b65f-46fe-b230-8ee29b693a92" },
                    { "ba838924-f7c9-49f2-9bd9-b97e4b6b6bbf", "8d4e0fe5-bcde-47ab-bb5e-a795776c94ce", "Where to find diamonds?", new DateTime(2022, 2, 1, 14, 58, 47, 18, DateTimeKind.Local).AddTicks(1130), "236be921-b65f-46fe-b230-8ee29b693a92" }
                });

            migrationBuilder.InsertData(
                table: "UserGroups",
                columns: new[] { "UserId", "GroupId" },
                values: new object[,]
                {
                    { "01a32623-8082-4788-a4a7-9b73a730d5bb", "eba6eb00-34ac-48e2-9e63-054dcfddb1fa" },
                    { "236be921-b65f-46fe-b230-8ee29b693a92", "eba6eb00-34ac-48e2-9e63-054dcfddb1fa" },
                    { "01a32623-8082-4788-a4a7-9b73a730d5bb", "b2694a4d-9fef-48d5-a6b1-f1e9f4ba8a75" },
                    { "236be921-b65f-46fe-b230-8ee29b693a92", "b2694a4d-9fef-48d5-a6b1-f1e9f4ba8a75" }
                });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "Id", "Content", "QuoteId", "ThreadId", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "fd47352f-1725-4d40-9f8d-1e9a6c3e2847", "I've been trying really long to figure how to print text but I just get errors plz help", null, "325afe2b-5f2a-4823-ba46-c4a3b3d53a8a", new DateTime(2022, 2, 1, 8, 58, 47, 18, DateTimeKind.Local).AddTicks(3102), "01a32623-8082-4788-a4a7-9b73a730d5bb" },
                    { "73f79481-0491-4d8b-8765-f89def1c801c", "Use google.", null, "325afe2b-5f2a-4823-ba46-c4a3b3d53a8a", new DateTime(2022, 2, 1, 13, 58, 47, 18, DateTimeKind.Local).AddTicks(3473), "236be921-b65f-46fe-b230-8ee29b693a92" },
                    { "6b8f4642-2048-4bde-9df6-a0efe0176223", "This is the most toxic game ever, everybody is just flaming. I QUIT!!!", null, "54cca2d8-5bfc-4fa5-b73f-37c03a4c3ecc", new DateTime(2022, 2, 1, 8, 58, 47, 18, DateTimeKind.Local).AddTicks(3496), "236be921-b65f-46fe-b230-8ee29b693a92" },
                    { "6f81f5f3-0052-4d7c-a15b-dcc3fd73e6f2", "lol noob", null, "54cca2d8-5bfc-4fa5-b73f-37c03a4c3ecc", new DateTime(2022, 2, 1, 12, 58, 47, 18, DateTimeKind.Local).AddTicks(3503), "01a32623-8082-4788-a4a7-9b73a730d5bb" },
                    { "5cf80d8f-19ca-480c-9a09-eef25205ff1a", "COME 1V1 ME", null, "54cca2d8-5bfc-4fa5-b73f-37c03a4c3ecc", new DateTime(2022, 2, 1, 14, 58, 47, 18, DateTimeKind.Local).AddTicks(3510), "236be921-b65f-46fe-b230-8ee29b693a92" },
                    { "b0a3fe22-517b-4186-89de-0030c502fa31", "I can't find diamonds anywhere, it's really hard :(", null, "ba838924-f7c9-49f2-9bd9-b97e4b6b6bbf", new DateTime(2022, 2, 1, 8, 58, 47, 18, DateTimeKind.Local).AddTicks(3520), "236be921-b65f-46fe-b230-8ee29b693a92" },
                    { "9fab24d2-f273-4e00-8481-e8575d5fe127", "I thinks it's below y-level 12 try that! ((:", null, "ba838924-f7c9-49f2-9bd9-b97e4b6b6bbf", new DateTime(2022, 2, 1, 10, 58, 47, 18, DateTimeKind.Local).AddTicks(3527), "236be921-b65f-46fe-b230-8ee29b693a92" }
                });
        }
    }
}
