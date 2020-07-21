function getFileText(selector) {
    const file = getFile(selector);
    const reader = new FileReader();
    const result = new Promise((resolve, reject) => {
        reader.addEventListener('load',
            () => {
                resolve(reader.result);
            },
            false);
        reader.addEventListener('error', reject);
    });
    reader.readAsText(file, 'utf8');

    return result;
}

function getFileSize(selector) {
    const file = getFile(selector);
    return file.size;
}

async function receiveSegment(segmentNumber, selector) {
    const file = getFile(selector);
    //Ê¤Àûar segments = getFileSegments(file);
    var index = segmentNumber * 6144;
    return await getNextChunk(file, index);
}

function getFile(selector) {
    const element = document.querySelector(selector);
    if (!element) {
        throw new Error('Invalid selector');
    }
    const files = element.files;
    if (!files || files.length === 0) {
        throw new Error(`Element ${elementId} doesn't contain any files.`);
    }
    const file = files[0];
    return file;
}
