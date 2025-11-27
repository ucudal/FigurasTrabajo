using System;
namespace Ucu.Poo.Shapes
{
    public class Export
    {
        public void Exporting(IExportingWay exportingWay, object objecto)
        {
            Console.WriteLine(exportingWay.Export(objecto));
        }
    }
}