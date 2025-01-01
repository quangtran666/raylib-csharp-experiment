using System.Numerics;
using Raylib_cs;

namespace Raylib_Experiment;

public class InputKeys
{
    public void Run()
    {
        const int screenWidth = 800;
        const int screenHeight = 450;
        
        Raylib.InitWindow(screenWidth, screenHeight, "raylib [core] example - input keys");
        
        var ballPosition = new Vector2((float)screenWidth / 2, (float)screenHeight / 2);
        
        Raylib.SetTargetFPS(60);

        while (!Raylib.WindowShouldClose())
        {
            if (Raylib.IsKeyDown(KeyboardKey.Left)) ballPosition += new Vector2(-4, 0);
            if (Raylib.IsKeyDown(KeyboardKey.Right)) ballPosition += new Vector2(4, 0);
            if (Raylib.IsKeyDown(KeyboardKey.Up)) ballPosition += new Vector2(0, -4);
            if (Raylib.IsKeyDown(KeyboardKey.Down)) ballPosition += new Vector2(0, 4);
            
            Raylib.BeginDrawing();
                
            Raylib.ClearBackground(Color.Blue);
          
            Raylib.DrawText("Move the ball with arrow keys!", 190, 200, 20, Color.White);
            
            Raylib.DrawCircleV(ballPosition, 50, Color.Maroon);
            
            Raylib.EndDrawing();
        }
        
        Raylib.CloseWindow();
    }
}