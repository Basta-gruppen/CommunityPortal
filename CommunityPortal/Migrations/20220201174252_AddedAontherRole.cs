using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPortal.Migrations
{
    public partial class AddedAontherRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ec4f0751-2622-44cf-b65d-eb11d06bcabe", "aca4dac8-c2d5-417b-8a4a-c5322e089d36", "Admin", "ADMIN" },
                    { "f1951b40-476c-4a7e-abec-2c66b0498ecd", "647c6ae2-3e71-4867-99ca-531d68144fbc", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageURL", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7d480373-51c9-4460-b92e-b586663313f9", 0, "9de54a28-1589-4ac0-8b30-eb690f1e8896", "admin@admin.com", false, null, false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEMvY+tUE6IBQsdybvXcYDPMRcHDzPOjCQOpbZOtDPpIUlFcEotbMUXQoKu8+llHFLw==", null, false, "2ab28ec0-c2a4-4143-bf00-3521de95804a", false, "Admin" },
                    { "384dba04-c496-4295-9349-c0b2cd1999e7", 0, "a424bcd2-1f2d-478e-b670-0fd91a0bf1cb", "seeduser@gmail.com", false, "https://i.pravatar.cc/100?img=2", false, null, "SEEDUSER@GMAIL.COM", "SEEDUSER", "AQAAAAEAACcQAAAAEPA1BAIHYZe9U3i3bntt6+xWuvMvS45OmKtaYJMlVfNe4tIncKcTNwfGd45JRNccgA==", null, false, "98bba1ba-b559-4672-9798-58be9f514be2", false, "SeedUser" },
                    { "5633e885-95e2-4644-aeb4-f745ffdbde11", 0, "72d04d32-9418-4d42-8c64-aab40ee876ca", "seeduser2@gmail.com", false, "https://i.pravatar.cc/100?img=4", false, null, "SEEDUSER2@GMAIL.COM", "SEEDUSER2", "AQAAAAEAACcQAAAAEBKZU/VzMrn8dKm0VQ3m8t3GjDPFYLgq3sKKhMnF6zO7vW2pOEgOXfa1hyy+Cz0m5Q==", null, false, "b35a4450-e0f9-40a9-9d6b-8ac894fdfb98", false, "SeedUser2" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "bb334afe-83d4-4581-94df-2d0525538aae", "Gaming" },
                    { "6f6f4edd-ffa4-4162-8d60-f691f543f525", "Health & Safety" }
                });

            migrationBuilder.InsertData(
                table: "Conversations",
                columns: new[] { "Id", "Subject" },
                values: new object[] { "3eb24adf-a022-42f2-92b4-346b3ca06331", "A cool conversation between seeded users" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "4d9152fa-3900-42b8-8d06-13513a1d1411", "Programming" },
                    { "bacae451-46cf-4b55-9b90-33f40a7e9410", "Gaming" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "2d4a304a-d4c9-4557-b8d6-ebae44a7f090", "First Post" },
                    { "0bea8d44-34a8-4cf6-a986-c71f62055ced", "Informative" },
                    { "9c000d20-6b61-499b-8d9f-211ebda4a45d", "Casual" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "7d480373-51c9-4460-b92e-b586663313f9", "ec4f0751-2622-44cf-b65d-eb11d06bcabe" });

            migrationBuilder.InsertData(
                table: "CategorySubscribers",
                columns: new[] { "CategoryId", "UserId" },
                values: new object[,]
                {
                    { "6f6f4edd-ffa4-4162-8d60-f691f543f525", "384dba04-c496-4295-9349-c0b2cd1999e7" },
                    { "bb334afe-83d4-4581-94df-2d0525538aae", "384dba04-c496-4295-9349-c0b2cd1999e7" },
                    { "6f6f4edd-ffa4-4162-8d60-f691f543f525", "5633e885-95e2-4644-aeb4-f745ffdbde11" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Content", "StartDate", "Subject", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { "a768494f-6be7-439f-9b2b-2107b2591b37", "We will begin a riot on Walmart on the second street", new DateTime(2022, 2, 11, 18, 42, 52, 98, DateTimeKind.Local).AddTicks(2030), "Riot at Walmart", new DateTime(2022, 2, 1, 18, 42, 52, 98, DateTimeKind.Local).AddTicks(2009), "5633e885-95e2-4644-aeb4-f745ffdbde11" },
                    { "f745604d-b2d3-46cb-bb63-caa49e5c34e3", "We will be meeting in the town centre on the specified date.", new DateTime(2022, 2, 4, 18, 42, 52, 98, DateTimeKind.Local).AddTicks(1578), "Meeting in town centre", new DateTime(2022, 2, 1, 18, 42, 52, 96, DateTimeKind.Local).AddTicks(236), "384dba04-c496-4295-9349-c0b2cd1999e7" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name", "OwnerId" },
                values: new object[,]
                {
                    { "2376472b-45bd-45f6-9e4f-ba9d731c9e97", "Programmers", "5633e885-95e2-4644-aeb4-f745ffdbde11" },
                    { "a1004d2f-1214-47a1-b149-8e0ecf210446", "General", "384dba04-c496-4295-9349-c0b2cd1999e7" },
                    { "0d076863-405d-4f02-9952-b728e5888254", "Gamers", "384dba04-c496-4295-9349-c0b2cd1999e7" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "ConversationId", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "35d88bd8-bd5b-41ef-98e5-64dc36d9e82c", "Hello my dear friend, how are you doing?", "3eb24adf-a022-42f2-92b4-346b3ca06331", new DateTime(2022, 2, 1, 18, 42, 52, 98, DateTimeKind.Local).AddTicks(6350), "384dba04-c496-4295-9349-c0b2cd1999e7" },
                    { "3da8676b-af01-4821-b93d-baf9eab66dc8", "Hi! I'm doing great, thanks for asking!!", "3eb24adf-a022-42f2-92b4-346b3ca06331", new DateTime(2022, 2, 1, 21, 42, 52, 98, DateTimeKind.Local).AddTicks(6678), "5633e885-95e2-4644-aeb4-f745ffdbde11" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Content", "Subject", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { "423f7313-d83f-47ba-9ce0-29b69583742e", "bb334afe-83d4-4581-94df-2d0525538aae", "Thank you so much for reading my first post, it means a lot to me!", "This is my first post (:", new DateTime(2022, 2, 1, 18, 42, 52, 98, DateTimeKind.Local).AddTicks(8251), "384dba04-c496-4295-9349-c0b2cd1999e7" },
                    { "d02f67bf-35bf-4be7-9146-0891a4c2e3bb", "6f6f4edd-ffa4-4162-8d60-f691f543f525", "Hey so I made my first post today, and this it! It's not much but it's something.", "So I made my first post today..", new DateTime(2022, 2, 1, 18, 42, 52, 98, DateTimeKind.Local).AddTicks(8591), "5633e885-95e2-4644-aeb4-f745ffdbde11" }
                });

            migrationBuilder.InsertData(
                table: "SubForums",
                columns: new[] { "Id", "Description", "ForumId", "Name", "OwnerId" },
                values: new object[,]
                {
                    { "e475f2d3-bb56-4b02-bd76-06d7eb15986f", "Everything about Minecraft", "bacae451-46cf-4b55-9b90-33f40a7e9410", "Minecraft", "384dba04-c496-4295-9349-c0b2cd1999e7" },
                    { "33bd95b2-946c-43ee-b34d-e587c40ebd83", "All programming related to the C# language and it's frameworks", "4d9152fa-3900-42b8-8d06-13513a1d1411", "C#", "384dba04-c496-4295-9349-c0b2cd1999e7" },
                    { "8b4cca06-3b23-453d-90b7-b375e8d905d0", "SubForum about the game League of Legends", "bacae451-46cf-4b55-9b90-33f40a7e9410", "League of Legends", "384dba04-c496-4295-9349-c0b2cd1999e7" }
                });

            migrationBuilder.InsertData(
                table: "UserConversations",
                columns: new[] { "UserId", "ConversationId" },
                values: new object[,]
                {
                    { "384dba04-c496-4295-9349-c0b2cd1999e7", "3eb24adf-a022-42f2-92b4-346b3ca06331" },
                    { "5633e885-95e2-4644-aeb4-f745ffdbde11", "3eb24adf-a022-42f2-92b4-346b3ca06331" }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { "423f7313-d83f-47ba-9ce0-29b69583742e", "2d4a304a-d4c9-4557-b8d6-ebae44a7f090" },
                    { "423f7313-d83f-47ba-9ce0-29b69583742e", "0bea8d44-34a8-4cf6-a986-c71f62055ced" },
                    { "d02f67bf-35bf-4be7-9146-0891a4c2e3bb", "2d4a304a-d4c9-4557-b8d6-ebae44a7f090" },
                    { "d02f67bf-35bf-4be7-9146-0891a4c2e3bb", "9c000d20-6b61-499b-8d9f-211ebda4a45d" }
                });

            migrationBuilder.InsertData(
                table: "SubForumGroups",
                columns: new[] { "GroupId", "SubForumId" },
                values: new object[,]
                {
                    { "2376472b-45bd-45f6-9e4f-ba9d731c9e97", "33bd95b2-946c-43ee-b34d-e587c40ebd83" },
                    { "0d076863-405d-4f02-9952-b728e5888254", "8b4cca06-3b23-453d-90b7-b375e8d905d0" },
                    { "0d076863-405d-4f02-9952-b728e5888254", "e475f2d3-bb56-4b02-bd76-06d7eb15986f" }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "SubForumId", "Subject", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "26ff131d-8aa9-4407-9a56-27f2a60e1519", "33bd95b2-946c-43ee-b34d-e587c40ebd83", "How do I print text?", new DateTime(2022, 2, 1, 18, 42, 52, 99, DateTimeKind.Local).AddTicks(5571), "384dba04-c496-4295-9349-c0b2cd1999e7" },
                    { "599e309a-9658-42cf-b588-6d84bf2d78f4", "8b4cca06-3b23-453d-90b7-b375e8d905d0", "Why League is the most toxic game", new DateTime(2022, 2, 2, 18, 42, 52, 99, DateTimeKind.Local).AddTicks(5889), "5633e885-95e2-4644-aeb4-f745ffdbde11" },
                    { "b26ae145-c7ef-4337-9b3e-dbf8fbcef1e4", "e475f2d3-bb56-4b02-bd76-06d7eb15986f", "Where to find diamonds?", new DateTime(2022, 2, 2, 0, 42, 52, 99, DateTimeKind.Local).AddTicks(5914), "5633e885-95e2-4644-aeb4-f745ffdbde11" }
                });

            migrationBuilder.InsertData(
                table: "UserGroups",
                columns: new[] { "UserId", "GroupId" },
                values: new object[,]
                {
                    { "384dba04-c496-4295-9349-c0b2cd1999e7", "0d076863-405d-4f02-9952-b728e5888254" },
                    { "5633e885-95e2-4644-aeb4-f745ffdbde11", "0d076863-405d-4f02-9952-b728e5888254" },
                    { "384dba04-c496-4295-9349-c0b2cd1999e7", "2376472b-45bd-45f6-9e4f-ba9d731c9e97" },
                    { "5633e885-95e2-4644-aeb4-f745ffdbde11", "2376472b-45bd-45f6-9e4f-ba9d731c9e97" }
                });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "Id", "Content", "QuoteId", "ThreadId", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "4775103d-66cc-4a1a-a413-d4ed6139d4f8", "I've been trying really long to figure how to print text but I just get errors plz help", null, "26ff131d-8aa9-4407-9a56-27f2a60e1519", new DateTime(2022, 2, 1, 18, 42, 52, 99, DateTimeKind.Local).AddTicks(7509), "384dba04-c496-4295-9349-c0b2cd1999e7" },
                    { "19cc3150-a271-42af-a676-18defbaa8e41", "Use google.", null, "26ff131d-8aa9-4407-9a56-27f2a60e1519", new DateTime(2022, 2, 1, 23, 42, 52, 99, DateTimeKind.Local).AddTicks(7826), "5633e885-95e2-4644-aeb4-f745ffdbde11" },
                    { "8710ab85-ef32-4d61-a05e-21a8c2ca0d9e", "This is the most toxic game ever, everybody is just flaming. I QUIT!!!", null, "599e309a-9658-42cf-b588-6d84bf2d78f4", new DateTime(2022, 2, 1, 18, 42, 52, 99, DateTimeKind.Local).AddTicks(7847), "5633e885-95e2-4644-aeb4-f745ffdbde11" },
                    { "dee605a7-1b25-4e72-b231-df1aea1743c9", "lol noob", null, "599e309a-9658-42cf-b588-6d84bf2d78f4", new DateTime(2022, 2, 1, 22, 42, 52, 99, DateTimeKind.Local).AddTicks(7854), "384dba04-c496-4295-9349-c0b2cd1999e7" },
                    { "939dfaa4-c421-4d44-8eec-b4dcbf709807", "COME 1V1 ME", null, "599e309a-9658-42cf-b588-6d84bf2d78f4", new DateTime(2022, 2, 2, 0, 42, 52, 99, DateTimeKind.Local).AddTicks(7860), "5633e885-95e2-4644-aeb4-f745ffdbde11" },
                    { "6099dce2-0c37-4214-91c8-5ea18574b38b", "I can't find diamonds anywhere, it's really hard :(", null, "b26ae145-c7ef-4337-9b3e-dbf8fbcef1e4", new DateTime(2022, 2, 1, 18, 42, 52, 99, DateTimeKind.Local).AddTicks(7869), "5633e885-95e2-4644-aeb4-f745ffdbde11" },
                    { "c2ab7ec2-e8c8-48ad-9f40-893d4f1b708c", "I thinks it's below y-level 12 try that! ((:", null, "b26ae145-c7ef-4337-9b3e-dbf8fbcef1e4", new DateTime(2022, 2, 1, 20, 42, 52, 99, DateTimeKind.Local).AddTicks(7874), "5633e885-95e2-4644-aeb4-f745ffdbde11" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1951b40-476c-4a7e-abec-2c66b0498ecd");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7d480373-51c9-4460-b92e-b586663313f9", "ec4f0751-2622-44cf-b65d-eb11d06bcabe" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "6f6f4edd-ffa4-4162-8d60-f691f543f525", "384dba04-c496-4295-9349-c0b2cd1999e7" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "6f6f4edd-ffa4-4162-8d60-f691f543f525", "5633e885-95e2-4644-aeb4-f745ffdbde11" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "bb334afe-83d4-4581-94df-2d0525538aae", "384dba04-c496-4295-9349-c0b2cd1999e7" });

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "a768494f-6be7-439f-9b2b-2107b2591b37");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "f745604d-b2d3-46cb-bb63-caa49e5c34e3");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "a1004d2f-1214-47a1-b149-8e0ecf210446");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "35d88bd8-bd5b-41ef-98e5-64dc36d9e82c");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "3da8676b-af01-4821-b93d-baf9eab66dc8");

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "423f7313-d83f-47ba-9ce0-29b69583742e", "0bea8d44-34a8-4cf6-a986-c71f62055ced" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "423f7313-d83f-47ba-9ce0-29b69583742e", "2d4a304a-d4c9-4557-b8d6-ebae44a7f090" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "d02f67bf-35bf-4be7-9146-0891a4c2e3bb", "2d4a304a-d4c9-4557-b8d6-ebae44a7f090" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "d02f67bf-35bf-4be7-9146-0891a4c2e3bb", "9c000d20-6b61-499b-8d9f-211ebda4a45d" });

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "19cc3150-a271-42af-a676-18defbaa8e41");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "4775103d-66cc-4a1a-a413-d4ed6139d4f8");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "6099dce2-0c37-4214-91c8-5ea18574b38b");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "8710ab85-ef32-4d61-a05e-21a8c2ca0d9e");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "939dfaa4-c421-4d44-8eec-b4dcbf709807");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "c2ab7ec2-e8c8-48ad-9f40-893d4f1b708c");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "dee605a7-1b25-4e72-b231-df1aea1743c9");

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "0d076863-405d-4f02-9952-b728e5888254", "8b4cca06-3b23-453d-90b7-b375e8d905d0" });

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "0d076863-405d-4f02-9952-b728e5888254", "e475f2d3-bb56-4b02-bd76-06d7eb15986f" });

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "2376472b-45bd-45f6-9e4f-ba9d731c9e97", "33bd95b2-946c-43ee-b34d-e587c40ebd83" });

            migrationBuilder.DeleteData(
                table: "UserConversations",
                keyColumns: new[] { "UserId", "ConversationId" },
                keyValues: new object[] { "384dba04-c496-4295-9349-c0b2cd1999e7", "3eb24adf-a022-42f2-92b4-346b3ca06331" });

            migrationBuilder.DeleteData(
                table: "UserConversations",
                keyColumns: new[] { "UserId", "ConversationId" },
                keyValues: new object[] { "5633e885-95e2-4644-aeb4-f745ffdbde11", "3eb24adf-a022-42f2-92b4-346b3ca06331" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "384dba04-c496-4295-9349-c0b2cd1999e7", "0d076863-405d-4f02-9952-b728e5888254" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "384dba04-c496-4295-9349-c0b2cd1999e7", "2376472b-45bd-45f6-9e4f-ba9d731c9e97" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "5633e885-95e2-4644-aeb4-f745ffdbde11", "0d076863-405d-4f02-9952-b728e5888254" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "5633e885-95e2-4644-aeb4-f745ffdbde11", "2376472b-45bd-45f6-9e4f-ba9d731c9e97" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec4f0751-2622-44cf-b65d-eb11d06bcabe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d480373-51c9-4460-b92e-b586663313f9");

            migrationBuilder.DeleteData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: "3eb24adf-a022-42f2-92b4-346b3ca06331");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "0d076863-405d-4f02-9952-b728e5888254");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "2376472b-45bd-45f6-9e4f-ba9d731c9e97");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "423f7313-d83f-47ba-9ce0-29b69583742e");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "d02f67bf-35bf-4be7-9146-0891a4c2e3bb");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "0bea8d44-34a8-4cf6-a986-c71f62055ced");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "2d4a304a-d4c9-4557-b8d6-ebae44a7f090");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "9c000d20-6b61-499b-8d9f-211ebda4a45d");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "26ff131d-8aa9-4407-9a56-27f2a60e1519");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "599e309a-9658-42cf-b588-6d84bf2d78f4");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "b26ae145-c7ef-4337-9b3e-dbf8fbcef1e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384dba04-c496-4295-9349-c0b2cd1999e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5633e885-95e2-4644-aeb4-f745ffdbde11");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "6f6f4edd-ffa4-4162-8d60-f691f543f525");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "bb334afe-83d4-4581-94df-2d0525538aae");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "33bd95b2-946c-43ee-b34d-e587c40ebd83");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "8b4cca06-3b23-453d-90b7-b375e8d905d0");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "e475f2d3-bb56-4b02-bd76-06d7eb15986f");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: "4d9152fa-3900-42b8-8d06-13513a1d1411");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: "bacae451-46cf-4b55-9b90-33f40a7e9410");

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
        }
    }
}
