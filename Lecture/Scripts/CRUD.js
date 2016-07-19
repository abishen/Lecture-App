$(document).ready(function () {
    $(".deleteStaff").click(function () {
        if (confirm("Are you sure to delete the record?")) {
            var idToDelete = ($(this).data('id'));
            var data = { 'id': idToDelete };
            $.post("/Admin/Delete", data,
                function (data) {
                    if (data = "deleted") {
                        window.location.reload();
                    } else {
                        alert(data);
                    }
                });
        }
    });
});