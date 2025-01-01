using System.Numerics;
using Raylib_cs;

namespace Raylib_Experiment;

public class InputMouse
{
    public void Run()
    {
        Raylib.InitWindow(ScreenConstant.ScreenWidth, ScreenConstant.ScreenHeight,
            "raylib [core] example - input mouse");

        var ballPosition = new Vector2(-100.0f, -100.0f);
        var ballColor = Color.DarkBlue;

        Raylib.SetTargetFPS(60);

        while (!Raylib.WindowShouldClose())
        {
            ballPosition = Raylib.GetMousePosition();

            if (Raylib.IsMouseButtonPressed(MouseButton.Left)) ballColor = Color.Maroon;
            else if (Raylib.IsMouseButtonPressed(MouseButton.Middle)) ballColor = Color.Lime;
            else if (Raylib.IsMouseButtonPressed(MouseButton.Right)) ballColor = Color.DarkBlue;
            else if (Raylib.IsMouseButtonPressed(MouseButton.Side)) ballColor = Color.Purple;
            else if (Raylib.IsMouseButtonPressed(MouseButton.Extra)) ballColor = Color.Yellow;
            else if (Raylib.IsMouseButtonPressed(MouseButton.Forward)) ballColor = Color.Orange;
            else if (Raylib.IsMouseButtonPressed(MouseButton.Back)) ballColor = Color.Beige;
            
            Raylib.BeginDrawing();
            
            Raylib.ClearBackground(Color.RayWhite);
            
            Raylib.DrawText("Move the ball with mouse!", 190, 200, 20, Color.White);
            
            Raylib.DrawCircleV(ballPosition, 50, ballColor);
            
            Raylib.EndDrawing();
        }
        
        Raylib.CloseWindow();
    }
}