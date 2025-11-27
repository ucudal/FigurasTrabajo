using System.IO;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;

namespace Ucu.Poo.Shapes
{
    public class Jason: IExportingWay
    {
        public string Export(object objeto)
        {
            return JsonSerializer.Serialize(objeto);
        }
    }
}