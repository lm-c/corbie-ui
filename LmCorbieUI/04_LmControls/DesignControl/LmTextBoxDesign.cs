﻿using System.Collections;
using System.ComponentModel;
using System.Windows.Forms.Design;

namespace LmCorbieUI.Controls.Design
{
    internal class LmTextBoxDesign : ControlDesigner
    {
        public override SelectionRules SelectionRules
        {
            get
            {
                PropertyDescriptor propDescriptor = TypeDescriptor.GetProperties(Component)["Multiline"];

                if (propDescriptor != null)
                {
                    bool isMultiline = (bool)propDescriptor.GetValue(Component);

                    if (isMultiline)
                    {
                        return SelectionRules.Visible | SelectionRules.Moveable | SelectionRules.AllSizeable;
                    }

                    return SelectionRules.Visible | SelectionRules.Moveable | SelectionRules.LeftSizeable | SelectionRules.RightSizeable;
                }

                return base.SelectionRules;
            }
        }

        protected override void PreFilterProperties(IDictionary properties)
        {
            properties.Remove("BackgroundImage");
            properties.Remove("ImeMode");
            properties.Remove("Padding");
            properties.Remove("BackgroundImageLayout");
            properties.Remove("Font");

            base.PreFilterProperties(properties);
        }
    }
}
