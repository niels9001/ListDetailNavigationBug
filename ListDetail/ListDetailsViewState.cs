using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ListDetail
{
    /// <summary>
    /// The <see cref="ListDetailsView"/> state.
    /// </summary>
    public enum ListDetailsViewState
    {
        /// <summary>
        /// Only the List view is shown-
        /// </summary>
        List,

        /// <summary>
        /// Only the Details view is shown-
        /// </summary>
        Details,

        /// <summary>
        /// Both the List and Details views are shown-
        /// </summary>
        Both
    }
}
