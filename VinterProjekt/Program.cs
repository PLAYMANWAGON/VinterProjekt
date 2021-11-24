using System.ComponentModel;
using Raylib_cs;

Console.WriteLine("Hello, World!");

Character player = new Character();

Raylib.InitWindow(800, 600, "CHOBLAN GAME");

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.WHITE);

    player.DrawCharacter();
    player.UpdateCharacter();

    Raylib.EndDrawing();
}
