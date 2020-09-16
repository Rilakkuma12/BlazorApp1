using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimulatorTool.PagesModel;

namespace BlazorApp1.PageModel
{
    public class CounterPageModel : MyComponentBase
    {
        public CounterPageModel()
        {

        }
        public int currentCount = 0;

        public void IncrementCount()
        {
            currentCount++;
        }
    }
}
