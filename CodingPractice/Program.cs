using CodingPractice;
using System;

// README.md를 읽고 코드를 작성하세요.

//1
Player player = new Player();
player.ShowStatus();

//2
Character character = new Character();
character.name = "용사";
character.level = 10;

Console.WriteLine($"{character.name}\n{character.level}");

//3
Character2 character2 = new Character2();
character2.SetInfo("용사", 10);
character2.ShowInfo();

//4
Player2 player2 = new Player2();
player2.ShowStatus();

//5
Say message = new Say();
message.Hi();

//6
Schedule schedule = new Schedule();
schedule.PrintWeekDays();

//7
DefaultValues def =  new DefaultValues();
def.ShowDefault();

//8
Counter count1 = new Counter();
Counter count2 = new Counter();
Counter count3 = new Counter();

//9
Player3 player_1 = new Player3("용사");
Player3 player_2 = new Player3("마법사");
Player3 player_3 = new Player3("궁수");
Console.WriteLine($"총 플레이어 수: {Player3.totalCount}");

//10
GameConfig config = new GameConfig();
config.ShowConfig();

//11
Example ex  = new Example();
ex.ShowValues();

//12
Player4 player4 = new Player4();

//13
Person person = new Person();
person.ShowProfile();

//14
GameCharacter hero = new GameCharacter("용사", 15);
GameCharacter mage = new GameCharacter("마법사", 25);

hero.ShowStatus();
Console.WriteLine();
mage.ShowStatus();
Console.WriteLine();

hero.TakeDamage(30);
hero.TakeDamage(50);
hero.TakeDamage(50);

Console.WriteLine();
GameCharacter.ShowTotalCharacters();