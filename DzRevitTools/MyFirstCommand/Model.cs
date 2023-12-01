using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows;

namespace DzRevitTools.MyFirstCommand;

public class Model
{
    private readonly UIApplication _uiApp;
    private readonly UIDocument _uiDoc;
    private readonly Document _doc;

    public Model(ExternalCommandData commandData)
    {
        _uiApp = commandData.Application;
        _uiDoc = _uiApp.ActiveUIDocument;
        _doc = _uiDoc.Document;
    }

    internal void DoJob()
    {
        // using var t = new Transaction(_doc);
        // t.Start(new Command().Title);

        MessageBox.Show("qwe12 fdddddddddddddddddqwe12 fdddddddddddddddddqwe12 fdddddddddddddddddqwe12 fdddddddddddddddddqwe12 fddddddddddddddddd");
        
        // t.SetName($"{t.GetName()} ({_resultCounter})");
        // t.Commit();
    }
}
