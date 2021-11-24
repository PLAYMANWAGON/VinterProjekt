using System.ComponentModel;
using Raylib_cs;

Console.WriteLine("Hello, World!");

Character player = new Character(10,10, 100,100);

Raylib.InitWindow(800, 600, "CHOBLAN GAME");

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.WHITE);

    player.DrawCharacter();
    player.UpdateCharacter();

    Raylib.EndDrawing();
}
