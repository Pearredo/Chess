using System.IO;
using System.Windows;
using System.Windows.Input;

namespace UI
{
    public static class ChessCursors
    {
        public static readonly Cursor WhiteCursor = LoadCursor("assets/CursorW.cur");
        public static readonly Cursor BlackCursor = LoadCursor("assets/CursorB.cur");
        private static Cursor LoadCursor(string filePath)
        {
            Stream stream = Application.GetResourceStream(new Uri(filePath, UriKind.Relative)).Stream;
            return new Cursor(stream, true);
        }
    }
}
