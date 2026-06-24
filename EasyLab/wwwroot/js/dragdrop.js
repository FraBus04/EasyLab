console.log('[dragdrop.js] script caricato (v3)');

window._dropZoneActive = false;
window._dropZoneDotNetRef = null;

window.initDropZone = function (elementId, dotNetRef) {
    console.log('[dragdrop.js] initDropZone chiamato');
    window._dropZoneDotNetRef = dotNetRef;
    window._dropZoneActive = true;

    if (window._dropZoneListenersAttached) return;
    window._dropZoneListenersAttached = true;

    document.addEventListener('dragover', function (e) {
        if (!window._dropZoneActive) return;
        e.preventDefault();
        if (e.dataTransfer) e.dataTransfer.dropEffect = 'copy';
    }, true);

    document.addEventListener('drop', function (e) {
        console.log('[dragdrop.js] drop event ricevuto, active=' + window._dropZoneActive, e.dataTransfer && e.dataTransfer.files);
        if (!window._dropZoneActive || !window._dropZoneDotNetRef) return;
        e.preventDefault();
        e.stopPropagation();

        var files = e.dataTransfer ? e.dataTransfer.files : null;
        if (!files || files.length === 0) return;

        var file = files[0];
        if (!file.type.startsWith('image/')) return;

        var reader = new FileReader();
        reader.onload = function (ev) {
            var binary = '';
            var bytes = new Uint8Array(ev.target.result);
            for (var i = 0; i < bytes.length; i++) {
                binary += String.fromCharCode(bytes[i]);
            }
            console.log('[dragdrop.js] invio immagine a OnImageDropped, bytes=' + bytes.length);
            window._dropZoneDotNetRef.invokeMethodAsync('OnImageDropped', btoa(binary), file.name);
        };
        reader.readAsArrayBuffer(file);
    }, true);
};

window.disposeDropZone = function () {
    window._dropZoneActive = false;
    window._dropZoneDotNetRef = null;
};
