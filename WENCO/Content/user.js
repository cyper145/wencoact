(function () {
    function OnToolbarItemClick(s, e) {
        if (!IsCustomExportToolbarCommand(e.item.name))
            return;
        var $exportFormat = $('#customExportCommand');
        $exportFormat.val(e.item.name);
        $('form').submit();
        window.setTimeout(function () {
            $exportFormat.val("");
        }, 0);
    }
    function IsCustomExportToolbarCommand(command) {
        return command == "CustomExportToXLS" || command == "CustomExportToXLSX";
    }
})();