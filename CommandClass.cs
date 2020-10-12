using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoCADTestProject
{
    public class CommandClass
    {
        /// <summary>
        /// Командный класс для тестовой команды
        /// </summary>
        [CommandMethod("TestCommand")]
        public void RunCommand()
        {
            //Получаем ссылку на активный документ
            Document adoc = Application.DocumentManager.MdiActiveDocument;
            if (adoc==null)
            {
                return;
            }
            Database db = adoc.Database;
            ObjectId layerTableId = db.LayerTableId;
            List<string> layersNames = new List<string>();
            using(Transaction tr =db.TransactionManager.StartTransaction())
            {
                LayerTable layerTable = (LayerTable)tr.GetObject(layerTableId,OpenMode.ForRead);
                foreach (ObjectId layerTableRecorId in layerTable)
                {
                    LayerTableRecord layerTableRecord = tr.GetObject(layerTableRecorId, OpenMode.ForRead) as LayerTableRecord;
                 
                } 
 
                tr.Commit();
            }
           
        }
    }
   

}
