using Jerald;
using System;
using System.Collections.Generic;
using System.Text;

namespace GorillaEarmuffs.Pages
{

    [AutoRegister]
    public class EarmuffPage : Page
    {
        public override string PageName => "EARMUFF";
        public static bool isWearingEarmuffs = true;

        public EarmuffPage()
        {
            base.OnKeyPressed += (key) =>
            {
                switch (key.Binding)
                {
                    case GorillaNetworking.GorillaKeyboardBindings.option1:
                        isWearingEarmuffs = true;
                        break;
                    case GorillaNetworking.GorillaKeyboardBindings.option2:
                        isWearingEarmuffs = false;
                        break;
                }
                UpdateContent();
            };
        }

        public override StringBuilder GetPageContent()
        {
            var str = new StringBuilder();
            str.AppendLine("PRESS OPTION 1 TO PUT ON THE EARMUFFS");
            str.AppendLine("PRESS OPTION 2 TO TAKE OFF THE EARMUFFS");
            str.AppendLine();
            str.AppendLine($"YOU ARE CURRENTLY{(isWearingEarmuffs ? " " : " NOT ")}WEARING EARMUFFS");
            return str;
        }
    }
}
