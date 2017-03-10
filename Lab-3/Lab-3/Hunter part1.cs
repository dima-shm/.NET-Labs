using System;

namespace Lab_3
{
    partial class Hunter : Fighter , IAction
    {
        private static Hunter instance;
        private int Force { get; set; }
    }
}
