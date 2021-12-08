using System.ComponentModel;
using Raylib_cs;

Character player = new Character(10,10, 100,100);

Raylib.InitWindow(800, 600, "CHOBLAN GAME");

while (!Raylib.WindowShouldClose())
{
    #region sk*t man behver inte se
    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.WHITE);

    #endregion

    player.DrawCharacter();
    player.UpdateCharacter();

    Raylib.EndDrawing();
}
