using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPortal.Migrations
{
    public partial class EndDateAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b9c0b0e3-50e5-4660-bf39-91a66172a677", "ca9f6835-bae2-4375-9ecd-152b8af16d0a", "Admin", "ADMIN" },
                    { "7126879e-2d6a-4b65-a7d8-52f23cd909c4", "fa89a04b-a4ea-4a7d-96e8-220f78c8b442", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageURL", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "053ca7c0-6c3c-4e30-941a-8486915e0e48", 0, "53d5f66e-45c4-484f-b4b1-7988875cb941", "admin@admin.com", false, "/images/default-profile.png", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAENyCXXqtPherrUEfgMyBt8B5izsnEFNeuMMDbujlsjpcRtnktoYzLLPCRD/atR4EQg==", null, false, "7c7ccc93-61e8-47ce-8078-3363255f7f5b", false, "Admin" },
                    { "9da7b9d4-2d62-455f-b482-535814e2c4d4", 0, "9e4d9096-b358-43ad-bc76-de015ecb1d33", "seeduser@gmail.com", false, "https://i.pravatar.cc/100?img=2", false, null, "SEEDUSER@GMAIL.COM", "SEEDUSER", "AQAAAAEAACcQAAAAEPP22BPrx+RebmhYqIe8nPyeI9QQ3b67P50SxNOKIqK4yxxePa8ufODLizp7vqV7Eg==", null, false, "d64f3d7e-b53a-4b8b-a858-72ba0cc46963", false, "SeedUser" },
                    { "8fb20f89-1f6f-474c-9c3b-794288e6545a", 0, "f2b10625-f2de-42db-8c0d-e639097bff22", "seeduser2@gmail.com", false, "https://i.pravatar.cc/100?img=4", false, null, "SEEDUSER2@GMAIL.COM", "SEEDUSER2", "AQAAAAEAACcQAAAAEO7zZ3nIe9LQ5ZSRGNDoZzdUeFHP8XWNYNTYpO54Xffmmdop37Kq4wx6eA+uWLP91g==", null, false, "4807f0ca-2eeb-48b2-8922-79c4688c8afc", false, "SeedUser2" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "90855d76-cbec-4a13-a8d8-02c963cdb0c5", "Gaming" },
                    { "a4d2c0d7-8fde-4658-bda0-858e934f9616", "Health & Safety" }
                });

            migrationBuilder.InsertData(
                table: "Conversations",
                columns: new[] { "Id", "Subject" },
                values: new object[] { "419c98a8-bb79-43bc-a2f6-e5ee82e932b8", "A cool conversation between seeded users" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1fc3272a-b1d5-4d4e-b9a5-578c553f2484", "Programming" },
                    { "16b00208-10e7-4cca-8df2-25179be88e53", "Gaming" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "31d2a604-01e5-4400-8271-51bfa8b28f19", "First Post" },
                    { "d05d7af6-0480-4521-a492-b566046374a0", "Informative" },
                    { "7df76fab-a5e2-4595-94f1-08da203fe9e2", "Casual" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "053ca7c0-6c3c-4e30-941a-8486915e0e48", "b9c0b0e3-50e5-4660-bf39-91a66172a677" });

            migrationBuilder.InsertData(
                table: "CategorySubscribers",
                columns: new[] { "CategoryId", "UserId" },
                values: new object[,]
                {
                    { "a4d2c0d7-8fde-4658-bda0-858e934f9616", "9da7b9d4-2d62-455f-b482-535814e2c4d4" },
                    { "90855d76-cbec-4a13-a8d8-02c963cdb0c5", "9da7b9d4-2d62-455f-b482-535814e2c4d4" },
                    { "a4d2c0d7-8fde-4658-bda0-858e934f9616", "8fb20f89-1f6f-474c-9c3b-794288e6545a" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Content", "EndDate", "StartDate", "Subject", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { "b4b15ed1-8b18-4cb4-b613-db0945305e05", "We will begin a riot on Walmart on the second street", new DateTime(2022, 2, 13, 2, 27, 38, 40, DateTimeKind.Local).AddTicks(6262), new DateTime(2022, 2, 12, 2, 27, 38, 40, DateTimeKind.Local).AddTicks(6200), "Riot at Walmart", new DateTime(2022, 2, 2, 2, 27, 38, 40, DateTimeKind.Local).AddTicks(6107), "8fb20f89-1f6f-474c-9c3b-794288e6545a" },
                    { "ac51b608-f5a9-4595-bf0e-ad65182c818f", "We will be meeting in the town centre on the specified date.", new DateTime(2022, 2, 6, 2, 27, 38, 40, DateTimeKind.Local).AddTicks(4496), new DateTime(2022, 2, 5, 2, 27, 38, 40, DateTimeKind.Local).AddTicks(3017), "Meeting in town centre", new DateTime(2022, 2, 2, 2, 27, 38, 29, DateTimeKind.Local).AddTicks(109), "9da7b9d4-2d62-455f-b482-535814e2c4d4" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name", "OwnerId" },
                values: new object[,]
                {
                    { "484c20af-6c98-4ffb-8710-6a9758b5b8c8", "Programmers", "8fb20f89-1f6f-474c-9c3b-794288e6545a" },
                    { "b4a2dc34-52a0-4837-8846-590129143156", "General", "9da7b9d4-2d62-455f-b482-535814e2c4d4" },
                    { "9c8bd8d9-9f74-4ef4-b851-aa5ebf853d4b", "Gamers", "9da7b9d4-2d62-455f-b482-535814e2c4d4" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "ConversationId", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "706c61e8-f966-40f5-938e-966a38889b48", "Hello my dear friend, how are you doing?", "419c98a8-bb79-43bc-a2f6-e5ee82e932b8", new DateTime(2022, 2, 2, 2, 27, 38, 88, DateTimeKind.Local).AddTicks(3957), "9da7b9d4-2d62-455f-b482-535814e2c4d4" },
                    { "a98ea8c6-b94c-447e-87d1-2370391f1062", "Hi! I'm doing great, thanks for asking!!", "419c98a8-bb79-43bc-a2f6-e5ee82e932b8", new DateTime(2022, 2, 2, 5, 27, 38, 88, DateTimeKind.Local).AddTicks(5708), "8fb20f89-1f6f-474c-9c3b-794288e6545a" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Content", "Subject", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { "7f7a8f92-96ec-4486-9efe-a45354f2a918", "90855d76-cbec-4a13-a8d8-02c963cdb0c5", "Thank you so much for reading my first post, it means a lot to me!", "This is my first post (:", new DateTime(2022, 2, 2, 2, 27, 38, 89, DateTimeKind.Local).AddTicks(5846), "9da7b9d4-2d62-455f-b482-535814e2c4d4" },
                    { "4d05755a-65fb-47a6-8cc3-20d0fdc4c8e1", "a4d2c0d7-8fde-4658-bda0-858e934f9616", "Hey so I made my first post today, and this it! It's not much but it's something.", "So I made my first post today..", new DateTime(2022, 2, 2, 2, 27, 38, 89, DateTimeKind.Local).AddTicks(7588), "8fb20f89-1f6f-474c-9c3b-794288e6545a" }
                });

            migrationBuilder.InsertData(
                table: "SubForums",
                columns: new[] { "Id", "Description", "ForumId", "Name", "OwnerId" },
                values: new object[,]
                {
                    { "bf70815f-5b55-452c-a996-c15c3606cae5", "Everything about Minecraft", "16b00208-10e7-4cca-8df2-25179be88e53", "Minecraft", "9da7b9d4-2d62-455f-b482-535814e2c4d4" },
                    { "ad3073bb-b8d6-46c8-97de-ea4b40f205d5", "All programming related to the C# language and it's frameworks", "1fc3272a-b1d5-4d4e-b9a5-578c553f2484", "C#", "9da7b9d4-2d62-455f-b482-535814e2c4d4" },
                    { "5a32669e-f556-450f-aefb-35ff7c1096c8", "SubForum about the game League of Legends", "16b00208-10e7-4cca-8df2-25179be88e53", "League of Legends", "9da7b9d4-2d62-455f-b482-535814e2c4d4" }
                });

            migrationBuilder.InsertData(
                table: "UserConversations",
                columns: new[] { "UserId", "ConversationId" },
                values: new object[,]
                {
                    { "9da7b9d4-2d62-455f-b482-535814e2c4d4", "419c98a8-bb79-43bc-a2f6-e5ee82e932b8" },
                    { "8fb20f89-1f6f-474c-9c3b-794288e6545a", "419c98a8-bb79-43bc-a2f6-e5ee82e932b8" }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { "7f7a8f92-96ec-4486-9efe-a45354f2a918", "31d2a604-01e5-4400-8271-51bfa8b28f19" },
                    { "7f7a8f92-96ec-4486-9efe-a45354f2a918", "d05d7af6-0480-4521-a492-b566046374a0" },
                    { "4d05755a-65fb-47a6-8cc3-20d0fdc4c8e1", "31d2a604-01e5-4400-8271-51bfa8b28f19" },
                    { "4d05755a-65fb-47a6-8cc3-20d0fdc4c8e1", "7df76fab-a5e2-4595-94f1-08da203fe9e2" }
                });

            migrationBuilder.InsertData(
                table: "SubForumGroups",
                columns: new[] { "GroupId", "SubForumId" },
                values: new object[,]
                {
                    { "484c20af-6c98-4ffb-8710-6a9758b5b8c8", "ad3073bb-b8d6-46c8-97de-ea4b40f205d5" },
                    { "9c8bd8d9-9f74-4ef4-b851-aa5ebf853d4b", "5a32669e-f556-450f-aefb-35ff7c1096c8" },
                    { "9c8bd8d9-9f74-4ef4-b851-aa5ebf853d4b", "bf70815f-5b55-452c-a996-c15c3606cae5" }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "SubForumId", "Subject", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "b321bba1-3c73-49b1-8852-6ffed613ee65", "ad3073bb-b8d6-46c8-97de-ea4b40f205d5", "How do I print text?", new DateTime(2022, 2, 2, 2, 27, 38, 93, DateTimeKind.Local).AddTicks(7839), "9da7b9d4-2d62-455f-b482-535814e2c4d4" },
                    { "507156e4-0f2e-469c-ae2f-dd33f021e5ac", "5a32669e-f556-450f-aefb-35ff7c1096c8", "Why League is the most toxic game", new DateTime(2022, 2, 3, 2, 27, 38, 93, DateTimeKind.Local).AddTicks(9662), "8fb20f89-1f6f-474c-9c3b-794288e6545a" },
                    { "07fb12d7-7d05-480f-a28c-23fa4a6a1b60", "bf70815f-5b55-452c-a996-c15c3606cae5", "Where to find diamonds?", new DateTime(2022, 2, 2, 8, 27, 38, 93, DateTimeKind.Local).AddTicks(9777), "8fb20f89-1f6f-474c-9c3b-794288e6545a" }
                });

            migrationBuilder.InsertData(
                table: "UserGroups",
                columns: new[] { "UserId", "GroupId" },
                values: new object[,]
                {
                    { "9da7b9d4-2d62-455f-b482-535814e2c4d4", "9c8bd8d9-9f74-4ef4-b851-aa5ebf853d4b" },
                    { "8fb20f89-1f6f-474c-9c3b-794288e6545a", "9c8bd8d9-9f74-4ef4-b851-aa5ebf853d4b" },
                    { "9da7b9d4-2d62-455f-b482-535814e2c4d4", "484c20af-6c98-4ffb-8710-6a9758b5b8c8" },
                    { "8fb20f89-1f6f-474c-9c3b-794288e6545a", "484c20af-6c98-4ffb-8710-6a9758b5b8c8" }
                });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "Id", "Content", "QuoteId", "ThreadId", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { "bae518bf-fe8c-498d-bf78-c3322dc4901e", "I've been trying really long to figure how to print text but I just get errors plz help", null, "b321bba1-3c73-49b1-8852-6ffed613ee65", new DateTime(2022, 2, 2, 2, 27, 38, 94, DateTimeKind.Local).AddTicks(8783), "9da7b9d4-2d62-455f-b482-535814e2c4d4" },
                    { "760065b4-0dcd-4e5a-b353-6db4b3b080ab", "Use google.", null, "b321bba1-3c73-49b1-8852-6ffed613ee65", new DateTime(2022, 2, 2, 7, 27, 38, 95, DateTimeKind.Local).AddTicks(402), "8fb20f89-1f6f-474c-9c3b-794288e6545a" },
                    { "9fa072fc-ec21-4711-8817-95b26ed0e45a", "This is the most toxic game ever, everybody is just flaming. I QUIT!!!", null, "507156e4-0f2e-469c-ae2f-dd33f021e5ac", new DateTime(2022, 2, 2, 2, 27, 38, 95, DateTimeKind.Local).AddTicks(564), "8fb20f89-1f6f-474c-9c3b-794288e6545a" },
                    { "7dac2f43-2581-49df-bca8-ee70bd4f310d", "lol noob", null, "507156e4-0f2e-469c-ae2f-dd33f021e5ac", new DateTime(2022, 2, 2, 6, 27, 38, 95, DateTimeKind.Local).AddTicks(610), "9da7b9d4-2d62-455f-b482-535814e2c4d4" },
                    { "88de14de-7fee-4707-94a5-2ee8ac419f4e", "COME 1V1 ME", null, "507156e4-0f2e-469c-ae2f-dd33f021e5ac", new DateTime(2022, 2, 2, 8, 27, 38, 95, DateTimeKind.Local).AddTicks(647), "8fb20f89-1f6f-474c-9c3b-794288e6545a" },
                    { "cc60612b-b30a-4e77-a10e-8469e1e90834", "I can't find diamonds anywhere, it's really hard :(", null, "07fb12d7-7d05-480f-a28c-23fa4a6a1b60", new DateTime(2022, 2, 2, 2, 27, 38, 95, DateTimeKind.Local).AddTicks(703), "8fb20f89-1f6f-474c-9c3b-794288e6545a" },
                    { "38b4aee7-2473-49c8-b733-b1b621d98a14", "I thinks it's below y-level 12 try that! ((:", null, "07fb12d7-7d05-480f-a28c-23fa4a6a1b60", new DateTime(2022, 2, 2, 4, 27, 38, 95, DateTimeKind.Local).AddTicks(739), "8fb20f89-1f6f-474c-9c3b-794288e6545a" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7126879e-2d6a-4b65-a7d8-52f23cd909c4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "053ca7c0-6c3c-4e30-941a-8486915e0e48", "b9c0b0e3-50e5-4660-bf39-91a66172a677" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "90855d76-cbec-4a13-a8d8-02c963cdb0c5", "9da7b9d4-2d62-455f-b482-535814e2c4d4" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "a4d2c0d7-8fde-4658-bda0-858e934f9616", "8fb20f89-1f6f-474c-9c3b-794288e6545a" });

            migrationBuilder.DeleteData(
                table: "CategorySubscribers",
                keyColumns: new[] { "CategoryId", "UserId" },
                keyValues: new object[] { "a4d2c0d7-8fde-4658-bda0-858e934f9616", "9da7b9d4-2d62-455f-b482-535814e2c4d4" });

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "ac51b608-f5a9-4595-bf0e-ad65182c818f");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: "b4b15ed1-8b18-4cb4-b613-db0945305e05");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "b4a2dc34-52a0-4837-8846-590129143156");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "706c61e8-f966-40f5-938e-966a38889b48");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "a98ea8c6-b94c-447e-87d1-2370391f1062");

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "4d05755a-65fb-47a6-8cc3-20d0fdc4c8e1", "31d2a604-01e5-4400-8271-51bfa8b28f19" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "4d05755a-65fb-47a6-8cc3-20d0fdc4c8e1", "7df76fab-a5e2-4595-94f1-08da203fe9e2" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "7f7a8f92-96ec-4486-9efe-a45354f2a918", "31d2a604-01e5-4400-8271-51bfa8b28f19" });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "7f7a8f92-96ec-4486-9efe-a45354f2a918", "d05d7af6-0480-4521-a492-b566046374a0" });

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "38b4aee7-2473-49c8-b733-b1b621d98a14");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "760065b4-0dcd-4e5a-b353-6db4b3b080ab");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "7dac2f43-2581-49df-bca8-ee70bd4f310d");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "88de14de-7fee-4707-94a5-2ee8ac419f4e");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "9fa072fc-ec21-4711-8817-95b26ed0e45a");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "bae518bf-fe8c-498d-bf78-c3322dc4901e");

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: "cc60612b-b30a-4e77-a10e-8469e1e90834");

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "484c20af-6c98-4ffb-8710-6a9758b5b8c8", "ad3073bb-b8d6-46c8-97de-ea4b40f205d5" });

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "9c8bd8d9-9f74-4ef4-b851-aa5ebf853d4b", "5a32669e-f556-450f-aefb-35ff7c1096c8" });

            migrationBuilder.DeleteData(
                table: "SubForumGroups",
                keyColumns: new[] { "GroupId", "SubForumId" },
                keyValues: new object[] { "9c8bd8d9-9f74-4ef4-b851-aa5ebf853d4b", "bf70815f-5b55-452c-a996-c15c3606cae5" });

            migrationBuilder.DeleteData(
                table: "UserConversations",
                keyColumns: new[] { "UserId", "ConversationId" },
                keyValues: new object[] { "8fb20f89-1f6f-474c-9c3b-794288e6545a", "419c98a8-bb79-43bc-a2f6-e5ee82e932b8" });

            migrationBuilder.DeleteData(
                table: "UserConversations",
                keyColumns: new[] { "UserId", "ConversationId" },
                keyValues: new object[] { "9da7b9d4-2d62-455f-b482-535814e2c4d4", "419c98a8-bb79-43bc-a2f6-e5ee82e932b8" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "8fb20f89-1f6f-474c-9c3b-794288e6545a", "484c20af-6c98-4ffb-8710-6a9758b5b8c8" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "8fb20f89-1f6f-474c-9c3b-794288e6545a", "9c8bd8d9-9f74-4ef4-b851-aa5ebf853d4b" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "9da7b9d4-2d62-455f-b482-535814e2c4d4", "484c20af-6c98-4ffb-8710-6a9758b5b8c8" });

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { "9da7b9d4-2d62-455f-b482-535814e2c4d4", "9c8bd8d9-9f74-4ef4-b851-aa5ebf853d4b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9c0b0e3-50e5-4660-bf39-91a66172a677");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "053ca7c0-6c3c-4e30-941a-8486915e0e48");

            migrationBuilder.DeleteData(
                table: "Conversations",
                keyColumn: "Id",
                keyValue: "419c98a8-bb79-43bc-a2f6-e5ee82e932b8");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "484c20af-6c98-4ffb-8710-6a9758b5b8c8");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "9c8bd8d9-9f74-4ef4-b851-aa5ebf853d4b");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "4d05755a-65fb-47a6-8cc3-20d0fdc4c8e1");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "7f7a8f92-96ec-4486-9efe-a45354f2a918");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "31d2a604-01e5-4400-8271-51bfa8b28f19");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "7df76fab-a5e2-4595-94f1-08da203fe9e2");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: "d05d7af6-0480-4521-a492-b566046374a0");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "07fb12d7-7d05-480f-a28c-23fa4a6a1b60");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "507156e4-0f2e-469c-ae2f-dd33f021e5ac");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "b321bba1-3c73-49b1-8852-6ffed613ee65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fb20f89-1f6f-474c-9c3b-794288e6545a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9da7b9d4-2d62-455f-b482-535814e2c4d4");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "90855d76-cbec-4a13-a8d8-02c963cdb0c5");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "a4d2c0d7-8fde-4658-bda0-858e934f9616");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "5a32669e-f556-450f-aefb-35ff7c1096c8");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "ad3073bb-b8d6-46c8-97de-ea4b40f205d5");

            migrationBuilder.DeleteData(
                table: "SubForums",
                keyColumn: "Id",
                keyValue: "bf70815f-5b55-452c-a996-c15c3606cae5");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: "16b00208-10e7-4cca-8df2-25179be88e53");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: "1fc3272a-b1d5-4d4e-b9a5-578c553f2484");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Events");

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
    }
}
