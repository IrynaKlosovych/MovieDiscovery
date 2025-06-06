﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieDiscovery.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMovieDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "У Барбіленді, матріархальному суспільстві з різними Барбі, Кенами та вигнанцями, Кен прагне тіснішого зв'язку з Барбі, яка зосереджена на своїй кар'єрі. Коли Барбі стикається з екзистенційною кризою, вона розуміє, що для зцілення їй необхідно знайти свого реального власника. Кен приєднується до неї, і їхня подорож приводить їх до Саші, дівчини, яка критично ставиться до стандартів краси Барбі.\r\n\r\nПовернувшись до Барбіленду, Кен захоплює владу, запроваджуючи патріархальну систему. Подруга Барбі Глорія допомагає їй і Саші вирватися з-під влади \"Маттел\". Разом вони згуртовують Барбі, щоб звільнитися від підпорядкування і відновити баланс.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Улюблені героїні \"Школи монстрів\" опиняються у вирі надприродних подій. Коли Френкі Стайн знаходить таємничий ліхтар джина, вона та її друзі мимоволі вивільняють силу бажань у своєму світі. Коли їхні бажання здійснюються, вони незабаром усвідомлюють, що їхні мрії мають непередбачувані наслідки і загрожують порушити рівновагу в їхній школі, наповненій монстрами.\r\n\r\nЗгодом учні мають пройти через низку випробувань, подолати власні страхи та невпевненість і, зрештою, зрозуміти важливість безкорисливості та вибору на користь більшого блага. Працюючи разом, вони відкривають для себе справжнє значення дружби і знаходять сили, щоб виправити хаос, який вони спричинили.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "\"Монстр Хай: Привиди\" - анімаційний фільм, що розповідає про пригоди групи учениць \"Монстр Хай\", які розслідують справу про привидів у місцевому історичному театрі. По дорозі вони натрапляють на таємничого привида, який, схоже, пов'язаний з минулим \"Монстр Хай\".\r\nСюжет наповнений інтригою, гумором і музичними номерами, які неодмінно сподобаються як дітям, так і дорослим.\r\nШанувальники франшизи \"Монстр Хай\" будуть у захваті, побачивши, як їхні улюблені персонажі, такі як Дракулаура та Вовк Клаудін, приймають нові виклики та зростають як особистості.\r\nЗагалом, \"Монстр Хай: Привиди\" - це веселий фільм, який оспівує дружбу, хоробрість і прийняття відмінностей, а також надає моторошних відчуттів і хвилювань.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Барбіленд – напрочуд прекрасний світ...");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Мультфільм «Школа монстрів: 13 бажань» продовжує розповідати...");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Незвичайний анімаційний мультфільм Школа монстрів: Привиди...");
        }
    }
}
