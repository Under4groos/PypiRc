using System.Windows;


public class WinDragMove
{


    public double? TopDown
    {
        get; set;
    } = 35;
    public double? LeftDown
    {
        get; set;
    } = 35;

    public WinDragMove(Window win_)
    {
        win_.MouseLeftButtonDown += (sender, e) =>
        {

            if (e.GetPosition(win_).Y < TopDown && e.LeftButton == System.Windows.Input.MouseButtonState.Pressed && (win_.Width - e.GetPosition(win_).X) > LeftDown)
                win_.DragMove();


        };
    }
}

