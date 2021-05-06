// script to allow user to download file. it takes the converted-from-csv-to-bytearray-to-base64 in fileContent parameter, decodes the base64, then redirects to a link
function FileSaveAs(filename, fileContent) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/octet-stream;base64,"
        + encodeURIComponent(fileContent);
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}
