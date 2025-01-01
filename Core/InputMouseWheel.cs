using Raylib_cs;

namespace Raylib_Experiment;

public class InputMouseWheel
{
    public void Run()
    {
        Raylib.InitWindow(ScreenConstant.ScreenWidth, ScreenConstant.ScreenHeight, "raylib [core] example - input mouse wheel");

        const int boxSize = 40;
        var boxPositionY = ScreenConstant.ScreenHeight / 2 - boxSize / 2;
        const int scrollSpeed = 4;
        
        Raylib.SetTargetFPS(60);

        while (!Raylib.WindowShouldClose())
        {
            boxPositionY -= (int)Raylib.GetMouseWheelMove() * scrollSpeed;
            
            Raylib.BeginDrawing();
            
            Raylib.ClearBackground(Color.Blue);
            
            Raylib.DrawRectangle(ScreenConstant.ScreenWidth / 2 - boxSize / 2, boxPositionY, boxSize, boxSize, Color.Maroon);
            
            Raylib.DrawText("Use mouse wheel to move cube up and down!", 10, 10, 20, Color.White);
            Raylib.DrawText($"Box position: {boxPositionY}", 10, 40, 20, Color.White);
            
            Raylib.EndDrawing();
        }
        
        Raylib.CloseWindow();
    }
}