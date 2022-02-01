using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPortal.Migrations
{
    public partial class AddedAdminImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { "9d39b344-1ff9-4a3c-b745-86e062bb0faf", "287888dd-1cc0-42e8-863c-bc2507de5c1e", "Admin", "ADMIN" },
                    { "f52267f1-7b3c-48da-915e-238bfda321d9", "516660a2-f28d-486e-b7c0-fa29894acdf1", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageURL", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9d2c7bd9-8d2b-45a5-9e1e-87392d0858bc", 0, "8af89bc0-34c5-4b1f-a5cb-4dd25bc8e85e", "admin@admin.com", false, "/images/default-profile.png", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEGNxbygzYcLLDFF0SipVDyt7kVA2s7jVYlGq0lN/I5PDlrMZYYnwjcAv/XvsNgc1kw==", null, false, "9fcab429-8e2c-460e-ae66-87c3d2cda96c", false, "Admin" },
                    { "e333f603-29f0-4ce7-8dd3-ff89508cef36", 0, "d8c972e6-7ddb-4cf6-bfe5-ba7860d7bb22", "seeduser@gmail.com", false, "https://i.pravatar.cc/100?img=2", false, null, "SEEDUSER@GMAIL.COM", "SEEDUSER", "AQAAAAEAACcQAAAAEICCG+x9O7Bxsw1Ujuaxo50snsQHLIq8wweP9XvJbGJR2YXuMorKmQZAwKwA3kaa6w==", null, false, "ac12274d-b03b-4dab-9304-f50b6f18f25b", false, "SeedUser" },
                    { "927b42b1-635f-46c7-af29-eab7a78f8822", 0, "e2072105-11e4-4844-a07e-df18c78e5ecf", "seeduser2@gmail.com", false, "https://i.pravatar.cc/100?img=4", false, null, "SEEDUSER2@GMAIL.COM", "SEEDUSER2", "AQAAAAEAACcQAAAAEDIpVNODC7KnICfIkaKdEIZt3gT/D2E2qcg9aF/3dDSBQFSpCgkz4q/OHqjQ1yu1vA==", null, false, "0eec2c9f-01f6-4204-a205-8dd74ebc589e", false, "SeedUser2" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "b22003a5-25f0-408c-ac40-bbf13e9322b4", "Gaming" },
                    { "aa8ddfad-98f4-4c57-b630-474c7ba9514e", "Health & Safety" }
                });

            migrationBuilder.InsertData(
                table: "Conversations",
                columns: new[] { "Id", "Subject" },
                values: new object[] { "83c60eda-b7c8-478a-88f4-d790842daf84", "A cool conversation between seeded users" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "e400ac20-8f62-42a9-a150-e676bb21b60f", "Programming" },
                    { "d443af63-669a-463f-b7b7-7561b50dd76e", "Gaming" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "4a646082-b17b-4d80-9f8d-cf79868c2c76", "First Post" },
                    { "d1209528-7da5-428c-8107-7e04429843de", "Informative" },
                    { "822ef3e4-86bf-48df-b041-ca69b7f715dc", "Casual" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "9d2c7bd9-8d2b-45a5-9e1e-87392d0858bc", "9d39b344-1ff9-4a3c-b745-86e062bb0faf" });

            migrationBuilder.InsertData(
                table: "CategorySubscribers",
                columns: new[] { "CategoryId", "UserId" },
                values: new object[,]
                {
                    { "aa8ddfad-98f4-4c57-b630-474c7ba9514e", "e333f603-29f0-4ce7-8dd3-ff89508cef36" },
                    { "b22003a5-25f0-408c-ac40-bbf13e9322b4", "e333f603-29f0-4ce7-8dd3-ff89508cef36" },
                    { "aa8ddfad-98f4-4c57-b630-474c7ba9514e", "927b42b1-635f-46c7-af29-eab7a78f8822" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Content", "StartDate", "Subject", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { "4e2e9201-c457-4d0e-a494-87d708e8c5cc", "We will begin a riot on Walmart on the second street", new DateTime(2022, 2, 11, 20, 34, 22, 508, DateTimeKind.Local).AddTicks(1464), "Riot at Walmart", new DateTime(2022, 2, 1, 20, 34, 22, 508, DateTimeKind.Local).AddTicks(1445), "927b42b1-635f-46c7-af29-eab7a78f8822" },
                    { "f171a852-bd7a-4f79-9a60-5b61d5710d28", "We will be meeting in the town centre on the specified date.", new DateTime(2022, 2, 4, 20, 34, 22, 508, DateTimeKind.Local).AddTicks(952), "Meeting in town centre", new DateTime(2022, 2, 1, 20, 34, 22, 505, DateTimeKind.Local).AddTicks(7764), "e333f603-29f0-4ce7-8dd3-ff89508cef36" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name", "OwnerId" },
                values: new object[,]
                {
                    { "c36b9b16-77b9-40b9-87d8-77c7d1a2d8fb", "Programmers", "927b42b1-635f-46c7-af29-eab7a78f8822" },
                    { "6d2af965-c19e-4165-834f-5b969c62c51f", "General", "e333f603-29f0-4ce7-8dd3-ff89508cef36" },
                    { "81bfe845-ebc9-4ca5-9e56-98652694aca3", "Gamers", "e333f603-29f0-4ce7-8dd3-ff89508cef36" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "ConversationId", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "9b09c258-3c8b-4fcb-9f68-73c2ecec2f15", "Hello my dear friend, how are you doing?", "83c60eda-b7c8-478a-88f4-d790842daf84", new DateTime(2022, 2, 1, 20, 34, 22, 508, DateTimeKind.Local).AddTicks(6872), "e333f603-29f0-4ce7-8dd3-ff89508cef36" },
                    { "1750327f-5d7b-4754-839f-b875b9b7f6dd", "Hi! I'm doing great, thanks for asking!!", "83c60eda-b7c8-478a-88f4-d790842daf84", new DateTime(2022, 2, 1, 23, 34, 22, 508, DateTimeKind.Local).AddTicks(7250), "927b42b1-635f-46c7-af29-eab7a78f8822" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Content", "Subject", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { "de10d3d4-d5e6-4c6c-81d8-b3e8772b6613", "b22003a5-25f0-408c-ac40-bbf13e9322b4", "Thank you so much for reading my first post, it means a lot to me!", "This is my first post (:", new DateTime(2022, 2, 1, 20, 34, 22, 508, DateTimeKind.Local).AddTicks(9378), "e333f603-29f0-4ce7-8dd3-ff89508cef36" },
                    { "1161c54d-2c22-408e-8b60-9f967f76402a", "aa8ddfad-98f4-4c57-b630-474c7ba9514e", "Hey so I made my first post today, and this it! It's not much but it's something.", "So I made my first post today..", new DateTime(2022, 2, 1, 20, 34, 22, 508, DateTimeKind.Local).AddTicks(9784), "927b42b1-635f-46c7-af29-eab7a78f8822" }
                });

            migrationBuilder.InsertData(
                table: "SubForums",
                columns: new[] { "Id", "Description", "ForumId", "Name", "OwnerId" },
                values: new object[,]
                {
                    { "cb73d2d1-d032-49cf-885b-a163f69e655e", "Everything about Minecraft", "d443af63-669a-463f-b7b7-7561b50dd76e", "Minecraft", "e333f603-29f0-4ce7-8dd3-ff89508cef36" },
                    { "68d442d8-08f9-4c89-89ae-700db063f058", "All programming related to the C# language and it's frameworks", "e400ac20-8f62-42a9-a150-e676bb21b60f", "C#", "e333f603-29f0-4ce7-8dd3-ff89508cef36" },
                    { "60186196-f38e-4528-8983-9f2e9c3713fb", "SubForum about the game League of Legends", "d443af63-669a-463f-b7b7-7561b50dd76e", "League of Legends", "e333f603-29f0-4ce7-8dd3-ff89508cef36" }
                });

            migrationBuilder.InsertData(
                table: "UserConversations",
                columns: new[] { "UserId", "ConversationId" },
                values: new object[,]
                {
                    { "e333f603-29f0-4ce7-8dd3-ff89508cef36", "83c60eda-b7c8-478a-88f4-d790842daf84" },
                    { "927b42b1-635f-46c7-af29-eab7a78f8822", "83c60eda-b7c8-478a-88f4-d790842daf84" }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { "de10d3d4-d5e6-4c6c-81d8-b3e8772b6613", "4a646082-b17b-4d80-9f8d-cf79868c2c76" },
                    { "de10d3d4-d5e6-4c6c-81d8-b3e8772b6613", "d1209528-7da5-428c-8107-7e04429843de" },
                    { "1161c54d-2c22-408e-8b60-9f967f76402a", "4a646082-b17b-4d80-9f8d-cf79868c2c76" },
                    { "1161c54d-2c22-408e-8b60-9f967f76402a", "822ef3e4-86bf-48df-b041-ca69b7f715dc" }
                });

            migrationBuilder.InsertData(
                table: "SubForumGroups",
                columns: new[] { "GroupId", "SubForumId" },
                values: new object[,]
                {
                    { "c36b9b16-77b9-40b9-87d8-77c7d1a2d8fb", "68d442d8-08f9-4c89-89ae-700db063f058" },
                    { "81bfe845-ebc9-4ca5-9e56-98652694aca3", "60186196-f38e-4528-8983-9f2e9c3713fb" },
                    { "81bfe845-ebc9-4ca5-9e56-98652694aca3", "cb73d2d1-d032-49cf-885b-a163f69e655e" }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "SubForumId", "Subject", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "25d3e7bf-a4c1-4eff-bb65-02da8ba55688", "68d442d8-08f9-4c89-89ae-700db063f058", "How do I print text?", new DateTime(2022, 2, 1, 20, 34, 22, 509, DateTimeKind.Local).AddTicks(8623), "e333f603-29f0-4ce7-8dd3-ff89508cef36" },
                    { "7dd3645f-ee52-45b8-9f2d-69dd23146485", "60186196-f38e-4528-8983-9f2e9c3713fb", "Why League is the most toxic game", new DateTime(2022, 2, 2, 20, 34, 22, 509, DateTimeKind.Local).AddTicks(9018), "927b42b1-635f-46c7-af29-eab7a78f8822" },
                    { "a3e03e3e-62d1-4134-ac90-4d637e441a30", "cb73d2d1-d032-49cf-885b-a163f69e655e", "Where to find diamonds?", new DateTime(2022, 2, 2, 2, 34, 22, 509, DateTimeKind.Local).AddTicks(9040), "927b42b1-635f-46c7-af29-eab7a78f8822" }
                });

            migrationBuilder.InsertData(
                table: "UserGroups",
                columns: new[] { "UserId", "GroupId" },
                values: new object[,]
                {
                    { "e333f603-29f0-4ce7-8dd3-ff89508cef36", "81bfe845-ebc9-4ca5-9e56-98652694aca3" },
                    { "927b42b1-635f-46c7-af29-eab7a78f8822", "81bfe845-ebc9-4ca5-9e56-98652694aca3" },
                    { "e333f603-29f0-4ce7-8dd3-ff89508cef36", "c36b9b16-77b9-40b9-87d8-77c7d1a2d8fb" },
                    { "927b42b1-635f-46c7-af29-eab7a78f8822", "c36b9b16-77b9-40b9-87d8-77c7d1a2d8fb" }
                });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "Id", "Content", "QuoteId", "ThreadId", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "bb3dc884-36ae-40f9-aa34-458d383bbf73", "I've been trying really long to figure how to print text but I just get errors plz help", null, "25d3e7bf-a4c1-4eff-bb65-02da8ba55688", new DateTime(2022, 2, 1, 20, 34, 22, 510, DateTimeKind.Local).AddTicks(935), "e333f603-29f0-4ce7-8dd3-ff89508cef36" },
                    { "a6b982f0-bb58-4299-9089-f04994bf417e", "Use google.", null, "25d3e7bf-a4c1-4eff-bb65-02da8ba55688", new DateTime(2022, 2, 2, 1, 34, 22, 510, DateTimeKind.Local).AddTicks(1306), "927b42b1-635f-46c7-af29-eab7a78f8822" },
                    { "070f69ba-a818-4516-a7c3-08e3fe9e4d82", "This is the most toxic game ever, everybody is just flaming. I QUIT!!!", null, "7dd3645f-ee52-45b8-9f2d-69dd23146485", new DateTime(2022, 2, 1, 20, 34, 22, 510, DateTimeKind.Local).AddTicks(1327), "927b42b1-635f-46c7-af29-eab7a78f8822" },
                    { "f24830a4-8839-41fd-89c4-58118ebf64e8", "lol noob", null, "7dd3645f-ee52-45b8-9f2d-69dd23146485", new DateTime(2022, 2, 2, 0, 34, 22, 510, DateTimeKind.Local).AddTicks(1334), "e333f603-29f0-4ce7-8dd3-ff89508cef36" },
                    { "f51301f0-38e0-4651-b030-e4558c0b7db1", "COME 1V1 ME", null, "7dd3645f-ee52-45b8-9f2d-69dd23146485", new DateTime(2022, 2, 2, 2, 34, 22, 510, DateTimeKind.Local).AddTicks(1341), "927b42b1-635f-46c7-af29-eab7a78f8822" },
                    { "977fda74-3551-4d3b-92a7-23f257ae5f07", "I can't find diamonds anywhere, it's really hard :(", null, "a3e03e3e-62d1-4134-ac90-4d637e441a30", new DateTime(2022, 2, 1, 20, 34, 22, 510, DateTimeKind.Local).AddTicks(1357), "927b42b1-635f-46c7-af29-eab7a78f8822" },
                    { "b53c59b5-b37c-463a-ae55-fa7f92383cfb", "I thinks it's below y-level 12 try that! ((:", null, "a3e03e3e-62d1-4134-ac90-4d637e441a30", new DateTime(2022, 2, 1, 22, 34, 22, 510, DateTimeKind.Local).AddTicks(1364), "927b42b1-635f-46c7-af29-eab7a78f8822" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f52267f1-7b3c-48da-915e-238bfda321d9");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9d2c7bd9-8d2b-45a5-9e1e-87392d0858bc", "9d39b344-1ff9-4a3c-b745-86e062bb0faf" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "aa8ddfad-98f4-4c57-b630-474c7ba9514e", "927b42b1-635f-46c7-af29-eab7a78f8822" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "aa8ddfad-98f4-4c57-b630-474c7ba9514e", "e333f603-29f0-4ce7-8dd3-ff89508cef36" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "b22003a5-25f0-408c-ac40-bbf13e9322b4", "e333f603-29f0-4ce7-8dd3-ff89508cef36" });

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "4e2e9201-c457-4d0e-a494-87d708e8c5cc");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "f171a852-bd7a-4f79-9a60-5b61d5710d28");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "6d2af965-c19e-4165-834f-5b969c62c51f");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "1750327f-5d7b-4754-839f-b875b9b7f6dd");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "9b09c258-3c8b-4fcb-9f68-73c2ecec2f15");

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "1161c54d-2c22-408e-8b60-9f967f76402a", "4a646082-b17b-4d80-9f8d-cf79868c2c76" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "1161c54d-2c22-408e-8b60-9f967f76402a", "822ef3e4-86bf-48df-b041-ca69b7f715dc" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "de10d3d4-d5e6-4c6c-81d8-b3e8772b6613", "4a646082-b17b-4d80-9f8d-cf79868c2c76" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "de10d3d4-d5e6-4c6c-81d8-b3e8772b6613", "d1209528-7da5-428c-8107-7e04429843de" });

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "070f69ba-a818-4516-a7c3-08e3fe9e4d82");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "977fda74-3551-4d3b-92a7-23f257ae5f07");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "a6b982f0-bb58-4299-9089-f04994bf417e");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "b53c59b5-b37c-463a-ae55-fa7f92383cfb");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "bb3dc884-36ae-40f9-aa34-458d383bbf73");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "f24830a4-8839-41fd-89c4-58118ebf64e8");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "f51301f0-38e0-4651-b030-e4558c0b7db1");

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "81bfe845-ebc9-4ca5-9e56-98652694aca3", "60186196-f38e-4528-8983-9f2e9c3713fb" });

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "81bfe845-ebc9-4ca5-9e56-98652694aca3", "cb73d2d1-d032-49cf-885b-a163f69e655e" });

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "c36b9b16-77b9-40b9-87d8-77c7d1a2d8fb", "68d442d8-08f9-4c89-89ae-700db063f058" });

            migrationBuilder.DeleteData(
                table: "UserConversations",
                keyColumns: new[] { "UserId", "ConversationId" },
                keyValues: new object[] { "927b42b1-635f-46c7-af29-eab7a78f8822", "83c60eda-b7c8-478a-88f4-d790842daf84" });

            migrationBuilder.DeleteData(
                table: "UserConversations",
                keyColumns: new[] { "UserId", "ConversationId" },
                keyValues: new object[] { "e333f603-29f0-4ce7-8dd3-ff89508cef36", "83c60eda-b7c8-478a-88f4-d790842daf84" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "927b42b1-635f-46c7-af29-eab7a78f8822", "81bfe845-ebc9-4ca5-9e56-98652694aca3" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "927b42b1-635f-46c7-af29-eab7a78f8822", "c36b9b16-77b9-40b9-87d8-77c7d1a2d8fb" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "e333f603-29f0-4ce7-8dd3-ff89508cef36", "81bfe845-ebc9-4ca5-9e56-98652694aca3" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "e333f603-29f0-4ce7-8dd3-ff89508cef36", "c36b9b16-77b9-40b9-87d8-77c7d1a2d8fb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d39b344-1ff9-4a3c-b745-86e062bb0faf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d2c7bd9-8d2b-45a5-9e1e-87392d0858bc");

            migrationBuilder.DeleteData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: "83c60eda-b7c8-478a-88f4-d790842daf84");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "81bfe845-ebc9-4ca5-9e56-98652694aca3");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "c36b9b16-77b9-40b9-87d8-77c7d1a2d8fb");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "1161c54d-2c22-408e-8b60-9f967f76402a");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "de10d3d4-d5e6-4c6c-81d8-b3e8772b6613");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "4a646082-b17b-4d80-9f8d-cf79868c2c76");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "822ef3e4-86bf-48df-b041-ca69b7f715dc");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "d1209528-7da5-428c-8107-7e04429843de");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "25d3e7bf-a4c1-4eff-bb65-02da8ba55688");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "7dd3645f-ee52-45b8-9f2d-69dd23146485");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "a3e03e3e-62d1-4134-ac90-4d637e441a30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927b42b1-635f-46c7-af29-eab7a78f8822");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e333f603-29f0-4ce7-8dd3-ff89508cef36");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "aa8ddfad-98f4-4c57-b630-474c7ba9514e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "b22003a5-25f0-408c-ac40-bbf13e9322b4");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "60186196-f38e-4528-8983-9f2e9c3713fb");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "68d442d8-08f9-4c89-89ae-700db063f058");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "cb73d2d1-d032-49cf-885b-a163f69e655e");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: "d443af63-669a-463f-b7b7-7561b50dd76e");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: "e400ac20-8f62-42a9-a150-e676bb21b60f");

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
    }
}
