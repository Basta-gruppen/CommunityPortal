using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPortal.Migrations
{
    public partial class AddReplyQuoteId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "QuoteId",
                table: "Replies",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "QuoteId",
                table: "Replies");

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
    }
}
