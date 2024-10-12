public class BufferedPanel : Panel
{
    public BufferedPanel()
    {
        this.DoubleBuffered = true; // Включаем двойную буферизацию
        this.ResizeRedraw = true; // Перерисовываем при изменении размера
    }
}
