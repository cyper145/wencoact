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
            columns.Add("username");
            columns.Add("password");
            columns.Add("firstname", MVCxGridViewColumnType.TextBox);
            columns.Add("lastname", MVCxGridViewColumnType.TextBox);
            columns.Add("email", MVCxGridViewColumnType.TextBox);
            columns.Add("address", MVCxGridViewColumnType.TextBox);
            columns.Add("phone1", MVCxGridViewColumnType.TextBox);
            columns.Add("phone2", MVCxGridViewColumnType.TextBox);
            columns.Add("date_of_birth", MVCxGridViewColumnType.TextBox);
            columns.Add("photo", MVCxGridViewColumnType.TextBox);
            columns.Add("created_at", MVCxGridViewColumnType.TextBox);
            columns.Add("updated_at", MVCxGridViewColumnType.TextBox);
            columns.Add("isactive", MVCxGridViewColumnType.TextBox);
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