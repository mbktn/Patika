function tarihSaat() {
    var date = new Date().toLocaleString();
    document.getElementById("zaman1").innerHTML = date;
}
// her 1 saniyede tarihSaat fonksiyonunu yeniden çalıştır
setInterval(tarihSaat, 1000);