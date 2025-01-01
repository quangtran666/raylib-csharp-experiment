using Raylib_cs;

namespace Raylib_Experiment;

public class BasicWindow
{
    public void Run()
    {
        const int screenWidth = 800;
        const int screenHeight = 450;
        
        Raylib.InitWindow(screenWidth, screenHeight, "raylib [core] example - basic window");
        
        Raylib.SetTargetFPS(60);

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            
                Raylib.ClearBackground(Color.Blue);
            
                Raylib.DrawText("Congratulations! You created your first window!", 190, 200, 20, Color.White);
            
            Raylib.EndDrawing();
        }
        
        Raylib.CloseWindow();
    }
}