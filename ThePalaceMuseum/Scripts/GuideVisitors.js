var count = 10;

function resizeimg(oImage) {
    count = Counting(count);
    Resize(oImage, count);
    return false;
}

function Counting(newzoom) {
    if (event.wheelDelta >= 120)
        newzoom++;
    else if (event.wheelDelta <= -120)
        newzoom--;
    if (newzoom < 2) newzoom = 2; //只允许缩小到20%
    if (newzoom > 50) newzoom = 50; //只允许放大到500%
    return newzoom;
}

function Resize(oImage, newzoom) {
    oImage.style.zoom = newzoom + '0%';
    count = newzoom;
}