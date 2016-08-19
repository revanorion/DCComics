
$(document).on('click', '.createNewButton', function () {
    var headerText = $(this).data('modal-header');
    $.ajax({
        url: $(this).data('request-url'),
        type: 'GET',
        dataType: 'html',
        success: function (data) {
            $('#modalHeaderText').html(headerText);
            $('#popUpEntityPartialView').html(data);
            $('#popUpEntityView').modal('show');
        }
    });
});

$(document).on('click', '.results-table tbody tr', function () {
    var row = table.row(this);   

    var mydata = table.row(this).data();
    var headerText = $('.results-table').data('modal-header');
    $.ajax({
        url: $('.results-table').data('request-url'),
        type: 'GET',
        data: { 'id': mydata.Id },
        dataType: 'html',
        success: function (data) {
            $('#modalHeaderText').html(headerText);
            $('#popUpEntityPartialView').html(data);
            $('#popUpEntityView').modal('show');
        }
    });
});

$(document).on('click', '#LocationTypesTable tbody tr', function () {

    var mydata = table.row(this).data();
    var headerText = $('#LocationTypesTable').data('modal-header');
    $.ajax({
        url: $('#LocationTypesTable').data('request-url'),
        type: 'GET',
        data: { 'id': mydata.Id },
        dataType: 'html',
        success: function (data) {
            $('#modalHeaderText').html(headerText);
            $('#popUpEntityPartialView').html(data);
            $('#popUpEntityView').modal('show');
        }
    });
});


$(document).on('click', '.editButton', function () {
    $.ajax({
        url: $(this).data('request-url'),
        type: 'GET',
        data: { 'id': $(this).data("id") },
        dataType: 'html',
        success: function (data) {
            $('#modalHeaderText').html($(this).data('modal-header'));
            $('#popUpEntityPartialView').html(data);
        }
    });
});


$(document).on('click', '.deleteButton', function () {
    $.ajax({
        url: $(this).data('request-url'),
        type: 'GET',
        data: { 'id': $(this).data("id") },
        dataType: 'html',
        success: function (data) {
            $('#modalHeaderText').html($(this).data('modal-header'));
            $('#popUpEntityPartialView').html(data);
        }
    });
});
