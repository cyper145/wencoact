using DevExpress.Web.Demos.Mvc;
using DevExpress.Web.Mvc;

namespace WENCO.Code.Helpers
{
    public class GridViewToolbarHelper
    {
        public const string KeyFieldName = "id";

        static MVCxGridViewColumnCollection exportedColumns;
        public static MVCxGridViewColumnCollection ExportedColumns
        {
            get
            {
                if (exportedColumns == null)
                    exportedColumns = CreateExportedColumns();
                return exportedColumns;
            }
        }

        static GridViewSettings exportGridSettings;
        public static GridViewSettings ExportGridSettings
        {
            get
            {
                if (exportGridSettings == null)
                    exportGridSettings = CreateExportGridSettings();
                return exportGridSettings;
            }
        }

        static MVCxGridViewColumnCollection CreateExportedColumns()
        {
            var columns = new MVCxGridViewColumnCollection();
            columns.Add("name");
           
            columns.Add("user");
            
            columns.Add("lastname", MVCxGridViewColumnType.SpinEdit);
            columns.Add("email", MVCxGridViewColumnType.CheckBox);
            return columns;
        }

        static GridViewSettings CreateExportGridSettings()
        {
            var settings = new GridViewSettings();
            settings.Name = "grid";
            settings.KeyFieldName = KeyFieldName;
            settings.Columns.Assign(ExportedColumns);
            return settings;
        }
    }
}