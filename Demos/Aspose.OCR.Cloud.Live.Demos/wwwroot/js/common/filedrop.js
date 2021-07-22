// File Upload Component
// options:
// - DropFilesPrompt (string)
// - ChooseFilePrompt (string)
// - Accept (string)
// - Multiple (boolean)
// - UseSorting (boolean)
// - MaximumUploadFiles (number)
// - FileWrongTypeMessage (string)
// - FileAmountMessage (string)
// - FileSelectMessage (string)
// - UploadOptions (array of string)
// - UIBasePath (string)
// - Method (callback)
// - UploadAndRedirect (boolean)
// - showAlert (function (string) => void)
// - hideAlert (function () => void)
// - showLoader (function () => void)
// - progress (function () => void)

(function ($) {
    $.fn.filedrop = function (options) {
        let getRandomIntInclusive = function (min, max) {
            min = Math.ceil(min);
            max = Math.floor(max);
            return Math.floor(Math.random() * (max - min + 1)) + min;
        };

        let randomId = getRandomIntInclusive(1, Number.MAX_SAFE_INTEGER);

        let acceptExts = options.Accept.split(/\s*,\s*/).map(ext => ext.substring(1).toUpperCase());

        let droppedFiles = [];

        let getFileExtension = function (file) {
            let pos = file.name.lastIndexOf('.');
            return pos !== -1 ? file.name.substring(pos + 1).toUpperCase() : null;
        };

        let nextFileId = function () {
            let id = 1;
            let found;
            do {
                found = false;

                for (let i = 0; i < droppedFiles.length; i++) {
                    if (droppedFiles[i].id === id) {
                        id += 1;
                        found = true;
                        break;
                    }
                }
            } while (found);
            return id;
        };

        let preventFileDrop = function (evt) {
            evt = evt || event;
            evt.preventDefault();
            evt.stopPropagation();
        };

        let findPostion = function (id) {
            let pos;
            for (pos = 0; pos < droppedFiles.length; pos++) {
                if (droppedFiles[pos].id === id) {
                    break;
                }
            }

            return pos;
        }

        let removeFileBlock = function (id) {
            let pos = findPostion(id);

            if (pos < droppedFiles.length) {
                droppedFiles.splice(pos, 1);
                $('#filedrop-' + randomId).find('#fileupload-' + id).remove();
                if (droppedFiles.length === 0) {
                    $('#filedrop-' + randomId).find('.chooseFilesLabel').removeClass('hidden');
                }
            }
        };

        let swapFiles = function (pos, swappos) {
            let flTemp = droppedFiles[swappos];
            droppedFiles[swappos] = droppedFiles[pos];
            droppedFiles[pos] = flTemp;
        }

        let moveUpFileBlock = function (id) {
            let pos = findPostion(id);

            if (pos < droppedFiles.length && pos !== 0) {
                let prevId = droppedFiles[pos - 1].id;
                swapFiles(pos, pos - 1);
                let block = $('#filedrop-' + randomId + ' > #fileupload-' + id).detach();
                $('#filedrop-' + randomId + ' > #fileupload-' + prevId).before(block);
            }
        };

        let moveDownFileBlock = function (id) {
            let pos = findPostion(id);

            if (pos < droppedFiles.length && pos != (droppedFiles.length - 1)) {
                let nextId = droppedFiles[pos + 1].id;
                swapFiles(pos, pos + 1);
                let block = $('#filedrop-' + randomId + ' > #fileupload-' + id).detach();
                $('#filedrop-' + randomId + ' > #fileupload-' + nextId).after(block);
            }
        }

        let appendFileBlock = function (file) {
            let id = nextFileId();
            let name = file.name;
            let fileMoveUpLink = null;
            let fileMoveDownLink = null;
            if (options.UseSorting) {
                fileMoveUpLink = $(`
                    <a class="fileMoveUpLink">
                        <i class="fa fa-arrow-up"></i>
                    </a>
                `);
                fileMoveDownLink = $(`
                    <a class="fileMoveDownLink">
                        <i class="fa fa-arrow-down"></i>
                    </a>\
                `);
                fileMoveUpLink.find("i").on('click', function () {
                    moveUpFileBlock(id);
                });
                fileMoveDownLink.find("i").on('click', function () {
                    moveDownFileBlock(id);
                });
            }
            let fileRemoveLink = $(`
                <a class="fileRemoveLink">
                    <i class="fa fa-times"></i>
                </a>\
            `);
            fileRemoveLink.find("i").on('click', function () {
                removeFileBlock(id);
            });
            let spanFileName = $(`
                <span class="filename">
                    <label class="custom-file-upload" style="display:inline">${name}</label>
                </span>
            `);
            if (fileMoveUpLink != null && fileMoveDownLink != null) {
                spanFileName.append(fileMoveUpLink);
                spanFileName.append(fileMoveDownLink);
            }
            spanFileName.append(fileRemoveLink);

            let fileBlock = $(`<div id="fileupload-${id}" class="fileupload"></div>`);
            fileBlock.on('dragover', preventFileDrop);
            fileBlock.on('drop', preventFileDrop);
            fileBlock.append(spanFileName);

            $('#filedrop-' + randomId).append(fileBlock);
            droppedFiles.push({
                id,
                file,
                name
            });
        };

        let prepareFormData = function (min = 1, max = undefined) {
            if (max === undefined)
                max = options.MaximumUploadFiles;

            if (droppedFiles.length) {
                if (droppedFiles.length < min || droppedFiles.length > max) {
                    options.showAlert(options.FileAmountMessage);
                    return null;
                }

                let data = new FormData();
                for (let i = 0; i < droppedFiles.length; i++) {
                    let ext = getFileExtension(droppedFiles[i]);
                    if (ext != null && options.UploadOptions.indexOf(ext) !== -1) {
                        data.append(droppedFiles[i].name, droppedFiles[i].file);
                    } else {
                        options.showAlert(options.FileWrongTypeMessage + ext);
                        return null;
                    }
                }
                return data;
            } else {
                options.showAlert(options.FileSelectMessage);
                return null;
            }
        };

        let uploadFileSelected = function (event) {
            let bError = false;
            if (event.target.files && event.target.files.length) {
                let fileCount = event.target.files.length + droppedFiles.length;
                if (fileCount <= options.MaximumUploadFiles) {
                    let ext;
                    options.hideAlert();
                    for (let i = 0; i < event.target.files.length; i++) {
                        ext = getFileExtension(event.target.files[i]);
                        if (ext !== null && acceptExts.indexOf(ext) !== -1) {
                            appendFileBlock(event.target.files[i])
                        } else {
                            bError = true;
                            if (ext !== null)
                                ext = ext.toUpperCase();
                            options.showAlert(options.FileWrongTypeMessage + ext);
                        }
                    }
                } else {
                    bError = true;
                    options.showAlert(options.FileAmountMessage);
                    window.setTimeout(function () {
                        options.hideAlert();
                    }, 5000);
                }
            }

            // clear the file input field
            $('input#UploadFileInput-' + randomId).val('')
            return bError;
        };

        let fileDropBlockStr = `
            <div class="filedrop filedrop-mvc fileplacement" id="filedrop-${randomId}">
                <label for="UploadFileInput-${randomId}" style="margin-top: 50px;text-decoration: underline">${options.DropFilesPrompt}</label>
                <input type="file" class="uploadfileinput" id="UploadFileInput-${randomId}" name="UploadFileInput-${randomId}"
                    title="" accept="${options.Accept}" ${options.Multiple ? `multiple="${options.Multiple}"` : ''} /></div>`;

        let fileDropBlock = $(fileDropBlockStr);

        //adding file drop block
        this.prepend(fileDropBlock);

        //adding event handlers
        $('input#UploadFileInput-' + randomId).on('change', uploadFileSelected);

        // return object with access fields
        return {
            get droppedFiles() {
                return droppedFiles;
            },
            get prepareFormData() {
                return prepareFormData;
            },
            reset: function reset() {
                droppedFiles = [];
                $('#filedrop-' + randomId).find('div[id^=fileupload-]').remove();
            }
        };
    };


})(jQuery)
