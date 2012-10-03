using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageEditor.Unleashed.Controls
{
    public interface ITabPane
    {
        string Title { get; }
        string TabID { get; }
    }
}
