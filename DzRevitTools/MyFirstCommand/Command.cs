using System;
using System.Drawing;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using DzRevitTools.BASE;
using static DzRevitTools.Utils;

namespace DzRevitTools.MyFirstCommand;

[Transaction(TransactionMode.Manual)]
[Regeneration(RegenerationOption.Manual)]
class Command : IButtonCommand, IExternalCommand
{
    public string ButtonText => "MyFirstCommand11111";
    public string Title => "Название окна, транзакции";
    public string Tooltip => "(Description is coming soon)";
    public Bitmap Logo { get; } = Properties.Resources.LogoTemplate;

    private static void Execute(ExternalCommandData commandData)
    {
        new Model(commandData).DoJob();
    }
    
    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
    {
        try
        {
            LogStartCommand(Title, commandData, ++Properties.Settings.Default.CounterRunMyFirstCommand);
            Execute(commandData);
            LogEndCommand(Title);
        }
        catch (Exception e)
        {
            LogException(e);
            ShowException(e);
        }
        return Result.Succeeded;
    }
}
