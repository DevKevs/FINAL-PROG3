function leerArchivo() {
    if (this.files && this.files[0]) {
        var FR = new FileReader();
        FR.onload = function (e) {
            document.getElementById("customFile").value = e.target.result;
            console.log(e.target.result);
        };
        FR.readAsDataURL(this.files[0]);
    }
}

