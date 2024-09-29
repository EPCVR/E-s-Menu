using StupidTemplate.Classes;
using StupidTemplate.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class Panic
    {
        public static void PANIC()
        {
            foreach (ButtonInfo[] buttons in Buttons.buttons)
            {
                foreach (ButtonInfo button in buttons)
                {
                    if (!button.enabled)
                    {

                    }
                    else
                    {
                        button.enabled = false;
                    }
                }
            }
        }
    }
}
