using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_DragonsCharacterBuilder.EventModels
{
    public class MoveViewsEventModel
    {
        public int _viewNum { get; set; }
        
        public MoveViewsEventModel(int viewNum)
        {
            _viewNum = viewNum;
        }
    }
}
