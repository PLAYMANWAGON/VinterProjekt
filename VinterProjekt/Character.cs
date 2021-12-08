using Raylib_cs;

public class Character
{
    public static List<Character> allCharacters = new List<Character>();

    protected string name = "Jorgan";

    protected int hp;     //Health Points
    protected int mp;     //Magic Points
    protected int sp;     //Strenght Points

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

    public void AddToInventory(Item item)
    {

    }

    public void RemoveFromInventory(int n)
    {

    }

    public void UseItem(int n, Character target)
    {

    }

    public void UseItem(int n)
    {

    }

    public int GetInventoryLength()
    {

    }

    public string GetItemInfo(int n)
    {

    }

    public int GetHp()
    {

    }

    public int ModifyHp(int amount)
    {

    }

    public void Attack(Character target)
    {

    }



    #region Raylib Updates

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

    #endregion
}