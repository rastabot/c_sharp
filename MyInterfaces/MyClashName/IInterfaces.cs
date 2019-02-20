using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClashName
{
    public interface IDrawToFile
    {
        void Draw();
    }
    public interface IDrawToPrinter
    {
        void Draw();
    }
    public interface IDrawToForm
    {
        void Draw();
    }
}
