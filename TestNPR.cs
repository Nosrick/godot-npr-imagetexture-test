using Godot;

public class TestNPR : Control
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        ImageTexture imageTexture = new ImageTexture();
        imageTexture.CreateFromImage(GD.Load<Texture>("res://background-border.png").GetData());
        NinePatchRect patchRect = new NinePatchRect
        {
            AnchorBottom = 1,
            AnchorLeft = 0,
            AnchorTop = 0,
            AnchorRight = 1,
            PatchMarginBottom = 9,
            PatchMarginTop = 9,
            PatchMarginLeft = 9,
            PatchMarginRight = 9,
            MarginBottom = -20,
            MarginTop = 20,
            MarginLeft = 20,
            MarginRight = -20,
            AxisStretchHorizontal = NinePatchRect.AxisStretchMode.TileFit,
            AxisStretchVertical = NinePatchRect.AxisStretchMode.TileFit,
            Texture = imageTexture,
            SelfModulate = Colors.Red
        };
        
        this.AddChild(patchRect);
    }
}
