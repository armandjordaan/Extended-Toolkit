﻿using System.Windows.Forms.Design;

namespace Krypton.Toolkit.Extended.Navi.Suite
{
    /// <summary>
    /// Enables design time mode for the ClientArea of the Band
    /// </summary>
    public class NaviBandDesigner : ParentControlDesigner
    {
        private NaviBand designingComponent;

        public override void Initialize(System.ComponentModel.IComponent component)
        {
            base.Initialize(component);
            if (component is NaviBand)
            {
                designingComponent = (NaviBand)component;

                EnableDesignMode(designingComponent.ClientArea, "ClientArea");
            }
        }
    }
}