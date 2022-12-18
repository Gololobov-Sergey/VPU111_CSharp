using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VPU111_CSharp
{

    static partial class ExtensionMethod
    {
        public static string Xn(this string data, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += data;
            }
            return result;
        }


        public static string Div(this string data, int n)
        {
            string result = "";
            for (int i = 0; i < data.Length/n; i++)
            {
                result += data[i];
            }
            return result;
        }

        public static string PadCenter(this string data, int totalWidth)
        {
            int lenSpace = (totalWidth - data.Length <= 0) ? 0 : totalWidth - data.Length;
            return " ".Xn(lenSpace / 2) + data + " ".Xn(lenSpace - lenSpace / 2);
        }
    }


    /// <summary>
    /// Горизонтальне вирівнювання елементів в межах рядка
    /// </summary>
    enum HorizontalAlignment
    {
        Center, Left, Right
    };

    /// <summary>
    /// Горизонтальна позиція елементів в межах екрану
    /// </summary>
    enum HPosition
    {
        Center, Left, Right
    };

    /// <summary>
    /// Вертикальна позиція елементів в межах екрану
    /// </summary>
    enum VPosition
    {
        Center, Top, Bottom
    };

    
    static class ConsoleMenu
    {
        public static int SelectVertical(HPosition hPos, VPosition vPos,
                                         HorizontalAlignment ha,
                                         params string[] menuElements)
        {
            List<string> list = menuElements.ToList();
            return SelectVertical(hPos, vPos, ha, list);
        }
        public static int SelectVertical(HPosition hPos,
                                         VPosition vPos,
                                         HorizontalAlignment ha,
                                         ICollection<string> menuElements)
        {
            List<string> list = menuElements.ToList();
            int maxLen = list.Max().Length;

            for (int i = 0; i < list.Count; i++)
            {
                switch (ha)
                {
                    case HorizontalAlignment.Left: list[i] = list[i].PadLeft(maxLen); break;
                    case HorizontalAlignment.Right: list[i] = list[i].PadRight(maxLen); break;
                    default: list[i] = list[i].PadCenter(maxLen + 2); break;
                }
                list[i] = list[i].PadCenter(maxLen);
            }


            ConsoleColor bg = Console.BackgroundColor;
            ConsoleColor fg = Console.ForegroundColor;

            int width = Console.WindowWidth;
            int height = Console.WindowHeight;

            int x = 0;
            switch (hPos)
            {
                case HPosition.Center: x = width / 2 - maxLen / 2; break;
                case HPosition.Left: x = 0; break;
                case HPosition.Right: x = width - maxLen; break;
            }

            int y = 0;
            switch (vPos)
            {
                case VPosition.Center: y = height / 2 - list.Count / 2; break;
                case VPosition.Top: y = 0; break;
                case VPosition.Bottom: y = height - list.Count; break;
            }


            int pos = 0;
            ConsoleKey consoleKey;
            do
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (i == pos)
                    {
                        Console.BackgroundColor = fg;
                        Console.ForegroundColor = bg;
                    }
                    else
                    {
                        Console.BackgroundColor = bg;
                        Console.ForegroundColor = fg;
                    }
                    Console.SetCursorPosition(x, y + i);
                    Console.Write(list[i]);
                    Console.SetCursorPosition(x, y + i);
                }
                Console.CursorVisible = false;
                consoleKey = Console.ReadKey().Key;
                Console.CursorVisible = true;
                switch (consoleKey)
                {
                    case ConsoleKey.Escape:
                        return list.Count - 1;

                    case ConsoleKey.UpArrow:
                        if (pos > 0)
                            pos--;
                        break;

                    case ConsoleKey.DownArrow:
                        if (pos < list.Count - 1)
                            pos++;
                        break;

                    default: break;
                }
            } while (consoleKey != ConsoleKey.Enter);

            for (int i = 0; i < 2; i++)
            {
                Console.BackgroundColor = bg;
                Console.ForegroundColor = fg;
                Console.SetCursorPosition(x, y + pos);
                Console.Write(list[pos]);
                Thread.Sleep(250);
                Console.BackgroundColor = fg;
                Console.ForegroundColor = bg;
                Console.SetCursorPosition(x, y + pos);
                Console.Write(list[pos]);
                Thread.Sleep(250);
            }
            Console.BackgroundColor = bg;
            Console.ForegroundColor = fg;

            return pos;
        }

    }
}
