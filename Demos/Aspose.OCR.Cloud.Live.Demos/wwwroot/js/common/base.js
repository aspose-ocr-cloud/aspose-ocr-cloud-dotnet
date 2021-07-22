// filedrop component
var fileDrop = {};

function showLoader() {
    let progressBar = $('.progress > .progress-bar');
    progressBar.html('15%');
    progressBar.css('width', '15%');
    $('#loader').removeClass("hidden");
    hideAlert();
}

function hideLoader() {
    $('#loader').addClass("hidden");
}

function workSuccess(data, textStatus, xhr) {
    hideLoader();

    const fromHexString = hexString => new Uint8Array(hexString.match(/.{1,2}/g).map(byte => parseInt(byte, 16)));

    if (data.statusCode == 200) {
        var fileData = fromHexString(data.fileData)

        const anchor = document.createElement('a');
        anchor.download = data.fileName;

        const blob = new Blob([fileData], { type: "application/octet-stream" });
        anchor.href = URL.createObjectURL(blob);
        anchor.click();
    }
    else {
        showAlert(statusCode);
    }
}

function hideAlert() {
    let alertMessage = $('#alertMessage');
    alertMessage.addClass("hidden");
    alertMessage.text("");

    let alertSuccess = $('#alertSuccess');
    alertSuccess.addClass("hidden");
    alertSuccess.text("");
}

function showAlert(msg) {
    hideLoader();

    let alertMessage = $('#alertMessage');
    alertMessage.html(msg);
    alertMessage.removeClass("hidden");
    alertMessage.fadeOut(100).fadeIn(100).fadeOut(100).fadeIn(100);
}

function showMessage(msg) {
    hideLoader();

    let alertSuccess = $('#alertSuccess');
    alertSuccess.text(msg);
    alertSuccess.removeClass("hidden");
}

function progress(evt) {
    if (evt.lengthComputable) {
        var max = evt.total;
        var current = evt.loaded;

        var percentage = Math.round((current * 100) / max);
        percentage = (percentage < 15 ? 15 : percentage) + '%';

        let progressBar = $('.progress > .progress-bar');
        progressBar.html(percentage);
        progressBar.css('width', percentage);
    }
}

function removeAllFileBlocks() {
    fileDrop.droppedFiles.forEach(function (item) {
        $('#fileupload-' + item.id).remove();
    });
    fileDrop.droppedFiles = [];
    hideLoader();
}

function request(url, data) {
    showLoader();
    $.ajax({
        type: 'POST',
        url: url,
        data: data,
        cache: false,
        contentType: false,
        processData: false,
        success: workSuccess,
        xhr: function () {
            var myXhr = $.ajaxSettings.xhr();
            if (myXhr.upload)
                myXhr.upload.addEventListener('progress', progress, false);
            return myXhr;
        },
        error: function (err) {
            hideLoader();
            if (err.data !== undefined && err.data.Status !== undefined)
                showAlert(err.data.Status);
            else
                showAlert("Error " + err.status + ": " + err.statusText);
        }
    });
}

function requestConversion() {
    let data = fileDrop.prepareFormData();
    if (data === null)
        return;

    let url = o.UIBasePath + 'Conversion/Conversion?outputType=' + $('#saveAs').val().trim().toLowerCase();

    request(url, data);
}

$(document).ready(function () {

    fileDrop = $('form#UploadFile').filedrop(Object.assign({
        showAlert: showAlert,
        hideAlert: hideAlert,
        showLoader: showLoader,
        progress: progress
    }, o));

    if (!o.UploadAndRedirect) {
        $('#uploadButton').on('click', o.Method);
    }
});
