using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using AvaloniaPaint.Models;
using ReactiveUI;

namespace AvaloniaPaint.ViewModels.Pages
{
    public class AvaloniaPaintPathViewModel : PaintShape
    {
        public override string ViewName => "Составная фигура";

        public override Unit ClearShape()
        {
            throw new NotImplementedException();
        }

        public override PaintBaseFigure GetShape()
        {
            throw new NotImplementedException();
        }
    }
}
