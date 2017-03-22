using System;

namespace Lab_5
{
    partial class Hunter : Fighter , IAction
    {
        private static Hunter instance;
        private int Force { get; set; }
    }
}
