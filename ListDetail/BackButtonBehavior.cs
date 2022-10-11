﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ListDetail
{
    /// <summary>
    /// The behavior to use for navigating between the <see cref="ListDetailsView"/> list and details views
    /// </summary>
    public enum BackButtonBehavior
    {
        /// <summary>
        /// Automatically determine the best approach to use.
        /// </summary>
        /// <remarks>
        /// If the back button controlled by <see cref="Windows.UI.Core.SystemNavigationManager"/> is already visible, the <see cref="ListDetailsView"/> will hook into that button.
        /// If the new NavigationView provided by the Windows UI NuGet package is used, the <see cref="ListDetailsView"/> will enable and show that button.
        /// Otherwise the inline button is used.
        /// </remarks>
        Automatic,

        /// <summary>
        /// Use a back button built into the <see cref="ListDetailsView"/>
        /// </summary>
        Inline,

        /// <summary>
        /// Use the system back button controlled by the <see cref="Windows.UI.Core.SystemNavigationManager"/>.
        /// </summary>
        System,

        /// <summary>
        /// Do not enable any back buttons. Use this if you plan to handle all navigation or have your own back button in the application.
        /// </summary>
        Manual,
    }
}