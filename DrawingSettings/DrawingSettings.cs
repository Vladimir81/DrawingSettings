﻿using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.ApplicationServices;
using Autodesk.AutoCAD.ApplicationServices;

namespace DrawingSettings
{
    public class DrawingSettings
    {
        [CommandMethod("SetDrawingSetting")]
        public void Setds()
        {
            // Получаем доступ к чертежу
            CivilDocument doc = CivilApplication.ActiveDocument;

            // Получаем доступ к параметрам, вкладка "Еденицы измерения и зона"
            doc.Settings.DrawingSettings.UnitZoneSettings.DrawingUnits = Autodesk.Civil.Settings.DrawingUnitType.Meters;
            doc.Settings.DrawingSettings.UnitZoneSettings.AngularUnits = Autodesk.Civil.AngleUnitType.Degree;
            doc.Settings.DrawingSettings.UnitZoneSettings.ImperialToMetricConversion = Autodesk.Civil.Settings.ImperialToMetricConversionType.InternationalFoot;
            doc.Settings.DrawingSettings.UnitZoneSettings.DrawingScale = 1;

            // Переходим на вкладку "Параметры среды"
            doc.Settings.DrawingSettings.AmbientSettings.Area.Unit.Value = Autodesk.Civil.AreaUnitType.SquareMeter;
            doc.Settings.DrawingSettings.AmbientSettings.Area.Precision.Value = 5;
            doc.Settings.DrawingSettings.AmbientSettings.Area.Rounding.Value = Autodesk.Civil.RoundingType.Normal;
            doc.Settings.DrawingSettings.AmbientSettings.Area.Sign.Value = Autodesk.Civil.SignType.Always;
            doc.Settings.DrawingSettings.AmbientSettings.General.SaveCommandChangesToSettings.Value = true;
            doc.Settings.DrawingSettings.AmbientSettings.General.IndependentLayerOn.Value = true;
            doc.Settings.DrawingSettings.AmbientSettings.DegreeOfCurvature.UnitChordLength.Value = 30;
            doc.Settings.DrawingSettings.AmbientSettings.DegreeOfCurvature.UnitArcLength.Value = 30;
            doc.Settings.DrawingSettings.AmbientSettings.Unitless.Precision.Value = 2;
            doc.Settings.DrawingSettings.AmbientSettings.Distance.Unit.Value = Autodesk.Civil.LinearUnitType.Meter;
            doc.Settings.DrawingSettings.AmbientSettings.Distance.Precision.Value = 2;
            doc.Settings.DrawingSettings.AmbientSettings.Dimension.Unit.Value = Autodesk.Civil.LinearUnitType.Millimeter;
            doc.Settings.DrawingSettings.AmbientSettings.Dimension.Precision.Value = 2;
            doc.Settings.DrawingSettings.AmbientSettings.Coordinate.Unit.Value = Autodesk.Civil.LinearUnitType.Meter;
            doc.Settings.DrawingSettings.AmbientSettings.Coordinate.Precision.Value = 2;
            doc.Settings.DrawingSettings.AmbientSettings.Elevation.Unit.Value = Autodesk.Civil.LinearUnitType.Meter;
            doc.Settings.DrawingSettings.AmbientSettings.Elevation.Precision.Value = 2;
            doc.Settings.DrawingSettings.AmbientSettings.Volume.Unit.Value = Autodesk.Civil.VolumeUnitType.CubicMeter;
            doc.Settings.DrawingSettings.AmbientSettings.Volume.Precision.Value = 2;
            doc.Settings.DrawingSettings.AmbientSettings.Speed.Unit.Value = Autodesk.Civil.SpeedUnitType.KilometerPerHour;
            doc.Settings.DrawingSettings.AmbientSettings.Speed.Precision.Value = 0;
            doc.Settings.DrawingSettings.AmbientSettings.Angle.DropLeadingZerosForDegrees.Value = Autodesk.Civil.DropLeadingZeroType.Yes;
            doc.Settings.DrawingSettings.AmbientSettings.Direction.Precision.Value = 4;
            doc.Settings.DrawingSettings.AmbientSettings.Direction.DropLeadingZerosForDegrees.Value = Autodesk.Civil.DropLeadingZeroType.Yes;
            doc.Settings.DrawingSettings.AmbientSettings.LatLong.DropLeadingZerosForDegrees.Value = Autodesk.Civil.DropLeadingZeroType.Yes;
            doc.Settings.DrawingSettings.AmbientSettings.Grade.Format.Value = Autodesk.Civil.GradeFormatType.PerMille;
            doc.Settings.DrawingSettings.AmbientSettings.Slope.Format.Value = Autodesk.Civil.SlopeFormatType.RiseRun;
            doc.Settings.DrawingSettings.AmbientSettings.GradeSlope.Format.Value = Autodesk.Civil.GradeSlopeFormatType.PerMille;
            doc.Settings.DrawingSettings.AmbientSettings.Station.Unit.Value = Autodesk.Civil.LinearUnitType.Meter;
            doc.Settings.DrawingSettings.AmbientSettings.Acceleration.Unit.Value = Autodesk.Civil.AccelerationUnitType.MeterPerSecSquared;
            doc.Settings.DrawingSettings.AmbientSettings.Pressure.Unit.Value = Autodesk.Civil.PressureUnitType.Kilopascal;

            // Выводим сообщение, что все ок
            Application.ShowAlertDialog("Настройки изменены");
            
        }

    }
}
