﻿using ScaleformUI.PauseMenus;

namespace ScaleformUI.LobbyMenu
{
    public delegate void IndexChanged(int index);
    public class Column
    {
        public PauseMenuBase Parent { get; internal set; }
        public string Label;
        public HudColor Color;
        public int Order;
        public Column(string label, HudColor color)
        {
            Label = label;
            Color = color;
        }
    }
}