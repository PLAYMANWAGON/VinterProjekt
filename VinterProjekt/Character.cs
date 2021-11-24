using System;
using Raylib_cs;

public class Character
{
    public static List<Character> allCharacters = new List<Character>();

    private string name = "Jorgan";

    private int hp;     //Health Points
    private int mp;     //Magic Points
    private int sp;     //Shield Points

    private float speed = 200;

    Rectangle rect = new Rectangle();


    //Gjort med hjälp av Elias!!!
    public Character(int x, int y, int width, int height)
    {
        rect.x = x;
        rect.y = y;
        rect.width = width;
        rect.height = height;


        allCharacters.Add(this);
    }

    public void DrawCharacter()
    {
        Raylib.DrawRectangleRec(rect, Color.GREEN);
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
            rect.y -= speed * Raylib.GetFrameTime();

        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
        {
            rect.y += speed * Raylib.GetFrameTime();

        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            rect.x -= speed * Raylib.GetFrameTime();

        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            rect.x += speed * Raylib.GetFrameTime();

        }

    }
}