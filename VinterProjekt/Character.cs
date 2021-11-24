using System;
using Raylib_cs;

public class Character
{
    private string name = "Jorgan";

    private int hp;     //Health Points
    private int mp;     //Magic Points
    private int sp;     //Shield Points

    private float speed = 200;

    public float x = 10;
    public float y = 10;

    public void DrawCharacter()
    {
        Raylib.DrawRectangle((int)x,(int)y,100,100,Color.GREEN);
    }

    public void UpdateCharacter()
    {

        if (Raylib.IsKeyDown(KeyboardKey.KEY_X))
        {
            speed = 400;
        }
        else
        {
            speed = 200;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
        {
            y -= speed * Raylib.GetFrameTime();

        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
        {
            y += speed * Raylib.GetFrameTime();

        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            x -= speed * Raylib.GetFrameTime();

        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            x += speed * Raylib.GetFrameTime();

        }

    }
}