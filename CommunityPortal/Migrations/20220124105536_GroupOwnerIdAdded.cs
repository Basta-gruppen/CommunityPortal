using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPortal.Migrations
{
    public partial class GroupOwnerIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Groups",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_Groups_OwnerId",
                table: "Groups",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_AspNetUsers_OwnerId",
                table: "Groups",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_AspNetUsers_OwnerId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_OwnerId",
                table: "Groups");

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

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Groups");

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
    }
}
