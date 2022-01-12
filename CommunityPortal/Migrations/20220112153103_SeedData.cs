using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPortal.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageURL", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5bc04d0b-a62e-416b-aa93-d5baa5ecd990", 0, "2c780c8c-f73e-4fb0-9b99-030ce614e7e7", "seeduser@gmail.com", false, "https://i.pravatar.cc/100?img=2", false, null, "SEEDUSER@GMAIL.COM", "SEEDUSER", "AQAAAAEAACcQAAAAELZ0D9z+jWyHVA5/IMhCSIMx6+Xn73GbtbAzra5DywqpVl0Dtn4XdUxmZYaLp9V25g==", null, false, "8249e95b-fa09-4b7b-bab2-fc01794d8ec6", false, "SeedUser" },
                    { "e0a3a264-a986-424e-8a47-724c5d0d693d", 0, "664ad2d4-cabc-4ef0-93cf-d8822359c1f2", "seeduser2@gmail.com", false, "https://i.pravatar.cc/100?img=4", false, null, "SEEDUSER2@GMAIL.COM", "SEEDUSER2", "AQAAAAEAACcQAAAAEBjnIqwJDLMXGnm/AhpU8Q/qurFz6grn6miUHjhW1R2yxT6TBShj8hBBkHIU4iVQaw==", null, false, "59047323-5ff4-4e28-abff-ef7e18b5da19", false, "SeedUser2" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "01dcb37d-5eff-48e8-afd0-3609461f6ea5", "Gaming" },
                    { "47929a0b-2eeb-44ae-8786-f567c5a80e87", "Health & Safety" }
                });

            migrationBuilder.InsertData(
                table: "Conversations",
                columns: new[] { "Id", "Subject" },
                values: new object[] { "34475f28-5d5c-401a-a171-f3eacd1d33a8", "A cool conversation between seeded users" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "bd292718-4b83-4184-ab3c-945d439514cd", "Programming" },
                    { "664d2b4e-336c-40f8-9053-fcc58fbabb62", "Gaming" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "3594104c-a45d-47f4-b75a-6690fa6f469b", "Gamers" },
                    { "ece46808-974c-40f3-ae90-e44245eab2d1", "Programmers" },
                    { "edb84255-9b2e-4924-b807-794ac7392f9a", "General" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "c4ee163c-c001-4a7f-aa52-ad460c0d263b", "First Post" },
                    { "a3b545f4-ec02-49b6-90d6-bdeb18144672", "Informative" },
                    { "67f2678f-a441-42ef-912c-5323a0a06c22", "Casual" }
                });

            migrationBuilder.InsertData(
                table: "CategorySubscribers",
                columns: new[] { "CategoryId", "UserId" },
                values: new object[,]
                {
                    { "01dcb37d-5eff-48e8-afd0-3609461f6ea5", "5bc04d0b-a62e-416b-aa93-d5baa5ecd990" },
                    { "47929a0b-2eeb-44ae-8786-f567c5a80e87", "5bc04d0b-a62e-416b-aa93-d5baa5ecd990" },
                    { "47929a0b-2eeb-44ae-8786-f567c5a80e87", "e0a3a264-a986-424e-8a47-724c5d0d693d" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Content", "StartDate", "Subject", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { "6bbdd8d6-1e74-40dd-97a8-379d5deb5fcf", "We will be meeting in the town centre on the specified date.", new DateTime(2022, 1, 15, 16, 31, 2, 593, DateTimeKind.Local).AddTicks(9116), "Meeting in town centre", new DateTime(2022, 1, 12, 16, 31, 2, 591, DateTimeKind.Local).AddTicks(7073), "5bc04d0b-a62e-416b-aa93-d5baa5ecd990" },
                    { "d0abed98-1a0d-4718-91a9-7f32a8f896a2", "We will begin a riot on Walmart on the second street", new DateTime(2022, 1, 22, 16, 31, 2, 593, DateTimeKind.Local).AddTicks(9572), "Riot at Walmart", new DateTime(2022, 1, 12, 16, 31, 2, 593, DateTimeKind.Local).AddTicks(9554), "e0a3a264-a986-424e-8a47-724c5d0d693d" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "ConversationId", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "a1f4bd4a-bda1-4156-90bc-d0bc6170f4c7", "Hello my dear friend, how are you doing?", "34475f28-5d5c-401a-a171-f3eacd1d33a8", new DateTime(2022, 1, 12, 16, 31, 2, 594, DateTimeKind.Local).AddTicks(4199), "5bc04d0b-a62e-416b-aa93-d5baa5ecd990" },
                    { "7337fc8e-a46f-4875-8f5b-5b3225b8d934", "Hi! I'm doing great, thanks for asking!!", "34475f28-5d5c-401a-a171-f3eacd1d33a8", new DateTime(2022, 1, 12, 19, 31, 2, 594, DateTimeKind.Local).AddTicks(4574), "e0a3a264-a986-424e-8a47-724c5d0d693d" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Content", "Subject", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { "c498f616-934a-4514-afe1-e1ad3e20faf2", "01dcb37d-5eff-48e8-afd0-3609461f6ea5", "Thank you so much for reading my first post, it means a lot to me!", "This is my first post (:", new DateTime(2022, 1, 12, 16, 31, 2, 594, DateTimeKind.Local).AddTicks(6701), "5bc04d0b-a62e-416b-aa93-d5baa5ecd990" },
                    { "d79dad39-f725-4719-9b18-af0e52cb89ef", "47929a0b-2eeb-44ae-8786-f567c5a80e87", "Hey so I made my first post today, and this it! It's not much but it's something.", "So I made my first post today..", new DateTime(2022, 1, 14, 5, 31, 2, 594, DateTimeKind.Local).AddTicks(7092), "e0a3a264-a986-424e-8a47-724c5d0d693d" }
                });

            migrationBuilder.InsertData(
                table: "SubForums",
                columns: new[] { "Id", "Description", "ForumId", "Name" },
                values: new object[,]
                {
                    { "79afe1e3-5e1f-4431-88ea-f7475ac2899d", "All programming related to the C# language and it's frameworks", "bd292718-4b83-4184-ab3c-945d439514cd", "C#" },
                    { "f245c60a-703b-4070-aa29-e0fa5deb8c4c", "SubForum about the game League of Legends", "664d2b4e-336c-40f8-9053-fcc58fbabb62", "League of Legends" },
                    { "4b8f1dc3-f999-4a39-9c29-a671c4cfb5b1", "Everything about Minecraft", "664d2b4e-336c-40f8-9053-fcc58fbabb62", "Minecraft" }
                });

            migrationBuilder.InsertData(
                table: "UserConversations",
                columns: new[] { "UserId", "ConversationId" },
                values: new object[,]
                {
                    { "5bc04d0b-a62e-416b-aa93-d5baa5ecd990", "34475f28-5d5c-401a-a171-f3eacd1d33a8" },
                    { "e0a3a264-a986-424e-8a47-724c5d0d693d", "34475f28-5d5c-401a-a171-f3eacd1d33a8" }
                });

            migrationBuilder.InsertData(
                table: "UserGroups",
                columns: new[] { "UserId", "GroupId" },
                values: new object[,]
                {
                    { "5bc04d0b-a62e-416b-aa93-d5baa5ecd990", "ece46808-974c-40f3-ae90-e44245eab2d1" },
                    { "5bc04d0b-a62e-416b-aa93-d5baa5ecd990", "3594104c-a45d-47f4-b75a-6690fa6f469b" },
                    { "e0a3a264-a986-424e-8a47-724c5d0d693d", "3594104c-a45d-47f4-b75a-6690fa6f469b" },
                    { "e0a3a264-a986-424e-8a47-724c5d0d693d", "ece46808-974c-40f3-ae90-e44245eab2d1" }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { "c498f616-934a-4514-afe1-e1ad3e20faf2", "c4ee163c-c001-4a7f-aa52-ad460c0d263b" },
                    { "c498f616-934a-4514-afe1-e1ad3e20faf2", "a3b545f4-ec02-49b6-90d6-bdeb18144672" },
                    { "d79dad39-f725-4719-9b18-af0e52cb89ef", "c4ee163c-c001-4a7f-aa52-ad460c0d263b" },
                    { "d79dad39-f725-4719-9b18-af0e52cb89ef", "67f2678f-a441-42ef-912c-5323a0a06c22" }
                });

            migrationBuilder.InsertData(
                table: "SubForumGroups",
                columns: new[] { "GroupId", "SubForumId" },
                values: new object[,]
                {
                    { "ece46808-974c-40f3-ae90-e44245eab2d1", "79afe1e3-5e1f-4431-88ea-f7475ac2899d" },
                    { "3594104c-a45d-47f4-b75a-6690fa6f469b", "f245c60a-703b-4070-aa29-e0fa5deb8c4c" },
                    { "3594104c-a45d-47f4-b75a-6690fa6f469b", "4b8f1dc3-f999-4a39-9c29-a671c4cfb5b1" }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "SubForumId", "Subject", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "de438842-e6ba-43c2-a8df-1491d067f1b8", "79afe1e3-5e1f-4431-88ea-f7475ac2899d", "How do I print text?", new DateTime(2022, 1, 12, 16, 31, 2, 595, DateTimeKind.Local).AddTicks(5475), "5bc04d0b-a62e-416b-aa93-d5baa5ecd990" },
                    { "bb0fb979-e9d2-4800-b845-ecebfe6f831f", "f245c60a-703b-4070-aa29-e0fa5deb8c4c", "Why League is the most toxic game", new DateTime(2022, 1, 13, 16, 31, 2, 595, DateTimeKind.Local).AddTicks(5845), "e0a3a264-a986-424e-8a47-724c5d0d693d" },
                    { "aff783e6-b55a-41cb-b9c5-258d75236b6d", "4b8f1dc3-f999-4a39-9c29-a671c4cfb5b1", "Where to find diamonds?", new DateTime(2022, 1, 12, 22, 31, 2, 595, DateTimeKind.Local).AddTicks(5866), "e0a3a264-a986-424e-8a47-724c5d0d693d" }
                });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "Id", "Content", "ThreadId", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "635175e0-310b-417c-bc6b-3529b2785c95", "I've been trying really long to figure how to print text but I just get errors plz help", "de438842-e6ba-43c2-a8df-1491d067f1b8", new DateTime(2022, 1, 12, 16, 31, 2, 595, DateTimeKind.Local).AddTicks(7958), "5bc04d0b-a62e-416b-aa93-d5baa5ecd990" },
                    { "1bda4319-0df3-4eb1-9f37-fd3844bd093d", "Use google.", "de438842-e6ba-43c2-a8df-1491d067f1b8", new DateTime(2022, 1, 12, 21, 31, 2, 595, DateTimeKind.Local).AddTicks(8371), "e0a3a264-a986-424e-8a47-724c5d0d693d" },
                    { "29ab1ada-c16f-44b4-987d-052697ff7fc9", "This is the most toxic game ever, everybody is just flaming. I QUIT!!!", "bb0fb979-e9d2-4800-b845-ecebfe6f831f", new DateTime(2022, 1, 12, 16, 31, 2, 595, DateTimeKind.Local).AddTicks(8396), "e0a3a264-a986-424e-8a47-724c5d0d693d" },
                    { "cb364747-fbd2-4d01-a36b-e500b46ccdd9", "lol noob", "bb0fb979-e9d2-4800-b845-ecebfe6f831f", new DateTime(2022, 1, 12, 20, 31, 2, 595, DateTimeKind.Local).AddTicks(8403), "5bc04d0b-a62e-416b-aa93-d5baa5ecd990" },
                    { "7b33d0aa-f5d3-4208-90b7-45b5255b2a61", "COME 1V1 ME", "bb0fb979-e9d2-4800-b845-ecebfe6f831f", new DateTime(2022, 1, 12, 22, 31, 2, 595, DateTimeKind.Local).AddTicks(8410), "e0a3a264-a986-424e-8a47-724c5d0d693d" },
                    { "c0a83f42-7dfd-4fc5-92fd-0fde7d55fdb5", "I can't find diamonds anywhere, it's really hard :(", "aff783e6-b55a-41cb-b9c5-258d75236b6d", new DateTime(2022, 1, 12, 16, 31, 2, 595, DateTimeKind.Local).AddTicks(8420), "e0a3a264-a986-424e-8a47-724c5d0d693d" },
                    { "8a0d2821-5d21-49c5-9431-407d7d98c702", "I thinks it's below y-level 12 try that! ((:", "aff783e6-b55a-41cb-b9c5-258d75236b6d", new DateTime(2022, 1, 12, 18, 31, 2, 595, DateTimeKind.Local).AddTicks(8431), "e0a3a264-a986-424e-8a47-724c5d0d693d" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "01dcb37d-5eff-48e8-afd0-3609461f6ea5", "5bc04d0b-a62e-416b-aa93-d5baa5ecd990" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "47929a0b-2eeb-44ae-8786-f567c5a80e87", "5bc04d0b-a62e-416b-aa93-d5baa5ecd990" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "47929a0b-2eeb-44ae-8786-f567c5a80e87", "e0a3a264-a986-424e-8a47-724c5d0d693d" });

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "6bbdd8d6-1e74-40dd-97a8-379d5deb5fcf");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "d0abed98-1a0d-4718-91a9-7f32a8f896a2");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "edb84255-9b2e-4924-b807-794ac7392f9a");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "7337fc8e-a46f-4875-8f5b-5b3225b8d934");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "a1f4bd4a-bda1-4156-90bc-d0bc6170f4c7");

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "c498f616-934a-4514-afe1-e1ad3e20faf2", "a3b545f4-ec02-49b6-90d6-bdeb18144672" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "c498f616-934a-4514-afe1-e1ad3e20faf2", "c4ee163c-c001-4a7f-aa52-ad460c0d263b" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "d79dad39-f725-4719-9b18-af0e52cb89ef", "67f2678f-a441-42ef-912c-5323a0a06c22" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "d79dad39-f725-4719-9b18-af0e52cb89ef", "c4ee163c-c001-4a7f-aa52-ad460c0d263b" });

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "1bda4319-0df3-4eb1-9f37-fd3844bd093d");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "29ab1ada-c16f-44b4-987d-052697ff7fc9");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "635175e0-310b-417c-bc6b-3529b2785c95");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "7b33d0aa-f5d3-4208-90b7-45b5255b2a61");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "8a0d2821-5d21-49c5-9431-407d7d98c702");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "c0a83f42-7dfd-4fc5-92fd-0fde7d55fdb5");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "cb364747-fbd2-4d01-a36b-e500b46ccdd9");

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "3594104c-a45d-47f4-b75a-6690fa6f469b", "4b8f1dc3-f999-4a39-9c29-a671c4cfb5b1" });

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "3594104c-a45d-47f4-b75a-6690fa6f469b", "f245c60a-703b-4070-aa29-e0fa5deb8c4c" });

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "ece46808-974c-40f3-ae90-e44245eab2d1", "79afe1e3-5e1f-4431-88ea-f7475ac2899d" });

            migrationBuilder.DeleteData(
                table: "UserConversations",
                keyColumns: new[] { "UserId", "ConversationId" },
                keyValues: new object[] { "5bc04d0b-a62e-416b-aa93-d5baa5ecd990", "34475f28-5d5c-401a-a171-f3eacd1d33a8" });

            migrationBuilder.DeleteData(
                table: "UserConversations",
                keyColumns: new[] { "UserId", "ConversationId" },
                keyValues: new object[] { "e0a3a264-a986-424e-8a47-724c5d0d693d", "34475f28-5d5c-401a-a171-f3eacd1d33a8" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "5bc04d0b-a62e-416b-aa93-d5baa5ecd990", "3594104c-a45d-47f4-b75a-6690fa6f469b" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "5bc04d0b-a62e-416b-aa93-d5baa5ecd990", "ece46808-974c-40f3-ae90-e44245eab2d1" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "e0a3a264-a986-424e-8a47-724c5d0d693d", "3594104c-a45d-47f4-b75a-6690fa6f469b" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "e0a3a264-a986-424e-8a47-724c5d0d693d", "ece46808-974c-40f3-ae90-e44245eab2d1" });

            migrationBuilder.DeleteData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: "34475f28-5d5c-401a-a171-f3eacd1d33a8");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "3594104c-a45d-47f4-b75a-6690fa6f469b");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "ece46808-974c-40f3-ae90-e44245eab2d1");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "c498f616-934a-4514-afe1-e1ad3e20faf2");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "d79dad39-f725-4719-9b18-af0e52cb89ef");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "67f2678f-a441-42ef-912c-5323a0a06c22");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "a3b545f4-ec02-49b6-90d6-bdeb18144672");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "c4ee163c-c001-4a7f-aa52-ad460c0d263b");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "aff783e6-b55a-41cb-b9c5-258d75236b6d");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "bb0fb979-e9d2-4800-b845-ecebfe6f831f");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "de438842-e6ba-43c2-a8df-1491d067f1b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bc04d0b-a62e-416b-aa93-d5baa5ecd990");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0a3a264-a986-424e-8a47-724c5d0d693d");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "01dcb37d-5eff-48e8-afd0-3609461f6ea5");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "47929a0b-2eeb-44ae-8786-f567c5a80e87");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "4b8f1dc3-f999-4a39-9c29-a671c4cfb5b1");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "79afe1e3-5e1f-4431-88ea-f7475ac2899d");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "f245c60a-703b-4070-aa29-e0fa5deb8c4c");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: "664d2b4e-336c-40f8-9053-fcc58fbabb62");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: "bd292718-4b83-4184-ab3c-945d439514cd");
        }
    }
}
